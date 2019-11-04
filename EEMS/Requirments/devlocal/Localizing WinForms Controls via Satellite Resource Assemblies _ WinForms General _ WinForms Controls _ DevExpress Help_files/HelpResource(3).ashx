/// <reference path="jquery.js" />
(function(){
DX = {
        Core: {
        setCookie: function(name, value) {
            document.cookie = escape(name) + "=" + escape(value) + "; expires=" + new Date(2099, 0, 1).toGMTString() + "; path=/";
        },

        getCookie: function(name) {
            name = escape(name);
            var c = document.cookie;
            var start = c.indexOf(name + "=");
            if (start < 0) return null;
            start = c.indexOf('=', start) + 1;
            var end = c.indexOf(';', start);
            if (end < 0) end = c.length;
            return unescape(c.substring(start, end));
        },

        getInnerText: function(el) {
            return el.textContent || el.innerText;
        }
    },
    Members: {
        init: function () {
            var showInherited = DX.Core.getCookie('dx_showInherited') !== "false";
            this.toggleMembers(null, showInherited);
        },
        toggleMembers: function (checkBox, value) {
            $('tr[data*="inherited"]', 'table[class="dx-members"]').toggle(value);
            $('input[name="toggleMembers"]').attr("checked", value);
            DX.Core.setCookie('dx_showInherited', value);
            if (checkBox != null) {
                checkBox.scrollIntoView();
                window.scrollBy(0, -100);
            }
        }
    },
    Tabs: {
        registry: [],

        init: function(id) {
            var table = document.getElementById(id);
            var dataTable = document.getElementById(id + '_data');
            var tabsTable = document.getElementById(id + '_tabs');

            var fillerCell = tabsTable.rows[0].cells[0];

            for (var i = 0; i < dataTable.rows.length; i++) {
                var h = document.createElement("td");
                tabsTable.rows[0].insertBefore(h, fillerCell);
                h.className = "dx-tabs-header";
                h.onclick = function() { DX.Tabs.activate(id, this) };
                h.innerHTML = "<div>" + dataTable.rows[i].cells[0].innerHTML + "</div>";

                var contentDiv = document.createElement("div");
                contentDiv.className = "dx-tabs-contents";
                contentDiv.innerHTML = dataTable.rows[i].cells[1].innerHTML;
                table.rows[1].cells[0].appendChild(contentDiv);
            }

            var name = DX.Core.getCookie("dx-lang") || 'C#';
			var initialTabIndex = Math.max(0, this.getActiveTabIndexByName(id, name));
            this.activateByTabIndex(id, initialTabIndex);
            this.registry.push(id);
        },

        activate: function(id, headerElement, chained) {
            var activateByTabIndex = this.getActiveTabIndex(id, headerElement);
            this.activateByTabIndex(id, activateByTabIndex, chained);
        },
        activateByName: function (id, name, chained) {
            var activateByTabIndex = this.getActiveTabIndexByName(id, name);
            this.activateByTabIndex(id, activateByTabIndex, chained);
        },
        activateByTabIndex: function (id, activeTabIndex, chained) {
            if(activeTabIndex < 0) return;

            var table = document.getElementById(id);
            var tabsRow = this.getTabsRow(id);
            var contentCell = table.rows[1].cells[0];
            var name = DX.Core.getInnerText(tabsRow.cells[activeTabIndex]);
            var TabsHeaderCssName = "dx-tabs-header";
            
            for (var i = 0; i < tabsRow.cells.length; i++) {
                var cell = tabsRow.cells[i];
                if (cell.className.indexOf(TabsHeaderCssName) < 0) continue;

                cell.className = TabsHeaderCssName;
                if(i == activeTabIndex){
                    cell.className += ' dx-active';
                    if (this.isCookable(name))
                        DX.Core.setCookie("dx-lang", name);
                }
            }

            for (var i = 0; i < contentCell.childNodes.length; i++) {
                var div = contentCell.childNodes[i];
                if (div.className == "dx-tabs-contents")
                    div.style.display = i == activeTabIndex ? "block" : "none";
            }

            if (!chained && this.isCookable(name)) {
                for (var i = 0; i < this.registry.length; i++) {
                    var broId = this.registry[i];
                    if (broId != id)
                        this.activateByName(broId, name, true);
                }
            }
        },
        cookableLangs: { 'c#': 1, 'vb': 1 },
        isCookable: function(lang) {
            return !!this.cookableLangs[lang.toLowerCase()];
        },
        getActiveTabIndex: function(id, headerElement){
            var headerRow = this.getTabsRow(id);
            return this.getCellIndex(headerRow, headerElement);
        },
        getActiveTabIndexByName: function(id, name){
            var activeTabIndex = -1;
            var possibleActiveTabs = [ ];
            var headerRow = this.getTabsRow(id);
            for(var i = 0; i < headerRow.cells.length && activeTabIndex < 0; i++){
                var cell = headerRow.cells[i];
                if (DX.Core.getInnerText(cell) != name) continue;

                possibleActiveTabs.push(cell);
                if(cell.className.indexOf('dx-active') > -1)
                    activeTabIndex = i;
            }
            if (activeTabIndex < 0 && possibleActiveTabs.length > 0)
                activeTabIndex = this.getCellIndex(headerRow, possibleActiveTabs[0]);
            return activeTabIndex;
        },
        getCellIndex: function(row, cell){
            var index = -1;
            for (var i = 0; i < row.cells.length && index < 0; i++) {
                if(row.cells[i] === cell)
                    index = i;
            }
            return index;
        },
        getTabsRow: function(id){
            var tabsTable = document.getElementById(id + '_tabs');
            return tabsTable ? tabsTable.rows[0] : null;
        }
    },
    Groups: {
        mainElement: {},
        timestamp: {},
        contentHeigth: {},
        firstClicked: {},
        initGroups: function() {
            this.mainElement = this.GetMainElement();
            this.updateTitle($('.dx-regiontitle'), 'toExpanded')
            if ($('.dx-initially-collapsed').length != 0) this.collapse($('.dx-initially-collapsed'));
        },
        GetMainElement: function() {
            return $('body');
        },
        collapse: function (e) {
            var windowPageOffset = this.mainElement.scrollTop[0];
            if (((Date.now() - this.timestamp) < 500) && (this.firstClicked[0].innerText == e[0].innerText)) {
                this.collapseAll(e);
            }
            else {
                this.firstClicked = e;
                var content = e.next().next();
                content.slideToggle(0);
                var icons = e.children('img');
                icons.slideToggle(0);
                this.timestamp = Date.now();
                this.mainElement.scroll(0, windowPageOffset);
                if (content[0].style.display == 'none') {
                    this.updateTitle(e, 'toCollapsed');
                }
                else { 
                    this.updateTitle(e, 'toExpanded');
                }
            }
        },
        collapseAll: function (e) {
            var content = e.next().next();
            if (content[0].style.display != 'none') {
                $('.dx-groupContent, .dx-seeAlso, .expanded').slideDown(0);
                $('.collapsed').slideUp(0);
                this.updateTitle($('.dx-regiontitle'), 'toExpanded');
            }
            else {
                $('.dx-groupContent, .dx-seeAlso, .expanded').slideUp(0);
                $('.collapsed').slideDown(0);
                this.updateTitle($('.dx-regiontitle'), 'toCollapsed');
            }
            this.mainElement.css('height', 'auto');
        },
        updateTitle: function(el, state) {
            if (state == 'toCollapsed') {
                el.attr('title',"Click to expand. Double-click to expand all.");
            }
            else {
                el.attr('title',"Click to collapse. Double-click to collapse all.");
            }
        }
    }
};

var imageGallery = function($mainElement, options){
    this.data = [ ];
    this.$mainElement = $mainElement;
    this.init(options);
};
$.extend(imageGallery.prototype, {
    init: function(options){
        this.assignOptions(options);
        this.createHierarchy();
        var _this = this;
        window.setTimeout(function(){ 
            _this.calculateMainElementSize();
            _this.show(0, true);
        }, 100);
    },
    calculateMainElementSize: function(){
        this.$mainElement.css({ width: this.imgWidth });

        var defaultPadding = 10;
        var descrHeight = this.getDescriptionAreaHeight();
        var height = descrHeight + this.imgHeight;
        this.$mainElement.css({ height: height });

        this.requireShowDescr && this.$mainElement.find(".dx-ig-descr").each(function(){
            var top = (descrHeight - $(this).height()) / 2;
            $(this).css("padding-top", top + "px");
        });
    },
    getDescriptionAreaHeight: function(){
        var height = 0;
        this.requireShowDescr && this.$mainElement.find(".dx-ig-descr").each(function(){
            height = Math.max(height, $(this).height());
        });
        return height;
    },
    assignOptions: function(options){
        this.imgWidth = options.imgWidth || "";
        this.imgHeight = options.imgHeight || "";

        for(var i = 0; options.data && i < options.data.length; i++){
            var item = {};
            item.src = !options.data[i].length ? options.data[i] : options.data[i][0];
            item.descr = options.data[i].length && options.data[i].length > 1 ? options.data[i][1] : "";
            item.descr && (this.requireShowDescr = true);
            this.data.push(item);
        }
    },
    createHierarchy: function(){
        this.$mainElement.addClass("dx-ig");
        this.$mainElement.append(this.createImageContainer());

        this.$mainElement.append(this.createPreviousButton());
        this.$mainElement.append(this.createNextButton());
    },
    createImageContainer: function(){
        var $div = $(document.createElement("div"));
        $div.addClass("dx-ig-container");
        for(var i = 0; i < this.data.length; i++){
            $div.append(this.createImageItem(i, this.data[i]));
        }
        return $div;
    },
    createImageItem: function(index, itemData){
        var $div = $(document.createElement("div"));
        $div.addClass("dx-ig-item");
        $div.attr("data-index", index);
        $div.css({ width: this.imgWidth })

        var $img = $(itemData.src);
        $img.css({ width: this.imgWidth, height: this.imgHeight });
        var _this = this;
        $img.load(function(){ _this.adjustImageSize(index); });
        $img.click(function(){ _this.showNextImage(); });
        $div.append($img);

        if(this.requireShowDescr){
            var $desc = $(document.createElement("div"));
            $desc.addClass("dx-ig-descr");
            itemData.descr && $desc.html(itemData.descr);
            $div.append($desc);
        }

        return $div;
    },
    createPreviousButton: function(){
        var $prevButtonArea = this.createNavigationButtonArea("dx-ig-navl");
        var _this = this;
        $prevButtonArea.click(function(){ _this.showPrevImage(); });
        return $prevButtonArea;
    },
    createNextButton: function(){
        var $nextButtonArea = this.createNavigationButtonArea("dx-ig-navr");
        var _this = this;
        $nextButtonArea.click(function(){ _this.showNextImage(); });
        return $nextButtonArea;
    },
    createNavigationButtonArea: function(areaCSS){
        var $prevButtonArea = $(document.createElement('div'));
        $prevButtonArea.addClass("dx-ig-nav");
        areaCSS && $prevButtonArea.addClass(areaCSS);
 
        var $prevButton = $(document.createElement('div'));
        $prevButton.addClass("dx-ig-navb");

        var $divImg = $(document.createElement('div'));
        $divImg.addClass("dx-ig-navbi");
        
        $prevButton.append($divImg);
        $prevButtonArea.append($prevButton);
        return $prevButtonArea;
    },
    adjustImageSize: function(index){
        var $item = this.getItem(index);
        if(!$item.length)
            return;
        var $img = $item.find("img");
        $img.width('auto');
        $img.height('auto');
 
        var ratio = $img.width() / $img.height();
        $img.width(ratio > 1 ? Math.min(this.imgWidth, ratio * this.imgHeight) : $img.height() * ratio);
        $img.height(ratio < 1 ? Math.min(this.imgHeight, this.imgWidth / ratio) : $img.width() / ratio);
 
        if(this.requireShowDescr){
            var defaultPadding = 10;
            var descrHeight = $item.children(".dx-ig-descr").find('span').height() + defaultPadding;
            $item.children(".dx-ig-descr").height(descrHeight).css({ lineHeight: descrHeight + "px" });
        }
    },

    show: function(index, withoutAnimate){
        var $item = this.getItem(index);
        if(!$item.length)
            return;
        this.$mainElement.find(".dx-ig-item").each(function(i, el){ 
            withoutAnimate && $(el).hide() || $(el).fadeOut("slow"); 
        });
        withoutAnimate && $item.show() || $item.fadeIn("slow");
    },
    showNextImage: function(){
        var index = this.getActiveIndex() + 1;
        if(index >= this.data.length)
            index = 0;
        this.show(index);
    },
    showPrevImage: function(){
        var index = this.getActiveIndex() - 1;
        if(index < 0)
            index = this.data.length - 1;
        this.show(index);
    },
    getActiveIndex: function(){
        return parseInt(this.getActiveItem().attr("data-index"));
    },

    getActiveItem: function(){
        return this.$mainElement.find(".dx-ig-item:visible");
    },
    getItem: function(index){
        return this.$mainElement.find("[data-index='" + index + "']");
    }
});

$.fn.extend({
    dxig: function(options){
        new imageGallery(this, options);
    }
});
}());