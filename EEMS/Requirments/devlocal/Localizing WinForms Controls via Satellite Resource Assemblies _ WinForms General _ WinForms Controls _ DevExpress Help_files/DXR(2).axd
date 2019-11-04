/*# namespace DevExpress.Web.ASPxClasses.Scripts #*/

/*# public class JavaScriptObject : object #*/

var ASPx = {};
ASPx.SSLSecureBlankUrl = "/DXR.axd?r=1_0-yRpS9";
ASPx.EmptyImageUrl = "/DXR.axd?r=1_5-yRpS9";

var __aspxStyleSheet = null;
var __aspxInvalidDimension = -10000;
var __aspxInvalidPosition = -10000;
var __aspxAbsoluteLeftPosition = -10000;
var __aspxAbsoluteRightPosition = 10000;
var __aspxMenuZIndex = 21998;
var __aspxPopupControlZIndex = 11998;
var __aspxPopupShadowWidth = 5;
var __aspxPopupShadowHeight = 5;

var /* const */ __aspxCheckSizeCorrectedFlag = true;
var __aspxCallbackSeparator = ":";
var __aspxItemIndexSeparator = "i";
var __aspxCallbackResultPrefix = "/*DX*/";
var __aspxItemClassName = "dxi";
var __aspxAccessibilityEmptyUrl = "javascript:;";
var __aspxAccessibilityMarkerClass = "dxalink";

var __aspxClassesScriptParsed = false;
var __aspxDocumentLoaded = false; 

var __aspxEmptyAttributeValue = { };
var __aspxEmptyCachedValue = { };
var __aspxCachedRules = { };
var __aspxStyleCount = 0;
var __aspxStyleNameCache = { };

var __aspxPossibleNumberDecimalSeparators = [",", "."];

var __aspxCultureInfo = {
    twoDigitYearMax: 2029,
    ts: ":",
    ds: "/",
    am: "AM",
    pm: "PM",
	monthNames: ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", ""],
	genMonthNames: null,
	abbrMonthNames: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec", ""],
	abbrDayNames: ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"],
	dayNames: ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"],
	
	numDecimalPoint: ".",
	numPrec: 2,
	numGroupSeparator: ",",	
	numGroups: [ 3 ],
	numNegPattern: 1,
	
	numPosInf: "Infinity",	
	numNegInf: "-Infinity", 
	numNan: "NaN",
	
	currency: "$",
	
	currDecimalPoint: ".",
	currPrec: 2,
	currGroupSeparator: ",",
	currGroups: [ 3 ],
	currPosPattern: 0,
	currNegPattern: 0,
	
	percentPattern: 0,

	shortTime: "h:mm tt",
	longTime: "h:mm:ss tt",
	shortDate: "M/d/yyyy",
	longDate: "dddd, MMMM dd, yyyy",
	monthDay: "MMMM dd",
	yearMonth: "MMMM, yyyy"
};
__aspxCultureInfo.genMonthNames = __aspxCultureInfo.monthNames;

function _aspxGetInvariantDateString(date) {
    if(!date)
        return "01/01/0001";
    var day = date.getDate();
    var month = date.getMonth() + 1;
    var year = date.getFullYear();
    var result = "";
    if(month < 10)
        result += "0";
    result += month.toString() + "/";
    if(day < 10)
        result += "0";
    result += day.toString() + "/";
    if(year < 1000)
        result += "0";
    result += year.toString();
    return result;
}
function _aspxGetInvariantDateTimeString(date) {
    var dateTimeString = _aspxGetInvariantDateString(date);
    
    var time = {
        h: date.getHours(),
        m: date.getMinutes(),
        s: date.getSeconds()
    };
    for(var key in time) {
        var str = time[key].toString();
        if(str.length < 2)
            str = "0" + str;
        time[key] = str;
    }
    dateTimeString += " " + time.h + ":" + time.m + ":" + time.s;
    
    var msec = date.getMilliseconds();
    if(msec > 0)
        dateTimeString += "." + msec.toString();

    return dateTimeString;
}
function _aspxExpandTwoDigitYear(value) {
    value += 1900;
    if(value + 99 < __aspxCultureInfo.twoDigitYearMax)
        value += 100;
    return value;	    
}
function _aspxToUtcTime(date) {
	var result = new Date();
	result.setTime(date.valueOf() + 60000 * date.getTimezoneOffset());
	return result;
}
function _aspxToLocalTime(date) {
	var result = new Date();
	result.setTime(date.valueOf() - 60000 * date.getTimezoneOffset());
	return result;	
}
function _aspxAreDatesEqualExact(date1, date2) {
    if(date1 == null && date2 == null)
        return true;
    if(date1 == null || date2 == null)
        return false;
    return date1.getTime() == date2.getTime();    
}
function _aspxFixTimezoneGap(oldDate, newDate) {
    // B31219, B95404, Q148106, Q151614, B159521
	var diff = newDate.getHours() - oldDate.getHours();
	if(diff == 0)
		return;

	var sign = (diff == 1 || diff == -23) ? -1 : 1;
	var trial = new Date(newDate.getTime() + sign * 3600000);

	if(sign > 0 || trial.getDate() == newDate.getDate())
		newDate.setTime(trial.getTime());
}

var ASPxKey = {
    F1           : 112,
    F2           : 113,
    F3           : 114,
    F4           : 115,
    F5           : 116,
    F6           : 117,
    F7           : 118,
    F8           : 119,
    F9           : 120,
    F10          : 121,
    F11          : 122,
    F12          : 123,
    Ctrl         : 17,
    Shift        : 16,
    Alt          : 18,
    Enter        : 13,
    Home         : 36,
    End          : 35,
    Left         : 37,
    Right        : 39,
    Up           : 38,
    Down         : 40,
    PageUp       : 33,
    PageDown     : 34,
    Esc          : 27,
    Space        : 32,
    Tab          : 9,
    Backspace    : 8,
    Delete       : 46,
    Insert       : 45,
    ContextMenu  : 93,
    Windows      : 91,
    Decimal      : 110
};
var ASPxCallbackType = {
    Data: "d",
    Common: "c"
};

var ASPxWhiteSpaces = { 
    0x0009: 1, 0x000a: 1, 0x000b: 1, 0x000c: 1, 0x000d: 1, 0x0020: 1, 0x0085: 1, 
    0x00a0: 1, 0x1680: 1, 0x180e: 1, 0x2000: 1, 0x2001: 1, 0x2002: 1, 0x2003: 1, 
    0x2004: 1, 0x2005: 1, 0x2006: 1, 0x2007: 1, 0x2008: 1, 0x2009: 1, 0x200a: 1, 
    0x200b: 1, 0x2028: 1, 0x2029: 1, 0x202f: 1, 0x205f: 1, 0x3000: 1
};
        
function _aspxFalseFunction() { return false; }
        
function _aspxGetActiveElement() {
    try{
        return document.activeElement;
    } catch(e) {

    }
    return null;
}

// Browsers

var __aspxUserAgent = navigator.userAgent.toLowerCase();
var __aspxMozilla,
    __aspxIE,
    __aspxFirefox,
    __aspxNetscape,
    __aspxSafari,
    __aspxChrome,
    __aspxOpera,
    
    __aspxBrowserVersion, // {major}.{1-digit minor}
    __aspxBrowserMajorVersion, // {major}
    
    __aspxWindowsPlatform,
    __aspxMacOSPlatform,
    __aspxMacOSMobilePlatform,
    
    __aspxWebKitFamily, // Safari or Chrome
    __aspxNetscapeFamily, // Mozilla, Nestcape, or Firefox
    __aspxBrowserWithHardwareAcceleration;

function _aspxIdentUserAgent(userAgent, ignoreDocumentMode) {
    var browserTypesOrderedList = [ "Mozilla", "IE", "Firefox", "Netscape", "Safari", "Chrome", "Opera", "Opera10" ];
    var defaultBrowserType = "IE";
    var defaultPlatform = "Win";
    var defaultVersions = { Safari: 2, Chrome: 0.1, Mozilla: 1.9, Netscape: 8, Firefox: 2, Opera: 9, IE: 6 };

    if(!userAgent || userAgent.length == 0) {
        _aspxFillUserAgentInfo(browserTypesOrderedList, defaultBrowserType, defaultVersions[defaultBrowserType], defaultPlatform);
        return;
    }

    try {
        var platformIdentStrings = {
            "Windows": "Win",
            "Macintosh": "Mac",
            "Mac OS": "Mac",
            "Mac_PowerPC": "Mac",
            "cpu os": "MacMobile",
            "cpu iphone os": "MacMobile",
            "Android": "Android"
        };

        var optSlashOrSpace = "(?:/|\\s*)?";
        var version = "(\\d+)(?:\\.((?:\\d+?[1-9])|\\d)0*?)?";
        var optVersion = "(?:" + version + ")?";
        var patterns = {
            Safari: "applewebkit(?:.*?(?:version/" + version + "[\\.\\w\\d]*?(?:\\s+mobile\/\\S*)?\\s+safari))?",
            Chrome: "chrome(?!frame)" + optSlashOrSpace + optVersion,
            Mozilla: "mozilla(?:.*rv:" + optVersion + ".*Gecko)?",
            Netscape: "(?:netscape|navigator)\\d*/?\\s*" + optVersion,
            Firefox: "firefox" + optSlashOrSpace + optVersion,
            Opera: "opera" + optSlashOrSpace + optVersion,
            Opera10: "opera.*\\s*version" + optSlashOrSpace + optVersion,
            IE: "msie\\s*" + optVersion
        };

        var browserType;
        var version = -1;
        for(var i = 0; i < browserTypesOrderedList.length; i++) {
            var browserTypeCandidate = browserTypesOrderedList[i];

            var regExp = new RegExp(patterns[browserTypeCandidate], "i");
            if(regExp.compile)
                regExp.compile(patterns[browserTypeCandidate], "i");
            var matches = regExp.exec(userAgent);

            if(matches && matches.index >= 0) {
                browserType = browserTypeCandidate;
                if(browserType == "Opera10")
                    browserType = "Opera";

                version = -1;
                var versionStr = "";
                if(matches[1]) {
                    versionStr += matches[1];
                    if(matches[2])
                        versionStr += "." + matches[2];
                }
                if(versionStr != "") {
                    version = parseFloat(versionStr);
                    if(version == NaN)
                        version = -1;
                }
            }
        }
        
        if(!browserType)
            browserType = defaultBrowserType;
        var browserVersionDetected = version != -1;
		if(!browserVersionDetected)
            version = defaultVersions[browserType];
            
        if(!ignoreDocumentMode && browserType == "IE" && version > 7 && document.documentMode < version) {
            version = document.documentMode;
        }
        
        var platform;
        var minOccurenceIndex = Number.MAX_VALUE;
        for(var identStr in platformIdentStrings) {
            var occurenceIndex = userAgent.toLowerCase().indexOf(identStr.toLowerCase());
            if(occurenceIndex >= 0 && occurenceIndex < minOccurenceIndex) {
                minOccurenceIndex = occurenceIndex;
                platform = platformIdentStrings[identStr];
            }
        }
        if(!platform)
            platform = defaultPlatform;
        if(platform == platformIdentStrings["cpu os"] && !browserVersionDetected) // Terra browser
            version = 4;

        _aspxFillUserAgentInfo(browserTypesOrderedList, browserType, version, platform);
    } catch(e) {
        _aspxFillUserAgentInfo(browserTypesOrderedList, defaultBrowserType, defaultVersions[defaultBrowserType], defaultPlatform);
    }
}
function _aspxFillUserAgentInfo(browserTypesOrderedList, browserType, version, platform) {
    for(var i = 0; i < browserTypesOrderedList.length; i++) {
        var type = browserTypesOrderedList[i];
        window["__aspx" + type] = type == browserType;
    }
    __aspxBrowserVersion = Math.floor(10.0 * version) / 10.0;
    __aspxBrowserMajorVersion = Math.floor(__aspxBrowserVersion);
    __aspxWindowsPlatform = platform == "Win";
    __aspxMacOSPlatform = platform == "Mac";
    __aspxMacOSMobilePlatform = platform == "MacMobile";
    __aspxAndroidMobilePlatform = platform == "Android";
    __aspxTouchUI = __aspxMacOSMobilePlatform || __aspxAndroidMobilePlatform;
    __aspxWebKitFamily = __aspxSafari || __aspxChrome;
    __aspxNetscapeFamily = __aspxNetscape || __aspxMozilla || __aspxFirefox;
    __aspxBrowserWithHardwareAcceleration = (__aspxIE && __aspxBrowserMajorVersion >= 9) || ( __aspxFirefox && __aspxBrowserMajorVersion >= 4);
}
_aspxIdentUserAgent(__aspxUserAgent);

ASPx.BlankUrl = __aspxIE
    ? ASPx.SSLSecureBlankUrl
    : (__aspxOpera
        ? "about:blank"
        : "");

// Array
function _aspxArrayInsert(array, element, position){
    if(0 <= position && position < array.length){
        for(var i = array.length; i > position; i --)
            array[i] = array[i - 1];
        array[position] = element;
    }
    else
        array.push(element);
}

function _aspxArrayRemove(array, element){
    var index = _aspxArrayIndexOf(array, element);
    if(index > -1) _aspxArrayRemoveAt(array, index);
}
function _aspxArrayRemoveAt(array, index){
    if(index >= 0  && index < array.length){
        for(var i = index; i < array.length - 1; i++)
            array[i] = array[i + 1];
        array.pop();
    }
}
function _aspxArrayClear(array){
    while(array.length > 0)
        array.pop();
}
function _aspxArrayIndexOf(array, element, comparer) {
    if(!comparer) {
        for(var i = 0; i < array.length; i++) {
            if(array[i] == element)
                return i;
        }
    } else {
        for(var i = 0; i < array.length; i++) {
            if(comparer(array[i], element))
                return i;
        }
    }
    return -1;
}
function _aspxArrayIntegerAscendingSort(array){
    array.sort(function(i1, i2){
        if (i1 > i2)
            return 1;
        else if (i1 < i2)
            return -1;
        else
            return 0;
    });
}
function _aspxCollectionsUnionToArray(firstCollection, secondCollection) {
    var result = [];
    var firstCollectionLength = firstCollection.length;
    var secondCollectionLength = secondCollection.length;
    for(var i = 0; i <  firstCollectionLength + secondCollectionLength; i++) {
        if(i < firstCollectionLength) 
            result.push(firstCollection[i]);
        else 
            result.push(secondCollection[i - firstCollectionLength]);
    }        
    return result;
}
function _aspxCollectionToArray(collection) {
    var array = [];
    for(var i = 0; i < collection.length; i++)
        array.push(collection[i]);
    return array;
}
function _aspxCreateHashTableFromArray(array) {
    var hash = [];
    for(var i = 0; i < array.length; i++)
        hash[array[i]] = 1;
    return hash;
}
function _aspxCreateIndexHashTableFromArray(array) {
    var hash = [];
    for(var i = 0; i < array.length; i++)
        hash[array[i]] = i;
    return hash;
}

var __aspxDefaultBinarySearchComparer = function(arrayElement, value) {
    if(arrayElement == value)
        return 0;
    else
        return arrayElement < value ? -1 : 1;
};
function _aspxArrayBinarySearch(array, value, binarySearchComparer, startIndex, length) {
    if(!binarySearchComparer)
        binarySearchComparer = __aspxDefaultBinarySearchComparer;
    if(!_aspxIsExists(startIndex))
        startIndex = 0;
    if(!_aspxIsExists(length))
        length = array.length - startIndex;        
    var endIndex = (startIndex + length) - 1;
    while (startIndex <= endIndex) {
        var middle =  (startIndex + ((endIndex - startIndex) >> 1));
        var compareResult = binarySearchComparer(array[middle], value);
        if (compareResult == 0)
            return middle;
        if (compareResult < 0)
            startIndex = middle + 1;
        else
            endIndex = middle - 1;
    }
    return -(startIndex + 1);
}
function _aspxApplyReplacement(text, replecementTable) {
    for(var i = 0; i < replecementTable.length; i++) {
        var replacement = replecementTable[i];
        text = text.replace(replacement[0], replacement[1]);
    }
    return text;
}

function _aspxNodeListToArray(nodeList, filter) {
    var result = [];

    for(var i = 0, element; element = nodeList[i]; i++) {
        if(filter && !filter(element))
            continue;

        result.push(element);
    }

    return result;
}

function _aspxEncodeHtml(html) {
    return _aspxApplyReplacement(html, [
        [ /&amp;/g,  '&ampx;'  ], [ /&/g, '&amp;'  ],
        [ /&quot;/g, '&quotx;' ], [ /"/g, '&quot;' ],
        [ /&lt;/g,   '&ltx;'   ], [ /</g, '&lt;'   ],
        [ /&gt;/g,   '&gtx;'   ], [ />/g, '&gt;'   ]
    ]);
}
function _aspxDecodeHtml(html) {
    return _aspxApplyReplacement(html, [
        [ /&gt;/g,   '>' ], [ /&gtx;/g,  '&gt;'   ],
        [ /&lt;/g,   '<' ], [ /&ltx;/g,  '&lt;'   ],
        [ /&quot;/g, '"' ], [ /&quotx;/g,'&quot;' ],
        [ /&amp;/g,  '&' ], [ /&ampx;/g, '&amp;'  ]
    ]);
}
// ** Keyboard support utils **
// for ex. CTRL+SHIFT+Z
function _aspxParseShortcutString(shortcutString) {
    if(!shortcutString)
        return 0;

    var isCtrlKey = false;
    var isShiftKey = false;
    var isAltKey = false;
    var keyCode = null;
    
    var shcKeys = shortcutString.toString().split("+");
    
    if (shcKeys.length > 0) {
        for (var i = 0; i < shcKeys.length; i++) {
            var key = _aspxTrim(shcKeys[i].toUpperCase());
            switch (key) {
                case "CTRL":
                    isCtrlKey = true;
                    break;
                case "SHIFT":
                    isShiftKey = true;
                    break;
                case "ALT":
                    isAltKey = true;
                    break;

                case "F1":    keyCode = ASPxKey.F1; break;
                case "F2":    keyCode = ASPxKey.F2; break;
                case "F3":    keyCode = ASPxKey.F3; break;
                case "F4":    keyCode = ASPxKey.F4; break;
                case "F5":    keyCode = ASPxKey.F5; break;
                case "F6":    keyCode = ASPxKey.F6; break;
                case "F7":    keyCode = ASPxKey.F7; break;
                case "F8":    keyCode = ASPxKey.F8; break;
                case "F9":    keyCode = ASPxKey.F9; break;
                case "F10":   keyCode = ASPxKey.F10; break;
                case "F11":   keyCode = ASPxKey.F11; break;
                case "F12":   keyCode = ASPxKey.F12; break;

                case "ENTER": keyCode = ASPxKey.Enter; break;
                case "HOME":  keyCode = ASPxKey.Home; break;
                case "END":   keyCode = ASPxKey.End; break;
                case "LEFT":  keyCode = ASPxKey.Left; break;
                case "RIGHT": keyCode = ASPxKey.Right; break;
                case "UP":    keyCode = ASPxKey.Up; break;
                case "DOWN":  keyCode = ASPxKey.Down; break;
                case "PAGEUP": keyCode = ASPxKey.PageUp; break;
                case "PAGEDOWN": keyCode = ASPxKey.PageDown; break;
                case "SPACE": keyCode = ASPxKey.Space; break;
                case "TAB":   keyCode = ASPxKey.Tab; break;
                case "BACK":  keyCode = ASPxKey.Backspace; break;
                case "CONTEXT": keyCode = ASPxKey.ContextMenu; break;

                case "ESCAPE":
                case "ESC":
                    keyCode = ASPxKey.Esc;
                    break;

                case "DELETE":
                case "DEL":
                    keyCode = ASPxKey.Delete;
                    break;

                case "INSERT":
                case "INS":
                    keyCode = ASPxKey.Insert;
                    break;

                case "PLUS":
                    keyCode = "+".charCodeAt(0);
                    break;
                default:
                    keyCode = key.charCodeAt(0);
                    break;
            }
        }
    } else
        alert("Invalid shortcut");
    return _aspxGetShortcutCode(keyCode, isCtrlKey, isShiftKey, isAltKey);
}
function _aspxGetShortcutCode(keyCode, isCtrlKey, isShiftKey, isAltKey) {
    var value = keyCode & 0xFFFF;
    var flags = 0;
    flags |= isCtrlKey ? 1 << 0 : 0;
    flags |= isShiftKey ? 1 << 2 : 0;
    flags |= isAltKey ? 1 << 4 : 0;
    value |= flags << 16;
    return value;
}
function _aspxGetShortcutCodeByEvent(evt) {
    return _aspxGetShortcutCode(_aspxGetKeyCode(evt), evt.ctrlKey, evt.shiftKey, evt.altKey);
}
function _aspxIsPasteShortcut(evt){
    var keyCode = _aspxGetKeyCode(evt);
    
    if (__aspxNetscapeFamily && evt.which == 0)        
        keyCode = evt.keyCode;
    
    return (evt.ctrlKey && (keyCode == 118 /*v*/ || (keyCode == 86)/*V*/)) ||
           (evt.shiftKey && !evt.ctrlKey && !evt.altKey &&
           (keyCode == ASPxKey.Insert)) ;
}
var ASPxImageUtils = {
    IsAlphaFilterNeed: function(src){
        return __aspxIE && __aspxBrowserVersion < 7 && this.IsPng(src);
    },
    IsPng: function(src){
        return src.slice(-3).toLowerCase() == "png";
    },
    GetImageFilterStyle: function(src){
        return "progid:DXImageTransform.Microsoft.AlphaImageLoader(src=" + src + ", sizingMethod=scale)";
    },
    GetImageSrc: function (image){
        if(_aspxIsAlphaFilterUsed(image)){ // TODO move _aspxIsAlphaFilterUsed  to ASPxImageUtils
            var filter = image.style.filter;
            var regSrc = new RegExp("src=", "g");
            var regPng = new RegExp(".png", "g");
            var beginIndex = regSrc.exec(filter).lastIndex;
            var endIndex = regPng.exec(filter).lastIndex;
            return filter.substring(beginIndex, endIndex);
        } 
        return image.src;
    },
    SetImageSrc: function(image, src){
        var isAlphaFilterNeed = this.IsAlphaFilterNeed(src);
        if(isAlphaFilterNeed){
            image.src = ASPx.EmptyImageUrl;
            image.style.filter = this.GetImageFilterStyle(src);
        } else {
            image.src = src;
            image.style.filter = "";
        }
    },
    SetSize: function(image, width, height){
        image.style.width = width + "px";
        image.style.height = height + "px";
    },
    GetSize: function(image, isWidth){
        return (isWidth ? image.offsetWidth : image.offsetHeight);
    }
};

function _aspxAddAlphaImageLoaderTarget(id, imageUrl) {
    if(!window._aspxAlphaImageLoaderTargets)
        window._aspxAlphaImageLoaderTargets = [];
    window._aspxAlphaImageLoaderTargets.push({ elementId: id, bgImageUrl: imageUrl });
}
function _aspxEnsureAlphaImageLoaderApplierRegistered() {
    if(!window._aspxPostponedAlphaImageLoaderApplierAdded) {
        var handler = function() {
            if(window._aspxAlphaImageLoaderTargets) {
                for(var i = 0; i < window._aspxAlphaImageLoaderTargets.length; i++) {
                    var target = window._aspxAlphaImageLoaderTargets[i];
                    _aspxApplyAlphaImageLoaderToBackground(target.elementId, target.bgImageUrl);
                }
                window._aspxAlphaImageLoaderTargets = [];
            }
        };
        if(typeof(aspxGetControlCollection) == "function")
            aspxGetControlCollection().ControlsInitialized.AddHandler(handler);
        else
            window.attachEvent("onload", handler);
        window._aspxPostponedAlphaImageLoaderApplierAdded = true;
    }
}
function _aspxApplyAlphaImageLoaderToBackground(elementId, bgImageUrl) {
    var element = document.all[elementId];
    if(element && element.length)
        element = document.getElementById(elementId);
    element.style.filter = "progid:DXImageTransform.Microsoft.AlphaImageLoader(src=" + bgImageUrl + ", sizingMethod=crop)";
}
function _aspxApplyAlphaImageLoaderToImage(image) {
    if(image.alphaImageLoaderApplied)
        return;

    image.alphaImageLoaderApplied = true;
    var imageUrl = image.src;
    image.src = ASPx.EmptyImageUrl;
    image.style.filter = "progid:DXImageTransform.Microsoft.AlphaImageLoader(src=" + imageUrl + ", sizingMethod=scale)";
}
var __aspxVerticalScrollBarWidth;
function _aspxGetVerticalScrollBarWidth() {
    if(typeof(__aspxVerticalScrollBarWidth) == "undefined") {
        var container = document.createElement("DIV");
        container.style.cssText = "position: absolute; top: 0px; left: 0px; visibility: hidden; width: 200px; height: 150px; overflow: hidden";
        document.body.appendChild(container);

        var child = document.createElement("P");
        container.appendChild(child);
        child.style.cssText = "width: 100%; height: 200px;";

        var widthWithoutScrollBar = child.offsetWidth;
        container.style.overflow = "scroll";
        var widthWithScrollBar = child.offsetWidth;
        if(widthWithoutScrollBar == widthWithScrollBar)
            widthWithScrollBar = container.clientWidth;

        __aspxVerticalScrollBarWidth = widthWithoutScrollBar - widthWithScrollBar;
        
        document.body.removeChild(container);
    }
    return __aspxVerticalScrollBarWidth;
}
function _aspxGetVerticalOverflow(element) {
    if(__aspxIE || __aspxSafari && __aspxBrowserVersion >= 3 || __aspxChrome)
        return element.style.overflowY;
    return element.style.overflow;
}
function _aspxSetVerticalOverflow(element, value) {
    if(__aspxIE || __aspxSafari && __aspxBrowserVersion >= 3 || __aspxChrome)
        element.style.overflowY = value;
    else
        element.style.overflow = value;
}

function _aspxHideScrollBarCore(element, scrollName) {
    if(element.tagName == "IFRAME") {
        if((element.scrolling == "yes") || (element.scrolling == "auto")) {
            _aspxChangeAttribute(element, "scrolling", "no");
            return true;
        }
    }
    else if(element.tagName == "DIV") {
        if((element.style[scrollName] == "scroll") || (element.style[scrollName] == "auto")) {
            _aspxChangeStyleAttribute(element, scrollName, "hidden");
            return true;
        }
    }
    return false;
}
function _aspxRestoreScrollBarCore(element, scrollName) {
    if(element.tagName == "IFRAME")
        return _aspxRestoreAttribute(element, "scrolling");
    else if(element.tagName == "DIV")
        return _aspxRestoreStyleAttribute(element, scrollName);
    return false;
}
function _aspxSetScrollBarVisibilityCore(element, scrollName, isVisible) {
    return isVisible ? _aspxRestoreScrollBarCore(element, scrollName) : _aspxHideScrollBarCore(element, scrollName);
}
function _aspxSetScrollBarVisibility(element, isVisible) {
    if(_aspxSetScrollBarVisibilityCore(element, "overflow", isVisible)) // B143193
        return true;
    var result = _aspxSetScrollBarVisibilityCore(element, "overflowX", isVisible)
        || _aspxSetScrollBarVisibilityCore(element, "overflowY", isVisible);
    return result;
}

// Timer
function _aspxSetTimeout(callString, timeout){
    return window.setTimeout(callString, timeout);
}
function _aspxClearTimer(timerID){
    if(timerID > -1)
        window.clearTimeout(timerID);
    return -1;
}
// Interval
function _aspxSetInterval(callString, interval){
    return window.setInterval(callString, interval);
}
function _aspxClearInterval(timerID){
    if(timerID > -1)
        window.clearInterval(timerID);
    return -1;
}
// Utils

// [Victor] Simple innerHTML property assignation doesn't affect the node
// inner HTML in IE when the insertable markup begins with the SCRIPT tag
// (or any other "special processing"-tags like STYLE or LINK)
function _aspxSetInnerHtml(element, html) {
    if(__aspxIE) {
        element.innerHTML = "<em>&nbsp;</em>" + html;
        element.removeChild(element.firstChild);
    } else
        element.innerHTML = html;
}
function _aspxGetInnerText(container) {
    if (__aspxNetscapeFamily)
        return container.textContent;
    else if (__aspxWebKitFamily) {
        var filter = _aspxGetHtml2PlainTextFilter();
        filter.innerHTML = container.innerHTML;
        _aspxSetElementDisplay(filter, true);
        var innerText = filter.innerText;
        _aspxSetElementDisplay(filter, false);
        return innerText;
    } else
        return container.innerText;
}
var __aspxHtml2PlainTextFilter = null;
function _aspxGetHtml2PlainTextFilter() {
    if (__aspxHtml2PlainTextFilter == null) {
        __aspxHtml2PlainTextFilter = document.createElement("DIV");
        __aspxHtml2PlainTextFilter.style.width = "0";
        __aspxHtml2PlainTextFilter.style.height = "0";
        __aspxHtml2PlainTextFilter.style.overflow = "visible";
        _aspxSetElementDisplay(__aspxHtml2PlainTextFilter, false);
        document.body.appendChild(__aspxHtml2PlainTextFilter);
    }
    return __aspxHtml2PlainTextFilter;
}
function _aspxCreateHiddenField(name, id) {
    var input = document.createElement("INPUT");
    input.setAttribute("type", "hidden");
    if(name)
        input.setAttribute("name", name);
    if(id)
        input.setAttribute("id", id);
    return input;
}
function _aspxCloneObject(srcObject) {
  if(typeof(srcObject) != 'object' || srcObject == null)
    return srcObject;
  var newObject = { };
  for(var i in srcObject) 
    newObject[i] = srcObject[i];
  return newObject;
}
function _aspxIsExists(obj){
    return (typeof(obj) != "undefined") && (obj != null);
}
function _aspxIsFunction(obj){
    return typeof(obj) == "function";
}
function _aspxGetDefinedValue(value, defaultValue){
    return (typeof(value) != "undefined") ? value : defaultValue;
}
function _aspxGetKeyCode(srcEvt) {
    return __aspxNetscapeFamily || __aspxOpera ? srcEvt.which : srcEvt.keyCode;
}

function _aspxPreventElementDrag(element) {
    if(__aspxIE)
        _aspxAttachEventToElement(element, "dragstart", _aspxPreventEvent);
    else
        _aspxAttachEventToElement(element, "mousedown", _aspxPreventEvent);
}
function _aspxPreventElementDragAndSelect(element, skipMouseMove, skipIESelect){
    if(__aspxWebKitFamily)
        _aspxAttachEventToElement(element, "selectstart", _aspxPreventEventAndBubble);
    if(__aspxIE){
        if(!skipIESelect)
            _aspxAttachEventToElement(element, "selectstart", _aspxFalseFunction);
        if(!skipMouseMove)
            _aspxAttachEventToElement(element, "mousemove", _aspxClearSelectionOnMouseMove);
        _aspxAttachEventToElement(element, "dragstart", _aspxPreventDragStart);
    }
}
function _aspxSetElementAsUnselectable(element, isWithChild) {
    if (element && element.nodeType == 1) {
        element.unselectable = "on";
        if(__aspxNetscapeFamily)
            element.onmousedown = _aspxFalseFunction;
        if((__aspxIE && __aspxBrowserVersion >= 9) || __aspxWebKitFamily)
            _aspxAttachEventToElement(element, "mousedown", _aspxPreventEventAndBubble);
        if(isWithChild === true){
            for(var j = 0; j < element.childNodes.length; j ++)
                _aspxSetElementAsUnselectable(element.childNodes[j]);
        }
    }
}
function _aspxIsWidthSetInPercentage(width) {
    return width.indexOf('%') != -1;
}
function _aspxClearSelection() {
    try {
        if (window.getSelection) {
            if (__aspxWebKitFamily)
                window.getSelection().collapse();
            else
                window.getSelection().removeAllRanges();
        }
        else if (document.selection) {
            if(document.selection.empty)
                document.selection.empty();
            else if(document.selection.clear)
                document.selection.clear();
        }
    } catch(e) {

    }
}
function _aspxClearSelectionOnMouseMove(evt) {
    if (!__aspxIE || (evt.button != 0)) 
        _aspxClearSelection();
}
function _aspxPreventDragStart(evt) {
    evt = _aspxGetEvent(evt);
    var element = _aspxGetEventSource(evt);
    element.releaseCapture(); 
    return false;
}
function _aspxSetElementSelectionEnabled(element, value) {
    var userSelectValue = value ? "" : "none";
    var func = value ? _aspxDetachEventFromElement : _aspxAttachEventToElement;
    if(__aspxFirefox)
        element.style.MozUserSelect = userSelectValue;
    else if(__aspxWebKitFamily)
        element.style.webkitUserSelect = userSelectValue;
    else if(__aspxOpera)
        func(element, "mousemove", _aspxClearSelection);
    else {
        func(element, "selectstart", _aspxFalseFunction);
        func(element, "mousemove", _aspxClearSelection);
    }
}

function _aspxGetElementById(id) {
    if(document.getElementById)
        return document.getElementById(id);
    else
        return document.all[id];
}
function _aspxGetInputElementById(id) {
    var elem = _aspxGetElementById(id);
    if(!__aspxIE)
        return elem;

    if(elem) {
        if(elem.id == id)
            return elem;
        else {
            for(var i = 1; i < document.all[id].length; i++) {
                if(document.all[id][i].id == id)
                    return document.all[id][i];
            }
        }
    }
    return null;
}
function _aspxGetElementByIdInDocument(documentObj, id) {
    if(documentObj.getElementById)
        return documentObj.getElementById(id);
    else
        return documentObj.all[id];
}
function _aspxGetIsParent(parentElement, element) {
    while(element){
        if(element === parentElement)
            return true;
        if(element.tagName === "BODY")
            return false;
        element = element.parentNode;
    }
    return false;
}
function _aspxGetParentById(element, id) {
    element = element.parentNode;
    while(element){
        if(element.id === id)
            return element;
        element = element.parentNode;
    }
    return null;
}
function _aspxGetParentByTagName(element, tagName) {
    tagName = tagName.toUpperCase();
    while(element) {
        if(element.tagName === "BODY")
            return null;
        if(element.tagName === tagName)
            return element;
        element = element.parentNode;
    }
    return null;
}
function _aspxElementHasCssClass(element, className) {
    //B220674
    try {
        return !!element.className.match("(^|\\s)" + className + "(\\s|$)");
    } catch(e) {
        return false;
    }
}
function _aspxElementCssClassContains(element, className) {
    //B187659
    try {
        return element.className.indexOf(className) != -1;
    } catch(e) {
        return false;
    }
}

function _aspxGetChildNodesByClassName(parent, className) {
    if(parent.querySelectorAll) {
        var children = parent.querySelectorAll('.' + className);

        return _aspxNodeListToArray(children, function(element) { 
            return element.parentNode === parent;
        });
    }
    return _aspxGetChildNodes(parent, function(elem) { return elem.className && _aspxElementHasCssClass(elem, className); });
}

function _aspxGetDescendantNodesByClassName(parent, className) {
    if(parent.querySelectorAll) {
        var children = parent.querySelectorAll('.' + className);
        return _aspxNodeListToArray(children);
    }

    return _aspxGetDescendantNodes(parent, function(elem) { return elem.className && _aspxElementHasCssClass(elem, className); });
}
function _aspxGetParentByClassNameInternal(element, className, selector) {
    while(element != null) {
        if(element.tagName == "BODY")
            return null;
        if(selector(element, className))
            return element;
        element = element.parentNode;
    }
    return null;
}
function _aspxGetParentByPartialClassName(element, className) {
    return _aspxGetParentByClassNameInternal(element, className, _aspxElementCssClassContains);
}
function _aspxGetParentByClassName(element, className) {
    return _aspxGetParentByClassNameInternal(element, className, _aspxElementHasCssClass);
}
function _aspxGetParentByTagNameAndAttributeValue(element, tagName, attrName, attrValue) {
    tagName = tagName.toUpperCase();
    while(element != null) {
        if(element.tagName == "BODY")
            return null;
        if(element.tagName == tagName && element[attrName] == attrValue)
            return element;
        element = element.parentNode;
    }
    return null;
}
function _aspxGetChildById(element, id) {
    if(!__aspxIE)
        return _aspxGetElementById(id);
    else{
        var element = element.all[id];
        if(!element)
            return null;
        else if(!_aspxIsExists(element.length)) // fix two element with the same name and id
            return element;
        else
            return _aspxGetElementById(id);
    }
}
function _aspxGetElementsByTagName(element, tagName) {
    tagName = tagName.toUpperCase();

    if(element != null){
        var elementAllExists = !!element.all;
        var opera10_50 = __aspxOpera && elementAllExists && !element.all.tags;
        if (elementAllExists && !opera10_50 && (!__aspxFirefox || __aspxBrowserVersion < 3))
            return __aspxNetscape ? element.all.tags[tagName] : element.all.tags(tagName);
        else
            return element.getElementsByTagName(tagName);
    }
    return null;
}
function _aspxGetChildByTagName(element, tagName, index) {
    if(element != null){                
        var collection = _aspxGetElementsByTagName(element, tagName);
        if(collection != null){
            if(index < collection.length)
                return collection[index];
        }
    }
    return null;
}
function _aspxRetrieveByPredicate(scourceCollection, predicate) {
    var result = [];
    for(var i = 0; i < scourceCollection.length; i++) {
        var element = scourceCollection[i];
        if(!predicate || predicate(element)) 
            result.push(element);
    }
    return result;
}
function _aspxGetChildNodes(parent, predicate) {
    return _aspxRetrieveByPredicate(parent.childNodes, predicate);
}
function _aspxGetDescendantNodes(parent, predicate) {
    var c = parent.all || parent.getElementsByTagName('*');
    return _aspxRetrieveByPredicate(c, predicate);
}
function _aspxGetElementNodes(parent) {
    if(!parent) return null;
    return _aspxGetChildNodes(parent, function(e) { return e.nodeType == 1 })
}
function _aspxGetElementNodesByPredicate(parent, predicate) {
    if(!parent) return null;
    if(!predicate) return _aspxGetElementNodes(parent);
    return _aspxGetChildNodes(parent, function(e) { return e.nodeType == 1 && predicate(e); })
}
function _aspxGetChildTextNode(element, index) {
    if(element != null){
        var collection = [ ];
        _aspxGetChildTextNodeCollection(element, collection);
        if(index < collection.length)
            return collection[index];
    }
    return null;
}
function _aspxGetChildTextNodeCollection(element, collection) {
    for(var i = 0; i < element.childNodes.length; i ++){
        var childNode = element.childNodes[i];
        if(_aspxIsExists(childNode.nodeValue))
            collection.push(childNode);
        _aspxGetChildTextNodeCollection(childNode, collection);
    }
}
function _aspxGetChildrenByPartialClassName(element, className) {
    if(element.querySelectorAll) {
        var list = element.querySelectorAll('*[class*=' + className + ']');
        return _aspxNodeListToArray(list);
    }

    var collection = element.all || element.getElementsByTagName('*');
    
    var ret = [ ];
    if(collection != null) {
        for(var i = 0; i < collection.length; i ++) {
            if(_aspxElementCssClassContains(collection[i], className))
                ret.push(collection[i]);
        }
    }
    return ret;
}
function _aspxGetParentByPartialId(element, idPart){
    while(element && element.tagName != "BODY") {
        if(element.id && element.id.indexOf(idPart) > -1) 
            return element;

        element = element.parentNode;
    }
    return null;
}
function _aspxGetElementsByPartialId(element, partialName, list) {
    if(element.id && element.id.indexOf(partialName) > -1) {
        list.push(element);
    }
    if(element.childNodes)
    for(var i = 0; i < element.childNodes.length; i ++) {
        _aspxGetElementsByPartialId(element.childNodes[i], partialName, list);
    }
}
function _aspxGetElementDocument(element) {
    return element.document || element.ownerDocument;
}

function _aspxRemoveElement(element) {
    if(element && element.parentNode)
        element.parentNode.removeChild(element);
}
function _aspxReplaceTagName(element, newTagName) {
    if (element.nodeType != 1)
        return null;
    if (element.nodeName == newTagName)
        return element;
        
    var doc = element.ownerDocument;
    var newElem = doc.createElement(newTagName);
    _aspxCopyAllAttributes(element, newElem);
    
    for (var i = 0; i < element.childNodes.length; i++)
        newElem.appendChild(element.childNodes[i].cloneNode(true));
    element.parentNode.replaceChild(newElem, element);
    return newElem;
}
function _aspxRemoveOuterTags(element) {
    if (__aspxIE) {
        element.insertAdjacentHTML( 'beforeBegin', element.innerHTML ) ;
        _aspxRemoveElement(element);
    } else {
        var docFragment = element.ownerDocument.createDocumentFragment();
        for (var i = 0; i < element.childNodes.length; i++)
            docFragment.appendChild(element.childNodes[i].cloneNode(true));
        element.parentNode.replaceChild(docFragment, element);
    }
}
function _aspxWrapElementInNewElement(element, newElementTagName) {    
    var wrapElement = null;
    if (__aspxIE) {
        var wrapElement = element.ownerDocument.createElement(newElementTagName);
        wrapElement.appendChild(element.cloneNode(true));
        element.parentNode.insertBefore(wrapElement, element);
        element.parentNode.removeChild(element);
    } else {
        var docFragment = element.ownerDocument.createDocumentFragment();
        wrapElement = element.ownerDocument.createElement(newElementTagName);
        docFragment.appendChild(wrapElement);
        wrapElement.appendChild(element.cloneNode(true));
        element.parentNode.replaceChild(docFragment, element);
    }
    return wrapElement;
}
function _aspxInsertElementAfter(newElement, targetElement) {
    var parentElem = targetElement.parentNode;
    
    if(parentElem.childNodes[parentElem.childNodes.length - 1] == targetElement)
		parentElem.appendChild(newElement);
    else
		parentElem.insertBefore(newElement, targetElement.nextSibling);
}

function _aspxGetEvent(evt){
    return (typeof(event) != "undefined" && event != null && __aspxIE) ? event : evt; 
}
function _aspxPreventEvent(evt){
    if (evt.preventDefault)
        evt.preventDefault();
    else
        evt.returnValue = false;
    return false;
}
function _aspxPreventEventAndBubble(evt){
    _aspxPreventEvent(evt);
    if (evt.stopPropagation)
        evt.stopPropagation();
    evt.cancelBubble = true;
    return false;
}
function _aspxCancelBubble(evt){
    evt.cancelBubble = true;
    return false;
}

function _aspxClientEventRequiresDocScrollCorrection() {
    return !(__aspxSafari && __aspxBrowserVersion < 3 || __aspxMacOSMobilePlatform && __aspxBrowserVersion < 5.1);
}
function _aspxGetEventSource(evt){
    if(!_aspxIsExists(evt)) return null; 
    return evt.srcElement ? evt.srcElement : evt.target;
}
function _aspxGetEventX(evt){
    if(ASPxClientTouchUI.isTouchEvent(evt))
        return ASPxClientTouchUI.getEventX(evt);
    return evt.clientX  - _aspxGetIEDocumentClientOffsetInternal(true) + (_aspxClientEventRequiresDocScrollCorrection() ? _aspxGetDocumentScrollLeft() : 0);
}
function _aspxGetEventY(evt){
    if(ASPxClientTouchUI.isTouchEvent(evt))
        return ASPxClientTouchUI.getEventY(evt);
    var oldSafari = __aspxSafari && __aspxBrowserVersion < 3 || __aspxMacOSMobilePlatform && __aspxBrowserVersion < 5.1;
    return evt.clientY - _aspxGetIEDocumentClientOffsetInternal(false) + (_aspxClientEventRequiresDocScrollCorrection() ? _aspxGetDocumentScrollTop() : 0 );
}
function _aspxGetIEDocumentClientOffsetInternal(IsX){
    var clientOffset = 0;
    if(__aspxIE && __aspxBrowserVersion < 8){
        if(document.documentElement)
            clientOffset = IsX ? document.documentElement.clientLeft : document.documentElement.clientTop;
        if(clientOffset == 0 && document.body)
            var clientOffset = IsX ? document.body.clientLeft : document.body.clientTop;
    }
    return clientOffset;
}
function _aspxGetIsLeftButtonPressed(evt){
    if(ASPxClientTouchUI.isTouchEvent(evt))    
        return true;

    evt = _aspxGetEvent(evt);
    if(!evt) return false;
    if(__aspxIE)
        return evt.button % 2 == 1; // B213431
    else if(__aspxNetscapeFamily || __aspxWebKitFamily)
        return evt.which == 1;
    else if (__aspxOpera)
        return evt.button == 0;        
    return true;        
}
function _aspxGetWheelDelta(evt){
    var ret = __aspxNetscapeFamily ? -evt.detail : evt.wheelDelta;
    if (__aspxOpera && __aspxBrowserVersion < 9)
        ret = -ret;
    return ret;
}

function _aspxDelCookie(name){
    _aspxSetCookieInternal(name, "", new Date(1970, 1, 1));
}
function _aspxGetCookie(name) {
    name = escape(name);
    var cookies = document.cookie.split(';');
    for(var i = 0; i < cookies.length; i++) {
        var cookie = _aspxTrim(cookies[i]);
        if(cookie.indexOf(name + "=") == 0)
            return unescape(cookie.substring(name.length + 1, cookie.length));
        else if(cookie.indexOf(name + ";") == 0 || cookie === name)
            return "";
    }
    return null;
}
function _aspxSetCookie(name, value, expirationDate){
    if(!_aspxIsExists(value)) {
        _aspxDelCookie(name);
        return;
    }

    if(!ASPxIdent.IsDate(expirationDate)) {
        expirationDate = new Date();
        expirationDate.setFullYear(expirationDate.getFullYear() + 1);
    }
    _aspxSetCookieInternal(name, value, expirationDate);
}
function _aspxSetCookieInternal(name, value, date){
    document.cookie = escape(name) + "=" + escape(value.toString()) + "; expires=" + date.toGMTString() + "; path=/";
}

function _aspxSetElementOpacity(element, value) {
     var useOpacityStyle = !__aspxIE || __aspxBrowserVersion > 8;
     if (useOpacityStyle)
        element.style.opacity = value;
     else
        element.style.filter = "alpha(opacity=" + (value * 100) + ")";
}

function _aspxGetElementOpacity(element) {
    var useOpacityStyle = !__aspxIE || __aspxBrowserVersion > 8;
    if (useOpacityStyle)
        return parseFloat(element.style.opacity);
    else {
        var alphaValue = element.style.filter;
        if (alphaValue) {
            var value = alphaValue.replace("alpha(opacity=", "");
            value = value.replace(")", "");
            return parseInt(value) / 100;
        }
        return 100;
    }
}

function _aspxGetElementDisplay(element){
    return element.style.display != "none";
}
function _aspxSetElementDisplay(element, value){
    element.style.display = value ? "" : "none";
}
function _aspxGetElementVisibility(element){
    return element.style.visibility != "hidden";
}
function _aspxSetElementVisibility(element, value){
    element.style.visibility = value ? "visible" : "hidden";
}
function _aspxElementIsVisible(element){
    while(element && element.tagName != "BODY") {
        if(!_aspxGetElementVisibility(element) || !_aspxGetElementDisplay(element))
           return false;
        element = element.parentNode;
    }
    return true;
}
function _aspxElementIsDisplayed(element) {
    while(element && element.tagName != "BODY") {
        if(!_aspxGetElementDisplay(element))
           return false;
        element = element.parentNode;
    }
    return true;
}
function _aspxAddStyleSheetLinkToDocument(doc, linkUrl) {
    var newLink = _aspxCreateStyleLink(doc, linkUrl);
    var head = _aspxGetHeadElementOrCreateIfNotExist(doc);
    head.appendChild(newLink);
}
function _aspxGetHeadElementOrCreateIfNotExist(doc) {
    var elements = _aspxGetElementsByTagName(doc, "head");
    var head = null;
    // The Head element might not exist in the Safari browser, if the document content 
    // was created via the document.write() method. In this situation, we must create it.
    if (elements.length == 0) {
        head = doc.createElement("head");
        head.visibility = "hidden";
        doc.insertBefore(head, doc.body);
    } else
        head = elements[0];
    return head;
}
function _aspxCreateStyleLink(doc, url) {
    var newLink = doc.createElement("link");
    _aspxSetAttribute(newLink, "href", url);
    _aspxSetAttribute(newLink, "type", "text/css");
    _aspxSetAttribute(newLink, "rel", "stylesheet");
    return newLink;
}
function _aspxGetCurrentStyle(element){
    if (__aspxIE)
        return element.currentStyle;
    else if (__aspxOpera && __aspxBrowserVersion < 9)
        return window.getComputedStyle(element, null);
    else
        return document.defaultView.getComputedStyle(element, null);
}
function _aspxIsElementRightToLeft(element) {
    return _aspxGetElementDirection(element) == "rtl";
}
function _aspxCreateStyleSheetInDocument(doc) {
    if(__aspxIE)
        return doc.createStyleSheet();
    else {
        var styleSheet = doc.createElement("STYLE");
        _aspxGetChildByTagName(doc, "HEAD", 0).appendChild(styleSheet);
        return styleSheet.sheet;
    }
}
function _aspxGetCurrentStyleSheet() {
    if(!__aspxStyleSheet)
        __aspxStyleSheet = _aspxCreateStyleSheetInDocument(document);
    return __aspxStyleSheet;
}
function _aspxCreateStyleSheet(){
    return _aspxCreateStyleSheetInDocument(document);
}
function _aspxGetStyleSheetRules(styleSheet){
    try {
        return __aspxIE ? styleSheet.rules : styleSheet.cssRules;
    }
    catch(e) {
        return null;
    }
}

function _aspxGetStyleSheetRule(className){
    if(__aspxCachedRules[className]) {
        if(__aspxCachedRules[className] != __aspxEmptyCachedValue)
            return __aspxCachedRules[className];
        return null;
    }
    for(var i = 0; i < document.styleSheets.length; i ++){
        var styleSheet = document.styleSheets[i];
        var rules = _aspxGetStyleSheetRules(styleSheet);
        if(rules != null){
            for(var j = 0; j < rules.length; j ++){
                if(rules[j].selectorText == "." + className){
                    __aspxCachedRules[className] = rules[j];
                    return rules[j];
                }
            }
        }
    }
    __aspxCachedRules[className] = __aspxEmptyCachedValue;
    return null;
}
function _aspxCreateImportantStyleRule(styleSheet, cssText, postfix) {
	var cacheKey = (postfix ? postfix + "||" : "") + cssText;
    if(__aspxStyleNameCache[cacheKey])
		return __aspxStyleNameCache[cacheKey];
		
	var className = "dxh" + __aspxStyleCount + (postfix ? postfix : "");
	_aspxAddStyleSheetRule(styleSheet, "." + className, _aspxCreateImportantCssText(cssText));
	__aspxStyleCount++;
	__aspxStyleNameCache[cacheKey] = className;
	return className;	
}
function _aspxCreateImportantCssText(cssText) {
    var newText = "";
	var attributes = cssText.split(";");
	for(var i = 0; i < attributes.length; i++){
		if(attributes[i] != "")
			newText += attributes[i] + " !important;";
	}
    return newText;
}

function _aspxRemoveStyleSheetRule(styleSheet, index){
    var rules = _aspxGetStyleSheetRules(styleSheet);
    if(rules != null && rules.length > 0 && rules.length >= index){
        if(__aspxIE)
            styleSheet.removeRule(index);
        else            
            styleSheet.deleteRule(index);     
    }                
}
function _aspxAddStyleSheetRule(styleSheet, selector, cssText){
    if(!cssText) return;
    if(__aspxIE)
        styleSheet.addRule(selector, cssText);
    else
        styleSheet.insertRule(selector + " { " + cssText + " }", styleSheet.cssRules.length);
}

function _aspxGetPointerCursor() {
    return "pointer";
}
function _aspxSetPointerCursor(element) {
    if(element.style.cursor == "")
        element.style.cursor = _aspxGetPointerCursor();
}

function _aspxSetElementFloat(element, value) {
    if(_aspxIsExists(element.style.cssFloat))
        element.style.cssFloat = value;
    else if(_aspxIsExists(element.style.styleFloat))
        element.style.styleFloat = value;
    else
        _aspxSetAttribute(element.style, "float", value);
}
function _aspxGetElementFloat(element) {
    var currentStyle = _aspxGetCurrentStyle(element);
    
    if(_aspxIsExists(currentStyle.cssFloat))
        return currentStyle.cssFloat;
    if(_aspxIsExists(currentStyle.styleFloat))
        return currentStyle.styleFloat;
    return _aspxGetAttribute(currentStyle, "float");
}

function _aspxGetElementDirection(element) {
    return _aspxGetCurrentStyle(element).direction;
}
function _aspxSetElementDirection(element, value) {
    element.style.direction = value;
}

var _aspxWebKit3TDRealInfo = {
    GetOffsetTop: function(tdElement){
        switch(_aspxGetCurrentStyle(tdElement).verticalAlign){
            case "middle":
                return Math.round(tdElement.offsetTop - (tdElement.offsetHeight - tdElement.clientHeight )/2 + tdElement.clientTop);
            case "bottom":
                return tdElement.offsetTop - tdElement.offsetHeight + tdElement.clientHeight + tdElement.clientTop;
        }
        return tdElement.offsetTop;
    },
    GetClientHeight: function(tdElement){
        var valign = _aspxGetCurrentStyle(tdElement).verticalAlign;
        switch(valign){
            case "middle":
                return tdElement.clientHeight + tdElement.offsetTop * 2;
            case "top":
                return tdElement.offsetHeight - tdElement.clientTop * 2;
            case "bottom":
                return tdElement.clientHeight + tdElement.offsetTop;
        }
        return tdElement.clientHeight;
    }
}
function _aspxGetIsValidPosition(pos){
    return pos != __aspxInvalidPosition && pos != -__aspxInvalidPosition;
}
function _aspxGetAbsoluteX(curEl){
    return _aspxGetAbsolutePositionX(curEl);
}
function _aspxGetAbsoluteY(curEl){
    return _aspxGetAbsolutePositionY(curEl);
}
function _aspxSetAbsoluteX(element, x){
    element.style.left = _aspxPrepareClientPosForElement(x, element, true) + "px";
}
function _aspxSetAbsoluteY(element, y){
    element.style.top = _aspxPrepareClientPosForElement(y, element, false) + "px";
}
function _aspxGetAbsolutePositionX(element){
    if (__aspxIE)
        return _aspxGetAbsolutePositionX_IE(element);
    else if (__aspxFirefox && __aspxBrowserVersion >= 3)
        return _aspxGetAbsolutePositionX_FF3(element);
    else if (__aspxOpera)
        return _aspxGetAbsolutePositionX_Opera(element);
    else if(__aspxNetscapeFamily && (!__aspxFirefox || __aspxBrowserVersion < 3))
        return _aspxGetAbsolutePositionX_NS(element);
    else if(__aspxWebKitFamily)
        return _aspxGetAbsolutePositionX_Safari(element);
    else
        return _aspxGetAbsolutePositionX_Other(element);
}
function _aspxGetAbsolutePositionX_Opera(curEl){
    var isFirstCycle = true;
    var pos = _aspxGetAbsoluteScrollOffset_OperaFF(curEl, true);
    while (curEl != null) {
        pos += curEl.offsetLeft;
        if(!isFirstCycle)
            pos -= curEl.scrollLeft;
        curEl = curEl.offsetParent;
        isFirstCycle = false;
    }
    pos += document.body.scrollLeft;
    return pos;
}
function _aspxGetAbsolutePositionX_IE(element){
    if(element == null || __aspxIE && element.parentNode == null) return 0; // B96664
    return element.getBoundingClientRect().left + _aspxGetDocumentScrollLeft() - _aspxGetIEDocumentClientOffsetInternal(true);
}
function _aspxGetAbsolutePositionX_FF3(element){
    if(element == null) return 0;
    var x = element.getBoundingClientRect().left + _aspxGetDocumentScrollLeft();
    return Math.round(x);
}
function _aspxGetAbsolutePositionX_NS(curEl){
    var pos = _aspxGetAbsoluteScrollOffset_OperaFF(curEl, true);
    var isFirstCycle = true;
    while (curEl != null) {
        pos += curEl.offsetLeft;
        if (!isFirstCycle && curEl.offsetParent != null)
            pos -= curEl.scrollLeft;
        if (!isFirstCycle && __aspxFirefox){
            var style = _aspxGetCurrentStyle(curEl);
            if(curEl.tagName == "DIV" && style.overflow != "visible")
                pos += _aspxPxToInt(style.borderLeftWidth);
        }
        isFirstCycle = false;
        curEl = curEl.offsetParent;
    }
    return pos;
}
function _aspxGetAbsolutePositionX_Safari(curEl){
    var pos = _aspxGetAbsoluteScrollOffset_WebKit(curEl, true);
	var isSafariVerNonLessThan3OrChrome = __aspxSafari && __aspxBrowserVersion >= 3 || __aspxChrome;
    if(curEl != null){
        var isFirstCycle = true;
        if(isSafariVerNonLessThan3OrChrome && curEl.tagName == "TD") {
            pos += curEl.offsetLeft;
            curEl = curEl.offsetParent;
            isFirstCycle = false;
        }
        while (curEl != null) {
            pos += curEl.offsetLeft;

            var style = _aspxGetCurrentStyle(curEl);
            var posDiv = curEl.tagName == "DIV" && (style.position == "absolute" || style.position == "relative");
            if(!isFirstCycle && (curEl.tagName == "TD" || curEl.tagName == "TABLE" || posDiv))
                pos += curEl.clientLeft;
            isFirstCycle = false;
            curEl = curEl.offsetParent;
        }
    }
    return pos;
}
function _aspxGetAbsolutePositionX_Other(curEl){
    var pos = 0;
    var isFirstCycle = true;
    while (curEl != null) {
        pos += curEl.offsetLeft;
        if (!isFirstCycle && curEl.offsetParent != null)
            pos -= curEl.scrollLeft;
        isFirstCycle = false;
        curEl = curEl.offsetParent;
    }
    return pos;
}
function _aspxGetAbsolutePositionY(element){
    if (__aspxIE)
        return _aspxGetAbsolutePositionY_IE(element);
    else if (__aspxFirefox && __aspxBrowserVersion >= 3)
        return _aspxGetAbsolutePositionY_FF3(element);
    else if (__aspxOpera)
        return _aspxGetAbsolutePositionY_Opera(element);
    else if(__aspxNetscapeFamily && (!__aspxFirefox || __aspxBrowserVersion < 3))
        return _aspxGetAbsolutePositionY_NS(element);
    else if(__aspxWebKitFamily)
        return _aspxGetAbsolutePositionY_Safari(element);
    else
        return _aspxGetAbsolutePositionY_Other(element);
}
function _aspxGetAbsolutePositionY_Opera(curEl){
    var isFirstCycle = true;
    if(curEl && curEl.tagName == "TR" && curEl.cells.length > 0)
        curEl = curEl.cells[0];
    var pos = _aspxGetAbsoluteScrollOffset_OperaFF(curEl, false);
    while (curEl != null) {
        pos += curEl.offsetTop;
        if(!isFirstCycle)
            pos -= curEl.scrollTop;
        curEl = curEl.offsetParent;
        isFirstCycle = false;
    }
    pos += document.body.scrollTop;
    return pos;
}
function _aspxGetAbsolutePositionY_IE(element){
    if(element == null || __aspxIE && element.parentNode == null) return 0; // B96664
    return element.getBoundingClientRect().top + _aspxGetDocumentScrollTop() - _aspxGetIEDocumentClientOffsetInternal(false);
}
function _aspxGetAbsolutePositionY_FF3(element){
    if(element == null) return 0;
    var y = element.getBoundingClientRect().top + _aspxGetDocumentScrollTop();
    return Math.round(y);
}
function _aspxGetAbsolutePositionY_NS(curEl){
    var pos = _aspxGetAbsoluteScrollOffset_OperaFF(curEl, false);
    var isFirstCycle = true;
    while (curEl != null) {
        pos += curEl.offsetTop;
        if (!isFirstCycle && curEl.offsetParent != null)
            pos -= curEl.scrollTop;
        if (!isFirstCycle && __aspxFirefox){
            var style = _aspxGetCurrentStyle(curEl);
            if(curEl.tagName == "DIV" && style.overflow != "visible")
                pos += _aspxPxToInt(style.borderTopWidth);
        }
        isFirstCycle = false;
        curEl = curEl.offsetParent;
    }
    return pos;
}
function _aspxGetAbsolutePositionY_Safari(curEl){
    var pos = _aspxGetAbsoluteScrollOffset_WebKit(curEl, false);
    var isSafariVerNonLessThan3OrChrome = __aspxSafari && __aspxBrowserVersion >= 3 || __aspxChrome;
    if(curEl != null){
        var isFirstCycle = true;
        if(isSafariVerNonLessThan3OrChrome && curEl.tagName == "TD") {
            pos += _aspxWebKit3TDRealInfo.GetOffsetTop(curEl);
            curEl = curEl.offsetParent;
            isFirstCycle = false;
        }
        while (curEl != null) {
            pos += curEl.offsetTop;

            var style = _aspxGetCurrentStyle(curEl);
            var posDiv = curEl.tagName == "DIV" && (style.position == "absolute" || style.position == "relative");
            if(!isFirstCycle && (curEl.tagName == "TD" || curEl.tagName == "TABLE" || posDiv))
                pos += curEl.clientTop;
            isFirstCycle = false;
            curEl = curEl.offsetParent;
        }
    }
    return pos;
}
// B91523
function _aspxGetAbsoluteScrollOffset_OperaFF(curEl, isX) {
    var pos = 0;   
    var isFirstCycle = true;
    while (curEl != null) {
        if(curEl.tagName == "BODY")
            break;
        var style = _aspxGetCurrentStyle(curEl);
        if(style.position == "absolute")
            break;
        if(!isFirstCycle && curEl.tagName == "DIV" && (style.position == "" || style.position == "static"))
            pos -= isX ? curEl.scrollLeft : curEl.scrollTop;
        curEl = curEl.parentNode;
        isFirstCycle = false;
    }
    return pos; 
}
function _aspxGetAbsoluteScrollOffset_WebKit(curEl, isX) {
    var pos = 0;   
    var isFirstCycle = true;
    var step = 0;
    var absoluteWasFoundAtStep = -1;
    while (curEl != null) {
        if(curEl.tagName == "BODY")
            break;
        var style = _aspxGetCurrentStyle(curEl);

        var positionIsDefault = style.position == "" || style.position == "static";
        var absoluteWasFoundAtPreviousStep = absoluteWasFoundAtStep >= 0 && absoluteWasFoundAtStep < step;
        if(!isFirstCycle && curEl.tagName == "DIV" && (!positionIsDefault || !absoluteWasFoundAtPreviousStep))
            pos -= isX ? curEl.scrollLeft : curEl.scrollTop;
        
        if(style.position == "absolute")
            absoluteWasFoundAtStep = step;
        else if(style.position == "relative")
            absoluteWasFoundAtStep = -1;

        curEl = curEl.parentNode;
        isFirstCycle = false;
        step ++;
    }
    return pos; 
}
function _aspxGetAbsolutePositionY_Other(curEl){
    var pos = 0;
    var isFirstCycle = true;
    while (curEl != null) {
        pos += curEl.offsetTop;
        if (!isFirstCycle && curEl.offsetParent != null)
            pos -= curEl.scrollTop;
        
        isFirstCycle = false;
        curEl = curEl.offsetParent;
    }
    return pos;
}

function _aspxPrepareClientPosForElement(pos, element, isX) {
    pos -= _aspxGetPositionElementOffset(element, isX);
    return pos;
}

function _aspxGetExperimentalPositionOffset(element, isX) {
       var div = document.createElement('div');
       div.style.top = "0px";
       div.style.left = "0px";
       div.visibility = "hidden";
       div.style.position = _aspxGetCurrentStyle(element).position;
       element.parentNode.appendChild(div); 
       var realPos = isX ? _aspxGetAbsoluteX(div) : _aspxGetAbsoluteY(div);
       element.parentNode.removeChild(div);
       return realPos;
}
function _aspxTestElementParentsByFunc(element, func) {
    while(element) {  
        var tagName = element.tagName;
        if(tagName == "HTML" || tagName == "BODY" )
            return false;
        if(func(element)) 
            return true;
        element = element.parentNode;    
    }
    return false;   
}
function _aspxGetPositionElementOffset(element, isX) {
    if(__aspxFirefox && __aspxBrowserVersion >= 10){ // B212418
        return _aspxGetExperimentalPositionOffset(element, isX);
    }
    return _aspxGetPositionElementOffsetCore(element, isX);
}
function _aspxGetPositionElementOffsetCore(element, isX) {
    var curEl = element.offsetParent;
    var offset = 0;
    var scroll = 0;
    var isThereFixedParent = false;
    var isFixed = false;
    var hasDisplayTableParent = false;
    var position = "";
    while(curEl != null) {
        var tagName = curEl.tagName;
        if(tagName == "HTML"){
            break;
        }
        if(tagName == "BODY"){
            if(!__aspxOpera && !__aspxChrome){
                var style = _aspxGetCurrentStyle(curEl);
                if(style.position != "" && style.position != "static"){
                    offset += _aspxPxToInt(isX ? style.left : style.top);
                    offset += _aspxPxToInt(isX ? style.marginLeft : style.marginTop);
                }
            }
            break;
        }
        if(tagName != "TD" && tagName != "TR") {
            var style = _aspxGetCurrentStyle(curEl);
            isFixed = style.position == "fixed";
            if(isFixed) {
                isThereFixedParent = true;
                if(__aspxIE && __aspxBrowserVersion >= 8) {
                    return _aspxGetExperimentalPositionOffset(element, isX); //Q260707, B157137
                }
            }

            hasDisplayTableParent = style.display == "table" && (style.position == "absolute" || style.position == "relative");
            if(hasDisplayTableParent && __aspxIE && __aspxBrowserVersion >= 8)
                return _aspxGetExperimentalPositionOffset(element, isX);
            
            if (style.position == "absolute" || isFixed || style.position == "relative") {
                offset += isX ? curEl.offsetLeft : curEl.offsetTop;
                offset += _aspxPxToInt(isX ? style.borderLeftWidth : style.borderTopWidth);
            }
            if(style.position == "relative" && !(__aspxIE && __aspxBrowserVersion < 8)) // B199061
                scroll += _aspxGetElementChainScroll(curEl, curEl.offsetParent, isX);
        }
        scroll += isX ? curEl.scrollLeft : curEl.scrollTop;
        curEl = curEl.offsetParent;
    }
    offset -= scroll; // Bug B92105
    if((__aspxIE && __aspxBrowserVersion >= 7 || __aspxFirefox && __aspxBrowserVersion >= 3) && isThereFixedParent)
        offset += isX ? _aspxGetDocumentScrollLeft() : _aspxGetDocumentScrollTop();
    return offset;
}
function _aspxGetElementChainScroll(startElement, endElement, isX){
    var curEl = startElement.parentNode;
    var scroll = 0;
    while(curEl != endElement){
        scroll += isX ? curEl.scrollLeft : curEl.scrollTop;
        curEl = curEl.parentNode;
    }
    return scroll;
}
function _aspxPxToInt(px) {
    return _aspxPxToNumber(px, parseInt);
}
function _aspxPxToFloat(px) {
    return _aspxPxToNumber(px, parseFloat);
}
function _aspxPxToNumber(px, parseFunction) {
    var result = 0;
    if (px != null && px != "") {
        try {
            var indexOfPx = px.indexOf("px");
            if (indexOfPx > -1)
                result = parseFunction(px.substr(0, indexOfPx));
        } catch(e) { }
    }
    return result;
}
function _aspxPercentageToFloat(perc) {
    var result = 0;
    if(perc != null && perc != "") {
        try {
            var indexOfPerc = perc.indexOf("%");
            if(indexOfPerc > -1)
                result = parseFloat(perc.substr(0, indexOfPerc)) / 100;
        } catch(e) { }
    }
    return result;
}
function _aspxGetLeftRightBordersAndPaddingsSummaryValue(element) {
    var currentStyle = _aspxGetCurrentStyle(element);
    var value = _aspxPxToInt(currentStyle.paddingLeft) + _aspxPxToInt(currentStyle.paddingRight);
           
    return value + _aspxGetHorizontalBordersWidth(element);
}
function _aspxGetTopBottomBordersAndPaddingsSummaryValue(element) {
    var currentStyle = _aspxGetCurrentStyle(element);
    var value = _aspxPxToInt(currentStyle.paddingTop) + _aspxPxToInt(currentStyle.paddingBottom);

    return value + _aspxGetVerticalBordersWidth(element);
}
function _aspxGetVerticalBordersWidth(element) {
    var style = _aspxGetCurrentStyle(element);
    var res = 0;

    if(style.borderTopStyle != "none")
		res += _aspxPxToInt(style.borderTopWidth);
    if(style.borderBottomStyle != "none")
		res += _aspxPxToInt(style.borderBottomWidth);

    return res;
}
function _aspxGetHorizontalBordersWidth(element) {
    var style = _aspxGetCurrentStyle(element);
    var res = 0;

    if(style.borderLeftStyle != "none")
		res += _aspxPxToInt(style.borderLeftWidth);
    if(style.borderRightStyle != "none")
		res += _aspxPxToInt(style.borderRightWidth);

    return res;
}

function _aspxGetCeilOffsetHeight(element) {
    if(__aspxIE && __aspxBrowserVersion > 9)
        return Math.ceil(element.getBoundingClientRect().height);
    return element.offsetHeight;
}
function _aspxGetClearClientWidth(element) {
    return element.offsetWidth - _aspxGetLeftRightBordersAndPaddingsSummaryValue(element);
}
function _aspxGetClearClientHeight(element) {
    return element.offsetHeight - _aspxGetTopBottomBordersAndPaddingsSummaryValue(element);
}
function _aspxSetOffsetWidth(element, widthValue) {
    var currentStyle = _aspxGetCurrentStyle(element);
    var value = widthValue - _aspxPxToInt(currentStyle.marginLeft) - _aspxPxToInt(currentStyle.marginRight);
        value -= _aspxGetLeftRightBordersAndPaddingsSummaryValue(element);
    // B90988
    if(value > -1)
        element.style.width = value + "px";
}
function _aspxSetOffsetHeight(element, heightValue) {
    var currentStyle = _aspxGetCurrentStyle(element);
    var value = heightValue - _aspxPxToInt(currentStyle.marginTop) - _aspxPxToInt(currentStyle.marginBottom);
        value -= _aspxPxToInt(currentStyle.paddingTop) + _aspxPxToInt(currentStyle.paddingBottom) +
            _aspxPxToInt(currentStyle.borderTopWidth) + _aspxPxToInt(currentStyle.borderBottomWidth);    
    // B90988
    if(value > -1)
        element.style.height = value + "px";
}
function _aspxFindOffsetParent(element) {
    // B37917 (IE8)
    if(__aspxIE && __aspxBrowserVersion < 8)
        return element.offsetParent;
    var currentElement = element.parentNode;
    while(_aspxIsExistsElement(currentElement) && currentElement.tagName != "BODY") {
        if (currentElement.offsetWidth > 0 && currentElement.offsetHeight > 0)
            return currentElement;
        currentElement = currentElement.parentNode;
    }
    return document.body;
}
function _aspxGetDocumentScrollTop(){
    if(__aspxWebKitFamily || __aspxIE && __aspxBrowserVersion == 5.5 || document.documentElement.scrollTop == 0) {
        if(__aspxMacOSMobilePlatform) //B157267
            return window.pageYOffset;
        else 
            return document.body.scrollTop;
    }
    else
        return document.documentElement.scrollTop;
}
function _aspxSetDocumentScrollTop(scrollTop) {
    if(__aspxWebKitFamily || __aspxIE && __aspxBrowserVersion == 5.5 || document.documentElement.scrollTop == 0) {
        if(__aspxMacOSMobilePlatform) //B157267
            window.pageYOffset = scrollTop;
        else 
            document.body.scrollTop = scrollTop;
    }
    else
        document.documentElement.scrollTop = scrollTop;
}
function _aspxGetDocumentScrollLeft(){
    if(__aspxIE && __aspxBrowserVersion < 8) {
        var body = document.body || document.documentElement;
        if(_aspxIsElementRightToLeft(body))
            return body.scrollWidth - body.scrollLeft - body.clientWidth;
    }
    if(__aspxWebKitFamily || __aspxIE && __aspxBrowserVersion == 5.5 || document.documentElement.scrollLeft == 0)
        return document.body.scrollLeft;
    return document.documentElement.scrollLeft;
}
function _aspxGetDocumentClientWidth(){
    if(__aspxIE && __aspxBrowserVersion == 5.5 || document.documentElement.clientWidth == 0)
        return document.body.clientWidth;
    else
        return document.documentElement.clientWidth;
}
function _aspxGetDocumentClientHeight(){
    if(__aspxOpera) // B33854
        return __aspxBrowserVersion >= 9.6 ? document.documentElement.clientHeight : document.body.clientHeight;
    else if(__aspxIE && __aspxBrowserVersion == 5.5 ||  document.documentElement.clientHeight == 0)
        return document.body.clientHeight;
    else
        return document.documentElement.clientHeight;
}
function _aspxSetStylePosition(element, x, y){
    element.style.left = x + "px";
    element.style.top = y + "px";
}
function _aspxSetStyleSize(element, width, height){
    element.style.width = width + "px";
    element.style.height = height + "px";
}
function _aspxGetDocumentWidth(){
    var bodyWidth = document.body.offsetWidth;
    var docWidth = (__aspxIE && __aspxBrowserMajorVersion != 7) ? document.documentElement.clientWidth : document.documentElement.offsetWidth;
    var bodyScrollWidth = document.body.scrollWidth;
    var docScrollWidth = document.documentElement.scrollWidth;
    return _aspxGetMaxDimensionOf(bodyWidth, docWidth, bodyScrollWidth, docScrollWidth);
}
function _aspxGetDocumentHeight(){
    var bodyHeight = document.body.offsetHeight;
    var docHeight = (__aspxIE && __aspxBrowserMajorVersion != 7) ? document.documentElement.clientHeight : document.documentElement.offsetHeight;
    var bodyScrollHeight = document.body.scrollHeight;
    var docScrollHeight = document.documentElement.scrollHeight;
    var maxHeight = _aspxGetMaxDimensionOf(bodyHeight, docHeight, bodyScrollHeight, docScrollHeight);

    if(__aspxOpera && __aspxBrowserVersion >= 9.6){
        if(__aspxBrowserVersion < 10)
            maxHeight = _aspxGetMaxDimensionOf(bodyHeight, docHeight, bodyScrollHeight);
        var visibleHeightOfDocument = document.documentElement.clientHeight;
        if(maxHeight > visibleHeightOfDocument)
            maxHeight = _aspxGetMaxDimensionOf(window.outerHeight, maxHeight);
        else
            maxHeight = document.documentElement.clientHeight;
        return maxHeight;
    }
    return maxHeight;
}
function _aspxGetDocumentMaxClientWidth(){
    var bodyWidth = document.body.offsetWidth;
    var docWidth = document.documentElement.offsetWidth;
    var docClientWidth = document.documentElement.clientWidth;
    return _aspxGetMaxDimensionOf(bodyWidth, docWidth, docClientWidth);
}
function _aspxGetDocumentMaxClientHeight(){
    var bodyHeight = document.body.offsetHeight;
    var docHeight = document.documentElement.offsetHeight;
    var docClientHeight = document.documentElement.clientHeight;
    return _aspxGetMaxDimensionOf(bodyHeight, docHeight, docClientHeight);
}
function _aspxGetMaxDimensionOf(){
    var max = __aspxInvalidDimension;
    for (var i = 0; i < arguments.length; i++){
        if(max < arguments[i])
            max = arguments[i];
    }
    return max;
}
function _aspxGetClientLeft(element){
    return _aspxIsExists(element.clientLeft) ? element.clientLeft : (element.offsetWidth - element.clientWidth) / 2;
}
function _aspxGetClientTop(element){
    return _aspxIsExists(element.clientTop) ? element.clientTop : (element.offsetHeight - element.clientHeight) / 2;
}
function _aspxRemoveBorders(element) {
    if(!element)
        return;
    element.style.borderWidth = 0;
    for(var i = 0; i < element.childNodes.length; i++) {
        var child = element.childNodes[i];
        if(child.style)
            child.style.border = "0";
    }
}
function _aspxSetBackground(element, background) {
    if(!element)
        return;
    element.style.backgroundColor = background;
    for(var i = 0; i < element.childNodes.length; i++) {
        var child = element.childNodes[i];
        if(child.style)
            child.style.backgroundColor = background;
    }
}
function _aspxDoElementClick(element) {
    try{
        element.click();
    }
    catch(e){ // B153651
    }
}

// Selection management

function _aspxSetSelection(input, startPos, endPos, scrollToSelection) {
    if(!_aspxIsExistsElement(input))
        return;

    var textLen = input.value.length;

    startPos = _aspxGetDefinedValue(startPos, 0);
    endPos = _aspxGetDefinedValue(endPos, textLen);

    if(startPos < 0)
        startPos = 0;

    if(endPos < 0 || endPos > textLen)
        endPos = textLen;

    if(startPos > endPos)
        startPos = endPos;

    var makeReadOnly = false;
    if(__aspxWebKitFamily && input.readOnly) {
        input.readOnly = false;
        makeReadOnly = true;
    }
    
    try {
        if(__aspxIE) {
            var range = input.createTextRange();
            range.collapse(true);
            range.moveStart("character", startPos);
            range.moveEnd("character", endPos - startPos);
            range.select();
        } else {
            input.setSelectionRange(startPos, endPos);
            // B188482
            if(__aspxOpera || __aspxFirefox)
                input.focus();
        }
    } catch(e) { }
    
    if(scrollToSelection && input.tagName == 'TEXTAREA') {
        var scrollHeight = input.scrollHeight;
        var approxCaretPos = startPos;
        var scrollTop = Math.max(Math.round(approxCaretPos * scrollHeight / textLen  - input.clientHeight / 2), 0);
        input.scrollTop = scrollTop;
    }

    if(makeReadOnly)
        input.readOnly = true;
}

function _aspxGetSelectionInfo(input) {
    var start, end;
    if(__aspxIE) {
        var range = document.selection.createRange();
        var rangeCopy = range.duplicate();
        range.move('character', -input.value.length);
        range.setEndPoint('EndToStart', rangeCopy);
        start = range.text.length;
        end = start + rangeCopy.text.length;
    } else {
        try {
            start = input.selectionStart;
            end = input.selectionEnd;
        } catch (e) {
        }
    }
    return { startPos: start, endPos: end };
}

function _aspxSetCaretPosition(input, caretPos) {
    if(typeof caretPos === "undefined" || caretPos < 0)
        caretPos = input.value.length;
    _aspxSetSelection(input, caretPos, caretPos, true);
}

// deprecated, back compat
_aspxSetInputSelection = _aspxSetSelectionCore = _aspxSetSelection;
_aspxClearInputSelection = _aspxSetCaretPosition;

// Focus management

function _aspxSetFocus(element, selectAction) {
    function focusCore(element, selectAction){
        try {
                element.focus();
                if(__aspxIE && document.activeElement != element)
                    element.focus();

                // Q339238
                if(selectAction) {
                    var currentSelection = _aspxGetSelectionInfo(element);
                    // apply selection only if there is no selection present already
                    if(currentSelection.startPos == currentSelection.endPos) {
                    
                        switch(selectAction) {
                            case "start":
                                _aspxSetCaretPosition(element, 0);
                                break;
                            case "all":
                                _aspxSetSelection(element);
                                break;
                        }
                    }
                }
            } catch (e) {
        }
    }
    if(ASPxClientUtils.iOSPlatform) // Q471191
        focusCore(element, selectAction);
    else {
        window.setTimeout(function() { // B39538
            focusCore(element, selectAction);
        }, 100);
    }
}
function _aspxIsFocusableCore(element, skipContainerVisibilityCheck) {
    var current = element;
    while(current) {
        if (current == element || !skipContainerVisibilityCheck(current)) {
            if (current.tagName == "BODY")
                return true;
            if (current.disabled || !_aspxGetElementDisplay(current) || !_aspxGetElementVisibility(current))
                return false;
        }
        current = current.parentNode;
    }
    return true;
}
function _aspxIsFocusable(element) {
    return _aspxIsFocusableCore(element, _aspxFalseFunction);
}
function _aspxAttachEventToElement(element, eventName, func, onlyBubbling) {
    if(element.addEventListener)
        element.addEventListener(eventName, func, !onlyBubbling);
    else
        element.attachEvent("on" + eventName, func);
}
function _aspxDetachEventFromElement(element, eventName, func) {
    if(element.removeEventListener)
        element.removeEventListener(eventName, func, true);
    else
        element.detachEvent("on" + eventName, func);
}
function _aspxAttachEventToDocument(eventName, func) {
    var attachingAllowed = ASPxClientTouchUI.onEventAttachingToDocument(eventName, func);
    if(attachingAllowed)
        _aspxAttachEventToDocumentCore(eventName, func);
}
function _aspxAttachEventToDocumentCore(eventName, func) {
    _aspxAttachEventToElement(document, eventName, func);
}
function _aspxDetachEventFromDocument(eventName, func) {
    _aspxDetachEventFromDocumentCore(eventName, func);
    ASPxClientTouchUI.onEventDettachedFromDocument(eventName, func);
}
function _aspxDetachEventFromDocumentCore(eventName, func){
    _aspxDetachEventFromElement(document, eventName, func);
}
function _aspxCreateEventHandlerFunction(funcName, controlName, withHtmlEventArg) {
    if(withHtmlEventArg)
        return function(e) { window[funcName](controlName, e) };
        
    return function() { window[funcName](controlName) };
}
function _aspxGetMouseWheelEventName(){
    return __aspxNetscapeFamily ? "DOMMouseScroll" : "mousewheel";
}

function _aspxCreateClass(parentClass, properties) {
    var ret = function() {
        if (ret.preparing) 
            return delete(ret.preparing);
        if (ret.constr) {
            this.constructor = ret;
            ret.constr.apply(this, arguments);
        }
    }
    ret.prototype = {};
    if(parentClass) {
        parentClass.preparing = true;
        ret.prototype = new parentClass;
        ret.prototype.constructor = parentClass;
        ret.constr = parentClass;
    }
    if(properties) {
        var constructorName = "constructor";
        for(var name in properties){
            if (name != constructorName) 
                ret.prototype[name] = properties[name];
        }
        if (properties[constructorName] && properties[constructorName] != Object)
            ret.constr = properties[constructorName];
    }
    return ret;
}
// Attributes
function _aspxGetAttribute(obj, attrName){
    if(obj.getAttribute)
        return obj.getAttribute(attrName);
    else if(obj.getPropertyValue)
        return obj.getPropertyValue(attrName);
    return null;
}
function _aspxSetAttribute(obj, attrName, value){
    if(obj.setAttribute)
        obj.setAttribute(attrName, value);
    else if(obj.setProperty)
        obj.setProperty(attrName, value, "");
}
function _aspxRemoveAttribute(obj, attrName){
    if(obj.removeAttribute)
        obj.removeAttribute(attrName);
    else if(obj.removeProperty)
        obj.removeProperty(attrName);
}
function _aspxIsExistsAttribute(obj, attrName){
    var value = _aspxGetAttribute(obj, attrName);
    return (value != null) && (value !== "");
}
function _aspxSetOrRemoveAttribute(obj, attrName, value) {
    if (!value)
        _aspxRemoveAttribute(obj, attrName);
    else
        _aspxSetAttribute(obj, attrName, value);
}
function _aspxSaveAttribute(obj, attrName, savedObj, savedAttrName){
    if(!_aspxIsExistsAttribute(savedObj, savedAttrName)){
        var oldValue = _aspxIsExistsAttribute(obj, attrName) ? _aspxGetAttribute(obj, attrName) : __aspxEmptyAttributeValue;
        _aspxSetAttribute(savedObj, savedAttrName, oldValue);
    }
}
function _aspxChangeAttributeExtended(obj, attrName, savedObj, savedAttrName, newValue){
    _aspxSaveAttribute(obj, attrName, savedObj, savedAttrName);
    _aspxSetAttribute(obj, attrName, newValue);
}
function _aspxChangeAttribute(obj, attrName, newValue){
    _aspxChangeAttributeExtended(obj, attrName, obj, "saved" + attrName, newValue);
}
function _aspxChangeStyleAttribute(obj, attrName, newValue){
    _aspxChangeAttributeExtended(obj.style, attrName, obj, "saved" + attrName, newValue);
}
function _aspxResetAttributeExtended(obj, attrName, savedObj, savedAttrName){
    _aspxSaveAttribute(obj, attrName, savedObj, savedAttrName);
    _aspxSetAttribute(obj, attrName, "");
    _aspxRemoveAttribute(obj, attrName);
}
function _aspxResetAttribute(obj, attrName){
    _aspxResetAttributeExtended(obj, attrName, obj, "saved" + attrName);
}
function _aspxResetStyleAttribute(obj, attrName){
    _aspxResetAttributeExtended(obj.style, attrName, obj, "saved" + attrName);
}
function _aspxRestoreAttributeExtended(obj, attrName, savedObj, savedAttrName){
    if(_aspxIsExistsAttribute(savedObj, savedAttrName)){
        var oldValue = _aspxGetAttribute(savedObj, savedAttrName);
        if(oldValue != __aspxEmptyAttributeValue)
            _aspxSetAttribute(obj, attrName, oldValue);
        else
            _aspxRemoveAttribute(obj, attrName);
        _aspxRemoveAttribute(savedObj, savedAttrName);
        return true;
    }
    return false;
}
function _aspxRestoreAttribute(obj, attrName){
    return _aspxRestoreAttributeExtended(obj, attrName, obj, "saved" + attrName);
}
function _aspxRestoreStyleAttribute(obj, attrName){
    return _aspxRestoreAttributeExtended(obj.style, attrName, obj, "saved" + attrName);
}

function _aspxCopyAllAttributes(sourceElem, destElement) {
    var attrs = sourceElem.attributes;
    for (var n = 0; n < attrs.length; n++) {
	    var attr = attrs[n];
	    if (attr.specified) {
	        var attrName = attr.nodeName;
	        var attrValue = sourceElem.getAttribute(attrName, 2);
	        if (attrValue == null)
	            attrValue = attr.nodeValue;
	        destElement.setAttribute(attrName, attrValue, 0); // 0 : Case Insensitive
		}
	}
	if (sourceElem.style.cssText !== '')
	    destElement.style.cssText = sourceElem.style.cssText;
}
function _aspxRemoveAllAttributes(element, excludedAttributes) {
    var excludedAttributesHashTable = {};
    if (excludedAttributes)
        excludedAttributesHashTable = _aspxCreateHashTableFromArray(excludedAttributes);
        
    if (element.attributes) {
        var attrArray = element.attributes;
        for (var i = 0; i < attrArray.length; i++) {
            var attrName = attrArray[i].name;
            if (!_aspxIsExists(excludedAttributesHashTable[attrName.toLowerCase()])) {
                try {
                    attrArray.removeNamedItem(attrName);
                } catch (e) { }
            }
        }
    }
}
function _aspxRemoveStyleAttribute(element, attrName) {
    if (element.style) {
        if (__aspxFirefox && element.style[attrName]) // attribute isn't removed if it isn't empty
            element.style[attrName] = "";
        if (element.style.removeAttribute && element.style.removeAttribute != "")
            element.style.removeAttribute(attrName);
        else if (element.style.removeProperty && element.style.removeProperty != "")
            element.style.removeProperty(attrName);
    }
}
function _aspxRemoveAllStyles(element) {
    if (element.style) {
        for(var key in element.style)
            _aspxRemoveStyleAttribute(element, key);
       _aspxRemoveAttribute(element, "style");
    }
}
function _aspxChangeTabIndexAttribute(element){
    var attribute = _aspxGetTabIndexAttribute();    
    if(_aspxGetAttribute(element, attribute) != -1)
       _aspxChangeAttribute(element, attribute, -1);
}

function _aspxSaveTabIndexAttributeAndReset(element) {
    var attribute = _aspxGetTabIndexAttribute();
    if(_aspxIsExistsAttribute(element, attribute)) {
        var value = _aspxGetAttribute(element, attribute);
        if(value != __aspxEmptyAttributeValue)
            _aspxSetAttribute(element, "saved" + attribute, value);
    }
    _aspxSetAttribute(element, attribute, -1);
}

function _aspxRestoreTabIndexAttribute(element){
    var attribute = _aspxGetTabIndexAttribute();
    if(_aspxIsExistsAttribute(element, attribute)) 
       if(_aspxGetAttribute(element, attribute) == -1)      
          if(_aspxIsExistsAttribute(element, "saved" + attribute)){
             var oldValue = _aspxGetAttribute(element, "saved" + attribute);
             if(oldValue != __aspxEmptyAttributeValue)
                 _aspxSetAttribute(element, attribute, oldValue);
             else {
                if (__aspxWebKitFamily) 
			        _aspxSetAttribute(element, attribute, 0); 
                _aspxRemoveAttribute(element, attribute);            
             }
             _aspxRemoveAttribute(element, "saved" + attribute); 
          } 
}
function _aspxGetTabIndexAttribute(){
    return __aspxIE  ? "tabIndex" : "tabindex";
}

function _aspxChangeAttributesMethod(enabled){
    return enabled ? _aspxRestoreAttribute : _aspxResetAttribute;
}
function _aspxInitiallyChangeAttributesMethod(enabled){
    return enabled ? _aspxChangeAttribute : _aspxResetAttribute;
}
function _aspxChangeStyleAttributesMethod(enabled){
    return enabled ? _aspxRestoreStyleAttribute : _aspxResetStyleAttribute;
}
function _aspxInitiallyChangeStyleAttributesMethod(enabled){
    return enabled ? _aspxChangeStyleAttribute : _aspxResetStyleAttribute;
}
function _aspxChangeEventsMethod(enabled){
    return enabled ? _aspxAttachEventToElement : _aspxDetachEventFromElement;
}
function _aspxChangeDocumentEventsMethod(enabled){
    return enabled ? _aspxAttachEventToDocument : _aspxDetachEventFromDocument;
}
// String Utils

function _aspxTrimStart(str) {    
    return _aspxTrimImpl(str, true);
}
function _aspxTrimEnd(str) {    
    return _aspxTrimImpl(str, false, true);
}
function _aspxTrim(str) {    
    return _aspxTrimImpl(str, true, true);    
}

function _aspxTrimImpl(source, trimStart, trimEnd) {
    var len = source.length;
    if(!len)
        return source;

    if(len < 0xBABA1) { // B181394        
        var result = source;
        if(trimStart) {
            result = result.replace(/^\s+/, "");
        }
        if(trimEnd) {
            result = result.replace(/\s+$/, "");
        }
        return result;        
    } else {
        var start = 0;
        if(trimEnd) {            
            while(len > 0 && ASPxWhiteSpaces[source.charCodeAt(len - 1)]) {
                len--;
            }
        }
        if(trimStart && len > 0) {
            while(start < len && ASPxWhiteSpaces[source.charCodeAt(start)]) { 
                start++; 
            }            
        }
        return source.substring(start, len);
    }
}


function _aspxInsert(str, subStr, index) {    
    var leftText = str.slice(0, index);
    var rightText = str.slice(index);
    return leftText + subStr + rightText;
}
function _aspxInsertEx(str, subStr, startIndex, endIndex) {    
    var leftText = str.slice(0, startIndex);
    var rightText = str.slice(endIndex);
    return leftText + subStr + rightText;
}

//Url utils
function _aspxNavigateUrl(url, target) {
    var javascriptPrefix = "javascript:";
    if(url == "")
        return;
    else if(url.indexOf(javascriptPrefix) != -1) 
        eval(url.substr(javascriptPrefix.length));
    else {
        try{
            if(target != "")
                _aspxNavigateTo(url, target);
            else
                location.href = url;
        }
        catch(e){
            // fix IE bug - B145116
        }
    }
}
function _aspxNavigateByLink(linkElement) {
    _aspxNavigateUrl(_aspxGetAttribute(linkElement, "href"), linkElement.target);
} 

function _aspxNavigateTo(url, target) {
    var lowerCaseTarget = target.toLowerCase();
    if("_top" == lowerCaseTarget)
        top.location.href = url;
    else if("_self" == lowerCaseTarget)
        location.href = url;
    else if("_search" == lowerCaseTarget)
        window.open(url, '_blank');
    else if("_media" == lowerCaseTarget)
        window.open(url, '_blank');
    else if("_parent" == lowerCaseTarget)
        window.parent.location.href = url;
    else if("_blank" == lowerCaseTarget)
        window.open(url, '_blank');
    else {
        var frame = _aspxGetFrame(top.frames, target);
        if(frame != null)
            frame.location.href = url;
        else
            window.open(url, '_blank');
    }
}
function _aspxGetFrame(frames, name) {
    if(frames[name])
        return frames[name];
    for(var i = 0; i < frames.length; i++) {
        try {
            var frame = frames[i];
            if(frame.name == name) 
                return frame;    

            frame = _aspxGetFrame(frame.frames, name);
            if(frame != null)   
                return frame;    
        } catch(e) {
        
        }    
    }
    return null;
}
// Color utils
function _aspxToHex(d) {
    return (d < 16) ? ("0" + d.toString(16)) : d.toString(16);
}
function _aspxColorToHexadecimal(colorValue) {
    if (typeof(colorValue) == "number") {
        var r = colorValue & 0xFF;
        var g = (colorValue >> 8) & 0xFF;
        var b = (colorValue >> 16) & 0xFF;
        return "#" + _aspxToHex(r) + _aspxToHex(g) + _aspxToHex(b);
    }
    if (colorValue && (colorValue.substr(0, 3).toLowerCase() == "rgb")) {
        // in rgb(...) form -- Mozilla
        var re = /rgb\s*\(\s*([0-9]+)\s*,\s*([0-9]+)\s*,\s*([0-9]+)\s*\)/;
        var regResult = colorValue.match(re);
        if (regResult) {
            var r = parseInt(regResult[1]);
            var g = parseInt(regResult[2]);
            var b = parseInt(regResult[3]);
            return "#" + _aspxToHex(r) + _aspxToHex(g) + _aspxToHex(b);
        }
        return null;
    }    
    if (colorValue && (colorValue.charAt(0) == "#"))
        return colorValue;
    return null;
}

// Callbacks
function _aspxFormatCallbackArg(prefix, arg) {
    // [Victor] TODO: refactor HtmlEditor->Dialogs.js and remove this logics (only simple data types are expected)
    if(prefix == null && arg == null)
        return "";    
    if(prefix == null) prefix = "";
    if(arg == null) arg = "";
    
    if(arg != null && !_aspxIsExists(arg.length) && _aspxIsExists(arg.value))
        arg = arg.value;
    arg = arg.toString();
    return [prefix, '|', arg.length, '|' , arg].join('');
}
function _aspxFormatCallbackArgs(callbackData) {
    var sb = [ ];
    for(var i = 0; i < callbackData.length; i++)
        sb.push(_aspxFormatCallbackArg(callbackData[i][0], callbackData[i][1]));
    return sb.join("");
}

function _aspxIsValidElement(element) {
    if(!element) 
        return false;
    if(!(__aspxFirefox && __aspxBrowserVersion < 4)) {
        if(element.ownerDocument && element.ownerDocument.body.compareDocumentPosition)
            return element.ownerDocument.body.compareDocumentPosition(element) % 2 === 0;
    }
    if(!__aspxOpera && !(__aspxIE && __aspxBrowserVersion < 9) && element.offsetParent && element.parentNode.tagName)
        return true;
    while(element != null){
        if(element.tagName == "BODY")
            return true;
        element = element.parentNode;
    }
    return false;
}
function _aspxIsValidElements(elements) {
    if (!elements)
        return false;    
    for(var i = 0; i < elements.length; i++) {
        if(elements[i] && !_aspxIsValidElement(elements[i]))
            return false;
    }
    return true;
}
function _aspxIsExistsElement(element) {
    return element && _aspxIsValidElement(element);
}
function _aspxFindParentByTestFunc(element, testFunc){
    if (!testFunc) return null;
    
    while(element != null && element.tagName != "BODY"){
		if(testFunc(element))
		    return element;
        element = element.parentNode;
	}
    return null;
}

function _aspxCorrectJSFloatNumber(number) {
    // Hack: 3.12 + 10 = 13.1200000000000001 - bug is javascript
    var ret = 21; // max number
    var numString = number.toPrecision(21);
    numString = numString.replace("-", ""); // B196112
    var integerDigitsCount = numString.indexOf(__aspxPossibleNumberDecimalSeparators[0]);

    if (integerDigitsCount < 0)
        integerDigitsCount = numString.indexOf(__aspxPossibleNumberDecimalSeparators[1]);

    var floatDigitsCount = numString.length - integerDigitsCount - 1;
    if(floatDigitsCount < 10)
        return number;

    if (integerDigitsCount > 0) {
        // 12 was fitted. Elsewise, the testChangeNumberInternal isn't successful
        ret = integerDigitsCount + 12;
    }
    
    var toPrecisionNumber = Math.min(ret, 21);
    var newValueString = number.toPrecision(toPrecisionNumber);
    return parseFloat(newValueString, 10);
}

/*# public class ASPxClientEvent : JavaScriptObject #*/
ASPxClientEvent = _aspxCreateClass(null, {
    constructor: function() {
        this.handlerInfoList = [];
    },
    /*# public void AddHandler(object handler){} #*/
    AddHandler: function(handler, executionContext) {
        if(typeof(executionContext) == "undefined")
            executionContext = null;
        var handlerInfo = ASPxClientEvent.CreateHandlerInfo(handler, executionContext);
        this.handlerInfoList.push(handlerInfo);
    },
    /*# public void RemoveHandler(object handler){} #*/
    RemoveHandler: function(handler, executionContext) {
        this.removeHandlerByCondition(function(handlerInfo) {
            return handlerInfo.handler == handler && 
                (!executionContext || handlerInfo.executionContext == executionContext);
        });
    },

    removeHandlerByCondition: function(predicate) {
         for(var i = this.handlerInfoList.length - 1; i >= 0; i--) {
            var handlerInfo = this.handlerInfoList[i];
            if(predicate(handlerInfo))
                _aspxArrayRemoveAt(this.handlerInfoList, i);
        }
    },

    removeHandlerByControlName: function(controlName) {
        this.removeHandlerByCondition(function(handlerInfo) {
            return handlerInfo.executionContext &&  
                handlerInfo.executionContext.name === controlName;
        });
    },

    /*# public void ClearHandlers(){} #*/
    ClearHandlers: function() {
        this.handlerInfoList.length = 0;
    },
    /*# public void FireEvent(object source, ASPxClientEventArgs e){} #*/
    FireEvent: function(obj, args) {
        for(var i = 0; i < this.handlerInfoList.length; i++) {
            var handlerInfo = this.handlerInfoList[i];
            handlerInfo.handler.call(handlerInfo.executionContext, obj, args);
        }
    },
    InsertFirstHandler: function(handler, executionContext){
        if(typeof(executionContext) == "undefined")
            executionContext = null;
        var handlerInfo = ASPxClientEvent.CreateHandlerInfo(handler, executionContext);
        _aspxArrayInsert(this.handlerInfoList, handlerInfo, 0);
    },
    IsEmpty: function() {
        return this.handlerInfoList.length == 0;
    }
});
ASPxClientEvent.CreateHandlerInfo = function(handler, executionContext) {
    return {
        handler: handler,
        executionContext: executionContext
    };
};

/*# public delegate void ASPxClientEventHandler(object source, ASPxClientEventArgs e);#*/
/*# public class ASPxClientEventArgs: JavaScriptObject #*/
ASPxClientEventArgs = _aspxCreateClass(null, {
    /*# public ASPxClientEventArgs() : base(){} #*/
    constructor: function() {

    }
});
ASPxClientEventArgs.Empty = new ASPxClientEventArgs();

/*# public delegate void ASPxClientCancelEventHandler(object source, ASPxClientCancelEventArgs e);#*/
/*# public class ASPxClientCancelEventArgs: ASPxClientEventArgs #*/
ASPxClientCancelEventArgs = _aspxCreateClass(ASPxClientEventArgs, {
    /*# public ASPxClientCancelEventArgs() : base(){} #*/
    constructor: function(){
        this.constructor.prototype.constructor.call(this);
        /*# public bool cancel{ get{return false;} set{} } #*/
        this.cancel = false;
    }
});

/*# public delegate void ASPxClientProcessingModeEventHandler(object source, ASPxClientProcessingModeEventArgs e);#*/
/*# public class ASPxClientProcessingModeEventArgs: ASPxClientEventArgs #*/
ASPxClientProcessingModeEventArgs = _aspxCreateClass(ASPxClientEventArgs, {
    /*# public ASPxClientProcessingModeEventArgs(bool processOnServer) : base(){} #*/
    constructor: function(processOnServer){
        this.constructor.prototype.constructor.call(this);
        /*# public bool processOnServer{ get{return false;} set{} } #*/
        this.processOnServer = processOnServer;
    }
});

/*# public delegate void ASPxClientProcessingModeCancelEventHandler(object source, ASPxClientProcessingModeCancelEventArgs e);#*/
/*# public class ASPxClientProcessingModeCancelEventArgs: ASPxClientProcessingModeEventArgs #*/
ASPxClientProcessingModeCancelEventArgs = _aspxCreateClass(ASPxClientProcessingModeEventArgs, {
    /*# public ASPxClientProcessingModeCancelEventArgs(bool processOnServer) : base(processOnServer){} #*/
    constructor: function(processOnServer){
        this.constructor.prototype.constructor.call(this, processOnServer);
        /*# public bool cancel{ get{return false;} set{} } #*/
        this.cancel = false;
    }
});

/*# public delegate void ASPxClientBeginCallbackEventHandler(object source, ASPxClientBeginCallbackEventArgs e);#*/
/*# public class ASPxClientBeginCallbackEventArgs : ASPxClientEventArgs #*/
ASPxClientBeginCallbackEventArgs = _aspxCreateClass(ASPxClientEventArgs, {
    /*# public ASPxClientBeginCallbackEventArgs(string command) : base(){} #*/
    constructor: function(command){
        this.constructor.prototype.constructor.call(this);
        /*# public string command{ get{return string.Empty;} } #*/
        this.command = command;
    }
});
/*# public delegate void ASPxClientEndCallbackEventHandler(object source, ASPxClientEndCallbackEventArgs e);#*/
/*# public class ASPxClientEndCallbackEventArgs : ASPxClientEventArgs #*/
ASPxClientEndCallbackEventArgs = _aspxCreateClass(ASPxClientEventArgs, {
    /*# public ASPxClientEndCallbackEventArgs() : base(){} #*/
    constructor: function(){
        this.constructor.prototype.constructor.call(this);
    }
});
/*# public delegate void ASPxClientCustomDataCallbackEventHandler(object source, ASPxClientCustomDataCallbackEventArgs e);#*/
/*# public class ASPxClientCustomDataCallbackEventArgs : ASPxClientEventArgs #*/
ASPxClientCustomDataCallbackEventArgs = _aspxCreateClass(ASPxClientEventArgs, {
    /*# public ASPxClientCustomDataCallbackEventArgs(string result) : base() { } #*/
    constructor: function(result) {
        this.constructor.prototype.constructor.call(this);
        /*# public string result { get { return string.Empty; } set { } } #*/
        this.result = result;
    }
});
/*# public delegate void ASPxClientCallbackErrorEventHandler(object source, ASPxClientCallbackErrorEventArgs e);#*/
/*# public class ASPxClientCallbackErrorEventArgs : ASPxClientEventArgs #*/
ASPxClientCallbackErrorEventArgs = _aspxCreateClass(ASPxClientEventArgs, {
    /*# public ASPxClientCallbackErrorEventArgs(string message) : base(){} #*/
    constructor: function(message){
        this.constructor.prototype.constructor.call(this);
        /*# public string message{ get{return string.Empty;} set{} } #*/
        this.message = message;
        /*# public bool handled{ get{return false;} set{} } #*/
        this.handled = false;
    }
});

// Values of unnamed fields must not be sent to the server on a callback
if(_aspxIsFunction(window.WebForm_InitCallbackAddField)) {
    (function() {
        var original = window.WebForm_InitCallbackAddField;
        window.WebForm_InitCallbackAddField = function(name, value) {
            if(typeof(name) == "string" && name)
                original.apply(null, arguments);
        };
    })();
}

ASPxPostHandler = _aspxCreateClass(null, {
    constructor: function() {
        this.Post = new ASPxClientEvent();
        this.PostFinalization = new ASPxClientEvent();
        this.observableForms = [];

        this.ReplaceGlobalPostFunctions();
        this.HandleDxCallbackBeginning();
        this.HandleMSAjaxRequestBeginning();
    },
    Update: function() {
        this.ReplaceFormsSubmit(true);
    },
    OnPost: function() {
        this.Post.FireEvent(this, ASPxClientEventArgs.Empty);
        this.PostFinalization.FireEvent(this, ASPxClientEventArgs.Empty);
    },
    ReplaceGlobalPostFunctions: function() {
        if(_aspxIsFunction(window.__doPostBack))
            this.ReplaceDoPostBack();
        if(_aspxIsFunction(window.WebForm_DoCallback))
            this.ReplaceDoCallback();
                        
        this.ReplaceFormsSubmit();
    },
    HandleDxCallbackBeginning: function() {
        aspxGetControlCollection().BeforeInitCallback.AddHandler(function() {
            _aspxRaisePostHandlerOnPost(false, true);
        });
    },
    HandleMSAjaxRequestBeginning: function() {
        if(window.Sys && Sys.WebForms && Sys.WebForms.PageRequestManager && Sys.WebForms.PageRequestManager.getInstance) {
            var pageRequestManager = Sys.WebForms.PageRequestManager.getInstance();
            if(pageRequestManager != null && ASPxIdent.IsArray(pageRequestManager._onSubmitStatements)) {
                pageRequestManager._onSubmitStatements.unshift(function() {
                    _aspxRaisePostHandlerOnPost(true); return true;
                });
            }
        }
    },
    ReplaceDoPostBack: function() {
        var original = __doPostBack;
        __doPostBack = function(eventTarget, eventArgument) {
            _aspxRaisePostHandlerOnPost();
            original(eventTarget, eventArgument);
        };
    },
    ReplaceDoCallback: function() {
        var original = WebForm_DoCallback;
        WebForm_DoCallback = function(eventTarget, eventArgument, eventCallback, context, errorCallback, useAsync) {
            var postHandler = aspxGetPostHandler();
            
            if(postHandler.dxCallbackHandled)
                delete postHandler.dxCallbackHandled;
            else
                _aspxRaisePostHandlerOnPost();
            
            return original(eventTarget, eventArgument, eventCallback, context, errorCallback, useAsync);
        };
    },
    ReplaceFormsSubmit: function(checkObservableCollection) {
        for(var i = 0; i < document.forms.length; i++) { // In WebForms there will be only one form, but in MVC page can have multiple forms (B203688)
            var form = document.forms[i];
            
            if(checkObservableCollection && _aspxArrayIndexOf(this.observableForms, form) >= 0)
                continue;

            if(form.submit)
                this.ReplaceFormSubmit(form);
            this.ReplaceFormOnSumbit(form);
            this.observableForms.push(form);
        }
    },
    ReplaceFormSubmit: function(form) {
        var originalSubmit = form.submit;
        form.submit = function() {
            _aspxRaisePostHandlerOnPost();
            var callee = arguments.callee;
            this.submit = originalSubmit;
            var submitResult = this.submit();
            this.submit = callee;
            return submitResult;
        };
        form = null;
    },
    ReplaceFormOnSumbit: function(form) {
        var originalSubmit = form.onsubmit;
        form.onsubmit = function() {
            var postHandler = aspxGetPostHandler();

            if(postHandler.msAjaxRequestBeginningHandled)
                delete postHandler.msAjaxRequestBeginningHandled;
            else
                _aspxRaisePostHandlerOnPost();

            return _aspxIsFunction(originalSubmit)
                ? originalSubmit.apply(this, arguments)
                : true;
        };
        form = null;
    }
});

function _aspxRaisePostHandlerOnPost(isMSAjaxRequestBeginning, isDXCallbackBeginning) {
    var postHandler = aspxGetPostHandler();
    if(postHandler) {
        if(isMSAjaxRequestBeginning)
            postHandler.msAjaxRequestBeginningHandled = true;
        else if(isDXCallbackBeginning)
            postHandler.dxCallbackHandled = true;
        postHandler.OnPost();
    }
}
function aspxGetPostHandler() {
    if (!window.__aspxPostHandler)
        window.__aspxPostHandler = new ASPxPostHandler();
    return window.__aspxPostHandler;
}

/*# public delegate void ASPxClientControlsInitializedEventHandler(object source, ASPxClientControlsInitializedEventArgs e); #*/
/*# public class ASPxClientControlsInitializedEventArgs : ASPxClientEventArgs  #*/
ASPxClientControlsInitializedEventArgs = _aspxCreateClass(ASPxClientEventArgs, {
    /*# public ASPxClientControlsInitializedEventArgs(bool isCallback) : base() { } #*/
    constructor: function(isCallback) {
        /*# public bool isCallback { get { return false; } } #*/
        this.isCallback = isCallback;
    }
});

/*# public class ASPxClientControlCollection: JavaScriptObject #*/
ASPxClientControlCollection = _aspxCreateClass(null, {
    constructor: function(){
        this.elements = new Object();
        this.windowResizeSubscribers = [];
        this.prevWndWidth = "";
        this.prevWndHeight = "";

        this.BeforeInitCallback = new ASPxClientEvent();
        /*# public event ASPxClientControlsInitializedEventHandler ControlsInitialized { add{} remove{} } #*/
        this.ControlsInitialized = new ASPxClientEvent();
    },
    
    Add: function(element){
        this.elements[element.name] = element;
    },
    Remove: function(element) {
        this.elements[element.name] = null;
    },
    /*# [Obsolete("Use the GetByName method instead.")]public object Get(object name){return null;} #*/    
    Get: function(name){
        return this.elements[name];
    },
    GetGlobal: function(name) {
        var result = window[name];
        return result && result.isASPxClientControl
            ? result
            : null;
    },
    /*# public object GetByName(string name){return null;} #*/    
    GetByName: function(name){
        return this.Get(name) || this.GetGlobal(name);
    },
    
    ForEachControl: function(processFunc, context) {
        if(!context)
            context = this;
        for(var name in this.elements) {
            var control = this.elements[name];
            if(ASPxIdent.IsASPxClientControl(control))
                if(processFunc.call(context, control))
                    return;
        }
    },
    
    // controls group operations
    AdjustControls: function(container, checkSizeCorrectedFlag) {
        if(typeof(container) == "undefined")
            container = null;
        if(typeof(checkSizeCorrectedFlag) == "undefined")
            checkSizeCorrectedFlag = false;
        var collection = this;
        window.setTimeout(function() {
            collection.ProcessControlsInContainer(container, function(control) {
                control.AdjustControl(checkSizeCorrectedFlag);
            });
        }, 0);
    },
    CollapseControls: function(container, checkSizeCorrectedFlag) {
        this.ProcessControlsInContainer(container, function(control) {
            control.CollapseControl(checkSizeCorrectedFlag);
        });
    },
    
    AtlasInitialize: function(isCallback) {
        if(__aspxIE && __aspxBrowserMajorVersion < 9) {
            var func = function() {
                if(_aspxIsLinksLoaded())
                    _aspxProcessScriptsAndLinks("", isCallback);    
                else
                    setTimeout(func, 100);
            }   
            func();
        }
        else
            _aspxProcessScriptsAndLinks("", isCallback);
    },
    Initialize: function() {
        this.InitializeElements(false /* isCallback */);
        if(typeof(Sys) != "undefined" && typeof(Sys.Application) != "undefined")
            Sys.Application.add_load(aspxCAInit);
        this.InitWindowSizeCache();
    },
    InitializeElements: function(isCallback) {
        this.ForEachControl(function(control){
            if(!control.isInitialized)
                control.Initialize();
        });
        
        if(typeof(_aspxGetEditorStretchedInputElementsManager) != "undefined")
            _aspxGetEditorStretchedInputElementsManager().Initialize();
        
        this.AfterInitializeElements(true);
        this.AfterInitializeElements(false);
        this.RaiseControlsInitialized(isCallback);
    },
    AfterInitializeElements: function(leadingCall) {
        this.ForEachControl(function(control){
            if (control.leadingAfterInitCall && leadingCall || !control.leadingAfterInitCall && !leadingCall) {
                if(!control.isInitialized)
                    control.AfterInitialize();
            }
        });
    },
    DoFinalizeCallback: function() {
        this.ForEachControl(function(control){
            control.DoFinalizeCallback();
        });
    },
    ProcessControlsInContainer: function(container, processFunc) {
        this.ForEachControl(function(control){
            if(!container || this.IsControlInContainer(container, control))
                processFunc(control);
        });
    },
    IsControlInContainer: function(container, control) {
        if(control.GetMainElement) {
            var mainElement = control.GetMainElement();
            if(mainElement && (mainElement != container)) {
                if(_aspxGetIsParent(container, mainElement))
                    return true;
            }
        }
        return false;
    },
    RaiseControlsInitialized: function(isCallback) {
        if(!this.ControlsInitialized.IsEmpty()){
            if(typeof(isCallback) == "undefined")
                isCallback = true;
            var args = new ASPxClientControlsInitializedEventArgs(isCallback);
            this.ControlsInitialized.FireEvent(this, args);
        }
    },
    Before_WebForm_InitCallback: function(){
        var args = new ASPxClientEventArgs();
        this.BeforeInitCallback.FireEvent(this, args);
    },
    
    InitWindowSizeCache: function(){
        this.prevWndWidth = document.documentElement.clientWidth;
        this.prevWndHeight = document.documentElement.clientHeight;
    },
    BrowserWindowSizeChanged: function(){
        var wndWidth = document.documentElement.clientWidth == 0 ? document.body.clientWidth : document.documentElement.clientWidth;
        var wndHeight = document.documentElement.clientHeight == 0 ? document.body.clientHeight : document.documentElement.clientHeight;
        var browserWindowSizeChanged = (this.prevWndWidth != wndWidth) || (this.prevWndHeight != wndHeight);
        if(browserWindowSizeChanged){
            this.prevWndWidth = wndWidth;
            this.prevWndHeight = wndHeight;
            return true;
        }
        return false;
    },
//    SubscribeObjectToBrowserWindowResize: function(object){
//        this.windowResizeSubscribers.push(object);
//    },
    OnBrowserWindowResize: function(evt){
        if(this.BrowserWindowSizeChanged()){
			this.ForEachControl(function(control) {
			    control.OnBrowserWindowResizeInternal(evt);
			});
 			for(var i = 0; i < this.windowResizeSubscribers.length; i++)
            	this.windowResizeSubscribers[i].OnBrowserWindowResize(evt);
        }
    }
});
/*# public delegate void ASPxClientDataCallback(object sender, string result); #*/
/*# public class ASPxClientControl: JavaScriptObject #*/
ASPxClientControl = _aspxCreateClass(null, {
    constructor: function(name){
        this.isASPxClientControl = true;
        
        /*# public string name{ get{ return ""; } } #*/    
        this.name = name;
        this.uniqueID = name;        

        this.enabled = true;
        this.clientEnabled = true;
        this.clientVisible = true;
        this.rtl = false;

        this.autoPostBack = false;
        this.allowMultipleCallbacks = true;
        this.callBack = null;
        this.savedCallbacks = null;
        this.isNative = false;
        this.requestCount = 0;

        this.isInitialized = false;
        this.initialFocused = false;
        this.leadingAfterInitCall = false; // AfterInitialize call will be displaced to the beginning of call queue
        this.sizeCorrectedOnce = false;
        this.serverEvents = [];
        
        this.dialogContentHashTable = { };
        
        this.loadingPanelElement = null;
        this.loadingDivElement = null;        
        this.hasPhantomLoadingPanel = false;
        this.mainElement = null;
        this.renderIFrameForPopupElements = false;
        this.widthValueSetInPercentage = false;

        this.sizingConfig = {
            allowSetWidth: true,
            allowSetHeight: true,
            correction : false,
            adjustControl : false
        };

        /*# public event ASPxClientEventHandler Init{ add{} remove{}}#*/
        this.Init = new ASPxClientEvent();
        this.BeginCallback = new ASPxClientEvent();
        this.EndCallback = new ASPxClientEvent();
        this.CallbackError = new ASPxClientEvent();
        this.CustomDataCallback = new ASPxClientEvent();
        
        aspxGetControlCollection().Add(this);        
    },
    Initialize: function() {
        if(this.callBack != null)
            this.InitializeCallBackData();
    },
    InlineInitialize: function() {

    },
    InitailizeFocus: function() {
        if(this.initialFocused && this.IsVisible())
            this.Focus();
    },
    AfterInitialize: function() {
        this.AdjustControl(__aspxCheckSizeCorrectedFlag);
        this.InitailizeFocus();
        this.isInitialized = true;
        this.RaiseInit();
            
        if(this.savedCallbacks) {
            for(var i = 0; i < this.savedCallbacks.length; i++) 
                this.CreateCallbackInternal(this.savedCallbacks[i].arg, this.savedCallbacks[i].command, 
                    false, this.savedCallbacks[i].callbackInfo);
            this.savedCallbacks = null;
        }
    },
    InitializeCallBackData: function() {

    },
    RenderExistsOnPage: function() {
    	return _aspxIsExistsElement(this.GetMainElement());
    },
    IsStateControllerEnabled: function(){
        return typeof(aspxGetStateController) != "undefined" && aspxGetStateController();
    },
    
    // Sizes
    /*# public int GetWidth() { return 0; } #*/
    GetWidth: function() {
        return this.GetMainElement().offsetWidth;
    },
    /*# public int GetHeight() { return 0; } #*/
    GetHeight: function() {
        return this.GetMainElement().offsetHeight;
    },
    /*# public void SetWidth(int width) { } #*/
    SetWidth: function(width) {
        if(this.sizingConfig.allowSetWidth)
            this.SetSizeCore("width", width, "GetWidth", false);
    },
    /*# public void SetHeight(int height) { } #*/
    SetHeight: function(height) {
        if(this.sizingConfig.allowSetHeight)
            this.SetSizeCore("height", height, "GetHeight", false);
    },
    SetSizeCore: function(sizePropertyName, size, getFunctionName, corrected) {
        if(size < 0)
            return;
            
        this.GetMainElement().style[sizePropertyName] = size + "px";
        if(this.sizingConfig.adjustControl)
            this.AdjustControl(false, true);
        
        if(this.sizingConfig.correction && !corrected) {
            var realSize = this[getFunctionName]();
            if(realSize != size) {
                var correctedSize = size - (realSize - size);
                this.SetSizeCore(sizePropertyName, correctedSize, getFunctionName, true);
            }
        }
    },
    
    // Size correction
    CollapseControl: function(checkSizeCorrectedFlag) {
    
    },
    /*# public void AdjustControl() { } #*/
    AdjustControl: function(checkSizeCorrectedFlag, nestedCall) {
        if(checkSizeCorrectedFlag && this.sizeCorrectedOnce || ASPxClientControl.adjustControlLocked && !nestedCall) {
            this.TryShowPhantomLoadingPanel();
            return;
        }

        ASPxClientControl.adjustControlLocked = true;
        try {
            var mainElement = this.GetMainElement();
            if (!mainElement || !this.IsDisplayed() || this.IsHidden())
                return;
            
            if(!this.sizeCorrectedOnce)
                this.UpdateWidthCorrectionRequired();

            this.AdjustControlCore();
            this.TryShowPhantomLoadingPanel();
                
            this.sizeCorrectedOnce = true;
        } finally {
            delete ASPxClientControl.adjustControlLocked;
        }
    },
    ResetControlAdjustment: function() {
        this.sizeCorrectedOnce = false;
    },
	UpdateWidthCorrectionRequired: function() {
		var mainElement = this.GetMainElement();
	    if(mainElement) {
	        var mainElementStyle = _aspxGetCurrentStyle(mainElement);
	    	this.widthValueSetInPercentage = _aspxIsWidthSetInPercentage(mainElementStyle.width) || _aspxIsWidthSetInPercentage(mainElement.style.width);
	    }
	},
    OnBrowserWindowResize: function(evt) {
    },
    AdjustControlCore: function() {

    },
	OnBrowserWindowResizeInternal: function(evt){
        if(this.widthValueSetInPercentage) 
            this.OnBrowserWindowResize(evt);
    },
    
    RegisterServerEventAssigned: function(eventNames){
        for(var i = 0; i < eventNames.length; i++)
            this.serverEvents[eventNames[i]] = true;
    },
    IsServerEventAssigned: function(eventName){
        return !!this.serverEvents[eventName];
    },
    
    GetChild: function(idPostfix){
        var mainElement = this.GetMainElement();
        return mainElement ? _aspxGetChildById(mainElement, this.name + idPostfix) : null;
    },
    GetItemElementName: function(element) {
        var name = "";
        if(element.id)
            name = element.id.substring(this.name.length + 1);
        return name;
    },
    GetLinkElement: function(element) {
        if (element == null) return null;
        return (element.tagName == "A") ? element : _aspxGetChildByTagName(element, "A", 0);
    },
    GetInternalHyperlinkElement: function(parentElement, index) {
        var element = _aspxGetChildByTagName(parentElement, "A", index);
        if (element == null) 
            element = _aspxGetChildByTagName(parentElement, "SPAN", index);
        return element;
    },
    GetParentForm: function(){
        return _aspxGetParentByTagName(this.GetMainElement(), "FORM");
    },
    /*# public object GetMainElement() { return null; } #*/
    GetMainElement: function(){
        if(!_aspxIsExistsElement(this.mainElement))
            this.mainElement = _aspxGetElementById(this.name);
        return this.mainElement;
    },

    OnControlClick: function(clickedElement, htmlEvent) {

    },
    // Callback
    IsLoadingContainerVisible: function(){
        return this.IsVisible();
    },
    GetLoadingPanelElement: function(){
        return _aspxGetElementById(this.name + "_LP");
    },
    CloneLoadingPanel: function(element, parent) {
        var clone = element.cloneNode(true);
        clone.id = element.id + "V";
        parent.appendChild(clone);
        return clone;
    },
    CreateLoadingPanelInsideContainer: function(parentElement, hideContent, collapseHeight, collapseWidth) {
        if(this.ShouldHideExistingLoadingPanel())
            this.HideLoadingPanel();
        if(parentElement == null)
            return null;
        if(!this.IsLoadingContainerVisible()) {
            this.hasPhantomLoadingPanel = true;
            return null;
        }

        var element = this.GetLoadingPanelElement();
        if (element != null){
            var width = collapseWidth ? 0 : _aspxGetClearClientWidth(parentElement);
            var height = collapseHeight ? 0 : _aspxGetClearClientHeight(parentElement);
            if(hideContent){
                for(var i = parentElement.childNodes.length - 1; i > -1; i--){
                    if(parentElement.childNodes[i].style)
                        parentElement.childNodes[i].style.display = "none";
                    else if(parentElement.childNodes[i].nodeType == 3) // Q353968
                        parentElement.removeChild(parentElement.childNodes[i]);
                }
            }
            else
                parentElement.innerHTML = "";
            
            var table = document.createElement("TABLE");
            parentElement.appendChild(table);
            table.border = 0;
            table.cellPadding = 0;
            table.cellSpacing = 0;
            table.style.height = (height > 0) ? height + "px" : "100%";
            table.style.width = (width > 0) ? width + "px" : "100%";
            var tbody = document.createElement("TBODY");
            table.appendChild(tbody);
            var tr = document.createElement("TR");
            tbody.appendChild(tr);
            var td = document.createElement("TD");
            tr.appendChild(td);
            td.align = "center";
            td.vAlign = "middle";
            
            element = this.CloneLoadingPanel(element, td);
            _aspxSetElementDisplay(element, true);
            this.loadingPanelElement = element;
            return element;
        } else
            parentElement.innerHTML = "&nbsp;";
        return null;
    },
    CreateLoadingPanelWithAbsolutePosition: function(parentElement, offsetElement) {
        if(this.ShouldHideExistingLoadingPanel())
            this.HideLoadingPanel();
        if(parentElement == null)
            return null;
        if(!this.IsLoadingContainerVisible()) {
            this.hasPhantomLoadingPanel = true;
            return null;
        }
        
        if(!offsetElement)
            offsetElement = parentElement;
        var element = this.GetLoadingPanelElement();
        if(element != null) {
            element = this.CloneLoadingPanel(element, parentElement);
            element.style.position = "absolute";
            _aspxSetElementDisplay(element, true);
            this.SetLoadingPanelLocation(offsetElement, element);
            this.loadingPanelElement = element;
            return element;
        }
        return null;
    },
    CreateLoadingPanelInline: function(parentElement){
        if(this.ShouldHideExistingLoadingPanel())
            this.HideLoadingPanel();
        if(parentElement == null)
            return null;
        if(!this.IsLoadingContainerVisible()) {
            this.hasPhantomLoadingPanel = true;
            return null;
        }

        var element = this.GetLoadingPanelElement();
        if(element != null) {
            element = this.CloneLoadingPanel(element, parentElement);
            _aspxSetElementDisplay(element, true);
            this.loadingPanelElement = element;
            return element;
        }
        return null;
    },
    ShowLoadingPanel: function() {
    },
    HideLoadingPanel: function() {
        this.hasPhantomLoadingPanel = false;
        if(_aspxIsExistsElement(this.loadingPanelElement)) {
            _aspxRemoveElement(this.loadingPanelElement);
            this.loadingPanelElement = null;
        }
    },
    SetLoadingPanelLocation: function(offsetElement, loadingPanel, x, y, offsetX, offsetY) {
        if(!_aspxIsExists(x) || !_aspxIsExists(y)){
            var x1 = _aspxGetAbsoluteX(offsetElement);
            var y1 = _aspxGetAbsoluteY(offsetElement);
            var x2 = x1;
            var y2 = y1;
            if(offsetElement == document.body){
                x2 += _aspxGetDocumentMaxClientWidth();
                y2 += _aspxGetDocumentMaxClientHeight();
            }
            else{
                x2 += offsetElement.offsetWidth;
                y2 += offsetElement.offsetHeight;
            }
            if(x1 < _aspxGetDocumentScrollLeft())
                x1 = _aspxGetDocumentScrollLeft();
            if(y1 < _aspxGetDocumentScrollTop())
                y1 = _aspxGetDocumentScrollTop();
            if(x2 > _aspxGetDocumentScrollLeft() + _aspxGetDocumentClientWidth())
                x2 = _aspxGetDocumentScrollLeft() + _aspxGetDocumentClientWidth();
            if(y2 > _aspxGetDocumentScrollTop() + _aspxGetDocumentClientHeight())
                y2 = _aspxGetDocumentScrollTop() + _aspxGetDocumentClientHeight();

            x = x1 + ((x2 - x1 - loadingPanel.offsetWidth) / 2);
            y = y1 + ((y2 - y1 - loadingPanel.offsetHeight) / 2);
        }
        if(_aspxIsExists(offsetX) && _aspxIsExists(offsetY)){
            x += offsetX;
            y += offsetY;
        }
        x = _aspxPrepareClientPosForElement(x, loadingPanel, true);
        y = _aspxPrepareClientPosForElement(y, loadingPanel, false);
        if(__aspxIE && __aspxBrowserVersion == 9 && (y - Math.floor(y) === 0.5))
            y = Math.ceil(y);
        loadingPanel.style.left = x + "px";
        loadingPanel.style.top = y + "px";
    },
    TryShowPhantomLoadingPanel: function() {
        if(this.hasPhantomLoadingPanel && this.InCallback())
            this.ShowLoadingPanel();
        this.hasPhantomLoadingPanel = false;
    },
    
    GetLoadingDiv: function(){
        return _aspxGetElementById(this.name + "_LD");
    },
    CreateLoadingDiv: function(parentElement, offsetElement){
        if(this.ShouldHideExistingLoadingPanel())
            this.HideLoadingDiv();
        if(parentElement == null || !this.IsLoadingContainerVisible()) return null;
    
        if(!offsetElement)
            offsetElement = parentElement;
        var div = this.GetLoadingDiv();
        if(div != null){
            div = div.cloneNode(true);
            parentElement.appendChild(div);
            _aspxSetElementDisplay(div, true);
            this.SetLoadingDivBounds(offsetElement, div);
            this.loadingDivElement = div;
            return div;
        }
        return null;
    },
    SetLoadingDivBounds: function(offsetElement, loadingDiv) {
        var absX = (offsetElement == document.body) ? 0 : _aspxGetAbsoluteX(offsetElement);
        var absY = (offsetElement == document.body) ? 0 : _aspxGetAbsoluteY(offsetElement);
        loadingDiv.style.left = _aspxPrepareClientPosForElement(absX, loadingDiv, true) + "px";
        loadingDiv.style.top = _aspxPrepareClientPosForElement(absY, loadingDiv, false) + "px";
        var width = (offsetElement == document.body) ? _aspxGetDocumentWidth() : offsetElement.offsetWidth;
        var height = (offsetElement == document.body) ? _aspxGetDocumentHeight() : offsetElement.offsetHeight;
        if(height < 0) // B148866
            height = 0;
        _aspxSetStyleSize(loadingDiv, width, height);    
        var correctedWidth = 2 * width - loadingDiv.offsetWidth;
        if(correctedWidth <= 0) correctedWidth = width;
        var correctedHeight = 2 * height - loadingDiv.offsetHeight;
        if(correctedHeight <= 0) correctedHeight = height;
        _aspxSetStyleSize(loadingDiv, correctedWidth, correctedHeight);
    },
    HideLoadingDiv: function() {
        if(_aspxIsExistsElement(this.loadingDivElement)){
            _aspxRemoveElement(this.loadingDivElement);
            this.loadingDivElement = null;
        }
    },

    RaiseInit: function(){
        if(!this.Init.IsEmpty()){
            var args = new ASPxClientEventArgs();
            this.Init.FireEvent(this, args);
        }
    },
    RaiseBeginCallbackInternal: function(command){
        if(!this.BeginCallback.IsEmpty()){
            var args = new ASPxClientBeginCallbackEventArgs(command);
            this.BeginCallback.FireEvent(this, args);
        }
    },
    RaiseBeginCallback: function(command){
        this.RaiseBeginCallbackInternal(command);
        if(typeof(aspxGetGlobalEvents) != "undefined")
            aspxGetGlobalEvents().OnBeginCallback(this, command);
    },
    RaiseEndCallback: function(){
        if(!this.EndCallback.IsEmpty()){
            var args = new ASPxClientEndCallbackEventArgs();
            this.EndCallback.FireEvent(this, args);
        }
        if(typeof(aspxGetGlobalEvents) != "undefined")
            aspxGetGlobalEvents().OnEndCallback(this);
    },
    RaiseCallbackError: function(message) {
        if(!this.CallbackError.IsEmpty()) {
            var args = new ASPxClientCallbackErrorEventArgs(message);
            this.CallbackError.FireEvent(this, args);
            if(args.handled)
                return { isHandled: true, errorMessage: args.message };
        }
        if(typeof(aspxGetGlobalEvents) != "undefined") {
            var args = new ASPxClientCallbackErrorEventArgs(message);
            aspxGetGlobalEvents().OnCallbackError(this, args);
            if(args.handled)
                return { isHandled: true, errorMessage: args.message };
        }
        return { isHandled: false, errorMessage: message };
    },
    IsVisible: function() {
        var element = this.GetMainElement();
        return _aspxElementIsVisible(element);
    },
    IsDisplayed: function() {
        var element = this.GetMainElement();
        while(element && element.tagName != "BODY") {
            if(!_aspxGetElementDisplay(element)) 
                return false;
            element = element.parentNode;
        }
        return true;
    },
    IsHidden: function() {
        var element = this.GetMainElement();
        return element.offsetWidth == 0 && element.offsetHeight == 0;
    },
    Focus: function() {
    
    },
    /*# [Obsolete("Use the GetVisible method instead.")]public bool GetClientVisible() { return false; } #*/    
    GetClientVisible: function(){
        return this.GetVisible();
    },
    /*# [Obsolete("Use the SetVisible method instead.")]public void SetClientVisible(bool visible) {} #*/
    SetClientVisible: function(visible){
        this.SetVisible(visible);
    },
    /*# public bool GetVisible() { return false; } #*/    
    GetVisible: function(){
        return this.clientVisible;
    },
    /*# public void SetVisible(bool visible) {} #*/
    SetVisible: function(visible){
        if(this.clientVisible != visible){
            this.clientVisible = visible;
            _aspxSetElementDisplay(this.GetMainElement(), visible);
            if (visible) {
                this.AdjustControl(__aspxCheckSizeCorrectedFlag);
                
                var mainElement = this.GetMainElement();
                if(mainElement)
                    aspxGetControlCollection().AdjustControls(mainElement, __aspxCheckSizeCorrectedFlag);
            }
        }
    },
    GetEnabled: function() {
        return this.clientEnabled;
    },
    SetEnabled: function(enabled) {
        this.clientEnabled = enabled;
        
        if(ASPxClientControl.setEnabledLocked)
            return;
        else
            ASPxClientControl.setEnabledLocked = true;

        aspxGetControlCollection().ProcessControlsInContainer(this.GetMainElement(), function(control) {
            if(_aspxIsFunction(control.SetEnabled))
                control.SetEnabled(enabled);
        });

        delete ASPxClientControl.setEnabledLocked;
    },
    /*# public bool InCallback() { return false; } #*/        
    InCallback: function() {
        return this.requestCount > 0;
    },
    DoBeginCallback: function(command) {
        this.RaiseBeginCallback(command || "");

        aspxGetControlCollection().Before_WebForm_InitCallback();
        if(typeof(WebForm_InitCallback) != "undefined" && WebForm_InitCallback) {
            __theFormPostData = "";
            __theFormPostCollection = [ ];
            this.ClearPostBackEventInput("__EVENTTARGET");
            this.ClearPostBackEventInput("__EVENTARGUMENT");
            WebForm_InitCallback();
            this.savedFormPostData = __theFormPostData;            
            this.savedFormPostCollection = __theFormPostCollection;
        }
    },
    ClearPostBackEventInput: function(id){
        var element = _aspxGetElementById(id);
        if(element != null) element.value = "";
    },
    PerformDataCallback: function(arg, handler) {
        this.CreateCustomDataCallback(arg, "", handler);
    }, 
    CreateCallback: function(arg, command) {
        var callbackInfo = this.CreateCallbackInfo(ASPxCallbackType.Common, null);
        this.CreateCallbackByInfo(arg, command, callbackInfo);
    },
    CreateCustomDataCallback: function(arg, command, handler) {
        var callbackInfo = this.CreateCallbackInfo(ASPxCallbackType.Data, handler);
        this.CreateCallbackByInfo(arg, command, callbackInfo);
    },
    CreateCallbackByInfo: function(arg, command, callbackInfo) {
        if(!this.CanCreateCallback()) return;

        if(typeof(WebForm_DoCallback) != "undefined" && WebForm_DoCallback && __aspxDocumentLoaded)
            this.CreateCallbackInternal(arg, command, true, callbackInfo);
        else {
            if(!this.savedCallbacks)
                this.savedCallbacks = [];
            var callbackInfo = { arg: arg, command: command, callbackInfo: callbackInfo };
            if(this.allowMultipleCallbacks)
                this.savedCallbacks.push(callbackInfo);
            else
                this.savedCallbacks[0] = callbackInfo;
        }
    },
    CreateCallbackInternal: function(arg, command, viaTimer, callbackInfo) {
        this.requestCount++;
        this.DoBeginCallback(command);
        
        if(typeof(arg) == "undefined")
            arg = "";
        if(typeof(command) == "undefined")
            command = "";
        
        var callbackID = this.SaveCallbackInfo(callbackInfo);
        if(viaTimer)
            window.setTimeout("aspxCreateCallback('" + this.name + "', '" + escape(arg) + "', '" + escape(command) + "', " + callbackID + ");", 0);
        else
            this.CreateCallbackCore(arg, command, callbackID);
    },
    CreateCallbackCore: function(arg, command, callbackID) {
        __theFormPostData = this.savedFormPostData;
        __theFormPostCollection = this.savedFormPostCollection;
        this.callBack(this.GetSerializedCallbackInfoByID(callbackID) + arg);
    },
    CanCreateCallback: function() {
        return this.allowMultipleCallbacks || !this.InCallback();
    },
    DoLoadCallbackScripts: function() {
        _aspxProcessScriptsAndLinks(this.name);
    },
    DoEndCallback: function() {
        this.requestCount--;
        if(this.HideLoadingPanelOnCallback() && this.requestCount < 1) {
            this.HideLoadingDiv();
            this.HideLoadingPanel();
        }
        this.RaiseEndCallback();
    },
    DoFinalizeCallback: function() {
    },
    HideLoadingPanelOnCallback: function() {
        return true;
    },
	ShouldHideExistingLoadingPanel: function() {
        return true;
    },
    EvalCallbackResult: function(resultString){
        return eval(resultString)
    },
    DoCallback: function(result) {
        result = _aspxTrim(result);
        if(result.indexOf(__aspxCallbackResultPrefix) != 0) 
            this.ProcessCallbackGeneralError(result);
        else {
            var resultObj = null;
            try {
                resultObj = this.EvalCallbackResult(result);
            } 
            catch(e) {
                // B36430
            }
            if(resultObj) {
                if(resultObj.redirect){
                    if(!__aspxIE)
                        window.location.href = resultObj.redirect;
                    else { // B194434
                        var fakeLink = document.createElement("a");
                        fakeLink.href = resultObj.redirect;
                        document.body.appendChild(fakeLink); 
                        fakeLink.click();
                    }
                }
                else if(resultObj.generalError){
                    this.ProcessCallbackGeneralError(resultObj.generalError);
                }
                else {
                    var errorObj = resultObj.error;
                    if(errorObj)
                        this.ProcessCallbackError(errorObj);
                    else {
                        if(resultObj.cp) {
                            for(var name in resultObj.cp)
                                this[name] = resultObj.cp[name];
                        }
                        var callbackInfo = this.DequeueCallbackInfo(resultObj.id);
                        if(callbackInfo.type == ASPxCallbackType.Data)    
                            this.ProcessCustomDataCallback(resultObj.result, callbackInfo);
                        else    
                            this.ProcessCallback(resultObj.result);
                    }
                    
                }
            } 
        }
        // B156350, B148956, B204609
        this.DoLoadCallbackScripts();
    },
    DoCallbackError: function(result) {
        this.HideLoadingDiv();
        this.HideLoadingPanel();
        this.ProcessCallbackGeneralError(result); // B191862
    },
    DoControlClick: function(evt) {
        this.OnControlClick(_aspxGetEventSource(evt), evt);
    },
    ProcessCallback: function(result) {
        this.OnCallback(result);
    },
    ProcessCustomDataCallback: function(result, callbackInfo) {
        if(callbackInfo.handler != null)
            callbackInfo.handler(this, result);
        this.RaiseCustomDataCallback(result);
    },
    RaiseCustomDataCallback: function(result) {
        if(!this.CustomDataCallback.IsEmpty()) {
            var arg = new ASPxClientCustomDataCallbackEventArgs(result);
            this.CustomDataCallback.FireEvent(this, arg);
        }
    },
    OnCallback: function(result) {
    
    },
    CreateCallbackInfo: function(type, handler) {
        return { type: type, handler: handler };
    },
    GetSerializedCallbackInfoByID: function(callbackID) {
        return this.GetCallbackInfoByID(callbackID).type + callbackID + __aspxCallbackSeparator;
    },
    SaveCallbackInfo: function(callbackInfo) {
        var activeCallbacksInfo = this.GetActiveCallbacksInfo();
        for(var i = 0; i < activeCallbacksInfo.length; i++) {
            if(activeCallbacksInfo[i] == null) {
                activeCallbacksInfo[i] = callbackInfo;
                return i;
            }
        }
        activeCallbacksInfo.push(callbackInfo);
        return activeCallbacksInfo.length - 1;
    },
    GetActiveCallbacksInfo: function() {
        var persistentProperties = this.GetPersistentProperties();
        if(!persistentProperties.activeCallbacks)
            persistentProperties.activeCallbacks = [ ];
        return persistentProperties.activeCallbacks;
    },
    GetPersistentProperties: function() {
        var storage = _aspxGetPersistentControlPropertiesStorage();
        var persistentProperties = storage[this.name];
        if(!persistentProperties) {
            persistentProperties = { };
            storage[this.name] = persistentProperties;
        }
        return persistentProperties;
    },
    GetCallbackInfoByID: function(callbackID) {
        return this.GetActiveCallbacksInfo()[callbackID];
    },
    DequeueCallbackInfo: function(index) {
        var activeCallbacksInfo = this.GetActiveCallbacksInfo();
        if(index < 0 || index >= activeCallbacksInfo.length)
            return null;
        var result = activeCallbacksInfo[index];
        activeCallbacksInfo[index] = null;
        return result;
    },
    ProcessCallbackError: function(errorObj) {
        var data = _aspxIsExists(errorObj.data) ? errorObj.data : null;
        var result = this.RaiseCallbackError(errorObj.message);
        if(!result.isHandled)
            this.OnCallbackError(result.errorMessage, data);
    },
    OnCallbackError: function(errorMessage, data) {
        if(errorMessage)
            alert(errorMessage);
    },
    ProcessCallbackGeneralError: function(errorMessage) {
        var result = this.RaiseCallbackError(errorMessage);
        if(!result.isHandled)
            this.OnCallbackGeneralError(result.errorMessage);
    },
    OnCallbackGeneralError: function(errorMessage) {
        this.OnCallbackError(errorMessage, null);
    },

    SendPostBack: function(params) {
        __doPostBack(this.uniqueID, params);
    }
});

/*# public static void AdjustControls(){ } #*/ 
/*# public static void AdjustControls(object container){ } #*/ 
ASPxClientControl.AdjustControls = function(container){
    aspxGetControlCollection().AdjustControls(container);
};

/*# public static ASPxClientControl Cast(object obj){ return null; } #*/ 
ASPxClientControl.Cast = function(obj) {
    if(typeof obj == "string")
        return window[obj];
    return obj;
};

// Identification

ASPxIdent = { };

ASPxIdent.IsDate = function(obj) {
    return obj && obj.constructor == Date;
};
ASPxIdent.IsRegExp = function(obj) {
    return obj && obj.constructor === RegExp;
};
ASPxIdent.IsArray = function(obj) {
    return obj && obj.constructor == Array;
};
ASPxIdent.IsASPxClientControl = function(obj) {
    return obj && obj.isASPxClientControl;
};
ASPxIdent.IsASPxClientEdit = function(obj) {
    return obj && obj.isASPxClientEdit;
};
ASPxIdent.IsASPxClientRadioButtonList = function(obj) {
    return obj && obj.isASPxClientRadioButtonList;
};

/*# public static ASPxClientControlCollection GetControlCollection(){return null;} #*/
ASPxClientControl.GetControlCollection = function(){
    return aspxGetControlCollection();
}

var __aspxControlCollection = null;
function aspxGetControlCollection(){
    if(__aspxControlCollection == null)
        __aspxControlCollection = new ASPxClientControlCollection();
    return __aspxControlCollection;
}

var __aspxPersistentControlPropertiesStorage = null;
function _aspxGetPersistentControlPropertiesStorage() {
    if(__aspxPersistentControlPropertiesStorage == null)
        __aspxPersistentControlPropertiesStorage = { };
    return __aspxPersistentControlPropertiesStorage;
}

function _aspxFunctionIsInCallstack(currentCallee, targetFunction, depthLimit) {
    var candidate = currentCallee;
    var depth = 0;
    while(candidate && depth <= depthLimit) {
        candidate = candidate.caller;
        if(candidate == targetFunction)
            return true;
        depth++;
    }
    return false;
}
function aspxCAInit() {
    var isAppInit = typeof(Sys$_Application$_doInitialize) != "undefined" &&
        _aspxFunctionIsInCallstack(arguments.callee, Sys$_Application$_doInitialize, 10 /* depthLimit */);
    aspxGetControlCollection().AtlasInitialize(!isAppInit);
}
function aspxCreateCallback(name, arg, command, callbackID){
    var control = aspxGetControlCollection().Get(name);
    if(control != null)
        control.CreateCallbackCore(unescape(arg), unescape(command), callbackID);
}
function aspxCallback(result, context){
    var collection = aspxGetControlCollection();
    collection.DoFinalizeCallback();
    var control = collection.Get(context);
    if(control != null)
        control.DoCallback(result);
}
function aspxCallbackError(result, context){
    var control = aspxGetControlCollection().Get(context);
    if(control != null)
        control.DoCallbackError(result, false);
}

function aspxCClick(name, evt) {
    var control = aspxGetControlCollection().Get(name);
    if(control != null) control.DoControlClick(evt);
}

_aspxAttachEventToElement(window, "resize", aspxGlobalWindowResize);
function aspxGlobalWindowResize(evt){
    aspxGetControlCollection().OnBrowserWindowResize(evt);    
}

_aspxAttachEventToElement(window, "load", aspxClassesWindowOnLoad);
function aspxClassesWindowOnLoad(evt){
    __aspxDocumentLoaded = true;
    ASPxResourceManager.SynchronizeResources();
    aspxGetControlCollection().Initialize();
    _aspxInitializeScripts();
    _aspxInitializeLinks();
    _aspxInitializeFocus();
}

// Default button
function aspxFireDefaultButton(evt, buttonID) {
    if(_aspxIsDefaultButtonEvent(evt, buttonID)) {
        var defaultButton = _aspxGetElementById(buttonID);
        if(defaultButton && defaultButton.click) {
            if(_aspxIsFocusable(defaultButton))
                defaultButton.focus();
            _aspxDoElementClick(defaultButton);
            _aspxPreventEventAndBubble(evt);
            return false;
        }
    }
    return true;
}
function _aspxIsDefaultButtonEvent(evt, defaultButtonID) {
    if(evt.keyCode != ASPxKey.Enter)
        return false;
    var srcElement = _aspxGetEventSource(evt);
    if(!srcElement || srcElement.id === defaultButtonID)
        return true;
    var tagName = srcElement.tagName;
    var type = srcElement.type;
    return tagName != "TEXTAREA" && tagName != "BUTTON" && tagName != "A" &&
        (tagName != "INPUT" || type != "checkbox" && type != "radio" && type != "button" && type != "submit" && type != "reset");
}

// Resources manager
ASPxResourceManager = {
    HandlerStr: "DXR.axd?r=",
    ResourceHashes: {},
    
    SynchronizeResources: function(){
        this.SynchronizeResourcesElements(_aspxGetIncludeScripts(), "src", "DXScript");
    },
    SynchronizeResourcesElements: function(elements, urlAttr, id){
        var s = this.GetResourcesElementsString(elements, urlAttr, id);
        this.UpdateInputElements(id, s);
    },
    GetResourcesElementsString: function(elements, urlAttr, id){
        if(!this.ResourceHashes[id]) 
            this.ResourceHashes[id] = {};
        var hash = this.ResourceHashes[id];

        for(var i = 0; i < elements.length; i++) {
            var resourceUrl = _aspxGetAttribute(elements[i], urlAttr);
            if(resourceUrl) {
                var pos = resourceUrl.indexOf(this.HandlerStr);
                if(pos > -1){
                    var list = resourceUrl.substr(pos + this.HandlerStr.length);
                    var ampPos = list.lastIndexOf("-");
                    if(ampPos > -1)
                        list = list.substr(0, ampPos);
                    var indexes = list.split(",");
                    for(var j = 0; j < indexes.length; j++)
                        hash[indexes[j]] = indexes[j];
                }
                else
                    hash[resourceUrl] = resourceUrl;
            }
        }
        var array = [];
        for(var key in hash) 
            array.push(key);
        return array.join(",");
    },
    UpdateInputElements: function(typeName, list){
        for(var i = 0; i < document.forms.length; i++){
            var inputElement = document.forms[i][typeName];
            if(!inputElement)
                inputElement = this.CreateInputElement(document.forms[i], typeName);
            inputElement.value = list;
        }
    },
    CreateInputElement: function(form, typeName){
        var inputElement = _aspxCreateHiddenField(typeName);
        form.appendChild(inputElement);
        return inputElement;
    }
};

// Javascript manager
var __aspxIncludeScriptPrefix = "dxis_";
var __aspxStartupScriptPrefix = "dxss_";
var __aspxIncludeScriptsCache = {};
var __aspxCreatedIncludeScripts = [];
var __aspxAppendedScriptsCount = 0;
var __aspxCallbackOwnerNames = [];
var __aspxScriptsRestartHandlers = { };

function _aspxGetScriptCode(script) {
    var useFirstChildElement = __aspxChrome && __aspxBrowserVersion < 11 
		|| __aspxSafari && __aspxBrowserVersion < 5; //B184987
	var text = useFirstChildElement ? script.firstChild.data : script.text;
    var comment = "<!--";
    var pos = text.indexOf(comment);
    if(pos > -1)
        text = text.substr(pos + comment.length);
    return text;
}
function _aspxAppendScript(script) {
    var parent = document.getElementsByTagName("head")[0];
    if(!parent)
        parent = document.body;
    if(parent)
        parent.appendChild(script);
}

function _aspxIsAlphaFilterUsed(img){
    return (__aspxIE && __aspxBrowserVersion < 9 && img.style.filter.indexOf("progid:DXImageTransform.Microsoft.AlphaImageLoader") > -1);
}
function _aspxIsKnownIncludeScript(script) {
    return !!__aspxIncludeScriptsCache[script.src];
}
function _aspxCacheIncludeScript(script) {
    __aspxIncludeScriptsCache[script.src] = 1;
}

function _aspxProcessScriptsAndLinks(ownerName, isCallback) {
    if(!__aspxDocumentLoaded) return; // Q206563
    _aspxProcessScripts(ownerName, isCallback);
    _aspxSweepDuplicatedLinks();
    _aspxMoveLinkElements();
    __aspxCachedRules = { };
}
function _aspxGetStartupScripts() {
    return _aspxGetScriptsCore(__aspxStartupScriptPrefix);
}
function _aspxGetIncludeScripts() {
    return _aspxGetScriptsCore(__aspxIncludeScriptPrefix);
}
function _aspxGetScriptsCore(prefix) {
    var result = [];
    var scripts = document.getElementsByTagName("SCRIPT");
    for(var i = 0; i < scripts.length; i++) {
        if (scripts[i].id.indexOf(prefix) == 0)
            result.push(scripts[i]);
    }
    return result;
}
function _aspxGetLinks() {
    var result = [];
    var links = document.getElementsByTagName("LINK");;
    for(var i = 0; i < links.length; i++) 
        result[i] = links[i];
    return result;
}
function _aspxIsLinksLoaded() {
    var links = _aspxGetLinks();
    for(var i = 0, link; link = links[i]; i++) {
        // B208826, B220948, B209968
        if(link.readyState && link.readyState.toLowerCase() == "loading")
                return false;
        }
    return true;
}

function _aspxInitializeLinks() {
    var links = _aspxGetLinks();
    for(var i = 0; i < links.length; i++)
        links[i].loaded = true;    
}
function _aspxInitializeScripts() {
    var scripts = _aspxGetIncludeScripts();
    for(var i = 0; i < scripts.length; i++)
        _aspxCacheIncludeScript(scripts[i]);            
        
    var startupScripts = _aspxGetStartupScripts();
    for(var i = 0; i < startupScripts.length; i++)
        startupScripts[i].executed = true;    
}
function _aspxSweepDuplicatedLinks() {
    if((__aspxIE && __aspxBrowserVersion < 7) || __aspxOpera)
        return;

    var hash = { };
    var links = _aspxGetLinks();
    for(var i = 0; i < links.length; i++) {
        var href = links[i].href;
        if(!href)
            continue;
            
        if(hash[href]){
            if(!hash[href].loaded && links[i].loaded){
                _aspxRemoveElement(hash[href]);
                hash[href] = links[i];
            }
            else
                _aspxRemoveElement(links[i]);
        }
        else
            hash[href] = links[i];
    }
}
function _aspxSweepDuplicatedScripts() {
    var hash = { };
    var scripts = _aspxGetIncludeScripts();
    for(var i = 0; i < scripts.length; i++) {
        var src = scripts[i].src;
        if(!src) continue;
        
        if(hash[src])
            _aspxRemoveElement(scripts[i]);
        else
            hash[src] = scripts[i];
    }
}
function _aspxProcessScripts(ownerName, isCallback) {
    var scripts = _aspxGetIncludeScripts();
    var previousCreatedScript = null;
    var firstCreatedScript = null;

    for(var i = 0; i < scripts.length; i++) {
        var script = scripts[i];
        if(script.src == "") continue; // B134651
        if(_aspxIsKnownIncludeScript(script))
            continue;

        var createdScript = document.createElement("script");

        createdScript.type = "text/javascript";
        createdScript.src = script.src;
        createdScript.id = script.id;

        function AreScriptsEqual(script1, script2) {
            return script1.src == script2.src;
        }

        if(_aspxArrayIndexOf(__aspxCreatedIncludeScripts, createdScript, AreScriptsEqual) >= 0)
            continue;

        __aspxCreatedIncludeScripts.push(createdScript);
        _aspxRemoveElement(script);

        if(__aspxIE && __aspxBrowserVersion < 9) {
            createdScript.onreadystatechange = new Function("_aspxOnScriptReadyStateChangedCallback(this, \"" + ownerName + "\");");
        } else if(__aspxWebKitFamily || (__aspxFirefox && __aspxBrowserVersion >= 4) || __aspxIE && __aspxBrowserVersion >= 9) {
            // Organizing scripts into a linked list to perform their loading and execution sequentially
            createdScript.onload = new Function("_aspxOnScriptLoadCallback(this, \"" + ownerName + "\");");
            if(firstCreatedScript == null)
                firstCreatedScript = createdScript;
            createdScript.nextCreatedScript = null;
            if(previousCreatedScript != null)
                previousCreatedScript.nextCreatedScript = createdScript;
            previousCreatedScript = createdScript;
        } else {
            // Immediate script loading
            createdScript.onload = new Function("_aspxOnScriptLoadCallback(this, \"" + ownerName + "\");");
            _aspxAppendScript(createdScript);
            _aspxCacheIncludeScript(createdScript);
        }
    }

    // If a scripts linked list was organized, start script loading and executing from the first list element
    if(firstCreatedScript != null) {
        _aspxAppendScript(firstCreatedScript);
        _aspxCacheIncludeScript(firstCreatedScript);
    }

    __aspxCallbackOwnerNames.push(ownerName);

    if(__aspxCreatedIncludeScripts.length == 0)
        _aspxFinalizeScriptProcessing(ownerName, isCallback);
}
function _aspxFinalizeScriptProcessing(ownerName, isCallback) {
    __aspxCreatedIncludeScripts = [];
    __aspxAppendedScriptsCount = 0;

    _aspxSweepDuplicatedScripts();
    _aspxRunStartupScripts(isCallback);
    ASPxResourceManager.SynchronizeResources();

    while(__aspxCallbackOwnerNames.length > 0) {
        var callbackOwnerName = __aspxCallbackOwnerNames.pop();
        var callbackOwner = aspxGetControlCollection().Get(callbackOwnerName);
        if(callbackOwner)
            callbackOwner.DoEndCallback();
    }
}

function _aspxRunStartupScripts(isCallback) {
    var scripts = _aspxGetStartupScripts();
    var code;
    for(var i = 0; i < scripts.length; i++){
        if(!scripts[i].executed) {
            code = _aspxGetScriptCode(scripts[i]);
            eval(code);
            scripts[i].executed = true;
        }
    }
    if(__aspxDocumentLoaded) // B133784
        aspxGetControlCollection().InitializeElements(isCallback);
    
    for(var key in __aspxScriptsRestartHandlers)
        __aspxScriptsRestartHandlers[key]();
}

function _aspxOnScriptReadyStateChangedCallback(scriptElement, ownerName) {
    if(scriptElement.readyState == "loaded") {
        _aspxCacheIncludeScript(scriptElement);

        for(var i = 0; i < __aspxCreatedIncludeScripts.length; i++) {
            var script = __aspxCreatedIncludeScripts[i];
            if(_aspxIsKnownIncludeScript(script)) {
                if(!script.executed) {
                    script.executed = true;
                    _aspxAppendScript(script);
                    __aspxAppendedScriptsCount++;
                }
            } else
                break;
        }

        if(__aspxCreatedIncludeScripts.length == __aspxAppendedScriptsCount)
            _aspxFinalizeScriptProcessing(ownerName);
    }
}
function _aspxOnScriptLoadCallback(scriptElement, ownerName) {
    __aspxAppendedScriptsCount++;

    if(scriptElement.nextCreatedScript) {
        _aspxAppendScript(scriptElement.nextCreatedScript);
        _aspxCacheIncludeScript(scriptElement.nextCreatedScript);
    }

    if(__aspxCreatedIncludeScripts.length == __aspxAppendedScriptsCount)
        _aspxFinalizeScriptProcessing(ownerName);
}

function _aspxAddScriptsRestartHandler(objectName, handler) {
    __aspxScriptsRestartHandlers[objectName] = handler;
}

function _aspxMoveLinkElements() {
    if(__aspxIE)
        return;
    var head = _aspxGetElementsByTagName(document, "head")[0];
    var bodyLinks = _aspxGetElementsByTagName(document.body, "link");
    while(bodyLinks.length > 0) 
        head.appendChild(bodyLinks[0]);
}

function _aspxToJson(param){
    var paramType = typeof(param);
    if((paramType == "undefined") || (param == null))
        return null;
    if((paramType == "object") && (typeof(param.__toJson) == "function"))
        return param.__toJson();
    if((paramType == "number") || (paramType == "boolean"))
        return param;
    if(param.constructor == Date)
        return _aspxDateToJson(param);
    if(paramType == "string") {
        var result = param.replace(/\\/g, "\\\\");
        result = result.replace(/"/g, "\\\"");
        // For request validation
        result = result.replace(/</g, "\\u003c");
        result = result.replace(/>/g, "\\u003e");
        return "\"" + result + "\"";
    }
    if(param.constructor == Array){
        var values = [];
        for(var i = 0; i < param.length; i++)
            values.push(_aspxToJson(param[i]));
        return "[" + values.join(",") + "]";
    }
    var exceptKeys = {};
    if(ASPxIdent.IsArray(param.__toJsonExceptKeys))
        exceptKeys = _aspxCreateHashTableFromArray(param.__toJsonExceptKeys);
    exceptKeys["__toJsonExceptKeys"] = 1;
    var values = [];
    for(var key in param){
        if(_aspxIsFunction(param[key]))
            continue;
        if(exceptKeys[key] == 1)
            continue;
        values.push(_aspxToJson(key) + ":" + _aspxToJson(param[key]));
    }
    return "{" + values.join(",") + "}";
}

function _aspxDateToJson(date) {
    var result = [ 
        date.getFullYear(),
        date.getMonth(),
        date.getDate()
    ];
    var time = {
        h: date.getHours(),
        m: date.getMinutes(),
        s: date.getSeconds(),
        ms: date.getMilliseconds()
    };
    if(time.h || time.m || time.s || time.ms)
        result.push(time.h);
    if(time.m || time.s || time.ms)
        result.push(time.m);
    if(time.s || time.ms)
        result.push(time.s);
    if(time.ms)
        result.push(time.ms);
    return "new Date(" + result.join() + ")";
}

// Method doesn't work in WebKit browsers
function _aspxEmulateDocumentOnMouseDown(evt) {
    _aspxEmulateOnMouseDown(document, evt);
}
function _aspxEmulateOnMouseDown(element, evt) {
    if(__aspxIE && __aspxBrowserVersion < 9)
        element.fireEvent("onmousedown", evt);
    else if(!__aspxWebKitFamily){
        var emulatedEvt = document.createEvent("MouseEvents");
        emulatedEvt.initMouseEvent("mousedown", true, true, window, 0, evt.screenX, evt.screenY, 
            evt.clientX, evt.clientY, evt.ctrlKey, evt.altKey, evt.shiftKey, false, 0, null);
        element.dispatchEvent(emulatedEvt);
    }
}

function _aspxCreateHtmlElementFromString(str) {
    var dummy = document.createElement("DIV");
    dummy.innerHTML = str;
    return dummy.firstChild;
}

ASPxIFrame = _aspxCreateClass(null, {
    constructor: function(params) {
        this.params = params || {};
        this.params.src = this.params.src || "";
        this.CreateElements();
    },
    CreateElements: function() {
        var elements = ASPxIFrame.Create(this.params);
        this.containerElement = elements.container;
        this.iframeElement = elements.iframe;

        this.AttachOnLoadHandler(this, this.iframeElement);
        this.SetLoading(true);
        
        if(this.params.onCreate)
            this.params.onCreate(this.containerElement, this.iframeElement);
    },
    AttachOnLoadHandler: function(instance, element) {
        _aspxAttachEventToElement(element, "load", function() {
            instance.OnLoad(element);
        });
    },
    OnLoad: function(element) {
        this.SetLoading(false, element);
        if(!element.preventCustomOnLoad && this.params.onLoad)
            this.params.onLoad();
    },
    IsLoading: function(element) {
        element = element || this.iframeElement;
        if(element)
            return element.loading;
        return false;
    },
    SetLoading: function(value, element) {
        element = element || this.iframeElement;
        if(element)
            element.loading = value;
    },

    GetContentUrl: function() {
        return this.params.src;
    },
    SetContentUrl: function(url, preventBrowserCaching) {
        if(url) {
            this.params.src = url;
            if(preventBrowserCaching)
                url = ASPxIFrame.AddRandomParamToUrl(url);
            this.SetLoading(true);
            this.iframeElement.src = url;
        }
    },
    RefreshContentUrl: function() {
        if(this.IsLoading())
            return;
        this.SetLoading(true);

        var oldContainerElement = this.containerElement;
        var oldIframeElement = this.iframeElement;
        
        var postfix = "_del" + Math.floor(Math.random()*100000).toString();
        if(this.params.id)
            oldIframeElement.id = this.params.id + postfix;
        if(this.params.name)
            oldIframeElement.name = this.params.name + postfix;
        
        oldContainerElement.style.height = "0px";

        this.CreateElements();

        oldIframeElement.preventCustomOnLoad = true;
        oldIframeElement.src = ASPx.BlankUrl;
        window.setTimeout(function() {
            oldContainerElement.parentNode.removeChild(oldContainerElement);
        }, 10000); // This value has been chosen randomly. We hope that the new page will be loaded after the 10 seconds
    }
});
ASPxIFrame.Create = function(params) {
    var iframeHtmlStringParts = [ "<iframe frameborder='0'" ];
    if(params) {
        if(params.id)
            iframeHtmlStringParts.push(" id='", params.id, "'");
        if(params.name)
            iframeHtmlStringParts.push(" name='", params.name, "'");
        if(params.title)
            iframeHtmlStringParts.push(" title='", params.title, "'");
        if(params.scrolling)
            iframeHtmlStringParts.push(" scrolling='", params.scrolling, "'");
        if(params.src)
            iframeHtmlStringParts.push(" src='", params.src, "'");
    }
    iframeHtmlStringParts.push("></iframe>");
    
    var containerElement = _aspxCreateHtmlElementFromString("<div style='border-width: 0px; padding: 0px; margin: 0px'></div>");
    var iframeElement = _aspxCreateHtmlElementFromString(iframeHtmlStringParts.join(""));
    containerElement.appendChild(iframeElement);

    return {
        container: containerElement,
        iframe: iframeElement
    };
};
ASPxIFrame.AddRandomParamToUrl = function(url) {
    var prefix = url.indexOf("?") > -1
        ? "&"
        : "?";
    var param = prefix + Math.floor(Math.random()*100000).toString();
    
    var anchorIndex = url.indexOf("#");
    return anchorIndex == -1
        ? url + param
        : url.substr(0, anchorIndex) + param + url.substr(anchorIndex);
};
ASPxIFrame.GetWindow = function(name) {
    if(__aspxIE)
        return window.frames[name].window;
    else{
        var frameElement = document.getElementById(name);
        return (frameElement != null) ? frameElement.contentWindow : null;
    }
};
ASPxIFrame.GetDocument = function(name) {
    if(__aspxIE)
        return window.frames[name].document;
    else{
        var frameElement = document.getElementById(name);
        return (frameElement != null) ? frameElement.contentDocument : null;
    }
};
ASPxIFrame.GetDocumentBody = function(name) {
    var doc = ASPxIFrame.GetDocument(name);
    return (doc != null) ? doc.body : null;
};
ASPxIFrame.GetElement = function(name) {
    if(__aspxIE)
        return window.frames[name].window.frameElement;
    else
        return document.getElementById(name);
};

ASPxKbdHelper = _aspxCreateClass(null, {

    constructor: function(control) {
        this.control = control;
    },
    
    Init: function() {
        ASPxKbdHelper.GlobalInit();
        var element = this.GetFocusableElement();
        element.tabIndex = Math.max(element.tabIndex, 0);
        
        var instance = this;
        
        _aspxAttachEventToElement(element, "click", function(e) {
            instance.HandleClick(e);
        });        
        
        _aspxAttachEventToElement(element, "focus", function(e) {             
            if(!instance.CanFocus(e))
                return true;
            ASPxKbdHelper.active = instance;
        });
        
        _aspxAttachEventToElement(element, "blur", function() {
            delete ASPxKbdHelper.active;
        });          
    },

    GetFocusableElement: function() { return this.control.GetMainElement(); },
    
    CanFocus: function(e) {
        var tag = _aspxGetEventSource(e).tagName;
        if(tag == "A" || tag == "TEXTAREA" || tag == "INPUT" || tag == "SELECT")
            return false;    
        return true;
    },
    
    HandleClick: function(e) {
        if(!this.CanFocus(e))
            return;
        this.Focus();
    },
    Focus: function() {
        try {
            this.GetFocusableElement().focus();   
        } catch(e) {
        }
    },
    
    HandleKeyDown: function(e) { },    
    HandleKeyPress: function(e) { },    
    HandleKeyUp: function(e) { }
});


ASPxKbdHelper.GlobalInit = function() {
    if(ASPxKbdHelper.ready)
        return;
    _aspxAttachEventToDocument("keydown", ASPxKbdHelper.OnKeyDown);
    _aspxAttachEventToDocument("keypress", ASPxKbdHelper.OnKeyPress);
    _aspxAttachEventToDocument("keyup", ASPxKbdHelper.OnKeyUp);
    ASPxKbdHelper.ready = true;    
};

ASPxKbdHelper.swallowKey = false;
ASPxKbdHelper.accessKeys = { };

ASPxKbdHelper.ProcessKey = function(e, actionName) {
    if(!ASPxKbdHelper.active) 
        return;

    //B208466
    var ctl = ASPxKbdHelper.active.control;
    if(ctl !== aspxGetControlCollection().Get(ctl.name)) {
        delete ASPxKbdHelper.active;
        return;
    }

    if(!ASPxKbdHelper.swallowKey) 
        ASPxKbdHelper.swallowKey = ASPxKbdHelper.active[actionName](e);
    if(ASPxKbdHelper.swallowKey)
        _aspxPreventEvent(e);
};

ASPxKbdHelper.OnKeyDown = function(e) {
    ASPxKbdHelper.swallowKey = false;    
    if(e.ctrlKey && e.shiftKey && ASPxKbdHelper.TryAccessKey(_aspxGetKeyCode(e)))
        _aspxPreventEvent(e);        
    else    
        ASPxKbdHelper.ProcessKey(e, "HandleKeyDown"); 
};
ASPxKbdHelper.OnKeyPress = function(e) { ASPxKbdHelper.ProcessKey(e, "HandleKeyPress"); };
ASPxKbdHelper.OnKeyUp = function(e) { ASPxKbdHelper.ProcessKey(e, "HandleKeyUp"); };

ASPxKbdHelper.RegisterAccessKey = function(obj) {
    var key = obj.accessKey;
    if(!key) return;
    ASPxKbdHelper.accessKeys[key.toLowerCase()] = obj.name;
};
ASPxKbdHelper.TryAccessKey = function(code) {
    var name = ASPxKbdHelper.accessKeys[String.fromCharCode(code).toLowerCase()];
    if(!name) return false;
    var obj = aspxGetControlCollection().Get(name);
    if(!obj) return false;
    var el = obj.GetMainElement();
    if(!el) return false;
    el.focus();
    return true;
};

function _aspxDelayedFunctionCall(object, functionName) {
    var callTimerIdPropertyName = "delayed" + functionName + "CallTimerId";
    var additionalCallRequiredPropertyName = "delayed" + functionName + "AdditionalCallRequired";
    
    if(!object[callTimerIdPropertyName] || object[callTimerIdPropertyName] == -1) {
        var timeoutFunction = function() {
            object[functionName]();
            object[callTimerIdPropertyName] = _aspxClearTimer(object[callTimerIdPropertyName]);
            
            if(object[additionalCallRequiredPropertyName]) {
                object[additionalCallRequiredPropertyName] = false;
                object[callTimerIdPropertyName] = _aspxSetTimeout(timeoutFunction, 0);
            }
        };
        object[callTimerIdPropertyName] = _aspxSetTimeout(timeoutFunction, 0);
    }
    else
        object[additionalCallRequiredPropertyName] = true;
}

var __aspxFocusedElement = null;
function aspxOnElementFocused(evt) {
    evt = _aspxGetEvent(evt);
    if(evt && evt.target)
        __aspxFocusedElement = evt.target;
}
function _aspxInitializeFocus() {
    if(!_aspxGetActiveElement())
        _aspxAttachEventToDocument("focus", aspxOnElementFocused);
}
function _aspxGetFocusedElement() {
    var activeElement = _aspxGetActiveElement();
    return activeElement ? activeElement : __aspxFocusedElement;
}

function _aspxChangeElementContainer(element, container, savePreviousContainer) {
    if(element.parentNode != container) {
        var parentNode = element.parentNode;
        parentNode.removeChild(element);
        container.appendChild(element);
        if(savePreviousContainer)
            element.previousContainer = parentNode;
    }
}
function _aspxRestoreElementContainer(element) {
    if(element.previousContainer) {
        _aspxChangeElementContainer(element, element.previousContainer, false);
        element.previousContainer = null;
    }
}

var ASPxCacheHelper = {};
ASPxCacheHelper.GetCachedValue = function(obj, cacheName, func, cacheObj) {
    if(!cacheObj)
        cacheObj = obj;
    if(!cacheObj.cache)
        cacheObj.cache = {};
    if(!_aspxIsExists(cacheObj.cache[cacheName]))
        cacheObj.cache[cacheName] = func.apply(obj, []);
    return cacheObj.cache[cacheName];
};
ASPxCacheHelper.DropCachedValue = function(cacheObj, cacheName) {
    cacheObj.cache[cacheName] = null;
};  

ASPxClientTemporaryCache = _aspxCreateClass(null, {
    constructor: function() { 
        this.cache = { };
        this.invalidateTimerID = -1;
    },

    Get: function(key, getObjectFunc, context, args) {
        if(this.invalidateTimerID < 0) {
            this.invalidateTimerID = window.setTimeout(function() {
                this.Invalidate();
            }.aspxBind(this), 0);
        }

        if(!_aspxIsExists(this.cache[key])) {
            if(!_aspxIsExists(args))
                args = [ ];
            this.cache[key] = getObjectFunc.apply(context, args);
        }
        return this.cache[key];
    },

    Invalidate: function() {
        this.cache = { };
        this.invalidateTimerID = _aspxClearTimer(this.invalidateTimerID);
    }
});

// CheckBox
ASPxClientCheckBoxCheckState = {
    Checked : "Checked",
    Unchecked : "Unchecked",
    Indeterminate : "Indeterminate"
};

ASPxClientCheckBoxInputKey = { 
    Checked : "C",
    Unchecked : "U",
    Indeterminate : "I"
};

ASPxCheckableElementStateController = _aspxCreateClass(null, {
    constructor: function(imageProperties) {
        this.checkBoxStates = [];
        this.imageProperties = imageProperties;
    },
    
    GetValueByInputKey: function(inputKey) {
        return this.GetFirstValueBySecondValue("Value", "StateInputKey", inputKey);
    },
    GetInputKeyByValue: function(value) {
        return this.GetFirstValueBySecondValue("StateInputKey", "Value", value);
    },
    GetImagePropertiesNumByInputKey: function(value) {
        return this.GetFirstValueBySecondValue("ImagePropertiesNumber", "StateInputKey", value);
    },
    GetNextCheckBoxValue: function(currentValue, allowGrayed) {
        var currentInputKey = this.GetInputKeyByValue(currentValue);
        var nextInputKey = '';
        
        switch(currentInputKey) {
            case ASPxClientCheckBoxInputKey.Checked:
                nextInputKey = ASPxClientCheckBoxInputKey.Unchecked; break;
            case ASPxClientCheckBoxInputKey.Unchecked:
                nextInputKey = allowGrayed ? ASPxClientCheckBoxInputKey.Indeterminate : ASPxClientCheckBoxInputKey.Checked; break;
            case ASPxClientCheckBoxInputKey.Indeterminate:
                nextInputKey = ASPxClientCheckBoxInputKey.Checked; break;
        }
        return this.GetValueByInputKey(nextInputKey);
    },
    GetCheckStateByInputKey: function(inputKey) {
        switch(inputKey) {
            case ASPxClientCheckBoxInputKey.Checked: 
                return ASPxClientCheckBoxCheckState.Checked;
            case ASPxClientCheckBoxInputKey.Unchecked: 
                return ASPxClientCheckBoxCheckState.Unchecked;
            case ASPxClientCheckBoxInputKey.Indeterminate: 
                return ASPxClientCheckBoxCheckState.Indeterminate;
        }
    },
    GetValueByCheckState: function(checkState) {
        switch(checkState) {
            case ASPxClientCheckBoxCheckState.Checked: 
                return this.GetValueByInputKey(ASPxClientCheckBoxInputKey.Checked);
            case ASPxClientCheckBoxCheckState.Unchecked: 
                return this.GetValueByInputKey(ASPxClientCheckBoxInputKey.Unchecked);
            case ASPxClientCheckBoxCheckState.Indeterminate: 
                return this.GetValueByInputKey(ASPxClientCheckBoxInputKey.Indeterminate);
        }
    },
    GetFirstValueBySecondValue: function(firstValueName, secondValueName, secondValue) {
        return this.GetValueByFunc(firstValueName, 
            function(checkBoxState) { return checkBoxState[secondValueName] === secondValue; });
    },
    GetValueByFunc: function(valueName, func) {
        for(var i = 0; i < this.checkBoxStates.length; i++) {
            if(func(this.checkBoxStates[i]))
                return this.checkBoxStates[i][valueName];
        }        
    },
    AssignElementClassName: function(element, cssClassPropertyKey, disabledCssClassPropertyKey, assignedClassName) {
	    var classNames = [ ];
	    for(var i = 0; i < this.imageProperties[cssClassPropertyKey].length; i++) {
		    classNames.push(this.imageProperties[disabledCssClassPropertyKey][i]);
		    classNames.push(this.imageProperties[cssClassPropertyKey][i]);
	    }
	    var elementClassName = element.className;
	    for(var i = 0; i < classNames.length; i++) {
		    var className = classNames[i];
		    var index = elementClassName.indexOf(className);
		    if(index > -1)
			    elementClassName = elementClassName.replace((index == 0 ? '' : ' ') + className, "");
	    }
	    elementClassName += " " + assignedClassName;
	    element.className = elementClassName;
    },

    UpdateInternalCheckBoxDecoration: function(mainElement, inputKey, enabled) {
        var imagePropertiesNumber = this.GetImagePropertiesNumByInputKey(inputKey);
        for (var imagePropertyKey in this.imageProperties) {
            var propertyValue = this.imageProperties[imagePropertyKey][imagePropertiesNumber];
            propertyValue = propertyValue ? propertyValue : "";
            switch(imagePropertyKey) {
                case "0" : mainElement.title = propertyValue; break;
                case "1" : mainElement.style.width = propertyValue + (propertyValue != "" ? "px" : ""); break;
                case "2" : mainElement.style.height = propertyValue + (propertyValue != "" ? "px" : ""); break;
            }
            if(enabled) {
                switch(imagePropertyKey) {
                    case "3" : this.SetImageSrc(mainElement, propertyValue); break;
                    case "4" : 
                        this.AssignElementClassName(mainElement, "4", "8", propertyValue);
                        break;
                    case "5" : this.SetBackgroundPosition(mainElement, propertyValue, true); break;
                    case "6" : this.SetBackgroundPosition(mainElement, propertyValue, false); break;
                }
            } else {
                    switch(imagePropertyKey) {
                    case "7" : this.SetImageSrc(mainElement, propertyValue); break;
                    case "8" : 
                        this.AssignElementClassName(mainElement, "4", "8", propertyValue);
                        break;
                    case "9" : this.SetBackgroundPosition(mainElement, propertyValue, true); break;
                    case "10" : this.SetBackgroundPosition(mainElement, propertyValue, false); break;
                }
            }
        }
    },
	SetImageSrc: function(mainElement, src) {
		mainElement.style.backgroundImage = "url(" + src + ")";
		this.SetBackgroundPosition(mainElement, 0, 0);
	},
    SetBackgroundPosition: function(element, value, isX) {
        if(value == "") {
            element.style.backgroundPosition = value;
            return;
        }
        if(element.style.backgroundPosition === "")
            element.style.backgroundPosition = isX ? "-" + value.toString() + "px 0px" : "0px -" + value.toString() + "px";
        else {
            var position = element.style.backgroundPosition.split(' ');
            element.style.backgroundPosition = isX ? '-' + value.toString() + "px " + position[1] :  position[0] + " -" + value.toString() + "px";
        }
    },
   
    AddState: function(value, stateInputKey, imagePropertiesNumber) {
        this.checkBoxStates.push({
            "Value" : value, 
            "StateInputKey" : stateInputKey, 
            "ImagePropertiesNumber" : imagePropertiesNumber
        });
    }
});

ASPxCheckableElementStateController.Create = function(imageProperties, valueChecked, valueUnchecked, valueGrayed, allowGrayed) {
    var stateController = new ASPxCheckableElementStateController(imageProperties);
    stateController.AddState(valueChecked, ASPxClientCheckBoxInputKey.Checked, 0);
    stateController.AddState(valueUnchecked, ASPxClientCheckBoxInputKey.Unchecked, 1);
    if(typeof(valueGrayed) != "undefined")
        stateController.AddState(valueGrayed, ASPxClientCheckBoxInputKey.Indeterminate, allowGrayed ? 2 : 1);
    stateController.allowGrayed = allowGrayed;
    return stateController;
};

ASPxCheckableElementHelper = _aspxCreateClass(null, {
    InternalCheckBoxInitialize: function(internalCheckBox) {
        this.AttachToMainElement(internalCheckBox);
        this.AttachToInputElement(internalCheckBox);
    },
    AttachToMainElement: function(internalCheckBox) {
        var instance = this;
        if(internalCheckBox.mainElement) {
             _aspxAttachEventToElement(internalCheckBox.mainElement, "click",
                function (evt) { 
                    instance.InvokeClick(internalCheckBox, evt);
                    if(!internalCheckBox.disableCancelBubble)
                        return _aspxPreventEventAndBubble(evt);
                }
            );
            _aspxAttachEventToElement(internalCheckBox.mainElement, "mousedown",
                function (evt) {
                    internalCheckBox.Refocus();
                }
            );
            _aspxPreventElementDragAndSelect(internalCheckBox.mainElement, true);
        }
    },
    AttachToInputElement: function(internalCheckBox) {
        var instance = this;
        if(internalCheckBox.inputElement && internalCheckBox.mainElement) {
            _aspxAttachEventToElement(internalCheckBox.inputElement, "focus",
                function (evt) { 
                    if(!internalCheckBox.enabled)
                        internalCheckBox.inputElement.blur();
                    else
                        internalCheckBox.OnFocus();
                }
            );
            _aspxAttachEventToElement(internalCheckBox.inputElement, "blur", 
                function (evt) { 
                    internalCheckBox.OnLostFocus();
                }
            );
            _aspxAttachEventToElement(internalCheckBox.inputElement, "keyup",
                function (evt) { 
                    if(_aspxGetKeyCode(evt) == ASPxKey.Space)
                        instance.InvokeClick(internalCheckBox, evt);
                }
            );
            _aspxAttachEventToElement(internalCheckBox.inputElement, "keydown",
                function (evt) { 
                    if(_aspxGetKeyCode(evt) == ASPxKey.Space)
                        return _aspxPreventEvent(evt);
                }
            );
        }
    },
    IsKBSInputWrapperExist: function() {
        return __aspxOpera || __aspxWebKitFamily;
    },
    GetICBMainElementByInput: function(icbInputElement) {
        return this.IsKBSInputWrapperExist() ? icbInputElement.parentNode.parentNode : icbInputElement.parentNode;
    },
    InvokeClick: function(internalCheckBox, evt) {
         if(internalCheckBox.enabled && !internalCheckBox.readOnly) {
            var inputElementValue = internalCheckBox.inputElement.value; 
            internalCheckBox.inputElement.focus();
            if(!__aspxIE) // Q413117
                internalCheckBox.inputElement.value = inputElementValue;             
            this.InvokeClickCore(internalCheckBox, evt)
         }
    },
    InvokeClickCore: function(internalCheckBox, evt) {
        internalCheckBox.OnClick(evt);
    }
});

ASPxCheckableElementHelper.Instance = new ASPxCheckableElementHelper();

ASPxClientCheckBoxInternal = _aspxCreateClass(null, {
    constructor: function(inputElement, stateController, allowGrayed, allowGrayedByClick, helper, container, storeValueInInput, key, disableCancelBubble) {
        this.inputElement = inputElement;
        this.mainElement = helper.GetICBMainElementByInput(this.inputElement);
        this.name = (key ? key : this.inputElement.id) + ASPxClientCheckBoxInternal.GetICBMainElementPostfix();
        this.mainElement.id = this.name;
        this.stateController = stateController;
        this.container = container;

        this.allowGrayed = allowGrayed;
        this.allowGrayedByClick = allowGrayedByClick;
        this.autoSwitchEnabled = true;

        this.storeValueInInput = !!storeValueInInput;
        this.storedInputKey = !this.storeValueInInput ? this.inputElement.value : null;
        this.disableCancelBubble = !!disableCancelBubble;
        
		this.focusDecoration = null;
        this.focused = false;
        this.focusLocked = false;

        this.enabled = true;
        this.readOnly = false;
        
        this.CheckedChanged = new ASPxClientEvent();
        this.Focus = new ASPxClientEvent();
        this.LostFocus = new ASPxClientEvent();
        
        helper.InternalCheckBoxInitialize(this);
    },
    ChangeInputElementTabIndex: function() {        
        var changeMethod = this.enabled ? _aspxRestoreTabIndexAttribute : _aspxSaveTabIndexAttributeAndReset;
        changeMethod(this.inputElement);
    },
	CreateFocusDecoration: function(focusedStyle) {
		 this.focusDecoration = new ASPxClientEditStyleDecoration(this);
         this.focusDecoration.AddStyle('F', focusedStyle[0], focusedStyle[1]);
         this.focusDecoration.AddPostfix("");
	},
    UpdateFocusDecoration: function() {
    	this.focusDecoration.Update();
    },        
    StoreInputKey: function(inputKey) {
        if(this.storeValueInInput)
            this.inputElement.value = inputKey;
        else
            this.storedInputKey = inputKey;
    },
    GetStoredInputKey: function() {
        if(this.storeValueInInput)
            return this.inputElement.value;
        else
            return this.storedInputKey;
    },
    OnClick: function(e) {
        if(this.autoSwitchEnabled) {
            var currentValue = this.GetValue();
            var value = this.stateController.GetNextCheckBoxValue(currentValue, this.allowGrayedByClick && this.allowGrayed);
            this.SetValue(value);
        }
        this.CheckedChanged.FireEvent(this, e);
    },
    OnFocus: function() {
        if(!this.IsFocusLocked()) {
            this.focused = true;
            this.UpdateFocusDecoration();
            this.Focus.FireEvent(this, null);
        } else
            this.UnlockFocus();
    },
    OnLostFocus: function() {
         if(!this.IsFocusLocked()) {
            this.focused = false;
            this.UpdateFocusDecoration();
            this.LostFocus.FireEvent(this, null);
        }
    },
    Refocus: function() {
        if(this.focused) {
            this.LockFocus();
            this.inputElement.blur();
            _aspxSetFocus(this.inputElement);
        }
    },
    LockFocus: function() {
        this.focusLocked = true;
    },
    UnlockFocus: function() {
        this.focusLocked = false;
    },
    IsFocusLocked: function() {
        return this.focusLocked;
    },
    SetValue: function(value) {
        var currentValue = this.GetValue();
        if(currentValue !== value) {
            var newInputKey = this.stateController.GetInputKeyByValue(value);
            if(newInputKey) {
                this.StoreInputKey(newInputKey);            
                this.stateController.UpdateInternalCheckBoxDecoration(this.mainElement, newInputKey, this.enabled);
            }
        }
    },
    GetValue: function() {
        return this.stateController.GetValueByInputKey(this.GetCurrentInputKey());
    },
    GetCurrentCheckState: function() {
        return this.stateController.GetCheckStateByInputKey(this.GetCurrentInputKey());
    },
    GetCurrentInputKey: function() {
        return this.GetStoredInputKey();
    },
    GetChecked: function() {
        return this.GetCurrentInputKey() === ASPxClientCheckBoxInputKey.Checked;
    },
    SetChecked: function(checked) {
        var newValue = this.stateController.GetValueByCheckState(checked ? ASPxClientCheckBoxCheckState.Checked : ASPxClientCheckBoxCheckState.Unchecked);
        this.SetValue(newValue);
    },
    SetEnabled: function(enabled) {
        if(this.enabled != enabled) {
            this.enabled = enabled;
            this.stateController.UpdateInternalCheckBoxDecoration(this.mainElement, this.GetCurrentInputKey(), this.enabled);
            this.ChangeInputElementTabIndex();
        }
    }
});

ASPxClientCheckBoxInternal.GetICBMainElementPostfix = function() {
    return "_D";
};

ASPxCheckBoxInternalCollection = _aspxCreateClass(null, {
    constructor: function(imageProperties, allowGrayed, storeValueInInput, helper, disableCancelBubble) {
        this.checkBoxes = {};
        this.stateController = allowGrayed 
            ? ASPxCheckableElementStateController.Create(imageProperties, ASPxClientCheckBoxInputKey.Checked, ASPxClientCheckBoxInputKey.Unchecked, ASPxClientCheckBoxInputKey.Indeterminate, true)
            : ASPxCheckableElementStateController.Create(imageProperties, ASPxClientCheckBoxInputKey.Checked, ASPxClientCheckBoxInputKey.Unchecked);

        this.helper = helper || ASPxCheckableElementHelper.Instance;
        this.storeValueInInput = !!storeValueInInput;
        this.disableCancelBubble = !!disableCancelBubble;
    },
    Add: function(key, inputElement, container) {
        this.Remove(key);
        this.checkBoxes[key] = this.CreateInternalCheckBox(key, inputElement, container);
        return this.checkBoxes[key];
    },
    Clear: function(){
        this.checkBoxes = {};
    },
    Remove: function(key) {
        delete this.checkBoxes[key];
    },
    Get: function(id) {
        return this.checkBoxes[id];
    },
    SetImageProperties: function(imageProperties) {
        this.stateController.imageProperties = imageProperties;
    },
    CreateInternalCheckBox: function(key, inputElement, container) {
        return new ASPxClientCheckBoxInternal(inputElement, this.stateController, this.stateController.allowGrayed, false, this.helper, container, this.storeValueInInput, key, this.disableCancelBubble);
    }
});

ASPxClientEditStyleDecoration = _aspxCreateClass(null, {
	constructor: function(editor) {
		this.editor = editor;
		this.postfixList = [ ];
		this.styles = { };
		this.innerStyles = { };
	},
	
	GetStyleSheet: function() {
		if(!ASPxClientEditStyleDecoration.__sheet)
			ASPxClientEditStyleDecoration.__sheet = _aspxCreateStyleSheet();
		return ASPxClientEditStyleDecoration.__sheet;
	},
	
	AddPostfix: function(value, applyClass, applyBorders, applyBackground) {
		this.postfixList.push(value);
	},
	
	AddStyle: function(key, className, cssText) {
		this.styles[key] = this.CreateRule(className, cssText);
		this.innerStyles[key] = this.CreateRule("", this.FilterInnerCss(cssText));
	},
	
	CreateRule: function(className, cssText) {
	    return _aspxTrim(className + " " + _aspxCreateImportantStyleRule(this.GetStyleSheet(), cssText));
	},
	
	Update: function() {
		for(var i = 0; i < this.postfixList.length; i++) {
			var postfix = this.postfixList[i];
			var inner = postfix.length > 0;
			var element = _aspxGetElementById(this.editor.name + postfix);
			if(!element) continue;

            // Invalid Style
            if(this.HasDecoration("I")) {
			    var isValid = this.editor.GetIsValid();
			    this.ApplyDecoration("I", element, inner, !isValid);
			}

			// Focused Style
			if(this.HasDecoration("F"))
				this.ApplyDecoration("F", element, inner, this.editor.focused);
 
            // Null Text Style
			if(this.HasDecoration("N")) {
				var apply = !this.editor.focused;
				if(apply) {
					var value = this.editor.GetValue();
					apply = apply && (value == null || value === "");
				}				
				this.ApplyDecoration("N", element, inner, apply);
			}
		}
	},

	HasDecoration: function(key) {
		return !!this.styles[key];
	},
	
	ApplyDecoration: function(key, element, inner, active) {
		var value = inner ? this.innerStyles[key] : this.styles[key];
		element.className = element.className.replace(value, "");
		if(active)
			element.className = _aspxTrim(element.className + " " + value);
	},
	
	FilterInnerCss: function(css) {
	    return css.replace(/(border|background-image)[^:]*:[^;]+/gi, "");
	}
});

var ASPxClientTouchUI = {
    isGesture: false,
    isMouseEventFromScrolling: false,
    isNativeScrollingAllowed: true,
    clickSensetivity: 10,
    documentTouchHandlers: {},
    documentEventAttachingAllowed: true,

    touchMouseDownEventName: __aspxTouchUI ? "touchstart" : "mousedown",
    touchMouseUpEventName:   __aspxTouchUI ? "touchend"   : "mouseup",
    touchMouseMoveEventName: __aspxTouchUI ? "touchmove"  : "mousemove",

    isTouchEvent: function(evt) { 
        return __aspxTouchUI && _aspxIsExists(evt.changedTouches); 
    },
    isTouchEventName: function(eventName) {
        return __aspxTouchUI && (eventName.indexOf("touch") > -1 || eventName.indexOf("gesture") > -1);
    },
    getEventX: function(evt) { 
        return evt.changedTouches[0].pageX; 
    },
    getEventY: function (evt) { 
        return evt.changedTouches[0].pageY; 
    },
    getWebkitMajorVersion: function(){
        if(!this.webkitMajorVersion){
            var regExp = new RegExp("applewebkit/(\\d+)", "i");
            var matches = regExp.exec(__aspxUserAgent);
            if(matches && matches.index >= 1)
                this.webkitMajorVersion = matches[1];
        }
        return this.webkitMajorVersion;
    },
    getIsLandscapeOrientation: function(){
        if(__aspxMacOSMobilePlatform)
            return Math.abs(window.orientation) == 90;
        return screen.width > screen.height
    },
    nativeScrollingSupported: function(){
        return __aspxMacOSMobilePlatform && (__aspxBrowserVersion >= 5.1 || this.getWebkitMajorVersion() > 533);
    },
    makeScrollableIfRequired: function(element, options) {
        if(__aspxTouchUI && element) {
            var overflow = _aspxGetCurrentStyle(element).overflow;
            if (element.tagName == "DIV" &&  overflow != "hidden" && overflow != "visible" ){
                return this.MakeScrollable(element);
            }
        }
    },
    preventScrollOnEvent: function(evt){
    },

    ensureDocumentSizesCorrect: function (){
        return (document.documentElement.clientWidth - document.documentElement.clientHeight) / (screen.width - screen.height) > 0;
    },
    ensureOrientationChanged: function(onOrientationChangedFunction){
        if(ASPxClientUtils.iOSPlatform || this.ensureDocumentSizesCorrect())
            onOrientationChangedFunction();
        else {
            window.setTimeout(function(){
                this.ensureOrientationChanged(onOrientationChangedFunction);
            }.aspxBind(this), 100);
        }
    },

    onEventAttachingToDocument: function(eventName, func){
        if(__aspxMacOSMobilePlatform && this.isTouchEventName(eventName)) {
            if(!this.documentTouchHandlers[eventName])
                this.documentTouchHandlers[eventName] = [];
            this.documentTouchHandlers[eventName].push(func);
			return this.documentEventAttachingAllowed;
        }
        return true;
    },
    onEventDettachedFromDocument: function(eventName, func){
        if(__aspxMacOSMobilePlatform && this.isTouchEventName(eventName)) {
            var handlers = this.documentTouchHandlers[eventName];
            if(handlers)
                _aspxArrayRemove(handlers, func);
        }
    },
    processDocumentTouchEventHandlers: function(proc) {
        var touchEventNames = ["touchstart", "touchend", "touchmove", "gesturestart", "gestureend"];
        for (var i = 0; i < touchEventNames.length; i++) {
            var eventName = touchEventNames[i];
            var handlers = this.documentTouchHandlers[eventName];
            if(handlers) {
                for (var j = 0; j < handlers.length; j++) {
                    proc(eventName,handlers[j]);
                }
            }
        }
    },
    removeDocumentTouchEventHandlers: function() {
        if(__aspxMacOSMobilePlatform) {
            this.documentEventAttachingAllowed = false;
            this.processDocumentTouchEventHandlers(_aspxDetachEventFromDocumentCore);
        }
    },
    restoreDocumentTouchEventHandlers: function () {
        if(__aspxMacOSMobilePlatform) {
            this.documentEventAttachingAllowed = true;
            this.processDocumentTouchEventHandlers(_aspxAttachEventToDocumentCore);
        }
    },
    IsNativeScrolling: function() {
        return ASPxClientTouchUI.nativeScrollingSupported() && ASPxClientTouchUI.isNativeScrollingAllowed;
    }
};

Function.prototype.aspxBind = function(scope) {
    var func = this;

    return function() {
        return func.apply(scope, arguments);
    };
};
var ASPxAnimationHelper = {
    TIMER_INTERVAL: 10,
    EPSILON: 0.01,

    initAnimationInfo: function (element, maxDuration, endOpacityValue, callback) {
        element.aspxAnimationInfo = {
            iterationCount: 0,
            increment: 0,
            maxDuration: maxDuration,
            animationStartTime: new Date(),
            endOpacity: endOpacityValue,
            callback: callback
        };
    },

    clearAnimationInfo: function(element) {
        if(element.aspxAnimationInfo)
            element.aspxAnimationInfo = null;
    },

    completeAnimation: function (element) {
        if (element.aspxAnimationInfo) {        
            var callback = element.aspxAnimationInfo.callback;
            ASPxAnimationHelper.clearAnimationInfo(element);
            if (callback)
                callback(element);
        }
    },

    updateAnimationInfo: function (element) {
        element.aspxAnimationInfo.iterationCount++;
        element.aspxAnimationInfo.increment = element.aspxAnimationInfo.iterationCount / element.aspxAnimationInfo.maxDuration;
    },

    isFinished: function (element, opacity) {
        return ((new Date() - element.aspxAnimationInfo.animationStartTime) > element.aspxAnimationInfo.maxDuration) || 
            element.aspxAnimationInfo.endOpacity === opacity;
    },
    
    setOpacity: function (element, value) {
        if (__aspxIE && __aspxBrowserVersion < 8) 
            element.style.zoom = 1;
        _aspxSetElementOpacity(element, value);
    },
    
    increaseOpacity: function (element) {
        if(!element.aspxAnimationInfo)
            return;
        var opacity = _aspxGetElementOpacity(element);
        ASPxAnimationHelper.updateAnimationInfo(element);
        opacity += element.aspxAnimationInfo.increment;
        if (opacity >= 1)
            opacity = 1;
        ASPxAnimationHelper.setOpacity(element, opacity);

        if(ASPxAnimationHelper.isFinished(element, opacity)) {
            ASPxAnimationHelper.setOpacity(element, 1);
            ASPxAnimationHelper.completeAnimation(element);
            return;
        }
            
        window.setTimeout(function () { 
            ASPxAnimationHelper.increaseOpacity(element); 
        }, ASPxAnimationHelper.TIMER_INTERVAL);
    },

    decreaseOpacity: function (element) {
        if(!element.aspxAnimationInfo)
            return;
        var opacity = _aspxGetElementOpacity(element);
        ASPxAnimationHelper.updateAnimationInfo(element);
        opacity -= element.aspxAnimationInfo.increment;
        if (opacity <= ASPxAnimationHelper.EPSILON)
            opacity = 0;
        ASPxAnimationHelper.setOpacity(element, opacity);

        if(ASPxAnimationHelper.isFinished(element, opacity)) {
            ASPxAnimationHelper.setOpacity(element, 0);
            ASPxAnimationHelper.completeAnimation(element);
            return;
        }
            
        window.setTimeout(function () { 
            ASPxAnimationHelper.decreaseOpacity(element); 
        }, ASPxAnimationHelper.TIMER_INTERVAL);
    },

    fadeIn: function (element, maxDuration, callback) {
        ASPxAnimationHelper.initAnimationInfo(element, maxDuration, 1, callback);
        ASPxAnimationHelper.setOpacity(element, 0);
        ASPxAnimationHelper.increaseOpacity(element);
    },

    fadeOut: function (element, maxDuration, callback) {
        ASPxAnimationHelper.initAnimationInfo(element, maxDuration, 0, callback);
        ASPxAnimationHelper.setOpacity(element, 1);
        ASPxAnimationHelper.decreaseOpacity(element);
    }
};

/*# public class ASPxClientUtils : JavaScriptObject #*/
ASPxClientUtils = {};
/*# public static string agent{ get{ return ""; } } #*/
ASPxClientUtils.agent = __aspxUserAgent;
/*# public static bool opera{ get{ return false; } } #*/
ASPxClientUtils.opera = __aspxOpera;
/*# [Obsolete("This property is now obsolete. Use the ASPxClientUtils.opera and ASPxClientUtils.browserMajorVersion properties instead.")] public static bool opera9 { get { return false; } } #*/
ASPxClientUtils.opera9 = __aspxOpera && __aspxBrowserMajorVersion == 9;
/*# public static bool safari{ get{ return false; } } #*/
ASPxClientUtils.safari = __aspxSafari;
/*# [Obsolete("This property is now obsolete. Use the ASPxClientUtils.safari and ASPxClientUtils.browserMajorVersion properties instead.")] public static bool safari3 { get { return false; } } #*/
ASPxClientUtils.safari3 = __aspxSafari && __aspxBrowserMajorVersion == 3;
/*# [Obsolete("This property is now obsolete. Use the ASPxClientUtils.safari and ASPxClientUtils.macOSPlatform properties instead.")] public static bool safariMacOS{ get { return false; } } #*/
ASPxClientUtils.safariMacOS = __aspxSafari && __aspxMacOSPlatform;
/*# public static bool chrome { get { return false; } } #*/
ASPxClientUtils.chrome = __aspxChrome;
/*# public static bool ie{ get{ return false; } } #*/
ASPxClientUtils.ie = __aspxIE;
/*# [Obsolete("This property is now obsolete. Use the ASPxClientUtils.ie and ASPxClientUtils.browserVersion properties instead.")] public static bool ie55 { get { return false; } } #*/
ASPxClientUtils.ie55 = __aspxIE && __aspxBrowserVersion == 5.5;
/*# [Obsolete("This property is now obsolete. Use the ASPxClientUtils.ie and ASPxClientUtils.browserMajorVersion properties instead.")] public static bool ie7 { get { return false; } } #*/;
ASPxClientUtils.ie7 = __aspxIE && __aspxBrowserMajorVersion == 7;
/*# public static bool firefox{ get{ return false; } } #*/
ASPxClientUtils.firefox = __aspxFirefox;
/*# [Obsolete("This property is now obsolete. Use the ASPxClientUtils.firefox and ASPxClientUtils.browserMajorVersion properties instead.")] public static bool firefox3 { get { return false; } } #*/
ASPxClientUtils.firefox3 = __aspxFirefox && __aspxBrowserMajorVersion == 3;
/*# public static bool mozilla { get { return false; } } #*/
ASPxClientUtils.mozilla = __aspxMozilla;
/*# public static bool netscape{ get{ return false; } } #*/
ASPxClientUtils.netscape = __aspxNetscape;
/*# public static double browserVersion { get { return 0.0; } } #*/
ASPxClientUtils.browserVersion = __aspxBrowserVersion;
/*# public static int browserMajorVersion { get { return 0; } } #*/
ASPxClientUtils.browserMajorVersion = __aspxBrowserMajorVersion;
/*# public static bool macOSPlatform { get { return false; } } #*/
ASPxClientUtils.macOSPlatform = __aspxMacOSPlatform;
/*# public static bool windowsPlatform { get { return false; } } #*/
ASPxClientUtils.windowsPlatform = __aspxWindowsPlatform;
/*# public static bool webKitFamily { get { return false; } } #*/
ASPxClientUtils.webKitFamily = __aspxWebKitFamily;
/*# public static bool netscapeFamily { get { return false; } } #*/
ASPxClientUtils.netscapeFamily = __aspxNetscapeFamily;
/*# public static bool touchUI { get { return false; } } #*/
ASPxClientUtils.touchUI = __aspxTouchUI;
/*# public static bool iOSPlatform { get { return false; } } #*/
ASPxClientUtils.iOSPlatform = __aspxMacOSMobilePlatform;
/*# public static bool androidPlatform { get { return false; } } #*/
ASPxClientUtils.androidPlatform = __aspxAndroidMobilePlatform;


/*# public static void ArrayInsert(object[] array, object element){ } #*/
ASPxClientUtils.ArrayInsert = _aspxArrayInsert;
/*# public static void ArrayRemove(object[] array, object element){ } #*/
ASPxClientUtils.ArrayRemove = _aspxArrayRemove;
/*# public static void ArrayRemoveAt(object[] array, int index){ } #*/
ASPxClientUtils.ArrayRemoveAt = _aspxArrayRemoveAt;
/*# public static void ArrayClear(object[] array){ } #*/
ASPxClientUtils.ArrayClear = _aspxArrayClear;
/*# public static int ArrayIndexOf(object[] array, object element){ return 0; } #*/
ASPxClientUtils.ArrayIndexOf = _aspxArrayIndexOf;

/*# public static void AttachEventToElement(object element, string eventName, object method){ } #*/
ASPxClientUtils.AttachEventToElement = _aspxAttachEventToElement;
/*# public static void DetachEventFromElement(object element, string eventName, object method){ } #*/
ASPxClientUtils.DetachEventFromElement = _aspxDetachEventFromElement;

/*# public static object GetEventSource(object htmlEvent){ return null; } #*/
ASPxClientUtils.GetEventSource = _aspxGetEventSource;
/*# public static int GetEventX(object htmlEvent){ return 0; } #*/
ASPxClientUtils.GetEventX = _aspxGetEventX;
/*# public static int GetEventY(object htmlEvent){ return 0; } #*/
ASPxClientUtils.GetEventY = _aspxGetEventY;
/*# public static int GetKeyCode(object htmlEvent){ return 0; } #*/
ASPxClientUtils.GetKeyCode = _aspxGetKeyCode;

/*# public static bool PreventEvent(object htmlEvent){ return false; } #*/
ASPxClientUtils.PreventEvent = _aspxPreventEvent;
/*# public static bool PreventEventAndBubble(object htmlEvent){ return false; } #*/
ASPxClientUtils.PreventEventAndBubble = _aspxPreventEventAndBubble;
/*# public static bool PreventDragStart(object htmlEvent){ return false; } #*/
ASPxClientUtils.PreventDragStart = _aspxPreventDragStart;
/*# public static void ClearSelection(){ } #*/
ASPxClientUtils.ClearSelection = _aspxClearSelection;

/*# public static bool IsExists(object obj){ return false; } #*/
ASPxClientUtils.IsExists = _aspxIsExists;
/*# public static bool IsFunction(object obj){ return false; } #*/
ASPxClientUtils.IsFunction = _aspxIsFunction;

/*# public static int GetAbsoluteX(object element){ return 0; } #*/
ASPxClientUtils.GetAbsoluteX = _aspxGetAbsoluteX;
/*# public static int GetAbsoluteY(object element){ return 0; } #*/
ASPxClientUtils.GetAbsoluteY = _aspxGetAbsoluteY;
/*# public static void SetAbsoluteX(object element, int x){ } #*/
ASPxClientUtils.SetAbsoluteX = _aspxSetAbsoluteX;
/*# public static void SetAbsoluteY(object element, int y){ } #*/
ASPxClientUtils.SetAbsoluteY = _aspxSetAbsoluteY;

/*# public static int GetDocumentScrollTop(){ return 0; } #*/
ASPxClientUtils.GetDocumentScrollTop = _aspxGetDocumentScrollTop;
/*# public static int GetDocumentScrollLeft(){ return 0; } #*/
ASPxClientUtils.GetDocumentScrollLeft = _aspxGetDocumentScrollLeft;
/*# public static int GetDocumentClientWidth(){ return 0; } #*/
ASPxClientUtils.GetDocumentClientWidth = _aspxGetDocumentClientWidth;
/*# public static int GetDocumentClientHeight(){ return 0; } #*/
ASPxClientUtils.GetDocumentClientHeight = _aspxGetDocumentClientHeight;

/*# public static bool GetIsParent(object parentElement, object element){ return false; } #*/
ASPxClientUtils.GetIsParent = _aspxGetIsParent;
/*# public static object GetParentById(object element, string id){ return null; } #*/
ASPxClientUtils.GetParentById = _aspxGetParentById;
/*# public static object GetParentByTagName(object element, string tabName){ return null; } #*/
ASPxClientUtils.GetParentByTagName = _aspxGetParentByTagName;
/*# public static object GetParentByClassName(object element, string className){ return null; } #*/
ASPxClientUtils.GetParentByClassName = _aspxGetParentByPartialClassName;

/*# public static object GetChildById(object element, string id){ return null; } #*/
ASPxClientUtils.GetChildById = _aspxGetChildById;
/*# public static object GetChildByTagName(object element, string tagName, int index){ return null; } #*/
ASPxClientUtils.GetChildByTagName = _aspxGetChildByTagName;

/*# public static void SetCookie(string name, string value) { return; } #*/
/*# public static void SetCookie(string name, string value, DateTime expirationDate) { return; } #*/
ASPxClientUtils.SetCookie = _aspxSetCookie;
/*# public static string GetCookie(string name) { return ""; } #*/
ASPxClientUtils.GetCookie = _aspxGetCookie;
/*# public static void DeleteCookie(string name) { return; } #*/
ASPxClientUtils.DeleteCookie = _aspxDelCookie;

/*# public static int GetShortcutCode(int keyCode, bool isCtrlKey, bool isShiftKey, bool isAltKey) { return 0; } #*/
ASPxClientUtils.GetShortcutCode = _aspxGetShortcutCode; 
/*# public static int GetShortcutCodeByEvent(object htmlEvent) { return 0; } #*/
ASPxClientUtils.GetShortcutCodeByEvent = _aspxGetShortcutCodeByEvent;
/*# public static int StringToShortcutCode(string shortcutString) { return 0; } #*/
ASPxClientUtils.StringToShortcutCode = _aspxParseShortcutString;

/*# public static string Trim(string str) { return ""; } #*/
ASPxClientUtils.Trim = _aspxTrim; 
/*# public static string TrimStart(string str) { return ""; } #*/
ASPxClientUtils.TrimStart = _aspxTrimStart;
/*# public static string TrimEnd(string str) { return ""; } #*/
ASPxClientUtils.TrimEnd = _aspxTrimEnd;

__aspxClassesScriptParsed = true;
/* Don't write any code below this line!!! */

var __aspxStateItemsExist = false;
var __aspxFocusedItemKind = "FocusedStateItem";
var __aspxHoverItemKind = "HoverStateItem";
var __aspxPressedItemKind = "PressedStateItem";
var __aspxSelectedItemKind = "SelectedStateItem";
var __aspxDisabledItemKind = "DisabledStateItem";
var __aspxCachedStatePrefix = "cached";

ASPxStateItem = _aspxCreateClass(null, {
    constructor: function(name, classNames, cssTexts, postfixes, imageObjs, imagePostfixes, kind, disableApplyingStyleToLink){
        this.name = name;
        this.classNames = classNames;
        this.customClassNames = [];
        this.resultClassNames = [];
        this.cssTexts = cssTexts;
        this.postfixes = postfixes;
        this.imageObjs = imageObjs;
        this.imagePostfixes = imagePostfixes;
        this.kind = kind;
        this.classNamePostfix = kind.substr(0, 1).toLowerCase();
        this.enabled = true;
        this.needRefreshBetweenElements = false;
        
        this.elements = null;
        this.images = null;
        this.linkColor = null;
        this.lintTextDecoration = null;
        this.disableApplyingStyleToLink = !!disableApplyingStyleToLink;
    },
    
    GetCssText: function(index){
        if(_aspxIsExists(this.cssTexts[index]))
            return this.cssTexts[index];
        return this.cssTexts[0];
    },
    CreateStyleRule: function(index){
        if(this.GetCssText(index) == "") return "";
        
        var styleSheet = _aspxGetCurrentStyleSheet();
        if(styleSheet)
			return _aspxCreateImportantStyleRule(styleSheet, this.GetCssText(index), this.classNamePostfix);        
        return ""; 
    },
    GetClassName: function(index){
        if(_aspxIsExists(this.classNames[index]))
            return this.classNames[index];
        return this.classNames[0];
    },
    GetResultClassName: function(index){
        if(!_aspxIsExists(this.resultClassNames[index])) {
            if(!_aspxIsExists(this.customClassNames[index]))
                this.customClassNames[index] = this.CreateStyleRule(index);
                
            if(this.GetClassName(index) != "" && this.customClassNames[index] != "")
                this.resultClassNames[index] = this.GetClassName(index) + " " + this.customClassNames[index];
            else if(this.GetClassName(index) != "")
                this.resultClassNames[index] = this.GetClassName(index);
            else if(this.customClassNames[index] != "")
                this.resultClassNames[index] = this.customClassNames[index];
            else
                this.resultClassNames[index] = "";
        }
        return this.resultClassNames[index];
    },
    GetElements: function(element){
        if(!this.elements || !_aspxIsValidElements(this.elements)){
            if(this.postfixes && this.postfixes.length > 0){
                this.elements = [ ];
                var parentNode = element.parentNode;
                if(parentNode){
                    for(var i = 0; i < this.postfixes.length; i++){
                        var id = this.name + this.postfixes[i];
                        this.elements[i] = _aspxGetChildById(parentNode, id);
                        if(!this.elements[i])
                            this.elements[i] = _aspxGetElementById(id);
                    }
                }
            }
            else
                this.elements = [element];
        }
        return this.elements;
    },
    GetImages: function(element){
        if(!this.images || !_aspxIsValidElements(this.images)){
            this.images = [ ];
            if(this.imagePostfixes && this.imagePostfixes.length > 0){
                var elements = this.GetElements(element);
                for(var i = 0; i < this.imagePostfixes.length; i++){
                    var id = this.name + this.imagePostfixes[i];
                    for(var j = 0; j < elements.length; j++){
                        if(!elements[j]) continue;
                        
                        if(elements[j].id == id)
                            this.images[i] = elements[j];
                        else
                            this.images[i] = _aspxGetChildById(elements[j], id);
                        if(this.images[i])
                            break;
                    }
                }
            }
        }
        return this.images;
    },
    
    Apply: function(element){
        if(!this.enabled) return;
        try{
            this.ApplyStyle(element);
            if(this.imageObjs && this.imageObjs.length > 0)
                this.ApplyImage(element);
        }
        catch(e){
            // fix FF bug
        }
    },
    ApplyStyle: function(element){
        var elements = this.GetElements(element);
        for(var i = 0; i < elements.length; i++){
            if(!elements[i]) continue;

            var className = elements[i].className.replace(this.GetResultClassName(i), "");
            elements[i].className = _aspxTrim(className) + " " + this.GetResultClassName(i);
            if(!__aspxOpera || __aspxBrowserVersion >= 9)
                this.ApplyStyleToLinks(elements, i);
        }
    },
    ApplyStyleToLinks: function(elements, index){
        if(this.disableApplyingStyleToLink)
            return;
        var linkCount = 0;
        var savedLinkCount = -1;
        if(_aspxIsExists(elements[index]["savedLinkCount"]))
            savedLinkCount = parseInt(elements[index]["savedLinkCount"]);
        do{
            if(savedLinkCount > -1 && savedLinkCount <= linkCount)
                break;
            var link = elements[index]["link" + linkCount];
            if(!link){
                link = _aspxGetChildByTagName(elements[index], "A", linkCount);
                if(!link)
                    link = _aspxGetChildByTagName(elements[index], "SPAN", linkCount); // see InternalHyperLink
                if(link)
                    elements[index]["link" + linkCount] = link;
            }
            if(link)
                this.ApplyStyleToLinkElement(link, index);
            else
                elements[index]["savedLinkCount"] = linkCount;
            linkCount++;
        }
        while(link != null)
    },
    ApplyStyleToLinkElement: function(link, index){
        if(this.GetLinkColor(index) != "")
            _aspxChangeAttributeExtended(link.style, "color", link, "saved" + this.kind + "Color", this.GetLinkColor(index));
        if(this.GetLinkTextDecoration(index) != "")
            _aspxChangeAttributeExtended(link.style, "textDecoration", link, "saved" + this.kind + "TextDecoration", this.GetLinkTextDecoration(index));
    },
    ApplyImage: function(element){
        var images = this.GetImages(element);
        for(var i = 0; i < images.length; i++){
            if(!images[i] || !this.imageObjs[i]) continue;
            if(_aspxIsAlphaFilterUsed(images[i]))            
                _aspxChangeAttributeExtended(images[i].style, "filter", images[i], "saved" + this.kind + "Filter", 
                    "progid:DXImageTransform.Microsoft.AlphaImageLoader(src=" + this.imageObjs[i] + ", sizingMethod=scale)");                
            else{
                var useSpriteImage = typeof(this.imageObjs[i]) != "string";
                var newUrl = "", newCssClass = "", newBackground = "";
                if(useSpriteImage){
                    newUrl = ASPx.EmptyImageUrl;                                   
                    if(this.imageObjs[i].spriteCssClass) 
                        newCssClass = this.imageObjs[i].spriteCssClass;
                    if(this.imageObjs[i].spriteBackground)
                        newBackground = this.imageObjs[i].spriteBackground;
                }
                else{
                    newUrl = this.imageObjs[i];
                    if(_aspxIsExistsAttribute(images[i].style, "background"))   
                        newBackground = " ";
                }

                if(newUrl != "")
                    _aspxChangeAttributeExtended(images[i], "src", images[i], "saved" + this.kind + "Src", newUrl);
                if(newCssClass != "")
                    this.ApplyImageClassName(images[i], newCssClass);
                if(newBackground != ""){
                    if(__aspxWebKitFamily) {
                        // In WebKit browsers, "background" doesn't contain "backgroundPosition" on get
                        // On set you should set full "background" (which contains "backgroundPosition")
                        var savedBackground = _aspxGetAttribute(images[i].style, "background") + " " + images[i].style["backgroundPosition"];
                        _aspxSetAttribute(images[i], "saved" + this.kind + "Background", savedBackground);
                        _aspxSetAttribute(images[i].style, "background", newBackground);
                    }
                    else
                        _aspxChangeAttributeExtended(images[i].style, "background", images[i], "saved" + this.kind + "Background", newBackground);
                }                    
            }
        }
    },
    ApplyImageClassName: function(element, newClassName){
        var className = element.className.replace(newClassName, "");
        _aspxSetAttribute(element, "saved" + this.kind + "ClassName", className);
        element.className = className + " " + newClassName;
    },
    Cancel: function(element){
        if(!this.enabled) return;
        try{        
            if(this.imageObjs && this.imageObjs.length > 0)
                this.CancelImage(element);
            this.CancelStyle(element);
        }
        catch(e){
            // fix FF bug
        }
    },
    CancelStyle: function(element){
        var elements = this.GetElements(element);
        for(var i = 0; i < elements.length; i++){
            if(!elements[i]) continue;
            
            var className = _aspxTrim(elements[i].className.replace(this.GetResultClassName(i), ""));
            elements[i].className = className;
            if(!__aspxOpera || __aspxBrowserVersion >= 9)
                this.CancelStyleFromLinks(elements, i);
        }
    },
    CancelStyleFromLinks: function(elements, index){
        if(this.disableApplyingStyleToLink)
            return;
        var linkCount = 0;
        var savedLinkCount = -1;
        if(_aspxIsExists(elements[index]["savedLinkCount"]))
            savedLinkCount = parseInt(elements[index]["savedLinkCount"]);
        do{
            if(savedLinkCount > -1 && savedLinkCount <= linkCount)
                break;
            var link = elements[index]["link" + linkCount];
            if(!link){
                link = _aspxGetChildByTagName(elements[index], "A", linkCount);
                if(!link)
                    link = _aspxGetChildByTagName(elements[index], "SPAN", linkCount); // see InternalHyperLink
                if(link)
                    elements[index]["link" + linkCount] = link;
            }
            if(link)
                this.CancelStyleFromLinkElement(link, index);
            else
                elements[index]["savedLinkCount"] = linkCount;
            linkCount++;
        }
        while(link != null)
    },
    CancelStyleFromLinkElement: function(link, index){
        if(this.GetLinkColor(index) != "")
            _aspxRestoreAttributeExtended(link.style, "color", link, "saved" + this.kind + "Color");
        if(this.GetLinkTextDecoration(index) != "")
            _aspxRestoreAttributeExtended(link.style, "textDecoration", link, "saved" + this.kind + "TextDecoration");
    },
    CancelImage: function(element){
        var images = this.GetImages(element);
        for(var i = 0; i < images.length; i++){
            if(!images[i] || !this.imageObjs[i]) continue;
            if(_aspxIsAlphaFilterUsed(images[i]))
                _aspxRestoreAttributeExtended(images[i].style, "filter", images[i], "saved" + this.kind + "Filter");
            else{
                _aspxRestoreAttributeExtended(images[i], "src", images[i], "saved" + this.kind + "Src");
                this.CancelImageClassName(images[i]);
                _aspxRestoreAttributeExtended(images[i].style, "background", images[i], "saved" + this.kind + "Background");
            }
        }
    },
    CancelImageClassName: function(element){
        var savedClassName = _aspxGetAttribute(element, "saved" + this.kind + "ClassName");
        if(_aspxIsExists(savedClassName)) {
            element.className = savedClassName;
            _aspxRemoveAttribute(element, "saved" + this.kind + "ClassName");
        }
    },
    Clone: function(){
        return new ASPxStateItem(this.name, this.classNames, this.cssTexts, this.postfixes, 
            this.imageObjs, this.imagePostfixes, this.kind, this.disableApplyingStyleToLink);
    },
    IsChildElement: function(element){
        if(element != null){
            var elements = this.GetElements(element);
            for(var i = 0; i < elements.length; i++){
                if(!elements[i]) continue;
                if(_aspxGetIsParent(elements[i], element)) 
                    return true;
            }
        }
        return false;
    },
    
    GetLinkColor: function(index){
        if(!_aspxIsExists(this.linkColor)){
            var rule = _aspxGetStyleSheetRule(this.customClassNames[index]);
            this.linkColor = rule ? rule.style.color : null;
            if(!_aspxIsExists(this.linkColor)){
                var rule = _aspxGetStyleSheetRule(this.GetClassName(index));
                this.linkColor = rule ? rule.style.color : null;
            }
            if(this.linkColor == null) 
                this.linkColor = "";
        }
        return this.linkColor;
    },
    GetLinkTextDecoration: function(index){
        if(!_aspxIsExists(this.linkTextDecoration)){
            var rule = _aspxGetStyleSheetRule(this.customClassNames[index]);
            this.linkTextDecoration = rule ? rule.style.textDecoration : null;
            if(!_aspxIsExists(this.linkTextDecoration)){
                var rule = _aspxGetStyleSheetRule(this.GetClassName(index));
                this.linkTextDecoration = rule ? rule.style.textDecoration : null;
            }
            if(this.linkTextDecoration == null) 
                this.linkTextDecoration = "";
        }
        return this.linkTextDecoration;
    }
});

ASPxClientStateEventArgs = _aspxCreateClass(null, {
    constructor: function(item, element){
        this.item = item;
        this.element = element;
        this.toElement = null;
        this.fromElement = null;
        this.htmlEvent = null;
    }
});

ASPxStateController = _aspxCreateClass(null, {
    constructor: function(){
        this.focusedItems = { };
        this.hoverItems = { };
        this.pressedItems = { };
        this.selectedItems = { };
        this.disabledItems = { };
        
        this.currentFocusedElement = null;
        this.currentFocusedItemName = null;
        this.currentHoverElement = null;
        this.currentHoverItemName = null;
        this.currentPressedElement = null;
        this.currentPressedItemName = null;
        this.savedCurrentPressedElement = null;
        this.savedCurrentMouseMoveSrcElement = null;
        
        this.AfterSetFocusedState = new ASPxClientEvent();
        this.AfterClearFocusedState = new ASPxClientEvent();
        this.AfterSetHoverState = new ASPxClientEvent();
        this.AfterClearHoverState = new ASPxClientEvent();
        this.AfterSetPressedState = new ASPxClientEvent();
        this.AfterClearPressedState = new ASPxClientEvent();
        this.AfterDisabled = new ASPxClientEvent();
        this.AfterEnabled = new ASPxClientEvent();
        this.BeforeSetFocusedState = new ASPxClientEvent();
        this.BeforeClearFocusedState = new ASPxClientEvent();
        this.BeforeSetHoverState = new ASPxClientEvent();
        this.BeforeClearHoverState = new ASPxClientEvent();
        this.BeforeSetPressedState = new ASPxClientEvent();
        this.BeforeClearPressedState = new ASPxClientEvent();
        this.BeforeDisabled = new ASPxClientEvent();
        this.BeforeEnabled = new ASPxClientEvent();
        this.FocusedItemKeyDown = new ASPxClientEvent();
    },    
    AddHoverItem: function(name, classNames, cssTexts, postfixes, imageObjs, imagePostfixes, disableApplyingStyleToLink){
        this.AddItem(this.hoverItems, name, classNames, cssTexts, postfixes, imageObjs, imagePostfixes, __aspxHoverItemKind, disableApplyingStyleToLink);
        this.AddItem(this.focusedItems, name, classNames, cssTexts, postfixes, imageObjs, imagePostfixes, __aspxFocusedItemKind, disableApplyingStyleToLink);
    },
    AddPressedItem: function(name, classNames, cssTexts, postfixes, imageObjs, imagePostfixes ,disableApplyingStyleToLink){
        this.AddItem(this.pressedItems, name, classNames, cssTexts, postfixes, imageObjs, imagePostfixes, __aspxPressedItemKind, disableApplyingStyleToLink);
    },
    AddSelectedItem: function(name, classNames, cssTexts, postfixes, imageObjs, imagePostfixes, disableApplyingStyleToLink){
        this.AddItem(this.selectedItems, name, classNames, cssTexts, postfixes, imageObjs, imagePostfixes, __aspxSelectedItemKind, disableApplyingStyleToLink);
    },
    AddDisabledItem: function(name, classNames, cssTexts, postfixes, imageObjs, imagePostfixes, disableApplyingStyleToLink){
        this.AddItem(this.disabledItems, name, classNames, cssTexts, postfixes, imageObjs, imagePostfixes, __aspxDisabledItemKind, disableApplyingStyleToLink);
    },
    AddItem: function(items, name, classNames, cssTexts, postfixes, imageObjs, imagePostfixes, kind , disableApplyingStyleToLink){
        var stateItem = new ASPxStateItem(name, classNames, cssTexts, postfixes, imageObjs, imagePostfixes, kind, disableApplyingStyleToLink);
        if(postfixes && postfixes.length > 0){
            for(var i = 0; i < postfixes.length; i ++){
                items[name + postfixes[i]] = stateItem;
            }
        }
        else
            items[name] = stateItem;
        __aspxStateItemsExist = true;
    },
    RemoveHoverItem: function(name){
        this.RemoveItem(this.hoverItems, name);
        this.RemoveItem(this.focusedItems, name);
    },
    RemovePressedItem: function(name){
        this.RemoveItem(this.pressedItems, name);
    },
    RemoveSelectedItem: function(name){
        this.RemoveItem(this.selectedItems, name);
    },
    RemoveDisabledItem: function(name){
        this.RemoveItem(this.disabledItems, name);
    },
    RemoveItem: function(items, name){
        delete items[name];
    },
    
    GetFocusedElement: function(srcElement){
        return this.GetItemElement(srcElement, this.focusedItems, __aspxFocusedItemKind);
    },
    GetHoverElement: function(srcElement){
        return this.GetItemElement(srcElement, this.hoverItems, __aspxHoverItemKind);
    },
    GetPressedElement: function(srcElement){
        return this.GetItemElement(srcElement, this.pressedItems, __aspxPressedItemKind);
    },
    GetSelectedElement: function(srcElement){
        return this.GetItemElement(srcElement, this.selectedItems, __aspxSelectedItemKind);
    },
    GetDisabledElement: function(srcElement){
        return this.GetItemElement(srcElement, this.disabledItems, __aspxDisabledItemKind);
    },
    GetItemElement: function(srcElement, items, kind){
        if(srcElement && srcElement[__aspxCachedStatePrefix + kind]){
            var cachedElement = srcElement[__aspxCachedStatePrefix + kind];
            if(cachedElement != __aspxEmptyCachedValue)
                return cachedElement;
            return null;
        }
            
        var element = srcElement;
        while(element != null) {
            var item = items[element.id];
            if(item){
                this.CacheItemElement(srcElement, kind, element);
                element[kind] = item;
                return element;
            }
            element = element.parentNode;
        }
        this.CacheItemElement(srcElement, kind, __aspxEmptyCachedValue);
        return null;
    },
    CacheItemElement: function(srcElement, kind, value){
        if(srcElement && !srcElement[__aspxCachedStatePrefix + kind])
            srcElement[__aspxCachedStatePrefix + kind] = value;
    },

    DoSetFocusedState: function(element, fromElement){
        var item = element[__aspxFocusedItemKind];
        if(item){
            var args = new ASPxClientStateEventArgs(item, element);
            args.fromElement = fromElement;
            this.BeforeSetFocusedState.FireEvent(this, args);
            item.Apply(element);
            this.AfterSetFocusedState.FireEvent(this, args);
        }
    },
    DoClearFocusedState: function(element, toElement){
        var item = element[__aspxFocusedItemKind];
        if(item){
            var args = new ASPxClientStateEventArgs(item, element);
            args.toElement = toElement;
            this.BeforeClearFocusedState.FireEvent(this, args);
            item.Cancel(element);
            this.AfterClearFocusedState.FireEvent(this, args);
        }
    },
    DoSetHoverState: function(element, fromElement){
        var item = element[__aspxHoverItemKind];
        if(item){
            var args = new ASPxClientStateEventArgs(item, element);
            args.fromElement = fromElement;
            this.BeforeSetHoverState.FireEvent(this, args);
            item.Apply(element);
            this.AfterSetHoverState.FireEvent(this, args);
        }
    },
    DoClearHoverState: function(element, toElement){
        var item = element[__aspxHoverItemKind];
        if(item){
            var args = new ASPxClientStateEventArgs(item, element);
            args.toElement = toElement;
            this.BeforeClearHoverState.FireEvent(this, args);
            item.Cancel(element);
            this.AfterClearHoverState.FireEvent(this, args);
        }
    },
    DoSetPressedState: function(element){
        var item = element[__aspxPressedItemKind];
        if(item){
            var args = new ASPxClientStateEventArgs(item, element);
            this.BeforeSetPressedState.FireEvent(this, args);
            item.Apply(element);
            this.AfterSetPressedState.FireEvent(this, args);
        }
    },
    DoClearPressedState: function(element){
        var item = element[__aspxPressedItemKind];
        if(item){
            var args = new ASPxClientStateEventArgs(item, element);
            this.BeforeClearPressedState.FireEvent(this, args);
            item.Cancel(element);
            this.AfterClearPressedState.FireEvent(this, args);
        }
    },
    SetCurrentFocusedElement: function(element){
        if(this.currentFocusedElement && !_aspxIsValidElement(this.currentFocusedElement)){
            this.currentFocusedElement = null;
            this.currentFocusedItemName = "";
        }
        if(this.currentFocusedElement != element){
            var oldCurrentFocusedElement = this.currentFocusedElement;
            var item = (element != null) ? element[__aspxFocusedItemKind] : null;
            var itemName = (item != null) ? item.name : "";
            if(this.currentFocusedItemName != itemName){
                if(this.currentHoverItemName != "")
                    this.SetCurrentHoverElement(null);
                    
                if(this.currentFocusedElement != null)
                    this.DoClearFocusedState(this.currentFocusedElement, element);
                this.currentFocusedElement = element;
                item = (element != null) ? element[__aspxFocusedItemKind] : null;
                this.currentFocusedItemName = (item != null) ? item.name : "";
                if(this.currentFocusedElement != null)
                    this.DoSetFocusedState(this.currentFocusedElement, oldCurrentFocusedElement);
            }
        }
    },
    SetCurrentHoverElement: function(element){
        if(this.currentHoverElement && !_aspxIsValidElement(this.currentHoverElement)){
            this.currentHoverElement = null;
            this.currentHoverItemName = "";
        }
        var item = (element != null) ? element[__aspxHoverItemKind] : null;
        if(item && !item.enabled) { // B208787
            element = this.GetItemElement(element.parentNode, this.hoverItems, __aspxHoverItemKind);
            item = (element != null) ? element[__aspxHoverItemKind] : null;
        }
        if(this.currentHoverElement != element){
            var oldCurrentHoverElement = this.currentHoverElement,
                itemName = (item != null) ? item.name : "";
            if(this.currentHoverItemName != itemName || (item != null && item.needRefreshBetweenElements)){
                if(this.currentFocusedItemName != "")
                    this.SetCurrentFocusedElement(null);

                if(this.currentHoverElement != null)
                    this.DoClearHoverState(this.currentHoverElement, element);
                item = (element != null) ? element[__aspxHoverItemKind] : null;
                if(item == null || item.enabled){
                    this.currentHoverElement = element;
                    this.currentHoverItemName = (item != null) ? item.name : "";
                    if(this.currentHoverElement != null)
                        this.DoSetHoverState(this.currentHoverElement, oldCurrentHoverElement);
                }
            }
        }
    },
    SetCurrentPressedElement: function(element){
        if(this.currentPressedElement && !_aspxIsValidElement(this.currentPressedElement)){
            this.currentPressedElement = null;
            this.currentPressedItemName = "";
        }
            
        if(this.currentPressedElement != element){
            if(this.currentPressedElement != null)
                this.DoClearPressedState(this.currentPressedElement);
            var item = (element != null) ? element[__aspxPressedItemKind] : null;
            if(item == null || item.enabled){
                this.currentPressedElement = element;
                this.currentPressedItemName = (item != null) ? item.name : "";
                if(this.currentPressedElement != null)
                    this.DoSetPressedState(this.currentPressedElement);
            }
        }
    },
    SetCurrentFocusedElementBySrcElement: function(srcElement){
        var element = this.GetFocusedElement(srcElement);
        this.SetCurrentFocusedElement(element);
    },
    SetCurrentHoverElementBySrcElement: function(srcElement){
        var element = this.GetHoverElement(srcElement);
        this.SetCurrentHoverElement(element);
    },
    SetCurrentPressedElementBySrcElement: function(srcElement){
        var element = this.GetPressedElement(srcElement);
        this.SetCurrentPressedElement(element);
    },
    SetPressedElement: function (element) {
        this.SetCurrentHoverElement(null);
        this.SetCurrentPressedElementBySrcElement(element);
        this.savedCurrentPressedElement = this.currentPressedElement;
    },
    SelectElement: function (element) {
        var item = element[__aspxSelectedItemKind];
        if(item)
            item.Apply(element);
    },    
    SelectElementBySrcElement: function(srcElement){
        var element = this.GetSelectedElement(srcElement);
        if(element != null) this.SelectElement(element);
    },    
    DeselectElement: function(element){
        var item = element[__aspxSelectedItemKind];
        if(item)
            item.Cancel(element);
    },    
    DeselectElementBySrcElement: function(srcElement){
        var element = this.GetSelectedElement(srcElement);
        if(element != null) this.DeselectElement(element);
    },
    
    SetElementEnabled: function(element, enable){
        if(enable)
            this.EnableElement(element);
        else
            this.DisableElement(element);
    },
    DisableElement: function(element){
        var element = this.GetDisabledElement(element);
        if(element != null) {
            var item = element[__aspxDisabledItemKind];
            if(item){
                var args = new ASPxClientStateEventArgs(item, element);
                this.BeforeDisabled.FireEvent(this, args);
                if(item.name == this.currentPressedItemName)
                    this.SetCurrentPressedElement(null);
                if(item.name == this.currentHoverItemName)
                    this.SetCurrentHoverElement(null);
                item.Apply(element);
                this.SetMouseStateItemsEnabled(item.name, item.postfixes, false);
                this.AfterDisabled.FireEvent(this, args);
            }
        }
    },    
    EnableElement: function(element){
        var element = this.GetDisabledElement(element);
        if(element != null) {
            var item = element[__aspxDisabledItemKind];
            if(item){
                var args = new ASPxClientStateEventArgs(item, element);
                this.BeforeEnabled.FireEvent(this, args);
                item.Cancel(element);
                this.SetMouseStateItemsEnabled(item.name, item.postfixes, true);
                this.AfterEnabled.FireEvent(this, args);
            }
        }
    },    
    SetMouseStateItemsEnabled: function(name, postfixes, enabled){   
        if(postfixes && postfixes.length > 0){
            for(var i = 0; i < postfixes.length; i ++){
                this.SetItemsEnabled(this.hoverItems, name + postfixes[i], enabled);
                this.SetItemsEnabled(this.pressedItems, name + postfixes[i], enabled);
                this.SetItemsEnabled(this.focusedItems, name + postfixes[i], enabled);
            }
        }
        else{
            this.SetItemsEnabled(this.hoverItems, name, enabled);
            this.SetItemsEnabled(this.pressedItems, name, enabled);
            this.SetItemsEnabled(this.focusedItems, name, enabled);
        }        
    },
    SetItemsEnabled: function(items, name, enabled){   
        if(items[name])
            items[name].enabled = enabled;
    },
    
    OnFocusMove: function(evt){
        var element = _aspxGetEventSource(evt);
        aspxGetStateController().SetCurrentFocusedElementBySrcElement(element);
    },
    OnMouseMove: function(evt, checkElementChanged){
        var srcElement = _aspxGetEventSource(evt);
        if(checkElementChanged && srcElement == this.savedCurrentMouseMoveSrcElement) return;
        this.savedCurrentMouseMoveSrcElement = srcElement;
        
        if(__aspxIE && !_aspxGetIsLeftButtonPressed(evt) && this.savedCurrentPressedElement != null)
            this.ClearSavedCurrentPressedElement();
             
        if(this.savedCurrentPressedElement == null)
            this.SetCurrentHoverElementBySrcElement(srcElement);
        else{
            var element = this.GetPressedElement(srcElement);
            if(element != this.currentPressedElement){
                if(element == this.savedCurrentPressedElement)
                    this.SetCurrentPressedElement(this.savedCurrentPressedElement);
                else
                    this.SetCurrentPressedElement(null);
            }
        }
    },
    OnMouseDown: function(evt){
        if(!_aspxGetIsLeftButtonPressed(evt)) return;
        var srcElement = _aspxGetEventSource(evt);
        this.OnMouseDownOnElement(srcElement);
    },
    OnMouseDownOnElement: function (element) {
        if (this.GetPressedElement(element) == null) return;
        this.SetPressedElement(element);
    },
    OnMouseUp: function(evt){
        var srcElement = _aspxGetEventSource(evt);
        this.OnMouseUpOnElement(srcElement);
    },
    OnMouseUpOnElement: function(element){
        if(this.savedCurrentPressedElement == null) return;
        this.ClearSavedCurrentPressedElement();
        this.SetCurrentHoverElementBySrcElement(element);
    },
    OnMouseOver: function(evt){
        var element = _aspxGetEventSource(evt);
        if (element && element.tagName == "IFRAME")
            this.OnMouseMove(evt, true);
    },
    OnKeyDown: function(evt){
        var element = this.GetFocusedElement(_aspxGetEventSource(evt));
        if(element != null && element == this.currentFocusedElement) {
            var item = element[__aspxFocusedItemKind];
            if(item){
                var args = new ASPxClientStateEventArgs(item, element);
                args.htmlEvent = evt;
                this.FocusedItemKeyDown.FireEvent(this, args);
            }
        }
    },
    OnSelectStart: function(evt){
        if(this.savedCurrentPressedElement) {
            _aspxClearSelection();
            return false;
        }
    },
    ClearSavedCurrentPressedElement: function() {
        this.savedCurrentPressedElement = null;
        this.SetCurrentPressedElement(null);
    },
    ClearCache: function(srcElement, kind) {
        if(srcElement[__aspxCachedStatePrefix + kind])
            srcElement[__aspxCachedStatePrefix + kind] = null;
    },
    ClearElementCache: function(srcElement) {
        this.ClearCache(srcElement, __aspxFocusedItemKind);
        this.ClearCache(srcElement, __aspxHoverItemKind);
        this.ClearCache(srcElement, __aspxPressedItemKind);
        this.ClearCache(srcElement, __aspxSelectedItemKind);
        this.ClearCache(srcElement, __aspxDisabledItemKind);
    }
});

var __aspxStateController = null;
function aspxGetStateController(){
    if(__aspxStateController == null)
        __aspxStateController = new ASPxStateController();
    return __aspxStateController;
}

function aspxAddStateItems(method, namePrefix, classes, disableApplyingStyleToLink){
    for(var i = 0; i < classes.length; i ++){
        for(var j = 0; j < classes[i][2].length; j ++) {
            var name = namePrefix;
            if(classes[i][2][j])
                name += "_" + classes[i][2][j];
            var postfixes = classes[i][3] || null;
            var imageObjs = (classes[i][4] && classes[i][4][j]) || null;
            var imagePostfixes = classes[i][5] || null;
            method.call(aspxGetStateController(), name, classes[i][0], classes[i][1], postfixes, imageObjs, imagePostfixes, disableApplyingStyleToLink);
        }
    }
}
function aspxAddHoverItems(namePrefix, classes, disableApplyingStyleToLink){
    aspxAddStateItems(aspxGetStateController().AddHoverItem, namePrefix, classes, disableApplyingStyleToLink);
}
function aspxAddPressedItems(namePrefix, classes, disableApplyingStyleToLink){
    aspxAddStateItems(aspxGetStateController().AddPressedItem, namePrefix, classes, disableApplyingStyleToLink);
}
function aspxAddSelectedItems(namePrefix, classes, disableApplyingStyleToLink){
    aspxAddStateItems(aspxGetStateController().AddSelectedItem, namePrefix, classes, disableApplyingStyleToLink);
}
function aspxAddDisabledItems(namePrefix, classes, disableApplyingStyleToLink){
    aspxAddStateItems(aspxGetStateController().AddDisabledItem, namePrefix, classes, disableApplyingStyleToLink);
}
function aspxRemoveStateItems(method, namePrefix, classes){
    for(var i = 0; i < classes.length; i ++){
        for(var j = 0; j < classes[i][0].length; j ++) {
            var name = namePrefix;
            if(classes[i][0][j])
                name += "_" + classes[i][0][j];
            method.call(aspxGetStateController(), name);
        }
    }
}
function aspxRemoveHoverItems(namePrefix, classes){
    aspxRemoveStateItems(aspxGetStateController().RemoveHoverItem, namePrefix, classes);
}
function aspxRemovePressedItems(namePrefix, classes){
    aspxRemoveStateItems(aspxGetStateController().RemovePressedItem, namePrefix, classes);
}
function aspxRemoveSelectedItems(namePrefix, classes){
    aspxRemoveStateItems(aspxGetStateController().RemoveSelectedItem, namePrefix, classes);
}
function aspxRemoveDisabledItems(namePrefix, classes){
    aspxRemoveStateItems(aspxGetStateController().RemoveDisabledItem, namePrefix, classes);
}

function aspxAddAfterClearFocusedState(handler){
    aspxGetStateController().AfterClearFocusedState.AddHandler(handler);
}
function aspxAddAfterSetFocusedState(handler){
    aspxGetStateController().AfterSetFocusedState.AddHandler(handler);
}
function aspxAddAfterClearHoverState(handler){
    aspxGetStateController().AfterClearHoverState.AddHandler(handler);
}
function aspxAddAfterSetHoverState(handler){
    aspxGetStateController().AfterSetHoverState.AddHandler(handler);
}
function aspxAddAfterClearPressedState(handler){
    aspxGetStateController().AfterClearPressedState.AddHandler(handler);
}
function aspxAddAfterSetPressedState(handler){
    aspxGetStateController().AfterSetPressedState.AddHandler(handler);
}
function aspxAddAfterDisabled(handler){
    aspxGetStateController().AfterDisabled.AddHandler(handler);
}
function aspxAddAfterEnabled(handler){
    aspxGetStateController().AfterEnabled.AddHandler(handler);
}
function aspxAddBeforeClearFocusedState(handler){
    aspxGetStateController().BeforeClearFocusedState.AddHandler(handler);
}
function aspxAddBeforeSetFocusedState(handler){
    aspxGetStateController().BeforeSetFocusedState.AddHandler(handler);
}
function aspxAddBeforeClearHoverState(handler){
    aspxGetStateController().BeforeClearHoverState.AddHandler(handler);
}
function aspxAddBeforeSetHoverState(handler){
    aspxGetStateController().BeforeSetHoverState.AddHandler(handler);
}
function aspxAddBeforeClearPressedState(handler){
    aspxGetStateController().BeforeClearPressedState.AddHandler(handler);
}
function aspxAddBeforeSetPressedState(handler){
    aspxGetStateController().BeforeSetPressedState.AddHandler(handler);
}
function aspxAddBeforeDisabled(handler){
    aspxGetStateController().BeforeDisabled.AddHandler(handler);
}
function aspxAddBeforeEnabled(handler){
    aspxGetStateController().BeforeEnabled.AddHandler(handler);
}
function aspxAddFocusedItemKeyDown(handler){
    aspxGetStateController().FocusedItemKeyDown.AddHandler(handler);
}

function aspxSetHoverState(element){
    aspxGetStateController().SetCurrentHoverElementBySrcElement(element);
}
function aspxClearHoverState(evt){
    aspxGetStateController().SetCurrentHoverElementBySrcElement(null);
}
function aspxUpdateHoverState(evt){
    aspxGetStateController().OnMouseMove(evt, false);
}
function aspxSetFocusedState(element){
    aspxGetStateController().SetCurrentFocusedElementBySrcElement(element);
}
function aspxClearFocusedState(evt){
    aspxGetStateController().SetCurrentFocusedElementBySrcElement(null);
}
function aspxUpdateFocusedState(evt){
    aspxGetStateController().OnFocusMove(evt);
}
function aspxAssignAccessabilityEventsToChildrenLinks(container){
    var links = _aspxGetChildrenByPartialClassName(container, __aspxAccessibilityMarkerClass);
    for(var i = 0; i < links.length; i++)
        aspxAssignAccessabilityEventsToLink(links[i]);
}
function aspxAssignAccessabilityEventsToLink(link) {
    if (!_aspxElementCssClassContains(link, __aspxAccessibilityMarkerClass))
        return;
    _aspxAttachEventToElement(link, "focus", function(e) { aspxUpdateFocusedState(e); });
    _aspxAttachEventToElement(link, "blur", function(e) { aspxClearFocusedState(e); });
    if(__aspxIE && __aspxBrowserMajorVersion < 7 && link.href == __aspxAccessibilityEmptyUrl)
        _aspxAttachEventToElement(link, "click", function() { return false; });
}

_aspxAttachEventToDocument("mousemove", aspxClassesDocumentMouseMove);
function aspxClassesDocumentMouseMove(evt) {
    if(__aspxClassesScriptParsed && __aspxStateItemsExist)
        aspxGetStateController().OnMouseMove(evt, true);
}
_aspxAttachEventToDocument(ASPxClientTouchUI.touchMouseDownEventName, aspxClassesDocumentMouseDown);
function aspxClassesDocumentMouseDown(evt){
    if(__aspxClassesScriptParsed && __aspxStateItemsExist)
        aspxGetStateController().OnMouseDown(evt);
}
_aspxAttachEventToDocument(ASPxClientTouchUI.touchMouseUpEventName, aspxClassesDocumentMouseUp);
function aspxClassesDocumentMouseUp(evt){
    if(__aspxClassesScriptParsed && __aspxStateItemsExist)
        aspxGetStateController().OnMouseUp(evt);
}
_aspxAttachEventToDocument("mouseover", aspxClassesDocumentMouseOver);
function aspxClassesDocumentMouseOver(evt){
    if(__aspxClassesScriptParsed && __aspxStateItemsExist)
        aspxGetStateController().OnMouseOver(evt);
}
_aspxAttachEventToDocument("keydown", aspxClassesDocumentKeyDown);
function aspxClassesDocumentKeyDown(evt){
    if(__aspxClassesScriptParsed && __aspxStateItemsExist)
        aspxGetStateController().OnKeyDown(evt);
}
_aspxAttachEventToDocument("selectstart", aspxClassesDocumentSelectStart);
function aspxClassesDocumentSelectStart(evt){
    if(__aspxClassesScriptParsed && __aspxStateItemsExist)
        return aspxGetStateController().OnSelectStart(evt);    
}

/*# using DevExpress.Web.ASPxClasses.Scripts; #*/
/*# namespace DevExpress.Web.ASPxPanel.Scripts #*/

/*# public class ASPxClientPanel : ASPxClientControl #*/
ASPxClientPanel = _aspxCreateClass(ASPxClientControl, {
    constructor: function(name) {
        this.constructor.prototype.constructor.call(this, name);
        this.touchUIScroller = null;
    },
    Initialize: function(){
        this.touchUIScroller = ASPxClientTouchUI.makeScrollableIfRequired(this.GetMainElement());
    },
    GetContentElement: function() {
        return this.GetMainElement();
    },
    /*# [Obsolete("Use the GetContentHtml method instead.")]public string GetContentHTML(){ return ""; } #*/
    GetContentHTML: function(){
        return this.GetContentHtml();
    },
    /*# [Obsolete("Use the SetContentHtml method instead.")]public void SetContentHTML(string html){ return; } #*/
    SetContentHTML: function(html){
        this.SetContentHtml(html);
    },
    /*# public string GetContentHtml(){ return ""; } #*/
    GetContentHtml: function(){
        if(this.touchUIScroller)
            this.touchUIScroller.destroy();
        var contentElement = this.GetContentElement();
        contentHtml = _aspxIsExistsElement(contentElement) ? contentElement.innerHTML : null;
        if(this.touchUIScroller)
            this.touchUIScroller.ChangeElement(this.GetMainElement());
        return contentHtml;
    },
    /*# public void SetContentHtml(string html){ return; } #*/
    SetContentHtml: function(html){
        var contentElement = this.GetContentElement();
        if (_aspxIsExistsElement(contentElement))
            _aspxSetInnerHtml(contentElement, html);
        if(this.touchUIScroller)
            this.touchUIScroller.ChangeElement(this.GetMainElement());
    }
    /*# public void SetEnabled(bool enabled){ return; } #*/
    /*# public bool GetEnabled(){ return true; } #*/
});
/*# public static new ASPxClientPanel Cast(object obj){ return null; } #*/
ASPxClientPanel.Cast = ASPxClientControl.Cast;
/*# using DevExpress.Web.ASPxClasses.Scripts; #*/
/*# namespace DevExpress.Web.ASPxSplitter.Scripts #*/

ASPxSplitterHelper = _aspxCreateClass(null, {
    // Constructor
    constructor: function(splitter) {
        this.splitter = splitter;
        this.clientStateElementId = this.splitter.name + "_CS";
    },
    
    // Elements
    GetClientStateElement: function() {
        return ASPxCacheHelper.GetCachedValue(this, this.clientStateElementId, function(){
            return _aspxGetElementById(this.clientStateElementId);
        });
    },
        
    // Resizing
    GetMoveMaxDeltaSize: function(deltaSize) {
        if(deltaSize == 0)
            return 0;
        var splitter = this.splitter,
            leftPane = splitter.moveLeftPane,
            rightPane = splitter.moveRightPane;

        if(splitter.isHeavyUpdate) {
            var parent = leftPane.parent;
            var totalSize = 0, minSize = 0;
            for(var i = 0; i < parent.panes.length; i++) {
                var pane = parent.panes[i];
                if(pane.isSizePx)
                    continue;
                if(pane.collapsed) {
                    var collapsedSize = pane.GetSizeDiff(pane.isVertical);
                    totalSize += collapsedSize;
                    minSize += collapsedSize;
                }
                else {
                    totalSize += pane.GetOffsetSize();
                    minSize += pane.GetMinSize();
                }
            }
            
            var rightPanePx = rightPane.isSizePx;
            if(rightPanePx)
                deltaSize = this.GetPaneMaxDeltaSize(rightPane, -deltaSize);
            deltaSize = this.GetMaxDeltaSize(totalSize, minSize, Number.MAX_VALUE, -deltaSize);
            if(!rightPanePx)
                deltaSize = this.GetPaneMaxDeltaSize(leftPane, -deltaSize);
        }
        else {
            var parent = leftPane.parent,
                rightPaneAutoSize = rightPane.IsAutoSize(parent.isVertical),
                leftPaneAutoSize = leftPane.IsAutoSize(parent.isVertical);
            if(!rightPaneAutoSize)
                deltaSize = -this.GetPaneMaxDeltaSize(rightPane, -1 * deltaSize);
            if(!leftPaneAutoSize)
                deltaSize = this.GetPaneMaxDeltaSize(leftPane, deltaSize);
        }
        return deltaSize;
    },
    GetPaneMaxDeltaSize: function(pane, deltaSize) {
        return this.GetMaxDeltaSize(pane.GetOffsetSize(), pane.GetMinSize(), pane.maxSize, deltaSize);
    },
    GetMaxDeltaSize: function(size, min, max, deltaSize) {
        var minDeltaSize = Math.floor(min - size);
        var maxDeltaSize = Math.floor(max - size);
        if(deltaSize < minDeltaSize)
            return (size < min) ? 0 : minDeltaSize;
        else if(deltaSize > maxDeltaSize)
            return (size > max) ? 0 : maxDeltaSize;
        return deltaSize;
    },
    GetCurrentPos: function() {
        return this.splitter.moveIsVertical
            ? ASPxClientSplitter.CurrentYPos
            : ASPxClientSplitter.CurrentXPos;
    },
    
    // Resizing panel
    SetResizingPanelVisibility: function(visible, cursor) {
        var resizingPanel = ASPxCacheHelper.GetCachedValue(this, "resizingPanel", function(){
            var resizingPanel = document.createElement("DIV");
            resizingPanel.style.overflow = "hidden";
            resizingPanel.style.position = "absolute";
            
            if(__aspxIE && __aspxBrowserMajorVersion < 10) {
                resizingPanel.style.backgroundColor = "White";
                resizingPanel.style.filter = "alpha(opacity=1)";
            }
            
            resizingPanel.isVisible = false;
            
            return resizingPanel;
        });
        
        if(resizingPanel.isVisible != visible) {
            if(visible) {
                var mainElement = this.splitter.GetMainElement();
                _aspxSetStyleSize(resizingPanel, mainElement.offsetWidth, mainElement.offsetHeight);
                if(cursor)
                    resizingPanel.style.cursor = cursor;
                
                mainElement.parentNode.appendChild(resizingPanel);
                _aspxSetAbsoluteX(resizingPanel, _aspxGetAbsoluteX(mainElement));
                _aspxSetAbsoluteY(resizingPanel, _aspxGetAbsoluteY(mainElement));
            }
            else
                resizingPanel.parentNode.removeChild(resizingPanel);
            
            resizingPanel.isVisible = visible;
        }
    }
});
ASPxSplitterHelper.Resize = function(pane1, pane2, deltaSize) {
    if(pane1.isSizePx || pane2.isSizePx) {
        var parent = pane1.parent;
        if(pane1.isSizePx && !pane1.IsAutoSize(parent.isVertical))
            pane1.size += deltaSize;
        if(pane2.isSizePx && !pane2.IsAutoSize(parent.isVertical))
            pane2.size -= deltaSize;
    }
    else {
        var c = (pane1.size + pane2.size) / (pane1.GetOffsetSize() + pane2.GetOffsetSize());
        pane1.size = c * (pane1.GetOffsetSize() + deltaSize);
        pane2.size = c * (pane2.GetOffsetSize() - deltaSize);
    }
};
ASPxSplitterHelper.IsAllowResize = function(pane1, pane2) {
    if(!pane1 || !pane2)
        return false;
    if(!pane1.splitter.enabled)
        return false;

    var bothAutoSizeOrPercent = pane1.isVertical
        ? pane1.autoHeight && pane2.autoHeight || pane1.autoHeight && !pane2.isSizePx || !pane1.isSizePx && pane2.autoHeight
        : pane1.autoWidth && pane2.autoWidth || pane1.autoWidth && !pane2.isSizePx || !pane1.isSizePx && pane2.autoWidth;
    if(bothAutoSizeOrPercent)
        return false;

    return pane1.splitter.allowResize && pane1.allowResize && pane2.allowResize;
};

ASPxSplitterPaneHelper = _aspxCreateClass(null, {
    // Constructor
    constructor: function(pane) {
        this.pane = pane;
        
        this.indexPath = this.GetIndexPath();
        var paneIdPostfix = this.pane.isRootPane ? "" : "_" + this.indexPath;
        var separatorIdPostfix = paneIdPostfix + "_S";
                      
        this.postfixes = {
            pane: paneIdPostfix,
            separator: separatorIdPostfix,
            table: paneIdPostfix + "_T",
            contentContainer: paneIdPostfix + "_CC",
            collapseForwardButton: separatorIdPostfix + "_CF",
            collapseBackwardButton: separatorIdPostfix + "_CB",
            collapseButtonsSeparator: separatorIdPostfix + "_CS"
        };
    
        this.buttonsTableExists = !!this.GetCollapseBackwardButton();
        this.separatorImageExists = !!this.GetCollapseButtonsSeparatorImage();
        this.buttonsExists = this.buttonsTableExists || this.separatorImageExists;
    },
    
    // Caching
    GetCachedValue: function(name, func) {
         return ASPxCacheHelper.GetCachedValue(this, name, func);
    },
    DropCachedValue: function(name) {
        ASPxCacheHelper.DropCachedValue(this, name);
    },
        
    // Element IDs
    GetIndexPath: function() {
        if(this.pane.isRootPane)
            return "";
        var parentPane = this.pane.parent;
        if(parentPane.isRootPane)
            return "" + this.pane.index;
        return parentPane.helper.indexPath + __aspxItemIndexSeparator + this.pane.index;
    },
        
    // Elements
    GetCachedElement: function(idPostfix) {
        return this.GetCachedValue(idPostfix, function(){
            return this.pane.splitter.GetChild(idPostfix);
        });
    },
    DropCachedElement: function(idPostfix) {
        this.DropCachedValue(idPostfix);
    },
    GetPaneElement: function() {
        return this.GetCachedElement(this.postfixes.pane);
    },
    GetTableElement: function() {
        return this.GetCachedElement(this.postfixes.table);
    },
    GetContentContainerElement: function() {
        return this.GetCachedElement(this.postfixes.contentContainer);
    },
    DropContentContainerElementFromCache: function() {
        this.DropCachedElement(this.postfixes.contentContainer);
    },
    GetSeparatorElementId: function() {
        return this.pane.splitter.name + this.postfixes.separator;
    },
    GetSeparatorElement: function() {
        return this.GetCachedElement(this.postfixes.separator);
    },
    GetSeparatorDivElement: function() {
        return this.GetCachedValue("separatorDivElement", function(){
            var separatorElement = this.GetSeparatorElement();
            return separatorElement ? separatorElement.childNodes[0] : null;
        });
    },
    GetCollapseBackwardButton: function() {
        return this.GetCachedElement(this.postfixes.collapseBackwardButton);
    },
    GetCollapseForwardButton: function() {
        return this.GetCachedElement(this.postfixes.collapseForwardButton);
    },
    GetCollapseButtonsSeparator: function() {
        return this.GetCachedElement(this.postfixes.collapseButtonsSeparator);
    },
    GetCollapseButtonsTable: function() {
        return this.GetCachedValue("collapseButtonsTable", function(){
            return this.buttonsTableExists ? _aspxGetParentByTagName(this.GetCollapseForwardButton(), "TABLE") : null;
        });
    },
    GetCollapseButtonsSeparatorImage: function() {
        return this.GetCachedValue("collapseButtonsSeparatorImage", function(){
            var separator = this.GetCollapseButtonsSeparator();
            if(!separator) {
                if(!this.buttonsTableExists)
                    separator = this.GetSeparatorElement();
                else
                    return null;
            }
            return _aspxGetChildByTagName(separator, "IMG", 0);
        });
    },
    GetButtonUpdateElement: function(buttonElement) {
        return !this.pane.isVertical ? buttonElement.parentNode : buttonElement;
    },
    
    ClearElementSizeProperty: function(property) {
        var element = this.GetPaneElement(),
            isVertical = property === "width";
        this.pane.savedSizeProperty = element.style[property];
        element.style[property] = "";
        if(!this.pane.IsAutoSize(isVertical)) {
            var contentContainerElement = this.GetContentContainerElement();
            this.pane.savedContentSizeProperty = contentContainerElement.style[property];
            contentContainerElement.style[property] = (this.pane.GetMinSize() - (isVertical ? this.pane.contentContainerWidthDiff : this.pane.contentContainerHeightDiff)) + "px";
        }
    },
    RestoreElementSizeProperty: function(property) {
        if(this.pane.savedSizeProperty) {
            this.GetPaneElement().style[property] = this.pane.savedSizeProperty;
            this.pane.savedSizeProperty = null;
        }
        if(!this.pane.IsAutoSize(property === "width")) {
            this.GetContentContainerElement().style[property] = this.pane.savedContentSizeProperty;
            this.pane.savedContentSizeProperty = null;
        }
    },

    // Common
    SetEmptyDivVisible: function(visible) {
        var emptyDiv = this.GetCachedValue("emptyDiv", function(){
            var emptyDiv = document.createElement("DIV");
            emptyDiv.style.cssText = "overflow: hidden; width: 0px; height: 0px";
            emptyDiv.isVisible = false;
            return emptyDiv;
        });
        if(visible != emptyDiv.isVisible) {
            if(visible)
                this.GetPaneElement().appendChild(emptyDiv);
            else 
                this.GetPaneElement().removeChild(emptyDiv);
            emptyDiv.isVisible = visible;
        }
    },

    HasCollapsedParent: function() {
        var parent = this.pane.parent;
        if(parent)
            return parent.collapsed || parent.helper.HasCollapsedParent();
        return false;
    },

    HasVisibleAutoSizeChildren: function(isVertical) {
        var result = false;
        if(!_aspxIsExists(isVertical))
            isVertical = this.pane.isVertical;
        for(var i = 0; i < this.pane.panes.length; i++) {
            var pane = this.pane.panes[i];
            result = result || !pane.collapsed && pane.IsAutoSize(isVertical) && (!pane.panes.length || pane.helper.HasVisibleAutoSizeChildren(isVertical));
        }
        return result;
    }
});

ASPxSplitterResizingPointer = _aspxCreateClass(null, {
    constructor: function(elementId) {
        this.elementId = elementId;
        this.element = _aspxGetElementById(this.elementId);
        this.x = 0;
        this.y = 0;
    },
    SetCursor: function(cursor) {
        this.element.style.cursor = cursor;
    },
    SetPosition: function(x, y) {
        this.x = x;
        this.y = y;
        _aspxSetAbsoluteY(this.element, this.y);
        _aspxSetAbsoluteX(this.element, this.x);
    },
    SetVisibility: function(isVisible) {
        _aspxSetElementDisplay(this.element, isVisible);
    },
    Move: function(delta, isX) {
        if(isX)
            this.x += delta;
        else
            this.y += delta;
        this.SetPosition(this.x, this.y);
    },
    AttachToElement: function(element, isShow) {
        _aspxSetStyleSize(this.element, element.offsetWidth, element.offsetHeight);
        this.SetVisibility(true);
        this.SetPosition(_aspxGetAbsoluteX(element), _aspxGetAbsoluteY(element));
    }
});

/*# public class ASPxClientSplitter : ASPxClientControl #*/
ASPxClientSplitter = _aspxCreateClass(ASPxClientControl, {
    // Constructor
    constructor: function(name) {
        this.constructor.prototype.constructor.call(this, name);
        
        this.emptyUrls = [
            "javascript:false",
            "about:blank",
            "#"
        ];
        
        this.width = "100%";
        this.height = "200px";
        
        this.helper = new ASPxSplitterHelper(this);
        this.resizingPointer = new ASPxSplitterResizingPointer(this.name + "_RP");
        this.rootPane = new ASPxClientSplitterPane(this, null, 0, 0, {});
        
        this.liveResizing = false;
        this.allowResize = true;
        this.defaultMinSize = 5;
        //
        this.showSeparatorImage = true;
        this.showCollapseBackwardButton = false;        
        this.showCollapseForwardButton = false;
        //
        this.fullScreen = false;

        this.prepared = false;
        
        /*# public event ASPxClientSplitterPaneCancelEventHandler PaneResizing { add{} remove{} }#*/
        this.PaneResizing = new ASPxClientEvent();
        /*# public event ASPxClientSplitterPaneEventHandler PaneResized { add{} remove{} }#*/
        this.PaneResized = new ASPxClientEvent();
        /*# public event ASPxClientSplitterPaneCancelEventHandler PaneCollapsing { add{} remove{} }#*/
        this.PaneCollapsing = new ASPxClientEvent();
        /*# public event ASPxClientSplitterPaneEventHandler PaneCollapsed { add{} remove{} }#*/
        this.PaneCollapsed = new ASPxClientEvent();
        /*# public event ASPxClientSplitterPaneCancelEventHandler PaneExpanding { add{} remove{} }#*/
        this.PaneExpanding = new ASPxClientEvent();
        /*# public event ASPxClientSplitterPaneEventHandler PaneExpanded { add{} remove{} }#*/
        this.PaneExpanded = new ASPxClientEvent();
        /*# public event ASPxClientSplitterPaneEventHandler PaneResizeCompleted { add{} remove{} }#*/
        this.PaneResizeCompleted = new ASPxClientEvent();
        /*# public event ASPxClientSplitterPaneEventHandler PaneContentUrlLoaded { add{} remove{} }#*/
        this.PaneContentUrlLoaded = new ASPxClientEvent();
        
        this.isASPxClientSplitter = true;

        this.autoHeightPanes = [];
        this.autoWidthPanes = [];
    },
    
    // Panes creation
    CreatePanes: function(panesInfo) {
        this.CreatePanesInternal(this.rootPane, panesInfo);
        this.rootPane.ForEach("UpdateSize");
        this.rootPane.ForEach("UpdateAutoSize");
        this.state = this.GetStateObj(panesInfo);
    },
    CreatePanesInternal: function(parent, panesInfo) {
        var prevPane = null,
            visibleIndex = 0;
        for(var i = 0; i < panesInfo.length; i++) {
            var paneInfo = panesInfo[i];
            if(!paneInfo.v) continue; // server-side Visible == false
            
            var pane = new ASPxClientSplitterPane(this, parent, visibleIndex++, i, paneInfo);
            updatePrevNext(pane);
            updateAutoSize(parent, pane.autoWidth, pane.autoHeight);
            parent.panes.push(pane);

            if(_aspxIsExists(paneInfo["i"]))
                this.CreatePanesInternal(pane, paneInfo["i"]);
        }

        function updatePrevNext(pane) {
            pane.prevPane = prevPane;
            if(prevPane != null)
                prevPane.nextPane = pane;
            prevPane = pane;
        }
        function updateAutoSize(pane, autoWidth, autoHeight) {
            if(pane && (autoWidth || autoHeight)) {
                if(autoWidth)
                    pane.autoWidth = true;
                if(autoHeight)
                    pane.autoHeight = true;
                if(!pane.splitter.hasAutoSizePane)
                    pane.splitter.hasAutoSizePane = true;
                updateAutoSize(pane.parent, autoWidth, autoHeight);
            }
        }
    },
    GetStateObj: function(panesInfo) {
        var result = [];
        for(var i = 0; i < panesInfo.length; i++) {
            var paneState = {};
            if(panesInfo[i].st) {
                paneState.st = panesInfo[i].st;
                paneState.s = panesInfo[i].s;
            }
            if(panesInfo[i].c)
                paneState.c = panesInfo[i].c;
            if(panesInfo[i]["i"])
                paneState["i"] = this.GetStateObj(panesInfo[i]["i"]);
            result.push(paneState);
        }
        return result;
    },
    GetClientStateString: function() {
        return _aspxToJson(this.GetClientStateObject());
    },
    GetClientStateObject: function() {
        return this.RefreshState(this.state, this.rootPane.panes);
    },
    RefreshState: function(state, panes) {
        for(var i = 0; i < panes.length; i++) {
            var pane = panes[i];
            var paneState = state[pane._index];
            
            paneState.s = Math.round(pane.size * 1000) / 1000;
            paneState.st = pane.sizeType;
            paneState.c = pane.collapsed ? 1 : 0;
            
            if(pane.panes.length == 0) {
                paneState.spt = Math.round(pane.scrollTop);
                paneState.spl = Math.round(pane.scrollLeft);
            }
            
            if(pane.panes.length > 0)
                this.RefreshState(paneState["i"], pane.panes);
        }
        return state;
    },

    // Initialization
    InlineInitialize: function() {
        this.constructor.prototype.InlineInitialize.call(this);
        
        this.EnsureFullscreenMode();

        this.rootPane.ForEach("Initialize");
        
        var canEvaluateSizes = this.GetMainElement().offsetWidth > 0;
        if(canEvaluateSizes && this.IsDisplayed())
            this.AdjustControlCore();
    },
    EnsureFullscreenMode: function() {
        if(this.fullScreen) {
            var overflowProperty = "overflow",
                oldIEOverflowAutoProperty = null,
                autoWidth = this.rootPane.autoWidth,
                autoHeight = this.rootPane.autoHeight;

            if(autoWidth && autoHeight) {
                overflowProperty = null;
                oldIEOverflowAutoProperty = "overflow";
            }
            else if(autoWidth) {
                overflowProperty = "overflowY";
                oldIEOverflowAutoProperty = "overflowX";
            }
            else if(autoHeight) {
                overflowProperty = "overflowX";
                oldIEOverflowAutoProperty = "overflowY";
            }

            var element = this.GetMainElement().parentNode;
            while(element && element.tagName) {
                element.style.height = "100%";
                
                var tagName = element.tagName.toLowerCase();
                if(tagName == "form" || tagName == "body" || tagName == "html") {
                    element.style.margin = "0px";
                    element.style.padding = "0px";

                    if(overflowProperty)
                        element.style[overflowProperty] = "hidden";
                    if(__aspxIE && __aspxBrowserMajorVersion < 9 && tagName == "form" && oldIEOverflowAutoProperty)
                        element.style[oldIEOverflowAutoProperty] = "auto";
                    if((autoHeight != autoWidth || (__aspxIE && __aspxBrowserMajorVersion < 9)) && (tagName == "body" || tagName == "html"))
                        element.style.overflow = "hidden";
                }

                if(tagName == "html")
                    break;
                element = element.parentNode;
            }
        }
    },
    Initialize: function() {
        this.constructor.prototype.Initialize.call(this);
        this.rootPane.ForEach("CreateContentUrlIFrame", true);
    },
    AfterInitialize: function() {
        this.constructor.prototype.AfterInitialize.call(this);
        this.rootPane.ForEach("RaiseResizedEvent", true);
    },
    IsPrepared: function() {
        return this.prepared;
    },
    Prepare: function() {
        if(this.IsPrepared() || !this.IsDisplayed())
            return;
        this.rootPane.ForEach("Prepare", true);
        ASPxClientSplitter.Instances.Add(this);
        this.prepared = true;
    },
    
    AdjustControlCore: function() {
        this.Prepare();
        
        this.UpdateControlSizes();
    },
    
    NeedUpdateControlSizes: function() {
        return this.width.indexOf("%") > -1
            || this.height.indexOf("%") > -1
            || !this.sizeUpdatedOnce;
    },
    UpdateControlSizes: function(forceUpdate) {
        if(!(forceUpdate || this.NeedUpdateControlSizes()) || !this.IsDisplayed())
            return;
        
        var element = this.GetMainElement(),
            autoHeightSpacer;
        if(this.rootPane.autoHeight) {
            autoHeightSpacer = _aspxCreateHtmlElementFromString("<div style='float: left; width: 0px; height: " + element.offsetHeight + "px'></div>");
            element.parentNode.insertBefore(autoHeightSpacer, element);
        }
        element.style.width = this.width;
        element.style.height = this.height;
        
        var focusedElement = _aspxGetFocusedElement(); // B154375, B156237
        
        if(__aspxIE && __aspxBrowserVersion === 9) {  //Q435288
            _aspxChangeStyleAttribute(this.GetMainElement(), "display", "none");
            this.UpdatePanesVisible(_aspxChangeStyleAttribute);
            _aspxRestoreStyleAttribute(this.GetMainElement(), "display");
        }
        else
            this.UpdatePanesVisible(_aspxChangeStyleAttribute);
        if(__aspxWebKitFamily)
            this.CreateWebkitSpecialElement();
        var newWidth = _aspxGetClearClientWidth(element);
        var newHeight = _aspxGetClearClientHeight(element);
        this.UpdatePanesVisible(_aspxRestoreStyleAttribute);
        if(autoHeightSpacer)
            element.parentNode.removeChild(autoHeightSpacer);
        if((this.rootPane.offsetWidth != newWidth) || (this.rootPane.offsetHeight != newHeight)) {
            
            this.rootPane.offsetWidth = Math.max(newWidth, this.defaultMinSize);
            this.rootPane.offsetHeight = Math.max(newHeight, this.defaultMinSize);
            
            this.rootPane.UpdatePanes(true);
        }
        
        try { // Focused element can be unaccessible (B185659)
            if(focusedElement &&  // B154375, B156237
                !__aspxAndroidMobilePlatform && //Q425154
                !(__aspxMacOSMobilePlatform && __aspxBrowserVersion >= 6) && // Q437440
                _aspxGetIsParent(element, focusedElement) && // We shouldn't play with focused elements placed outside the splitter (B149308)
                !(focusedElement.tagName && focusedElement.tagName == "IFRAME")) { // B157503
                focusedElement.blur();
                if(__aspxIE && __aspxBrowserVersion < 8 && focusedElement.tagName == "TD") {
                    var childInput = _aspxGetChildByTagName(focusedElement, "INPUT", 0);
                    if(childInput && _aspxElementIsVisible(childInput))
                        focusedElement = childInput;
                }
                focusedElement.focus(); // This line should be try..catched because of B156539
            }
        }
        catch(e) { }

        this.rootPane.ForEach("ApplyScrollPosition", true);
        this.rootPane.ForEach("AdjustControls", true);

        if(this.IsPrepared())
            this.sizeUpdatedOnce = true;

        this.SynchronizeProperties();
    },
    
    // Auto size
    UpdateAutoSizePanes: function(forced) {
        if(this.hasAutoSizePane) {
            var heightChanged = this.UpdateAutoHeightPanes(forced),
                widthChanged = this.UpdateAutoWidthPanes(forced);
            if(forced || heightChanged || widthChanged)
                this.rootPane.ForEach("UpdateChildrenSize");
        }
    },
    UpdateAutoHeightPanes: function(forced) {
        var changed = false;
        for(var i = 0; i < this.autoHeightPanes.length; i++)
            changed = this.autoHeightPanes[i].IsContentHeightChanged() || changed;
        if(forced || changed)
            this.UpdateAutoSizePanesSizes(false);
        return changed;
    },
    UpdateAutoWidthPanes: function(forced) {
        var changed = false;
        for(var i = 0; i < this.autoWidthPanes.length; i++)
            changed = this.autoWidthPanes[i].IsContentWidthChanged() || changed;
        if(forced || changed)
            this.UpdateAutoSizePanesSizes(true);
        return changed;
    },
    UpdateAutoSizePanesSizes: function(isVertical) {
        var autoSizePanes = isVertical
            ? this.autoWidthPanes
            : this.autoHeightPanes,
            property = isVertical ? "width" : "height",
            percentPanes = [];
        for(var i = 0; i < autoSizePanes.length; i++) {
            var pane = autoSizePanes[i];
            if(!pane.helper.HasCollapsedParent()) {
                pane.helper.ClearElementSizeProperty(property);
                for(var child = pane.panes[0]; child; child = child.nextPane)
                    if(!child.isSizePx) {
                        percentPanes.push(child);
                        child.helper.ClearElementSizeProperty(property);
                    }
            }
        }
        for(var i = 0; i < autoSizePanes.length; i++)
            autoSizePanes[i].UpdateOffsetSize(isVertical);
        for(var i = 0; i < autoSizePanes.length; i++) {
            var pane = autoSizePanes[i];
            if(!pane.helper.HasCollapsedParent())
                pane.helper.RestoreElementSizeProperty(property);
        }
        for(var i = 0; i < percentPanes.length; i++)
            percentPanes[i].helper.RestoreElementSizeProperty(property);
    },

    // Common
    UpdatePanesVisible: function(func) {
        var firstTD = this.rootPane.panes[0].helper.GetPaneElement();
        func(firstTD, "width", "1px");
        func(firstTD, "height", "1px");
        
        func(this.rootPane.panes[0].helper.GetContentContainerElement(), "display", "none");
        for(var i = 1; i < this.rootPane.panes.length; i++) {
            var pane = this.rootPane.panes[i];
            func(pane.helper.GetPaneElement(), "display", "none");
            var separator = pane.helper.GetSeparatorElement();
            if (separator)
                func(separator, "display", "none");
        }
    },
    SynchronizeProperties: function() {
        var clientStateElement = this.helper.GetClientStateElement();
        if(clientStateElement) {
            var stateString = this.GetClientStateString();
            this.helper.GetClientStateElement().value = stateString;
        
            if(this.cookieName && this.cookieName != "") {
                _aspxDelCookie(this.cookieName);
                _aspxSetCookie(this.cookieName, stateString);
            }
        }
    },
    GetPaneByPath: function(panePath, parentPane) {
        var pane = parentPane || this.rootPane;
        for(var i = 0; i < panePath.length; i++)
            pane = pane.panes[panePath[i]];
        return pane;
    },
    GetPaneByStringPath: function(paneStringPath, paneIndexSeparator) {
        if(!paneIndexSeparator)
            paneIndexSeparator = __aspxItemIndexSeparator;
        return this.GetPaneByPath(paneStringPath.split(paneIndexSeparator));
    },

    IsDocumentWidthChanged: function() {
        var documentWidth = this.GetDocumentWidth();
        if(!_aspxIsExists(this.lastDocumentWidth) || documentWidth != this.lastDocumentWidth) {
            this.lastDocumentWidth = documentWidth;
            return true;
        }
        return false;
    },

    GetDocumentWidth: function() {
        if(this.fullScreen && (this.rootPane.autoHeight || this.rootPane.autoWidth))
            return this.GetDocumentWidthFullscreen();
        return _aspxGetDocumentWidth();
    },
    
    GetDocumentWidthFullscreen: function() {
        var sizeElement = ASPxCacheHelper.GetCachedValue(this, "fullscreenWidthElement", function() {
            var element = _aspxCreateHtmlElementFromString("<div style='width: 100%; height: 0px'></div>");
            this.GetMainElement().parentNode.insertBefore(element, this.GetMainElement());
            return element;
        });
        return sizeElement.offsetWidth;
    },

    CreateWebkitSpecialElement: function() {
        var webkitSpecialElement = document.createElement("DIV"),
                element = this.GetMainElement();
            element.parentNode.appendChild(webkitSpecialElement);
            var offsetHeight = element.offsetHeight;
            element.parentNode.removeChild(webkitSpecialElement);
    },
        
    // Global events
    OnWindowResize: function() {
        this.UpdateControlSizes();
        this.lastDocumentWidth = this.GetDocumentWidth();
    },
    OnSeparatorMouseDown: function(moveRightPanePath) {
        var pane = this.GetPaneByStringPath(moveRightPanePath);
        var invert = this.rtl && !pane.isVertical;
        this.moveRightPane = invert ? pane.prevPane : pane;
        this.moveLeftPane = invert ? pane : pane.prevPane;        
        this.moveIsVertical = pane.isVertical;
        this.moveStartPos = this.helper.GetCurrentPos();
        this.moveLastPos = this.moveStartPos;
        this.isHeavyUpdate = this.moveLeftPane.isSizePx != this.moveRightPane.isSizePx
            && !this.moveLeftPane.parent.IsAutoSize();

        if(!ASPxSplitterHelper.IsAllowResize(this.moveLeftPane, this.moveRightPane))
            return false;
        
        if(this.moveLeftPane.collapsed || this.moveRightPane.collapsed)
            return false;
        
        if(this.RaiseCancelEvent("PaneResizing", this.moveRightPane) || this.RaiseCancelEvent("PaneResizing", this.moveLeftPane))
            return false;

        var cursor = this.moveIsVertical ? "n-resize" : "w-resize";
        if(!this.liveResizing) {
            this.resizingPointer.SetCursor(cursor);
            this.resizingPointer.AttachToElement(pane.helper.GetSeparatorElement(), true);
        }
        else
            this.isInLiveResizing = true;
        
        this.helper.SetResizingPanelVisibility(true, cursor);
        
        return true;
    },
    OnSeparatorMouseUp: function() {
        this.helper.SetResizingPanelVisibility(false);
    
        if(!this.liveResizing || !this.isHeavyUpdate) {
            var deltaSize = this.moveLastPos - this.moveStartPos;
            if(!this.moveLeftPane.IsAutoSize(!this.moveLeftPane.isVertical)) {
                this.moveLeftPane.SetOffsetSize(this.moveLeftPane.GetOffsetSize() - deltaSize);
                this.moveLeftPane.inResizing = true;
            }

            if(!this.moveRightPane.IsAutoSize(!this.moveRightPane.isVertical)) {
                this.moveRightPane.SetOffsetSize(this.moveRightPane.GetOffsetSize() + deltaSize);
                this.moveRightPane.inResizing = true;
            }
            if(!this.liveResizing || !this.hasAutoSizePane)
                ASPxSplitterHelper.Resize(this.moveLeftPane, this.moveRightPane, deltaSize);
            
            this.moveLeftPane.parent.ForEach("UpdateChildrenSize");
        }
        
        if(!this.liveResizing)
            this.resizingPointer.SetVisibility(false);
        else
            this.isInLiveResizing = null;
        this.UpdateAutoSizePanes(true);
        this.moveLeftPane.parent.ForEach("AdjustControls");
        if(!this.liveResizing && (this.rootPane.autoHeight || this.rootPane.autoWidth) && this.IsDocumentWidthChanged())
            this.UpdateControlSizes();

        this.moveLeftPane.inResizing = null;
        this.moveRightPane.inResizing = null;

        this.SynchronizeProperties();
        this.RaiseEvent("PaneResizeCompleted", this.moveLeftPane);
        this.RaiseEvent("PaneResizeCompleted", this.moveRightPane);
    },
    OnMouseMove: function() {    
        var deltaSize = this.helper.GetMoveMaxDeltaSize(this.helper.GetCurrentPos() - this.moveLastPos);
        if(deltaSize == 0) return;

        if(!this.moveLeftPane.IsAutoSize(!this.moveLeftPane.isVertical) || this.liveResizing)
            this.moveLeftPane.SetOffsetSize(this.moveLeftPane.GetOffsetSize() + deltaSize);
        if(!this.moveRightPane.IsAutoSize(!this.moveRightPane.isVertical) || this.liveResizing)
            this.moveRightPane.SetOffsetSize(this.moveRightPane.GetOffsetSize() - deltaSize);
        if(this.liveResizing) {
            var changePaneSize = function(pane, deltaSize) {
                pane.SetContentVisible(false);
                if(pane.ApplyElementSize()) {
                    pane.ForEach("UpdateChildrenSize");
                    pane.SetContentVisible(true);
                    pane.RaiseResizedEvent();
                }
            }
            if(this.isHeavyUpdate || this.moveLeftPane.parent.autoHeight || this.moveLeftPane.parent.autoWidth) {
                ASPxSplitterHelper.Resize(this.moveLeftPane, this.moveRightPane, this.moveLeftPane.isSizePx || this.moveRightPane.isSizePx ? deltaSize : 0);
                this.moveLeftPane.parent.ForEach("UpdateChildrenSize");
            }
            else {
                changePaneSize(this.moveLeftPane, deltaSize, this.helper);
                changePaneSize(this.moveRightPane, -deltaSize, this.helper);
            }
            this.UpdateAutoSizePanes(this.liveResizing);
        }
        else
            this.resizingPointer.Move(deltaSize, !this.moveIsVertical);
        this.moveLastPos += deltaSize;
    },
    OnCollapseButtonClick: function(panePath, forwardDirection) {
        var rightPane = this.GetPaneByStringPath(panePath);
        
        var pane1 = forwardDirection ? rightPane.prevPane : rightPane;
        var pane2 = forwardDirection ? rightPane : rightPane.prevPane;
        if(pane1.collapsed && pane1.maximizedPane == pane2) {
            if(!this.RaiseCancelEvent("PaneExpanding", pane1))
                pane1.Expand();
        }
        else {
            if(!this.RaiseCancelEvent("PaneCollapsing", pane2))
                pane2.Collapse(pane1);
        }
    },
    
    IsEmptyUrl: function(url) {
        for(var i = 0; i < this.emptyUrls.length; i++)
            if(url == this.emptyUrls[i])
                return true;
        return false;
    },
    
    // Events
    RaiseEvent: function(eventName, pane) {
        if(this.isInitialized)
            this[eventName].FireEvent(this, new ASPxClientSplitterPaneEventArgs(pane));
    },
    RaiseCancelEvent: function(eventName, pane) {
        var args = new ASPxClientSplitterPaneCancelEventArgs(pane);
        this[eventName].FireEvent(this, args);
        return args.cancel;
    },
    
    /*# public int GetPaneCount() { return 0; } #*/
    GetPaneCount: function() {
        return this.rootPane.GetPaneCount();
    },
    /*# public ASPxClientSplitterPane GetPane(int index) { return null; } #*/
    GetPane: function(index) {
        return this.rootPane.GetPane(index);
    },
    /*# public ASPxClientSplitterPane GetPaneByName(string name) { return null; } #*/
    GetPaneByName: function(name) {
        return this.rootPane.GetPaneByName(name);
    },
    /*# public void SetAllowResize(bool allowResize) { } #*/
    SetAllowResize: function(allowResize) {
        if(this.allowResize == allowResize)
            return;
        this.allowResize = allowResize;
        this.rootPane.ForEach("UpdateSeparatorStyle", true);
    },
    
    SetWidth: function(width) {
        this.width = width + "px";
        if(this.IsPrepared())
            this.UpdateControlSizes(true);
    },
    SetHeight: function(height) {
        this.height = height + "px";
        if(this.IsPrepared())
            this.UpdateControlSizes(true);
    }
});
/*# public static new ASPxClientSplitter Cast(object obj){ return null; } #*/
ASPxClientSplitter.Cast = ASPxClientControl.Cast;

/*# public class ASPxClientSplitterPane : JavaScriptObject #*/
ASPxClientSplitterPane = _aspxCreateClass(null, {
    // Constructor
    constructor: function(splitter, parent, visibleIndex, index, paneInfo) {
        this.splitter = splitter;
        this.parent = parent;
        /*# public int index { get { return 0; } } #*/
        this.index = visibleIndex;
        this._index = index;
        /*# public string name { get { return ""; } } #*/
        this.name = paneInfo.n || "";
                       
        this.isRootPane = (this.parent == null);
        this.helper = new ASPxSplitterPaneHelper(this);
    
        this.prevPane = null;
        this.nextPane = null;
        this.panes = [];
        this.isVertical = this.isRootPane ? false : !parent.isVertical;
        this.hasSeparator = (this.index > 0);
        
        this.collapsed = _aspxIsExists(paneInfo.c);
        this.size = _aspxIsExists(paneInfo.s) ? paneInfo.s : 0;
        this.sizeType = _aspxIsExists(paneInfo.st) ? paneInfo.st : null;
        this.autoWidth = _aspxIsExists(paneInfo.aw);
        this.autoHeight = _aspxIsExists(paneInfo.ah);
        this.maxSize = _aspxIsExists(paneInfo.smax) ? paneInfo.smax : Number.MAX_VALUE;
        this.minSize = _aspxIsExists(paneInfo.smin) ? paneInfo.smin : this.splitter.defaultMinSize;
        this.allowResize = !_aspxIsExists(paneInfo.nar);
        this.showCollapseBackwardButton = _aspxIsExists(paneInfo.scbb);
        this.showCollapseForwardButton = _aspxIsExists(paneInfo.scfb);
        
        this.iframe = {};
        if(paneInfo.iframe) {
            this.iframe = {
                src: paneInfo.iframe[0],
                scrolling: paneInfo.iframe[1]
            };
            if(paneInfo.iframe[2] != "")
                this.iframe.name = paneInfo.iframe[2];
            if(paneInfo.iframe[3] != "")
                this.iframe.title = paneInfo.iframe[3];
            this.isContentUrl = true;
        }
        
        this.scrollTop = paneInfo.spt || 0;
        this.scrollLeft = paneInfo.spl || 0;

        this.isSizePx = (this.sizeType == "px");
        
        this.maximizedPane = null;
        this.dragPrevented = false;
        this.offsetWidth = 0;
        this.offsetHeight = 0;
        this.widthDiff = 0;
        this.heightDiff = 0;
        this.minimizedWidthDiff = 0;
        this.minimizedHeightDiff = 0;
        this.contentContainerWidthDiff = 0;
        this.contentContainerHeightDiff = 0;
        
        this.isASPxClientSplitterPane = true;
    },
    
    // Creation
    UpdateSize: function() {
        if(!this.panes.length) return;
        
        var prcSum = 0,
            emptyPanesCount = 0;
        for(var pane = this.panes[0]; pane; pane = pane.nextPane) {
            if(!pane.sizeType)
                emptyPanesCount++;
            else if(pane.sizeType == "%")
                prcSum += pane.size;
        }

        if(emptyPanesCount) {
            var emptyPaneSize = Math.max(100 - prcSum, 0) / emptyPanesCount;
            for(var pane = this.panes[0]; pane; pane = pane.nextPane) {
                if(!pane.sizeType) {
                    pane.sizeType = "%";
                    pane.size = emptyPaneSize;
                }
            }
        }
        if(prcSum && (!emptyPanesCount && prcSum != 100 || prcSum > 100)) {
            for(var pane = this.panes[0]; pane; pane = pane.nextPane) {
                if(pane.sizeType == "%")
                    pane.size = 100 * pane.size / prcSum;
            }
        }
    },

    // Auto size
    UpdateAutoSize: function() {
        if(this.panes.length) {
            var propertyAll = this.isVertical ? "autoHeight" : "autoWidth",
                propertyOne = this.isVertical ? "autoWidth" : "autoHeight";
            if(this[propertyAll]) {
                for(var pane = this.panes[0]; pane; pane = pane.nextPane) {
                    pane[propertyAll] = true;
                }
            }
            if(this[propertyOne]) {
                var selected;
                for(var pane = this.panes[0]; pane; pane = pane.nextPane) {
                    if(pane[propertyOne] || !pane.isSizePx || pane.isSizePx && !selected && !pane.nextPane)
                        selected = pane;
                    if(pane[propertyOne])
                        break;
                }
                selected[propertyOne] = true;
            }

            for(var pane = this.panes[0]; pane; pane = pane.nextPane) {
                if(pane.isSizePx)
                    continue;
                if(pane[propertyOne]) {
                    pane.size = pane.GetMinSize();
                    pane.sizeType = "px";
                    pane.isSizePx = true;
                }
            }
        }
        if(!this.isRootPane) {
            if(this.autoHeight)
                this.splitter.autoHeightPanes.push(this);
            if(this.autoWidth)
                this.splitter.autoWidthPanes.push(this);
        }
    },
    IsAutoSize: function(isVertical) {
        if(isVertical == null)
            isVertical = this.isVertical;
        return isVertical ? this.autoWidth : this.autoHeight;
    },
    IsContentHeightChanged: function() {
        var contentHeight = this.helper.GetContentContainerElement().offsetHeight;

        if(!_aspxIsExists(this.lastContentHeight) || contentHeight != this.lastContentHeight) {
            this.lastContentHeight = contentHeight;
            return true;
        }
        return false;
    },

    IsContentWidthChanged: function() {
        var contentWidth = this.helper.GetContentContainerElement().offsetWidth;

        if(!_aspxIsExists(this.lastContentWidth) || contentWidth != this.lastContentWidth) {
            this.lastContentWidth = contentWidth;
            return true;
        }
        return false;
    },

    UpdateOffsetSize: function(isVertical) {
        var hasPanes = !!this.panes.length,
            contentContainerSizeDiff = hasPanes
                ? 0
                : isVertical
                    ? this.widthDiff
                    : this.heightDiff,
                contentSize = 0;
        if(this.isContentUrl && !hasPanes) {
            var element = this.helper.GetContentContainerElement();
            element.style.display = "none";
        }
        var contentSize = this.GetContentMinSize(isVertical);
        this.SetOffsetSize(Math.max(this.GetMinSize(!isVertical), contentSize), !isVertical);
        if(this.isContentUrl && !hasPanes) {
            element.style[isVertical ? "width" : "height"] = this.isVertical || isVertical
                ? "100%"
                : this.helper.GetPaneElement().offsetHeight - contentContainerSizeDiff + "px";
            element.style.display = "";
        }
    },

    GetContentMinSize: function(isVertical) {
        if(!this.panes.length) {
            var contentContainerElement = this.helper.GetContentContainerElement(),
                contentContainerSizeDiff = isVertical
                    ? this.widthDiff
                    : this.heightDiff;
            return (isVertical ? contentContainerElement.offsetWidth : contentContainerElement.offsetHeight) + contentContainerSizeDiff;
        }
        var contentSize = 0;
        if(this.isVertical != isVertical)
            for(var pane = this.panes[0]; pane; pane = pane.nextPane)
                contentSize = Math.max(contentSize, pane.GetContentMinSize(isVertical));
        else {
            for(var pane = this.panes[0]; pane; pane = pane.nextPane)
                contentSize += pane.GetContentMinSize(isVertical);
            contentSize += this.GetTotalSeparatorsSize(!this.isVertical);
        }
        return contentSize;
    },

    // Initialization
    Initialize: function() {
        this.InitializePreventDragging();
        
        if(this.isRootPane)
            return;
        if(this.collapsed) {
            if(this.IsFirstPane())
                this.maximizedPane = this.parent.panes[1];
            else if (this.prevPane.maximizedPane != this)
                this.maximizedPane = this.prevPane;
            else
                this.maximizedPane = this.nextPane;
            
            if (this.maximizedPane == null)
                this.collapsed = false;
        }
    },
    Prepare: function() {
        var EvaluateWidthDiff = function(element) {
            return element.offsetWidth - element.clientWidth;
        };
        var EvaluateHeightDiff = function(element) {
            var elementClientHeight = ((__aspxSafari && (__aspxBrowserVersion < 4)) || (__aspxChrome && (__aspxBrowserVersion < 2))) ? (element.offsetHeight - element.clientTop * 2) : element.clientHeight;
            return element.offsetHeight - elementClientHeight;
        };
        
        this.GetSeparatorSize();
        
        var element = this.helper.GetPaneElement();
        
        if(__aspxIE && __aspxBrowserMajorVersion == 9) { // B203253
            var b203253_TestWidth = EvaluateWidthDiff(element);
            if(b203253_TestWidth > 10000) { // We assume that nobody would like to get more than 10000px of width
                _aspxChangeStyleAttribute(document.body, "width", "1px");
                var b203253_BodyWidthChanged = true;
            }
        }

        this.widthDiff = EvaluateWidthDiff(element);
        this.heightDiff = EvaluateHeightDiff(element);
                
        if(this.panes.length == 0) {
             var contentContainerElement = this.helper.GetContentContainerElement();
            _aspxSetScrollBarVisibility(contentContainerElement, false);
            _aspxSetStyleSize(contentContainerElement, 1, 1);
            
            if(__aspxIE && __aspxBrowserMajorVersion < 7) // B195589
                contentContainerElement.style.overflow = "hidden";

            this.contentContainerWidthDiff = contentContainerElement.offsetWidth - 1;
            this.contentContainerHeightDiff = contentContainerElement.offsetHeight - 1;
            if(this.autoWidth) {
                contentContainerElement.style.width = "";
                contentContainerElement.style.minWidth = (this.splitter.defaultMinSize - this.contentContainerWidthDiff) + "px";
            }
            if(this.autoHeight) {
                contentContainerElement.style.height = "";
                contentContainerElement.style.minHeight = (this.splitter.defaultMinSize - this.contentContainerWidthDiff) + "px";
            }
            _aspxSetScrollBarVisibility(contentContainerElement, true);

            if(!this.scrollEventAttached) {
                var _this = this;
                _aspxAttachEventToElement(contentContainerElement, "scroll", function() {
                    if(contentContainerElement.scrollTop >= 0)
                        _this.scrollTop = contentContainerElement.scrollTop;
                    if(contentContainerElement.scrollLeft >= 0)
                        _this.scrollLeft = contentContainerElement.scrollLeft;
                    _this.splitter.SynchronizeProperties();
                });
                this.scrollEventAttached = true;
            }
        }

        this.UpdateStyle(element, true);
        this.collapsedWidthDiff = EvaluateWidthDiff(element);
        this.collapsedHeightDiff = EvaluateHeightDiff(element);
        this.UpdateStyle(element, false);

        if(__aspxIE && __aspxBrowserMajorVersion == 9 && b203253_BodyWidthChanged) // B203253
            _aspxRestoreStyleAttribute(document.body, "width");
                
        var separator = this.helper.GetSeparatorElement();
        if(separator) {
            _aspxSetElementDisplay(this.helper.GetSeparatorDivElement(), false);
            if(!this.isVertical)
                this.separatorSizeDiff = separator.offsetWidth - separator.clientWidth;
            else
                this.separatorSizeDiff = separator.offsetHeight - separator.clientHeight;
            _aspxSetElementDisplay(this.helper.GetSeparatorDivElement(), true);
        }
        else
            this.separatorSizeDiff = 0;
        
        this.PrepareSeparatorButtons();

        if(__aspxTouchUI) {
            var contentContainer = this.helper.GetContentContainerElement();
            var scrollbarVisible = contentContainer.style.overflow == "auto" || contentContainer.style.overflow == "scroll";
            var hScrollbarVisible = scrollbarVisible || contentContainer.style.overflowX == "scroll";
            var vScrollbarVisible = scrollbarVisible || contentContainer.style.overflowY == "scroll";
            if(hScrollbarVisible || vScrollbarVisible) {
                ASPxClientTouchUI.MakeScrollable(contentContainer, {showHorizontalScrollbar: hScrollbarVisible, showVerticalScrollbar: vScrollbarVisible});
            }
        }

        if(!this.isRootPane) {
            if(this.autoHeight)
                this.offsetHeight = this.GetMinSize(true);
            if(this.autoWidth)
                this.offsetWidth = this.GetMinSize(false);
        }
    },
    PrepareSeparatorButtons: function() {
        if(!(this.hasSeparator && this.helper.buttonsExists))
            return;
        
        var sizeProperty = this.isVertical ? "offsetWidth" : "offsetHeight";
        
        if(this.helper.buttonsTableExists) {
            this.collapseBackwardButtonSize = this.helper.GetButtonUpdateElement(this.helper.GetCollapseBackwardButton())[sizeProperty];
            this.collapseForwardButtonSize = this.helper.GetButtonUpdateElement(this.helper.GetCollapseForwardButton())[sizeProperty];
            
            this.buttonsTableDiffSize = this.helper.GetCollapseButtonsTable()[sizeProperty] - this.collapseBackwardButtonSize - this.collapseForwardButtonSize;
            
            if(this.helper.separatorImageExists) {
                this.collapseButtonsSeparatorSize = this.helper.GetButtonUpdateElement(this.helper.GetCollapseButtonsSeparator())[sizeProperty];
                this.buttonsTableDiffSize -= this.collapseButtonsSeparatorSize;
            }
        }
        else
            this.collapseButtonsSeparatorSize = this.helper.GetCollapseButtonsSeparatorImage()[sizeProperty];
    },
    InitializePreventDragging: function() {
        if(!this.dragPrevented && this.helper.separatorImageExists) {
            _aspxPreventElementDrag(this.helper.GetCollapseButtonsSeparatorImage());
            this.dragPrevented = true;
        }
    },
    ApplyScrollPosition: function() {
        if(this.panes.length == 0) {
            if(__aspxIE && __aspxBrowserMajorVersion < 8) {
                var _this = this;
                window.setTimeout(function() {
                    _this.SetScrollTop(_this.scrollTop);
                    _this.SetScrollLeft(_this.scrollLeft);
                }, 0);
            }
            else {
                this.SetScrollTop(this.scrollTop);
                this.SetScrollLeft(this.scrollLeft);
            }
        }
    },
    
    // Common
    ForEach: function(funcName, skippSelf) {
        if(!skippSelf)
            this[funcName]();
        for(var i = 0; i < this.panes.length; i++)
            this.panes[i].ForEach(funcName);
    },
    SetContentVisible: function(visible) {
        _aspxSetElementDisplay(this.helper.GetContentContainerElement(), visible);
        
        // This is a hack for "empty td"-"borders gone" IE problem
        // "empty-cells: show;" isn't supported by IE6/IE7
        if(__aspxIE)
            this.helper.SetEmptyDivVisible(!visible);
    },
        
    // Elements updating
    AdjustControls: function() {
        if(this.panes.length == 0 && !this.collapsed && !this.isContentUrl)
            aspxGetControlCollection().AdjustControls(this.helper.GetContentContainerElement(), false);
    },
    UpdatePanes: function(forceAutoSizeUpdate) {
        this.ForEach("UpdateChildrenSize");
        this.ForEach("UpdateVisualElements", true);
        this.splitter.UpdateAutoSizePanes(forceAutoSizeUpdate);
        
    },
    UpdateVisualElements: function() {
        this.UpdateButtonsVisibility();
        this.UpdateSeparatorStyle();
        this.UpdatePaneStyle();
    },
    IsBackwardButtonVisible: function() {
        return ASPxCacheHelper.GetCachedValue(this, "isBackwardButtonVisible", function() {
            if(!this.helper.buttonsTableExists)
                return false;
                
            if(this.collapsed && (this.maximizedPane == this.prevPane))
                return true;
            if(this.prevPane.collapsed)
                return false;
            return this.showCollapseBackwardButton;
        }, this.helper);
    },
    IsForwardButtonVisible: function() {
        return ASPxCacheHelper.GetCachedValue(this, "isForwardButtonVisible", function(){
            if(!this.helper.buttonsTableExists)
                return false;
                
            if(this.prevPane.collapsed && (this.prevPane.maximizedPane == this))
                return true;
            if(this.collapsed)
                return false;
            return this.showCollapseForwardButton;
        }, this.helper);
    },
    DropCachedButtonsVisible: function() {
        ASPxCacheHelper.DropCachedValue(this.helper, "isBackwardButtonVisible");
        ASPxCacheHelper.DropCachedValue(this.helper, "isForwardButtonVisible");
    },
    UpdateSeparatorStyle: function() {
        var separator = this.helper.GetSeparatorElement();
        if(!separator) return;
        
        var prevPane = this.prevPane,
            isCollapsed = this.collapsed || prevPane && prevPane.collapsed,
            resizingEnabled = ASPxSplitterHelper.IsAllowResize(this, prevPane);
        if(this.splitter.IsStateControllerEnabled())
            aspxGetStateController().SetMouseStateItemsEnabled(this.helper.GetSeparatorElementId(), null, !isCollapsed && resizingEnabled);

        this.UpdateStyle(separator, isCollapsed);
    },
    UpdatePaneStyle: function() {
        this.UpdateStyle(this.helper.GetPaneElement(), this.collapsed);
    },
    UpdateStyle: function(element, isSelect) {
        if(!this.splitter.IsStateControllerEnabled()) return;

        if(isSelect)
            aspxGetStateController().SelectElementBySrcElement(element);
        else
            aspxGetStateController().DeselectElementBySrcElement(element);
    },
    UpdateButtonsVisibility: function() {
        if(!(this.hasSeparator && this.helper.buttonsExists))
            return;
        
        var separatorSize = this.GetOffsetSize(!this.isVertical) - this.separatorSizeDiff;
        if(this.helper.buttonsTableExists) {
            var buttonsSize = this.buttonsTableDiffSize;
            if(this.IsBackwardButtonVisible())
                buttonsSize += this.collapseBackwardButtonSize;
            if(this.IsForwardButtonVisible())
                buttonsSize += this.collapseForwardButtonSize;
            
            var buttonsVisible = (buttonsSize <= separatorSize);
            var backwardButtonVisible = buttonsVisible && this.IsBackwardButtonVisible();
            var forwardButtonVisible = buttonsVisible && this.IsForwardButtonVisible();
            
            _aspxSetElementDisplay(this.helper.GetButtonUpdateElement(this.helper.GetCollapseBackwardButton()), backwardButtonVisible);
            _aspxSetElementDisplay(this.helper.GetButtonUpdateElement(this.helper.GetCollapseForwardButton()), forwardButtonVisible);
            
            if(this.helper.separatorImageExists) {
                if(!buttonsVisible)
                    buttonsSize = this.buttonsTableDiffSize;
                buttonsSize += this.collapseButtonsSeparatorSize;
                
                var separatorImageVisible = this.splitter.showSeparatorImage && (backwardButtonVisible === forwardButtonVisible) && (buttonsSize <= separatorSize);
                _aspxSetElementDisplay(this.helper.GetButtonUpdateElement(this.helper.GetCollapseButtonsSeparator()), separatorImageVisible);
            }
        }
        else {
            var separatorImageVisible = this.splitter.showSeparatorImage && (this.collapseButtonsSeparatorSize <= separatorSize);
            _aspxSetElementDisplay(this.helper.GetCollapseButtonsSeparatorImage(), separatorImageVisible);
        }
    },
    
    // Size evaluation common
    GetSeparatorSize: function() {
        return ASPxCacheHelper.GetCachedValue(this, "SeparatorSize", function() {
            var separator = this.helper.GetSeparatorElement();
            return separator ? (this.isVertical ? separator.offsetHeight : separator.offsetWidth) : 0;
        }, this.helper);
    },    
    GetTotalSeparatorsSize: function(isVertical) {
        if(!_aspxIsExists(isVertical) || (isVertical == this.isVertical))
            return 0;
        var cacheKey = (isVertical ? "v" : "h") + "TotalSeparatorsSize"; 
        return ASPxCacheHelper.GetCachedValue(this, cacheKey, function() {
            var result = 0;
            for(var i = 0; i < this.panes.length; i++)
                result += this.panes[i].GetSeparatorSize();
            return result;
        }, this.helper);
    },
    GetMinSize: function(isVertical) {
        if(!_aspxIsExists(isVertical))
            isVertical = this.isVertical;
        var cacheKey = (isVertical ? "v" : "h") + "ItemMinSize";
        return ASPxCacheHelper.GetCachedValue(this, cacheKey, function() {
            var result = 0;
            for(var i = 0; i < this.panes.length; i++)
                if(isVertical != this.isVertical)
                    result += this.panes[i].GetMinSize(isVertical);
                else
                    result = Math.max(result, this.panes[i].GetMinSize(isVertical));
            
            result += this.GetTotalSeparatorsSize(isVertical);
            
            var minSize = (isVertical == this.isVertical) ? this.minSize : this.splitter.defaultMinSize;
            result = Math.max(result, Math.max(minSize, this.GetSizeDiff(isVertical)));
            
            return result;
        }, this.helper);
    },
    DropCachedSizes: function() {
        ASPxCacheHelper.DropCachedValue(this.helper, "SeparatorSize");
        ASPxCacheHelper.DropCachedValue(this.helper, "vTotalSeparatorsSize");
        ASPxCacheHelper.DropCachedValue(this.helper, "hTotalSeparatorsSize");
        ASPxCacheHelper.DropCachedValue(this.helper, "ItemMinSize");
    },
    GetMaxSize: function() {
        return Math.max(this.maxSize, this.GetSizeDiff(this.isVertical));
    },
    
    // Size evaluation core
    PrepareUpdateInfo: function() {
        var updateInfo = {};
        
        var prepareUpdateInfoPart = function() {
            return {
                panes: [],
                sum: 0,
                sumMin: 0,
                sumMax: 0,
                addPane: function() {
                    this.panes.push(pane);
                    if(pane.collapsed) {
                        var sizeDiff = pane.GetSizeDiff(pane.isVertical);
                        this.sum += sizeDiff;
                        this.sumMin += sizeDiff;
                    }
                    else {
                        this.sum += pane.size;
                        this.sumMin += pane.GetMinSize();
                    }
                    this.sumMax += pane.GetMaxSize();
                },
                IsIgnoreMaxSize: function() {
                    return this.sumMax < this.sum;
                }
            };
        };
        
        updateInfo.px = prepareUpdateInfoPart();
        updateInfo.prc = prepareUpdateInfoPart();
        updateInfo.collapsed = prepareUpdateInfoPart();
        updateInfo.autoSize = prepareUpdateInfoPart();
        
        updateInfo.onlyPxPanes = true; // TODO: evaluate it once on page load
        updateInfo.hasPxPanesShown = false;
        updateInfo.hasPrcPanesShown = false;
        for(var i = 0; i < this.panes.length; i++) {
            var pane = this.panes[i];
            
            if(pane.collapsed)
                updateInfo.collapsed.addPane(pane);
            else if(pane.IsAutoSize(this.isVertical) && pane.GetOffsetSize()) {
                updateInfo.autoSize.addPane(pane)
            }
            else if(pane.isSizePx) {
                updateInfo.px.addPane(pane);
                updateInfo.hasPxPanesShown = true;
            }
            else {
                updateInfo.prc.addPane(pane);
                updateInfo.hasPrcPanesShown = true;
            }
                
            if(!pane.isSizePx)
                updateInfo.onlyPxPanes = false;
        }
        
        updateInfo.px.isIgnoreMaxSize = (!updateInfo.hasPrcPanesShown && (updateInfo.px.sumMax < updateInfo.px.sum));
        updateInfo.prc.isIgnoreMaxSize = (updateInfo.prc.sumMax < updateInfo.prc.sum);
        
        return updateInfo;
    },
    SetChildrenSecondSize: function() {
        var orientation = this.isVertical;
        var size = this.GetClientSize(orientation);
        if(this.isRootPane)
            for(var pane = this.panes[0]; pane; pane = pane.nextPane) {
                if(pane.IsAutoSize(!this.isVertical))
                    size = Math.max(size, pane.GetOffsetSize(this.isVertical));
            }
        for(var i = 0; i < this.panes.length; i++)
            this.panes[i].SetOffsetSize(size, orientation);
    },
    GetChildrenTotalSize: function() {
        return this.GetClientSize(!this.isVertical) - this.GetTotalSeparatorsSize(!this.isVertical);
    },
    UpdateChildrenSize: function() {
        if(this.collapsed || (this.panes.length == 0))
            return;

        var updateInfo = this.PrepareUpdateInfo();
        var childrenTotalSize = this.GetChildrenTotalSize();

        var asTotalSize = 0;
        for(var i = 0; i < updateInfo.autoSize.panes.length; i++) {
            var pane = updateInfo.autoSize.panes[i];
            pane.size = pane.GetOffsetSize();
            asTotalSize += pane.size;
        }
        if(!updateInfo.hasPxPanesShown && !updateInfo.hasPrcPanesShown) {
            var asMaxSize = childrenTotalSize - (updateInfo.px.sumMin + updateInfo.prc.sumMin + updateInfo.collapsed.sumMin);
            asTotalSize = this.NormalizePanesSizes(updateInfo.autoSize.panes, asTotalSize, asMaxSize);
        }
        else {
            var pxMaxSize = childrenTotalSize - (updateInfo.prc.sumMin + updateInfo.collapsed.sumMin) - asTotalSize,
                isOutOfParentSize = !!(pxMaxSize < 0 && updateInfo.autoSize.panes.length);
            if(isOutOfParentSize)
                pxMaxSize = updateInfo.px.sum;

            var pxTotalSize = 0;
            if(updateInfo.hasPxPanesShown) {
                var c = !updateInfo.hasPrcPanesShown && !isOutOfParentSize && !updateInfo.autoSize.panes.length
                    ? (pxMaxSize / (updateInfo.px.sum + updateInfo.autoSize.sum))
                    : 1;
                for(var i = 0; i < updateInfo.px.panes.length; i++) {
                    var pane = updateInfo.px.panes[i];
                    var newSize = pxMaxSize > 0
                        ? Math.max(Math.round(pane.size * c), pane.GetMinSize())
                        : pane.GetMinSize();
                    if(!updateInfo.px.isIgnoreMaxSize)
                        newSize = Math.min(newSize, pane.GetMaxSize());
                    pane.SetOffsetSize(newSize);
                    pxTotalSize += newSize;
                }
            
                if(pxMaxSize > 0 && (!updateInfo.hasPrcPanesShown || (pxTotalSize > pxMaxSize))) {
                    pxTotalSize = this.NormalizePanesSizes(updateInfo.autoSize.panes, pxTotalSize, pxMaxSize);
                    pxTotalSize = this.NormalizePanesSizes(updateInfo.px.panes, pxTotalSize, pxMaxSize);
                }
                if (updateInfo.onlyPxPanes && !(this.IsAutoSize(this.isVertical) && !updateInfo.autoSize.panes.length)) {
                    for(var i = 0; i < updateInfo.px.panes.length; i++) {
                        var pane = updateInfo.px.panes[i];
                        pane.size = pane.GetOffsetSize();
                    }
                }
            }
        
            var prcMaxSize = pxMaxSize - pxTotalSize + updateInfo.prc.sumMin;
            var prcTotalSize = 0;
            if((prcMaxSize > 0) && updateInfo.hasPrcPanesShown) {
                var c = 1 / updateInfo.prc.sum;
            
                for(var i = 0; i < updateInfo.prc.panes.length; i++) {
                    var pane = updateInfo.prc.panes[i];
                    var newSize = Math.max(Math.round(pane.size * c * (childrenTotalSize - pxTotalSize - asTotalSize)), pane.GetMinSize());
                    if(!updateInfo.prc.isIgnoreMaxSize)
                        newSize = Math.min(newSize, pane.GetMaxSize());
                    pane.SetOffsetSize(newSize);
                    prcTotalSize += newSize;
                }
            
                if(prcTotalSize != prcMaxSize)
                    prcTotalSize = this.NormalizePanesSizes(updateInfo.prc.panes, prcTotalSize, prcMaxSize);
            }
        }
        for(var i = 0; i < updateInfo.collapsed.panes.length; i++) {
            var pane = updateInfo.collapsed.panes[i],
                collapsedSize = pane.GetSizeDiff(pane.isVertical);
            pane.SetOffsetSize(collapsedSize);
        }
        if(__aspxWebKitFamily && updateInfo.collapsed.panes.length && this.IsAutoSize(this.IsVertical))
            this.splitter.CreateWebkitSpecialElement();
        this.SetChildrenSecondSize();
        
        for(var i = 0; i < this.panes.length; i++) {
            var pane = this.panes[i];
            if(pane.collapsed)
                pane.SetContentVisible(false);
            else
                pane.SetContentVisible(true);
            if(pane.ApplyElementSize())
                pane.RaiseResizedEvent();
        }
        
        this.ForEach("UpdateButtonsVisibility", true);
    },
    GetPossibleUp: function() {
        if(this.inResizing)
            return -1;
        return this.GetMaxSize() - this.GetOffsetSize();
    },
    GetPossibleDown: function() {
        if(this.IsAutoSize(!this.isVertical) && !(this.panes.length && !this.helper.HasVisibleAutoSizeChildren(!this.isVertical)))
            return -1;
        if(this.inResizing)
            return -1;
        return this.GetOffsetSize() - this.GetMinSize();
    },
    NormalizePanesSizes: function(panes, size, maxSize) {
        var insufficientSize = maxSize - size;
        var changeStep = (insufficientSize > 0) ? 1 : -1;
        var possibleChangeFunction = (insufficientSize > 0) ? "GetPossibleUp" : "GetPossibleDown";
        
        var changed = true;
        while((insufficientSize != 0) && changed) {
            changed = false;
            for(var i = 0; i < panes.length; i++) {
                var pane = panes[i];
                if(pane[possibleChangeFunction]() > 0) {
                    pane.SetOffsetSize(pane.GetOffsetSize() + changeStep);
                    insufficientSize -= changeStep;
                    changed = true;
                    
                    if(insufficientSize == 0)
                        break;
                }
            }
        }
        return maxSize - insufficientSize;
    },
    
    // Sizes
    GetOffsetSize: function(isVertical) {
        if(!_aspxIsExists(isVertical))
            isVertical = this.isVertical;
        return isVertical ? this.offsetHeight : this.offsetWidth;
    },
    GetClientSize: function(isVertical) {
        return isVertical ? this.GetClientHeightInternal(true) : this.GetClientWidthInternal(true);
    },
    SetOffsetSize: function(value, isVertical) {
        if(!_aspxIsExists(isVertical))
            isVertical = this.isVertical;
        if(isVertical)
            this.offsetHeight = value;
        else
            this.offsetWidth = value;
    },
    GetSizeDiff: function(isVertical) {
        return isVertical ? this.GetHeightDiff(true) : this.GetWidthDiff(true);
    },
    GetWidthDiff: function(isContainer) {
        if(this.collapsed)
            return this.collapsedWidthDiff;
        return this.widthDiff + (isContainer ? this.contentContainerWidthDiff : 0);
    },
    GetHeightDiff: function(isContainer) {
        if(this.collapsed)
            return this.collapsedHeightDiff;
        return this.heightDiff + (isContainer ? this.contentContainerHeightDiff : 0);
    },
    GetClientWidthInternal: function(isContainer) {
        if(__aspxFirefox && this.autoWidth)
            return this.offsetWidth;
        return this.offsetWidth - this.GetWidthDiff(isContainer);
    },
    GetClientHeightInternal: function(isContainer) {
        if(__aspxFirefox && this.autoHeight)
            return this.offsetHeight - (isContainer ? 0 : _aspxGetVerticalBordersWidth(this.GetElement()));
        return this.offsetHeight - this.GetHeightDiff(isContainer);
    },
    
    // Size updating
    ApplyElementSize: function() {
        if(this.IsSizeChanged()) {
            this.ApplyElementSizeCore();
            var contentContainerElement = this.helper.GetContentContainerElement();
            
            if(__aspxChrome && __aspxBrowserMajorVersion >= 3
                    || __aspxSafari && __aspxBrowserMajorVersion >= 5) {
                var marginRight = _aspxPxToInt(contentContainerElement.style.marginRight);
                marginRight -= _aspxPxToInt(_aspxGetCurrentStyle(contentContainerElement).marginRight);
                contentContainerElement.style.marginRight = marginRight + "px";
            }
            
            if(__aspxWebKitFamily) {
                this.splitter.CreateWebkitSpecialElement(); //Q424762
                var updated = _aspxSetScrollBarVisibilityCore(contentContainerElement, "overflowY", this.GetClientWidthInternal(true) > _aspxGetVerticalScrollBarWidth());
                if(updated && this.isContentUrl)
                    this.RefreshContentUrl();
            }
                
            return true;
        }
        return false;
    },
    ApplyElementSizeCore: function() {
        var paneWidth = this.GetClientWidthInternal(false);
        var paneHeight = this.GetClientHeightInternal(false);
        var contentContainerWidth = this.GetClientWidthInternal(true);
        var contentContainerHeight = this.GetClientHeightInternal(true);
        if(contentContainerWidth < 0) {
            paneWidth -= contentContainerWidth;
            contentContainerWidth = 0;
        }
        if(contentContainerHeight < 0) {
            paneHeight -= contentContainerHeight;
            contentContainerHeight = 0;
        }
        
        var paneElement = this.helper.GetPaneElement(),
            contentContainerElement = this.helper.GetContentContainerElement();
        if(!(paneWidth === 0 && !this.collapsed))
            paneElement.style.width = paneWidth + "px";
        if(!(paneHeight === 0 && !this.collapsed))
            paneElement.style.height = paneHeight + "px";
        if(!this.autoWidth)
            contentContainerElement.style.width = contentContainerWidth + "px";
        if(!this.autoHeight)
            contentContainerElement.style.height = contentContainerHeight + "px";
    },
    IsSizeChanged: function() {
        if(!_aspxIsExists(this.lastWidth) || !_aspxIsExists(this.lastHeight) ||
            (this.offsetWidth != this.lastWidth) || (this.offsetHeight != this.lastHeight)) {
            this.lastWidth = this.offsetWidth;
            this.lastHeight = this.offsetHeight;
            return true;
        }
        return false;
    },
    
    // Client-side API
    
    /*# public ASPxClientSplitter GetSplitter() { return null; } #*/
    GetSplitter: function() {
        return this.splitter;
    },
        
    /*# public ASPxClientSplitterPane GetParentPane() { return null; } #*/
    GetParentPane: function() {
        return this.parent;
    },
    /*# public ASPxClientSplitterPane GetPrevPane() { return null; } #*/
    GetPrevPane: function() {
        return this.prevPane;
    },
    /*# public ASPxClientSplitterPane GetNextPane() { return null; } #*/
    GetNextPane: function() {
        return this.nextPane;
    },
        
    /*# public bool IsFirstPane() { return false; } #*/
    IsFirstPane: function() {
        return (this.prevPane == null);
    },
    /*# public bool IsLastPane() { return false; } #*/
    IsLastPane: function() {
        return (this.nextPane == null);
    },
    
    /*# public bool IsVertical() { return false; } #*/
    IsVertical: function() {
        return this.isVertical;
    },
    
    /*# public int GetPaneCount() { return 0; } #*/
    GetPaneCount: function() {
        return this.panes.length;
    },
    /*# public ASPxClientSplitterPane GetPane(int index) { return null; } #*/
    GetPane: function(index) {
        return (0 <= index && index < this.panes.length) ? this.panes[index] : null;
    },
    /*# public ASPxClientSplitterPane GetPaneByName(string name) { return null; } #*/
    GetPaneByName: function(name) {
        for(var i = 0; i < this.panes.length; i++)
            if(this.panes[i].name == name) return this.panes[i];
        for(var i = 0; i < this.panes.length; i++) {
            var pane = this.panes[i].GetPaneByName(name);
            if(pane != null) return pane;
        }
        return null;
    },
    
    /*# public int GetClientWidth() { return 0; } #*/
    GetClientWidth: function() {
        var clientWidth = this.GetClientWidthInternal(true);
        if(!this.IsContentUrlPane()){
            var contentContainer = this.helper.GetContentContainerElement();
            if((contentContainer.style.overflow == "auto" && contentContainer.scrollHeight > contentContainer.clientHeight) 
                    || contentContainer.style.overflow == "scroll"
                    || contentContainer.style.overflowY == "scroll"){
                clientWidth = clientWidth - _aspxGetVerticalScrollBarWidth();
            }
        }
        return clientWidth;
    },
    /*# public int GetClientHeight() { return 0; } #*/
    GetClientHeight: function() {
        return this.GetClientHeightInternal(true);
    },
    
    /*# public bool Collapse(ASPxClientSplitterPane maximizedPane) { return false; } #*/
    Collapse: function(maximizedPane) {
        if(!this.splitter.IsPrepared())
            return false;
        if(this.collapsed)
            return false;
        if(!_aspxIsExists(maximizedPane) || !maximizedPane.isASPxClientSplitterPane)
            return false;
        
        return this.CollapseExpandCore(true, maximizedPane, "PaneCollapsed");
    },
    /*# public bool CollapseForward() { return false; } #*/
    CollapseForward: function() {
        return this.Collapse(this.nextPane);
    },
    /*# public bool CollapseBackward() { return false; } #*/
    CollapseBackward: function() {
        return this.Collapse(this.prevPane);
    },
    /*# public bool Expand() { return false; } #*/
    Expand: function() {
        if(!this.splitter.IsPrepared())
            return false;
        if(!this.collapsed)
            return false;
        
        return this.CollapseExpandCore(false, null, "PaneExpanded");
    },
    CollapseExpandCore: function(collapsed, maximizedPane, eventName) {
        this.collapsed = collapsed;
        this.maximizedPane = maximizedPane;
        
        this.DropCachedButtonsVisible();
        if(this.nextPane != null)
            this.nextPane.DropCachedButtonsVisible();
        this.GetParentPane().UpdatePanes(!collapsed);
        this.GetParentPane().ForEach("AdjustControls");
        
        this.splitter.RaiseEvent(eventName, this);

        this.splitter.SynchronizeProperties();
        
        return true;
    },
    /*# public bool IsCollapsed() { return false; } #*/
    IsCollapsed: function() {
        return this.collapsed;
    },
    
    /*# public bool IsContentUrlPane() { return false; } #*/
    IsContentUrlPane: function() {
        return this.isContentUrl;
    },
    /*# public string GetContentUrl() { return ""; } #*/
    GetContentUrl: function() {
        return this.isContentUrl
            ? this.iframeObj.GetContentUrl()
            : "";
    },
    /*# public void SetContentUrl(string url) { } #*/
    /*# public void SetContentUrl(string url, bool preventBrowserCaching) { } #*/
    SetContentUrl: function(url, preventBrowserCaching) {
        if(!this.isContentUrl)
            return;
        this.iframeObj.SetContentUrl(url, preventBrowserCaching);
    },
    /*# public void RefreshContentUrl() { } #*/
    RefreshContentUrl: function() {
        if(!this.isContentUrl)
            return;
        this.iframeObj.RefreshContentUrl();
    },
    /*# public object GetContentIFrame() { return null; } #*/
    GetContentIFrame: function() {
        return this.isContentUrl
            ? this.helper.GetContentContainerElement()
            : null;
    },
    CreateContentUrlIFrame: function() {
        if(!this.isContentUrl)
            return;
        
        var contentContainer = this.helper.GetContentContainerElement();
        contentContainer.parentNode.removeChild(contentContainer);
        
        var instance = this;
        this.iframeObj = new ASPxIFrame({
            id: contentContainer.id,
            name: this.iframe.name,
            title: this.iframe.title,
            scrolling: this.iframe.scrolling,
            src: this.iframe.src,
            onCreate: function(containerElement, element) {
                instance.helper.GetPaneElement().appendChild(containerElement);
                instance.helper.DropContentContainerElementFromCache();
                instance.ApplyElementSizeCore();
                if(instance.autoHeight && instance.isVertical)
                    containerElement.style.height = "100%";
            },
            onLoad: function() {
                instance.splitter.RaiseEvent("PaneContentUrlLoaded", instance);
            }
        });
    },

    /*# public void SetAllowResize(bool allowResize) { } #*/
    SetAllowResize: function(allowResize) {
        this.allowResize = allowResize;
        this.UpdateSeparatorStyle();
        if(!this.IsLastPane())
            this.nextPane.UpdateSeparatorStyle();
    },
    
    /*# public void RaiseResizedEvent() { } #*/
    RaiseResizedEvent: function() {
        this.splitter.RaiseEvent("PaneResized", this);
    },
    
    /*# public object GetElement() { return null; } #*/
    GetElement: function() {
        return this.helper.GetPaneElement();
    },

    /*# public void SetSize(int size) { } #*/
    /*# public void SetSize(string size) { } #*/
    SetSize: function(size) {
        if(!this.splitter.IsPrepared())
            return;
        if(this.SetSizeCore(size)) {
            this.parent.ForEach("UpdateChildrenSize");
            this.splitter.UpdateAutoSizePanes();
            this.parent.ForEach("AdjustControls");

            this.splitter.SynchronizeProperties();
        }
    },
    
    /*# public string GetSize() { return ""; } #*/
    GetSize: function() {
        return this.size + this.sizeType;
    },
    
    SetSizeCore: function(size) {
        if(!_aspxIsExists(size))
            return false;
        if(this.IsAutoSize(!this.isVertical))
            return false;
        if(typeof(size) == "string") {
            var parsedSize = parseInt(size);
            if(isNaN(parsedSize))
                return false;
            
            this.size = parsedSize;
            this.sizeType = (size.indexOf("%") > -1) ? "%" : "px";
        }
        else if(typeof(size) == "number") {
            this.size = size;
            this.sizeType = "px";
        }
        else
            return false;
        this.isSizePx = this.sizeType == "px";
        return true;
    },

    /*# public int GetScrollTop() { return 0; } #*/
    GetScrollTop: function() {
        return this.scrollTop;
    },
    /*# public void SetScrollTop(int value) { } #*/
    SetScrollTop: function(value) {
        this.helper.GetContentContainerElement().scrollTop = value;
    },
    /*# public int GetScrollLeft() { return 0; } #*/
    GetScrollLeft: function() {
        return this.scrollLeft;
    },
    /*# public void SetScrollLeft(int value) { } #*/
    SetScrollLeft: function(value) {
        this.helper.GetContentContainerElement().scrollLeft = value;
    }
});

ASPxClientSplitter.Instances = {
    items: {},
    Add: function(instance) {
        this.items[instance.name] = instance;
        if(instance.hasAutoSizePane)
            ASPxClientSplitter.AutoSizePanesUpdater.Start();
    },
    Get: function(name) {
        var instance = this.items[name];
        if(instance) {
            if(instance.GetMainElement())
                return instance;
            delete this.items[name];
        }
        return null;
    },
    Each: function(cb) {
        var hasInstances = false;
        for(var name in this.items) {
            var instance = this.Get(name);
            if(instance) {
                hasInstances = true;
                cb.call(instance);
            }
        }
        return hasInstances;
    }
};
ASPxClientSplitter.AutoSizePanesUpdater = {
    timeoutId: -1,
    Start: function() {
        var updater = ASPxClientSplitter.AutoSizePanesUpdater;
        if(updater.timeoutId > -1)
            return;
        updater.timeoutId = _aspxSetTimeout(updater.OnTimeout, 300);
    },
    Stop: function() {
        var updater = ASPxClientSplitter.AutoSizePanesUpdater;
        updater.timeoutId = _aspxClearTimer(updater.timeoutId);
    },
    OnTimeout: function() {
        var updater = ASPxClientSplitter.AutoSizePanesUpdater;
        updater.Stop();
        if(ASPxClientSplitter.Instances.Each(function() {
            this.UpdateAutoSizePanes();
            if(!this.isInLiveResizing && this.hasAutoSizePane && this.IsDocumentWidthChanged())
                this.UpdateControlSizes();
        }))
        updater.Start();
    }
};
ASPxClientSplitter.timerInterval = 0;
ASPxClientSplitter.GetRegEx = function(idPostfix) {
    if(!this.regExs)
        this.regExs = {};
    if(!this.regExs[idPostfix])
        this.regExs[idPostfix] = "_\\d+(" + __aspxItemIndexSeparator + "\\d+)*_" + idPostfix + "$";
    return this.regExs[idPostfix];
};

ASPxClientSplitter.IsActualWindowResize = function() {
    var width = _aspxGetDocumentClientWidth();
    var height = _aspxGetDocumentClientHeight();
    if(width != ASPxClientSplitter.lastWindowResizeWidth || height != ASPxClientSplitter.lastWindowResizeHeight) {
        ASPxClientSplitter.lastWindowResizeWidth = width;
        ASPxClientSplitter.lastWindowResizeHeight = height;
        return true;
    }
    return false;
};
ASPxClientSplitter.SuspendedWindowResizeCore = function() {
    ASPxClientSplitter.Instances.Each(function() { this.OnWindowResize(); });
};
ASPxClientSplitter.mainWindowResizeTimeout = -1;
ASPxClientSplitter.additionalWindowResizeTimeout = -1;
ASPxClientSplitter.MainSuspendedWindowResize = function() {
    ASPxClientSplitter.SuspendedWindowResizeCore();
    ASPxClientSplitter.mainWindowResizeTimeout = _aspxClearTimer(ASPxClientSplitter.mainWindowResizeTimeout);
};
ASPxClientSplitter.AdditionalSuspendedWindowResize = function() {
    ASPxClientSplitter.SuspendedWindowResizeCore();
    ASPxClientSplitter.additionalWindowResizeTimeout = _aspxClearTimer(ASPxClientSplitter.additionalWindowResizeTimeout);
};
ASPxClientSplitter.OnWindowResize = function() {
    if(!ASPxClientSplitter.IsActualWindowResize())
        return;
    if(ASPxClientSplitter.additionalWindowResizeTimeout != -1)
        ASPxClientSplitter.additionalWindowResizeTimeout = _aspxClearTimer(ASPxClientSplitter.additionalWindowResizeTimeout);
    if(ASPxClientSplitter.mainWindowResizeTimeout == -1)
        ASPxClientSplitter.mainWindowResizeTimeout = _aspxSetTimeout(ASPxClientSplitter.MainSuspendedWindowResize, ASPxClientSplitter.timerInterval);
    else
        ASPxClientSplitter.additionalWindowResizeTimeout = _aspxSetTimeout(ASPxClientSplitter.AdditionalSuspendedWindowResize, 100);
};
ASPxClientSplitter.SaveCurrentPos = function(evt) {
    evt = _aspxGetEvent(evt);
    ASPxClientSplitter.CurrentXPos = _aspxGetEventX(evt);
    ASPxClientSplitter.CurrentYPos = _aspxGetEventY(evt);
};
ASPxClientSplitter.FindParentCell = function(element) {
    if(element.tagName != "TD") 
        element = _aspxGetParentByTagName(element, "TD");
    return element;
};
ASPxClientSplitter.FindSplitterInfo = function(evt, regex, suffixLength) {
    var element = ASPxClientSplitter.FindParentCell(_aspxGetEventSource(evt));
    if(element) {
        var matchResult = element.id.match(regex);
        
        if(matchResult) {
            var name = element.id.substring(0, matchResult.index);
            var splitter = ASPxClientSplitter.Instances.Get(name);
            if(splitter != null) {
                var panePath = element.id.substring(matchResult.index + 1, element.id.length - suffixLength);
                return { "splitter" : splitter, "panePath" : panePath };
            }
        }        
    }
    return null;
};
ASPxClientSplitter.OnMouseClick = function(evt) {
    var info = ASPxClientSplitter.FindSplitterInfo(evt, ASPxClientSplitter.GetRegEx("S_CF"), 5);
    if(info) {
        if(info.splitter.enabled)
            info.splitter.OnCollapseButtonClick(info.panePath, true);
    }
    else {
        info = ASPxClientSplitter.FindSplitterInfo(evt, ASPxClientSplitter.GetRegEx("S_CB"), 5);
        if(info && info.splitter.enabled)
            info.splitter.OnCollapseButtonClick(info.panePath, false);
    }    
};
ASPxClientSplitter.OnMouseDown = function(evt) {
    var info = ASPxClientSplitter.FindSplitterInfo(evt, ASPxClientSplitter.GetRegEx("S"), 2);
    if(!info) 
        info = ASPxClientSplitter.FindSplitterInfo(evt, ASPxClientSplitter.GetRegEx("S_CS"), 5);
    if(info && info.splitter) {
        _aspxSetElementSelectionEnabled(document.body, false);
        ASPxClientSplitter.current = info.splitter;
        ASPxClientSplitter.SaveCurrentPos(evt);
        ASPxClientSplitter.isInMove = info.splitter.OnSeparatorMouseDown(info.panePath);
    }
};
ASPxClientSplitter.OnMouseUp = function() {
    if(ASPxClientSplitter.isInMove) {
        ASPxClientSplitter.isInMove = false;
        _aspxSetElementSelectionEnabled(document.body, true);
        ASPxClientSplitter.current.OnSeparatorMouseUp();
    }
};
ASPxClientSplitter.mouseMoveTimeoutId = -1;
ASPxClientSplitter.SuspendedMouseMove = function() {
    if(ASPxClientSplitter.isInMove)
        ASPxClientSplitter.current.OnMouseMove();
    ASPxClientSplitter.mouseMoveTimeoutId = _aspxClearTimer(ASPxClientSplitter.mouseMoveTimeoutId);
};
ASPxClientSplitter.OnMouseMove = function(evt) {
    if(__aspxTouchUI && ASPxClientTouchUI.isGesture)
        return;
    if(!ASPxClientSplitter.isInMove)
        return;
    if(__aspxIE && !_aspxGetIsLeftButtonPressed(evt)) {
        ASPxClientSplitter.OnMouseUp(evt);
        return;
    }
    ASPxClientSplitter.SaveCurrentPos(evt);
    if(ASPxClientSplitter.mouseMoveTimeoutId == -1)
        ASPxClientSplitter.mouseMoveTimeoutId = _aspxSetTimeout(ASPxClientSplitter.SuspendedMouseMove, ASPxClientSplitter.timerInterval);
    if(__aspxTouchUI)
        evt.preventDefault();
};
_aspxAttachEventToElement(window, "resize", ASPxClientSplitter.OnWindowResize);
_aspxAttachEventToDocument("click", ASPxClientSplitter.OnMouseClick);
_aspxAttachEventToDocument(ASPxClientTouchUI.touchMouseDownEventName, ASPxClientSplitter.OnMouseDown);
_aspxAttachEventToDocument(ASPxClientTouchUI.touchMouseUpEventName, ASPxClientSplitter.OnMouseUp);
_aspxAttachEventToDocument(ASPxClientTouchUI.touchMouseMoveEventName, ASPxClientSplitter.OnMouseMove);

/*# public delegate void ASPxClientSplitterPaneEventHandler(object source, ASPxClientSplitterPaneEventArgs e);#*/
/*# public class ASPxClientSplitterPaneEventArgs : ASPxClientEventArgs #*/
ASPxClientSplitterPaneEventArgs = _aspxCreateClass(ASPxClientEventArgs, {
    /*# public ASPxClientSplitterPaneEventArgs(ASPxClientSplitterPane pane) : base() {} #*/
    constructor: function(pane) {
        this.constructor.prototype.constructor.call(this, pane);
        /*# public ASPxClientSplitterPane pane { get { return null; } } #*/
        this.pane = pane;
    }
});

/*# public delegate void ASPxClientSplitterPaneCancelEventHandler(object source, ASPxClientSplitterPaneCancelEventArgs e);#*/
/*# public class ASPxClientSplitterPaneCancelEventArgs : ASPxClientSplitterPaneEventArgs #*/
ASPxClientSplitterPaneCancelEventArgs = _aspxCreateClass(ASPxClientSplitterPaneEventArgs, {
    /*# public ASPxClientSplitterPaneCancelEventArgs(ASPxClientSplitterPane pane) : base(pane) {} #*/
    constructor: function(pane) {
        this.constructor.prototype.constructor.call(this, pane);
        /*# public bool cancel { get { return false; } set {} } #*/
        this.cancel = false;
    }
});
ASPxClientButton = _aspxCreateClass(ASPxClientControl, {
 constructor: function(name) {
  this.constructor.prototype.constructor.call(this, name);
  this.isASPxClientButton = true;
  this.allowFocus = true;
  this.autoPostBackFunction = null;
  this.causesValidation = true;
  this.checked = false;
  this.clickLocked = false;
  this.groupName = "";
  this.focusElementSelected = false;
  this.pressed = false;
  this.useSubmitBehavior = true;
  this.validationGroup = "";
  this.validationContainerID = null;
  this.validateInvisibleEditors = false;
  this.buttonCell = null;
  this.contentDiv = null;
  this.checkedInput = null;
  this.buttonImage = null;
  this.internalButton = null;
  this.textElement = null; 
  this.textControl = null;
  this.textContainer = null;
  this.isTextEmpty = false;
  this.CheckedChanged = new ASPxClientEvent();
  this.GotFocus = new ASPxClientEvent();
  this.LostFocus = new ASPxClientEvent();
  this.Click = new ASPxClientEvent();
 },
 InlineInitialize: function() {
  this.InitializeEvents();
  this.InitializeEnabled();
  this.InitializeChecked();
  this.PreventButtonImageDragging();
 },
 InitializeEnabled: function(){
  this.SetEnabledInternal(this.clientEnabled, true);
 },
 InitializeChecked: function(){
  this.SetCheckedInternal(this.checked, true);
 },
 InitializeEvents: function(){
  if (!this.isNative) {
   var element = this.GetInternalButton();
   if(element)
    element.onfocus = null;
   var textControl = this.GetTextControl();
   if (textControl) {
    if (__aspxIE)
     _aspxAttachEventToElement(textControl, "mouseup", _aspxClearSelection);
    _aspxPreventElementDragAndSelect(textControl, false);
   }    
  }
  var name = this.name;
  this.onClick = function() {
   var processOnServer = aspxBClick(name);
   if (!processOnServer) {
    var evt = _aspxGetEvent(arguments[0]);
    if (evt)
     _aspxPreventEvent(evt);
   }
   return processOnServer;
  };
  this.onGotFocus = function() { aspxBGotFocus(name); };
  this.onLostFocus = function() { aspxBLostFocus(name); };
  this.onKeyUp = function(evt) { aspxBKeyUp(evt, name); };
  this.onKeyDown = function(evt) { aspxBKeyDown(evt, name); }; 
  if(!this.isNative) {
   this.AttachNativeHandlerToMainElement("focus", "SetFocus");
   this.AttachNativeHandlerToMainElement("click", "DoClick");
  }
 },
 PreventButtonImageDragging: function() {
  var image = this.GetButtonImage();
  if(image) {
   if(__aspxNetscapeFamily)
    image.onmousedown = function(evt) {
     evt.cancelBubble = true;
     return false;
    };
   else
    image.ondragstart = function() {
     return false;
    };
  }
 },
 AttachNativeHandlerToMainElement: function(handlerName, correspondingMethodName) {
  var mainElement = this.GetMainElement();
  if (!_aspxIsExistsElement(mainElement))
   return;
  mainElement[handlerName] = Function("_aspxBCallButtonMethod('" + this.name + "', '" + correspondingMethodName + "')");
 },
 GetContentDiv: function(){
  if(!_aspxIsExistsElement(this.contentDiv))
   this.contentDiv = this.GetChild("_CD");
  return this.contentDiv;
 },       
 GetButtonCell: function(){
  if(!_aspxIsExistsElement(this.buttonCell))
   this.buttonCell = this.GetChild("_B");
  return this.buttonCell;
 },   
 GetButtonCheckedInput: function(){
  if(!_aspxIsExistsElement(this.checkedInput))
   this.checkedInput = _aspxGetElementById(this.name + "_CH");
  return this.checkedInput;
 },  
 GetButtonImage: function(){
  if(!_aspxIsExistsElement(this.buttonImage))
   this.buttonImage = _aspxGetChildByTagName(this.GetButtonCell(), "IMG", 0);
  return this.buttonImage;
 },
 GetInternalButton: function() {
  if(!_aspxIsExistsElement(this.internalButton))
   this.internalButton = this.isNative ? this.GetMainElement() : _aspxGetChildByTagName(this.GetMainElement(), "INPUT", 0);
  return this.internalButton;
 },
 GetTextContainer: function() {
  if (!this.textContainer) {
   var textElement = this.GetTextElement();
   this.textContainer = _aspxGetChildByTagName(textElement, "SPAN", 0);
  }
  return this.textContainer;
 },
 GetTextElement: function(){
  if(!_aspxIsExistsElement(this.textElement)){
   var contentDiv = this.GetContentDiv();
   if (this.GetButtonImage() == null) 
    this.textElement = contentDiv;
   else {
    this.textElement = _aspxGetChildByTagName(contentDiv, "TD", 0);
    var img = _aspxGetChildByTagName(this.textElement, "IMG", 0);
    if (img)
     this.textElement = _aspxGetChildByTagName(contentDiv, "TD", 1);
   }
  }
  return this.textElement;
 }, 
 GetTextControl: function(){
  if(!_aspxIsExistsElement(this.textControl))
   this.textControl = _aspxGetParentByTagName(this.GetTextElement(), "table");
  if (!_aspxIsExistsElement(this.textControl) || (this.textControl.id == this.name))
   this.textControl = this.GetTextElement();
  return this.textControl;
 },
 GetPostfixes: function(){
  return this.isNative ? [""] : ["_B"];
 },
 IsHovered: function(){
  var hoverElement = this.isNative ? this.GetMainElement() : this.GetButtonCell();
  return aspxGetStateController().currentHoverItemName == hoverElement.id;
 },   
 SetEnabledInternal: function(enabled, initialization) {
  if(!this.enabled)
   return;
  if(!initialization || !enabled)
   this.ChangeEnabledStateItems(enabled);
  this.ChangeEnabledAttributes(enabled);
 },
 ChangeEnabledAttributes: function(enabled) {
  if(this.isNative)
   this.GetMainElement().disabled = !enabled;
  else {
   var element = this.GetInternalButton();
   if(element)
    element.disabled = !enabled;
  }
  this.ChangeEnabledEventsAttributes(_aspxChangeEventsMethod(enabled));
 },
 ChangeEnabledEventsAttributes: function(method) {
  var element = this.GetMainElement();
  method(element, "click", this.onClick);
  if (this.allowFocus){
   if (!this.isNative) 
    element = this.GetInternalButton();
   if(element) {
    method(element, "focus", this.onGotFocus);
    method(element, "blur", this.onLostFocus);
    if (!this.isNative){
     method(element, "keyup", this.onKeyUp);
     method(element, "blur", this.onKeyUp);
     method(element, "keydown", this.onKeyDown);
    }
   }
  }
 },
 ChangeEnabledStateItems: function(enabled){
  if(!this.isNative){
   aspxGetStateController().SetElementEnabled(this.GetButtonCell(), enabled);
   this.UpdateFocusedStyle();
  }
 },
 RequiredPreventDoublePostback: function(){
  return __aspxFirefox && !this.isNative; 
 },
 OnFocus: function() {
  if(!this.allowFocus)
   return false;
  this.focused = true;
  if(this.isInitialized)
   this.RaiseFocus();
  this.UpdateFocusedStyle();
 },  
 OnLostFocus: function() {
  if(!this.allowFocus)
   return false;
  this.focused = false;
  if(this.isInitialized)
   this.RaiseLostFocus();
  this.UpdateFocusedStyle();
 },
 CauseValidation: function() {
  if (this.causesValidation && typeof(ASPxClientEdit) != "undefined")
   return this.validationContainerID != null ?
    ASPxClientEdit.ValidateEditorsInContainerById(this.validationContainerID, this.validationGroup, this.validateInvisibleEditors) :
    ASPxClientEdit.ValidateGroup(this.validationGroup, this.validateInvisibleEditors);
  else
   return true;
 },
 OnClick: function() {
  if(this.clickLocked)
   return true;
  else if(this.checked && this.groupName != "" && this.GetCheckedGroupList().length > 1)
   return;
  this.SetFocus();
  var isValid = this.CauseValidation();
  var processOnServer = this.autoPostBack;
  if (this.groupName != "") {
   if(this.GetCheckedGroupList().length == 1)
    this.SetCheckedInternal(!this.checked, false);
   else {
    this.SetCheckedInternal(true, false);
    this.ClearButtonGroupChecked(true);
   }
   processOnServer = this.RaiseCheckedChanged();
   if (processOnServer && isValid)
    this.SendPostBack("CheckedChanged");
  }
  processOnServer = this.RaiseClick();
  if (processOnServer && isValid){
   var requiredPreventDoublePostback = this.RequiredPreventDoublePostback();
   var postponePostback = __aspxAndroidMobilePlatform; 
   if(requiredPreventDoublePostback || postponePostback)
    _aspxSetTimeout("_aspxBCallButtonMethod(\"" + this.name + "\", \"SendPostBack\", \"Click\" );", 0); 
   else
    this.SendPostBack("Click");
   return !requiredPreventDoublePostback;
  }
  return false;
 },
 OnKeyUp: function(evt) {
    if(this.pressed)
   this.SetUnpressed();
 },
 OnKeyDown: function(evt) {
    if(evt.keyCode == ASPxKey.Enter || evt.keyCode == ASPxKey.Space)
     this.SetPressed();
 },  
 GetChecked: function(){
  return this.groupName != "" ? this.GetButtonCheckedInput().value == "1" : false;
 },  
 GetCheckedGroupList: function(){
  var result = [ ];
  aspxGetControlCollection().ForEachControl(function(control) {
   if (ASPxIdent.IsASPxClientButton(control) && (control.groupName == this.groupName) && control.RenderExistsOnPage())
    result.push(control);
  }, this);
  return result;
 },
 ClearButtonGroupChecked: function(raiseCheckedChanged){
  var list = this.GetCheckedGroupList();
  for(var i = 0; i < list.length; i ++){
   if(list[i] != this && list[i].checked) {
    list[i].SetCheckedInternal(false, false);
    if(raiseCheckedChanged)
     list[i].RaiseCheckedChanged();
   }
  }
 },
 ApplyCheckedStyle: function(){
  var stateController = aspxGetStateController();
  if(this.IsHovered()) 
   stateController.SetCurrentHoverElement(null);  
  stateController.SelectElementBySrcElement(this.GetButtonCell());
 }, 
 ApplyUncheckedStyle: function(){
  var stateController = aspxGetStateController();
  if(this.IsHovered()) 
   stateController.SetCurrentHoverElement(null);
  stateController.DeselectElementBySrcElement(this.GetButtonCell());
 },  
 SetCheckedInternal: function(checked, initialization){
  if(initialization && checked || (this.checked != checked)){
   this.checked = checked;
   var inputElement = this.GetButtonCheckedInput();
   if(inputElement) 
    inputElement.value = checked ? "1" : "0";         
   if(checked)
    this.ApplyCheckedStyle();
   else
    this.ApplyUncheckedStyle();
  }
 },
 ApplyPressedStyle: function(){
  aspxGetStateController().OnMouseDownOnElement(this.GetButtonCell());
 },
 ApplyUnpressedStyle: function(){ 
  aspxGetStateController().OnMouseUpOnElement(this.GetButtonCell());
 },
 SetPressed: function(){
  this.pressed = true;
  this.ApplyPressedStyle();
 }, 
 SetUnpressed: function(){
  this.pressed = false;
  this.ApplyUnpressedStyle();
 },
 SetFocus: function(){
  if(!this.allowFocus || this.focused)
   return;
  var element = this.GetInternalButton();
  if(element) {
   var hiddenInternalButtonRequiresVisibilityToGetFocused = __aspxWebKitFamily  && !this.isNative ;
   if(hiddenInternalButtonRequiresVisibilityToGetFocused)
    ASPxClientButton.MakeHiddenElementFocusable(element);
   if(_aspxIsFocusable(element) && _aspxGetActiveElement() != element)
    element.focus();
   if(hiddenInternalButtonRequiresVisibilityToGetFocused)
    ASPxClientButton.RestoreHiddenElementAppearance(element);
  }
 },
 ApplyFocusedStyle: function(){
  if(this.focusElementSelected) return;
  if(typeof(aspxGetStateController) != "undefined")
   aspxGetStateController().SelectElementBySrcElement(this.GetContentDiv());
  this.focusElementSelected = true;
 },
 ApplyUnfocusedStyle: function(){ 
  if(!this.focusElementSelected) return;
  if(typeof(aspxGetStateController) != "undefined")
   aspxGetStateController().DeselectElementBySrcElement(this.GetContentDiv());
  this.focusElementSelected = false;
 },
 UpdateFocusedStyle: function(){
  if(this.isNative)
   return;
  if(this.enabled && this.clientEnabled && this.allowFocus && this.focused)
   this.ApplyFocusedStyle();
  else
   this.ApplyUnfocusedStyle();
 },
 SendPostBack: function(postBackArg){
  if(!this.enabled || !this.clientEnabled)
   return;
  var arg = postBackArg || "";
  if(this.autoPostBackFunction)
   this.autoPostBackFunction(arg);
  else if(!this.useSubmitBehavior)
   ASPxClientControl.prototype.SendPostBack.call(this, arg);
  if(this.useSubmitBehavior && !this.isNative)
   this.ClickInternalButton();
 },
 ClickInternalButton: function(){
  var element = this.GetInternalButton();
  if(element) {
   this.clickLocked = true;
   if (__aspxNetscapeFamily)
    this.CreateUniqueIDCarrier(); 
   _aspxDoElementClick(element);
   if (__aspxNetscapeFamily)
    this.RemoveUniqueIDCarrier(); 
   this.clickLocked = false;
  }
 },
 CreateUniqueIDCarrier: function() {
  var name = this.uniqueID;
  var id = this.GetUniqueIDCarrierID();
  var field = _aspxCreateHiddenField(name, id);
  var form = this.GetParentForm();
  if(form) form.appendChild(field);
 },
 RemoveUniqueIDCarrier: function() {
  var field = document.getElementById(this.GetUniqueIDCarrierID());
  if (field)
   field.parentNode.removeChild(field);
 },
 GetUniqueIDCarrierID: function() {
  return this.uniqueID + "_UIDC";
 },
 DoClick: function(){
  if(!this.enabled || !this.clientEnabled)
   return;
  var button = this.isNative ? this.GetMainElement() : this.GetInternalButton();
  if(button)
   _aspxDoElementClick(button);
  else 
   this.OnClick();   
 },
 GetChecked: function(){
  return this.checked;
 },
 SetChecked: function(checked){
  this.SetCheckedInternal(checked, false);
  this.ClearButtonGroupChecked(false);
 },
 GetText: function(){
  if (this.isTextEmpty)
   return "";
  else
   return this.isNative ? this.GetMainElement().value : this.GetTextContainer().innerHTML;
 },
 SetText: function(text){
  this.isTextEmpty = (text == null || text == "");
  var mainElement = this.GetMainElement();
  if (this.isNative)
   mainElement.value = (text != null) ? text : "";
  else {
   var textContainer = this.GetTextContainer();
   textContainer.innerHTML = this.isTextEmpty ? "&nbsp;" : text;
   if (this.clientVisible && __aspxIE && __aspxBrowserVersion >= 9) 
    _aspxSetElementDisplay(mainElement, true);
  }
 },
 SetEnabled: function(enabled){
  if (this.clientEnabled != enabled) {
   if (!enabled && this.focused)
    this.OnLostFocus();
   this.clientEnabled = enabled;
   this.SetEnabledInternal(enabled, false);
  }
 },
 GetEnabled: function(){
  return this.enabled && this.clientEnabled;
 },
 Focus: function(){
  this.SetFocus();
 },
 RaiseCheckedChanged: function(){
  var processOnServer = this.autoPostBack || this.IsServerEventAssigned("CheckedChanged");
  if(!this.CheckedChanged.IsEmpty()){
   var args = new ASPxClientProcessingModeEventArgs(processOnServer);
   this.CheckedChanged.FireEvent(this, args);
   processOnServer = args.processOnServer;
  }
  return processOnServer;
 },
 RaiseFocus: function(){
  if(!this.GotFocus.IsEmpty()){
   var args = new ASPxClientEventArgs();
   this.GotFocus.FireEvent(this, args);
  }
 },
 RaiseLostFocus: function(){
  if(!this.LostFocus.IsEmpty()){
   var args = new ASPxClientEventArgs();
   this.LostFocus.FireEvent(this, args);
  }
 },
 RaiseClick: function(){
  var processOnServer = this.autoPostBack || this.IsServerEventAssigned("Click");
  if(!this.Click.IsEmpty()){
   var args = new ASPxClientProcessingModeEventArgs(processOnServer);
   this.Click.FireEvent(this, args);
   processOnServer = args.processOnServer;
  }
  return processOnServer;
 }
});
ASPxClientButton.Cast = ASPxClientControl.Cast;
ASPxClientButton.MakeHiddenElementFocusable = function(element) {
  element.__dxHiddenElementState = {
   parentDisplay: element.parentNode.style.display,
   height: element.style.height,
   width: element.style.width
  };
  element.parentNode.style.display = "block";
  element.style.height = "1px";
  element.style.width = "1px";
};
ASPxClientButton.RestoreHiddenElementAppearance = function(element) {
 var state = element.__dxHiddenElementState;
 element.parentNode.style.display = state.parentDisplay;
 element.style.height = state.height;
 element.style.width = state.width;
 delete element.__dxHiddenElementState;
};
ASPxIdent.IsASPxClientButton = function(obj) {
 return !!obj.isASPxClientButton;
};
function _aspxBCallButtonMethod(name, methodName, arg) {
 var button = aspxGetControlCollection().Get(name); 
 if (button != null)
  button[methodName](arg);
}
function aspxBGotFocus(name){
 var button = aspxGetControlCollection().Get(name); 
 if(button != null)
  return button.OnFocus();
}
function aspxBLostFocus(name){
 var button = aspxGetControlCollection().Get(name);
 if(button != null) 
  return button.OnLostFocus();
}
function aspxBClick(name){
 var button = aspxGetControlCollection().Get(name); 
 if(button != null)
  return button.OnClick();
}
function aspxBKeyDown(evt,name){
 var button = aspxGetControlCollection().Get(name); 
 if(button != null)
  button.OnKeyDown(evt);
}
function aspxBKeyUp(evt,name){
 var button = aspxGetControlCollection().Get(name); 
 if(button != null)
  button.OnKeyUp(evt);
}

var __aspxClientValidationStateNameSuffix = "$CVS";
ASPxClientEditBase = _aspxCreateClass(ASPxClientControl, {
 constructor: function(name) {
  this.constructor.prototype.constructor.call(this, name);
  this.EnabledChanged = new ASPxClientEvent();
 },
 InlineInitialize: function(){
  this.InitializeEnabled(); 
 },
 InitializeEnabled: function() {
  this.SetEnabledInternal(this.clientEnabled, true);
 },
 GetValue: function() {
  var element = this.GetMainElement();
  if(_aspxIsExistsElement(element))
   return element.innerHTML;
  return "";
 },
 GetValueString: function(){
  var value = this.GetValue();
  return (value == null) ? null : value.toString();
 },
 SetValue: function(value) {
  if(value == null)
   value = "";
  var element = this.GetMainElement();
  if(_aspxIsExistsElement(element))
   element.innerHTML = value;
 },
 GetEnabled: function(){
  return this.enabled && this.clientEnabled;
 },
 SetEnabled: function(enabled){
  if(this.clientEnabled != enabled) {
   var errorFrameRequiresUpdate = this.GetIsValid && !this.GetIsValid();
   if(errorFrameRequiresUpdate && !enabled)
    this.UpdateErrorFrameAndFocus(false , null , true );
   this.clientEnabled = enabled;
   this.SetEnabledInternal(enabled, false);
   if(errorFrameRequiresUpdate && enabled)
    this.UpdateErrorFrameAndFocus(false );
   this.RaiseEnabledChangedEvent();
  }
 },
 SetEnabledInternal: function(enabled, initialization){
  if(!this.enabled) return;
  if(!initialization || !enabled)
   this.ChangeEnabledStateItems(enabled);
  this.ChangeEnabledAttributes(enabled);
  if(__aspxChrome) {   
   var mainElement = this.GetMainElement();
   if(mainElement)
    mainElement.className = mainElement.className;
  } 
 },
 ChangeEnabledAttributes: function(enabled){
 },
 ChangeEnabledStateItems: function(enabled){
 },
 RaiseEnabledChangedEvent: function(){
  if(!this.EnabledChanged.IsEmpty()){
   var args = new ASPxClientEventArgs();
   this.EnabledChanged.FireEvent(this, args);
  }
 }
});
ASPxValidationPattern = _aspxCreateClass(null, {
 constructor: function(errorText) {
  this.errorText = errorText;
 }
});
ASPxRequiredFieldValidationPattern = _aspxCreateClass(ASPxValidationPattern, {
 constructor: function(errorText) {
  this.constructor.prototype.constructor.call(this, errorText);
 },
 EvaluateIsValid: function(value) {
  return value != null && (value.constructor == Array || _aspxTrim(value.toString()) != "");
 }
});
ASPxRegularExpressionValidationPattern = _aspxCreateClass(ASPxValidationPattern, {
 constructor: function(errorText, pattern) {
  this.constructor.prototype.constructor.call(this, errorText);
  this.pattern = pattern;
 },
 EvaluateIsValid: function(value) {
  if (value == null) 
   return true;
  var strValue = value.toString();
  if (_aspxTrim(strValue).length == 0)
   return true;
  var regEx = new RegExp(this.pattern);
  var matches = regEx.exec(strValue);
  return matches != null && strValue == matches[0];
 }
});
function _aspxIsEditorFocusable(inputElement) {
 return _aspxIsFocusableCore(inputElement, function(container) {
  return container.getAttribute("errorFrame") == "errorFrame";
 });
}
var __aspxInvalidEditorToBeFocused = null;
ASPxValidationType = {
 PersonalOnValueChanged: "ValueChanged",
 PersonalViaScript: "CalledViaScript",
 MassValidation: "MassValidation"
};
ASPxErrorFrameDisplay = {
 None: "None",
 Static: "Static",
 Dynamic: "Dynamic"
};
ASPxEditElementSuffix = {
 ExternalTable: "_ET",
 ControlCell: "_CC",
 ErrorCell: "_EC",
 ErrorTextCell: "_ETC",
 ErrorImage: "_EI"
};
ASPxClientEdit = _aspxCreateClass(ASPxClientEditBase, {
 constructor: function(name) {
  this.constructor.prototype.constructor.call(this, name);
  this.isASPxClientEdit = true;
  this.inputElement = null;
  this.elementCache = { };
  this.convertEmptyStringToNull = true;
  this.readOnly = false;
  this.focused = false;
  this.focusEventsLocked = false;
  this.receiveGlobalMouseWheel = true;
  this.styleDecoration = null;
  this.widthCorrectionRequired = false;
  this.heightCorrectionRequired = false;
  this.customValidationEnabled = false;
  this.display = ASPxErrorFrameDisplay.Static;
  this.initialErrorText = "";
  this.causesValidation = false;
  this.validateOnLeave = true;
  this.validationGroup = "";
  this.sendPostBackWithValidation = null;
  this.validationPatterns = [];
  this.setFocusOnError = false;
  this.errorDisplayMode = "it";
  this.errorText = "";
  this.isValid = true;
  this.errorImageIsAssigned = false;
  this.clientValidationStateElement = null;
  this.notifyValidationSummariesToAcceptNewError = false;
  this.enterProcessed = false;
  this.keyDownHandlers = {};
  this.keyPressHandlers = {};
  this.keyUpHandlers = {};
  this.specialKeyboardHandlingUsed = false;
  this.onKeyDownHandler = null;
  this.onKeyPressHandler = null;
  this.onKeyUpHandler = null;
  this.onGotFocusHandler = null;
  this.onLostFocusHandler = null;
  this.GotFocus = new ASPxClientEvent();
  this.LostFocus = new ASPxClientEvent();
  this.Validation = new ASPxClientEvent();
  this.ValueChanged = new ASPxClientEvent();
  this.KeyDown = new ASPxClientEvent();
  this.KeyPress = new ASPxClientEvent();
  this.KeyUp = new ASPxClientEvent();
 },
 Initialize: function() {
  this.initialErrorText = this.errorText;
  ASPxClientEditBase.prototype.Initialize.call(this);
  this.InitializeKeyHandlers();
  this.UpdateClientValidationState();
  this.UpdateValidationSummaries(null , true );
 },
 InlineInitialize: function() {
  ASPxClientEditBase.prototype.InlineInitialize.call(this);
  if(this.styleDecoration)
   this.styleDecoration.Update();
 }, 
 InitSpecialKeyboardHandling: function(){
  this.onKeyDownHandler = _aspxCreateEventHandlerFunction("aspxKBSIKeyDown", this.name, true);
  this.onKeyPressHandler = _aspxCreateEventHandlerFunction("aspxKBSIKeyPress", this.name, true);
  this.onKeyUpHandler = _aspxCreateEventHandlerFunction("aspxKBSIKeyUp", this.name, true);
  this.onGotFocusHandler = _aspxCreateEventHandlerFunction("aspxESGotFocus", this.name, false);
  this.onLostFocusHandler = _aspxCreateEventHandlerFunction("aspxESLostFocus", this.name, false);
  this.specialKeyboardHandlingUsed = true;
  this.InitializeDelayedSpecialFocus();
 },
 InitializeKeyHandlers: function() {
 },
 AddKeyDownHandler: function(key, handler) {
  this.keyDownHandlers[key] = handler;
 },
 ChangeSpecialInputEnabledAttributes: function(element, method){
  element.autocomplete = "off";
  if(this.onKeyDownHandler != null)
   method(element, "keydown", this.onKeyDownHandler);
  if(this.onKeyPressHandler != null)
   method(element, "keypress", this.onKeyPressHandler);
  if(this.onKeyUpHandler != null)
   method(element, "keyup", this.onKeyUpHandler);
  if(this.onGotFocusHandler != null)
   method(element, "focus", this.onGotFocusHandler);
  if(this.onLostFocusHandler != null)
   method(element, "blur", this.onLostFocusHandler);
 },
 UpdateClientValidationState: function() {
  if(!this.customValidationEnabled)
   return;
  var mainElement = this.GetMainElement();
  if (mainElement) {
   var hiddenField = this.GetClientValidationStateHiddenField();
   if(hiddenField)
    hiddenField.value = _aspxEncodeHtml(!this.GetIsValid() ? ("-" + this.GetErrorText()) : "");
  }
 },
 UpdateValidationSummaries: function(validationType, initializing) {
  if(typeof(ASPxClientValidationSummary) != "undefined") {
   var summaryCollection = aspxGetClientValidationSummaryCollection();
   summaryCollection.OnEditorIsValidStateChanged(this, validationType, initializing && this.notifyValidationSummariesToAcceptNewError);
  }
 },
 GetCachedElementByIdSuffix: function(idSuffix) {
  var element = this.elementCache[idSuffix];
  if(!_aspxIsExistsElement(element)) {
   element = _aspxGetElementById(this.name + idSuffix);
   this.elementCache[idSuffix] = element;
  }
  return element;
 },
 FindInputElement: function(){
  return null;
 },
 GetInputElement: function(){
  if(!_aspxIsExistsElement(this.inputElement))
   this.inputElement = this.FindInputElement();
  return this.inputElement;
 },
 GetFocusableInputElement: function() {
  return this.GetInputElement();
 },
 GetErrorImage: function() {
  return this.GetCachedElementByIdSuffix(ASPxEditElementSuffix.ErrorImage);
 },
 GetExternalTable: function() {
  return this.GetCachedElementByIdSuffix(ASPxEditElementSuffix.ExternalTable);
 },
 GetControlCell: function() {
  return this.GetCachedElementByIdSuffix(ASPxEditElementSuffix.ControlCell);
 },
 GetErrorCell: function() {
  return this.GetCachedElementByIdSuffix(ASPxEditElementSuffix.ErrorCell);
 },
 GetErrorTextCell: function() {
  return this.GetCachedElementByIdSuffix(this.errorImageIsAssigned ?
   ASPxEditElementSuffix.ErrorTextCell : ASPxEditElementSuffix.ErrorCell);
 },
 GetClientValidationStateHiddenField: function() {
  if(!this.clientValidationStateElement)
   this.clientValidationStateElement = this.CreateClientValidationStateHiddenField();
  return this.clientValidationStateElement;
 },
 CreateClientValidationStateHiddenField: function() {
  var mainElement = this.GetMainElement();
  var hiddenField = _aspxCreateHiddenField(this.uniqueID + __aspxClientValidationStateNameSuffix);
  mainElement.parentNode.appendChild(hiddenField);
  return hiddenField;
 },
 SetVisible: function(isVisible){
  if(this.clientVisible == isVisible)
   return;
  if(this.customValidationEnabled) {
   var errorFrame = this.GetExternalTable();
   if(errorFrame) {
    _aspxSetElementDisplay(errorFrame, isVisible);
    var isValid = !isVisible ? true : void(0);
    this.UpdateErrorFrameAndFocus(false , true , isValid );
   }
  }
  ASPxClientControl.prototype.SetVisible.call(this, isVisible);
 },
 GetValueInputToValidate: function() {
  return this.GetInputElement();
 },
 IsVisible: function() {
  if (!this.clientVisible)
   return false;
  var element = this.GetMainElement();
  if(!element) 
   return false;
  while(element && element.tagName != "BODY") {
   if (element.getAttribute("errorFrame") != "errorFrame" && (!_aspxGetElementVisibility(element) || !_aspxGetElementDisplay(element)))
    return false;
   element = element.parentNode;
  }
  return true;
 },
 AdjustControlCore: function() {
  this.CollapseControl();
  if (this.WidthCorrectionRequired())
   this.CorrectEditorWidth();
  else
   this.UnstretchInputElement();
  if (this.heightCorrectionRequired)
   this.CorrectEditorHeight();
 },
 WidthCorrectionRequired: function() {
  var mainElement = this.GetMainElement();
  if(_aspxIsExistsElement(mainElement)) {
   var mainElementCurStyle = _aspxGetCurrentStyle(mainElement);
   return this.widthCorrectionRequired && mainElementCurStyle.width != "" && mainElementCurStyle.width != "auto";
  }
  return false;
 },
 CorrectEditorWidth: function() {
 },
 CorrectEditorHeight: function() {
 },
 UnstretchInputElement: function() {
 },
 UseDelayedSpecialFocus: function() {
  return false;
 },
 GetDelayedSpecialFocusTriggers: function() {
  return [ this.GetMainElement() ];
 },
 InitializeDelayedSpecialFocus: function() {
  if(!this.UseDelayedSpecialFocus())
   return;
  this.specialFocusTimer = -1;    
  var handler = function(evt) { this.OnDelayedSpecialFocusMouseDown(evt); }.aspxBind(this);
  var triggers = this.GetDelayedSpecialFocusTriggers();
  for(var i = 0; i < triggers.length; i++)
   _aspxAttachEventToElement(triggers[i], "mousedown", handler);
 },
 OnDelayedSpecialFocusMouseDown: function(evt) {
  window.setTimeout(function() { this.SetFocus(); }.aspxBind(this), 0);
 },
 IsFocusEventsLocked: function() {
  return this.focusEventsLocked;
 },
 LockFocusEvents: function() {
  if(!this.focused) return;
  this.focusEventsLocked = true;
 },
 UnlockFocusEvents: function() {
  this.focusEventsLocked = false;
 },
 ForceRefocusEditor: function() {
  this.LockFocusEvents();
  var inputElement = this.GetFocusableInputElement();
  if(inputElement && inputElement.blur)
   inputElement.blur();
  window.setTimeout("aspxGetControlCollection().Get('" + this.name + "').SetFocus();", 0);
 },
 IsEditorElement: function(element) {
  return this.GetMainElement() == element || _aspxGetIsParent(this.GetMainElement(), element);
 },
 IsElementBelongToInputElement: function(element) {
  return this.GetInputElement() == element;
 },
 OnFocusCore: function() {
  if(this.UseDelayedSpecialFocus())
   window.clearTimeout(this.specialFocusTimer);
  if (!this.IsFocusEventsLocked()){
   this.focused = true;
   ASPxClientEdit.SetFocusedEditor(this);
   if(this.styleDecoration)
    this.styleDecoration.Update();
   if(this.isInitialized)
    this.RaiseFocus();
  }
  else
   this.UnlockFocusEvents();
 },
 OnLostFocusCore: function() {
  if (!this.IsFocusEventsLocked()){
   this.focused = false;
   ASPxClientEdit.SetFocusedEditor(null);
   if(this.styleDecoration)
    this.styleDecoration.Update();
   this.RaiseLostFocus();
   if (this.validateOnLeave)
    this.SetFocusOnError();
  }
 },
 OnFocus: function() {
  if (!this.specialKeyboardHandlingUsed)
   this.OnFocusCore();
 },
 OnLostFocus: function() {
  if (this.isInitialized && !this.specialKeyboardHandlingUsed)
   this.OnLostFocusCore();
 },
 OnSpecialFocus: function() {
  if (this.isInitialized)
   this.OnFocusCore();
 },
 OnSpecialLostFocus: function() {
  if (this.isInitialized)
   this.OnLostFocusCore();
 },
 OnMouseWheel: function(evt){
 },
 OnValidation: function(validationType) {
  if(this.customValidationEnabled && this.isInitialized && _aspxIsExistsElement(this.GetMainElement()) &&
   (this.display == ASPxErrorFrameDisplay.None || this.GetExternalTable())) {
   this.BeginErrorFrameUpdate();
   try {
    this.SetIsValid(true, true );
    this.SetErrorText(this.initialErrorText, true );
    if(this.validateOnLeave || validationType != ASPxValidationType.PersonalOnValueChanged) {
     this.ValidateWithPatterns();
     this.RaiseValidation();
    }
    this.UpdateErrorFrameAndFocus(validationType == ASPxValidationType.PersonalOnValueChanged && this.validateOnLeave && !this.GetIsValid());
   } finally {
    this.EndErrorFrameUpdate();
   }
   this.UpdateValidationSummaries(validationType);
  }
 },
 OnValueChanged: function() {
  var processOnServer = this.RaiseValidationInternal();
  processOnServer = this.RaiseValueChangedEvent() && processOnServer;
  if (processOnServer)
   this.SendPostBackInternal("");
 },
 ParseValue: function() {
 },
 RaisePersonalStandardValidation: function() {
  if(_aspxIsFunction(window.ValidatorOnChange)) {
   var inputElement = this.GetValueInputToValidate();
   if(inputElement && inputElement.Validators)
    window.ValidatorOnChange({ srcElement: inputElement });
  }
 },
 RaiseValidationInternal: function() {
  if (this.isPostBackAllowed() && this.causesValidation && this.validateOnLeave)
   return ASPxClientEdit.ValidateGroup(this.validationGroup);
  else {
   this.OnValidation(ASPxValidationType.PersonalOnValueChanged);
   return this.GetIsValid();
  }
 },
 RaiseValueChangedEvent: function(){
  return this.RaiseValueChanged();
 },
 SendPostBackInternal: function(postBackArg) {
  if (_aspxIsFunction(this.sendPostBackWithValidation))
   this.sendPostBackWithValidation(postBackArg);
  else
   this.SendPostBack(postBackArg);
 },
 SetElementToBeFocused: function() {
  if (this.IsVisible())
   __aspxInvalidEditorToBeFocused = this;
 },
 GetFocusSelectAction: function() {
  return null;
 },
 SetFocus: function() {
  var inputElement = this.GetFocusableInputElement();
  if (!inputElement) return; 
  var isIE9 = __aspxIE && __aspxBrowserVersion >= 9;
  if ((_aspxGetActiveElement() != inputElement || isIE9) && _aspxIsEditorFocusable(inputElement)) {
   _aspxSetFocus(inputElement, this.GetFocusSelectAction());
   if (_aspxGetActiveElement() == inputElement && isIE9)
    window.setTimeout(function() { _aspxClearInputSelection(inputElement); }, 100);
  }
 },
 SetFocusOnError: function() {
  if (__aspxInvalidEditorToBeFocused == this) {
   this.SetFocus();
   __aspxInvalidEditorToBeFocused = null;
  }
 },
 BeginErrorFrameUpdate: function() {
  if(!this.errorFrameUpdateLocked)
   this.errorFrameUpdateLocked = true;
 },
 EndErrorFrameUpdate: function() {
  this.errorFrameUpdateLocked = false;
  var args = this.updateErrorFrameAndFocusLastCallArgs;
  if(args) {
   this.UpdateErrorFrameAndFocus(args[0], args[1]);
   delete this.updateErrorFrameAndFocusLastCallArgs;
  }
 },
 UpdateErrorFrameAndFocus: function(setFocusOnError, ignoreVisibilityCheck, isValid) {
  if(!this.GetEnabled() || !ignoreVisibilityCheck && !this.GetVisible())
   return;
  if(this.errorFrameUpdateLocked) {
   this.updateErrorFrameAndFocusLastCallArgs = [ setFocusOnError, ignoreVisibilityCheck ];
   return;
  }
  if(this.styleDecoration)
   this.styleDecoration.Update();
  if(typeof(isValid) == "undefined")
   isValid = this.GetIsValid();
  var externalTable = this.GetExternalTable();
  var isStaticDisplay = this.display == ASPxErrorFrameDisplay.Static;
  var isErrorFrameDisplayed = this.display != ASPxErrorFrameDisplay.None;
  if(isValid && isErrorFrameDisplayed) {
   if(isStaticDisplay) {
    externalTable.style.visibility = "hidden";
   } else {
    this.HideErrorCell();
    this.SaveErrorFrameStyles();
    this.ClearErrorFrameElementsStyles();
   }
  } else {
   var editorLocatedWithinVisibleContainer = this.IsVisible();
   if(isErrorFrameDisplayed) {
    if(this.widthCorrectionRequired) {
     if(editorLocatedWithinVisibleContainer)
      this.CollapseControl(); 
     else
      this.ResetControlAdjustment();
    }
    this.UpdateErrorCellContent();
    if(isStaticDisplay) {
     externalTable.style.visibility = "visible";
    } else {
     this.EnsureErrorFrameStylesLoaded();
     this.RestoreErrorFrameElementsStyles();
     this.ShowErrorCell();
    }
   }
   if(editorLocatedWithinVisibleContainer) {
    if(isErrorFrameDisplayed && this.widthCorrectionRequired)
     this.AdjustControl(); 
    if(setFocusOnError && this.setFocusOnError && __aspxInvalidEditorToBeFocused == null)
     this.SetElementToBeFocused();
   }
  }
 },
 ShowErrorCell: function() {
  var errorCell = this.GetErrorCell();
  if(errorCell)
   _aspxSetElementDisplay(errorCell, true);
 },
 HideErrorCell: function() {
  var errorCell = this.GetErrorCell();
  if(errorCell)
   _aspxSetElementDisplay(errorCell, false);
 },
 SaveErrorFrameStyles: function() {
  this.EnsureErrorFrameStylesLoaded();
 },
 EnsureErrorFrameStylesLoaded: function() {
  if(typeof(this.errorFrameStyles) == "undefined") {
   var externalTable = this.GetExternalTable();
   var controlCell = this.GetControlCell();
   this.errorFrameStyles = {
    errorFrame: {
     cssClass: externalTable.className,
     style: this.ExtractElementStyleStringIgnoringVisibilityProps(externalTable)
    },
    controlCell: {
     cssClass: controlCell.className,
     style: this.ExtractElementStyleStringIgnoringVisibilityProps(controlCell)
    }
   };
  }
 },
 ClearErrorFrameElementsStyles: function() {
  this.ClearElementStyle(this.GetExternalTable());
  this.ClearElementStyle(this.GetControlCell());
 },
 RestoreErrorFrameElementsStyles: function() {
  var externalTable = this.GetExternalTable();
  externalTable.className = this.errorFrameStyles.errorFrame.cssClass;
  externalTable.style.cssText = this.errorFrameStyles.errorFrame.style;
  var controlCell = this.GetControlCell();
  controlCell.className = this.errorFrameStyles.controlCell.cssClass;
  controlCell.style.cssText = this.errorFrameStyles.controlCell.style;
 },
 ExtractElementStyleStringIgnoringVisibilityProps: function(element) {
  var savedVisibility = element.style.visibility;
  var savedDisplay = element.style.display;
  element.style.visibility = "";
  element.style.display = "";
  var styleStr = element.style.cssText;
  element.style.visibility = savedVisibility;
  element.style.display = savedDisplay;
  return styleStr;
 },
 ClearElementStyle: function(element) {
  if(!element)
   return;
  element.className = "";
  var excludedAttrNames = [
   "width", "display", "visibility",
   "position", "left", "top", "z-index",
   "margin", "margin-top", "margin-right", "margin-bottom", "margin-left",
   "float", "clear"
  ];
  var savedAttrValues = { };
  for(var i = 0; i < excludedAttrNames.length; i++) {
   var attrName = excludedAttrNames[i];
   var attrValue = element.style[attrName];
   if(attrValue)
    savedAttrValues[attrName] = attrValue;
  }
  element.style.cssText = "";
  for(var styleAttrName in savedAttrValues)
   element.style[styleAttrName] = savedAttrValues[styleAttrName];
 },
 UpdateErrorCellContent: function() {
  if (this.errorDisplayMode.indexOf("t") > -1)
   this.UpdateErrorText();
  if (this.errorDisplayMode == "i")
   this.UpdateErrorImage();
 },
 UpdateErrorImage: function() {
  var image = this.GetErrorImage();
  if (_aspxIsExistsElement(image)) {
   image.alt = this.errorText;
   image.title = this.errorText;
  } else {
   this.UpdateErrorText();
  }
 },
 UpdateErrorText: function() {
  var errorTextCell = this.GetErrorTextCell();
  if(_aspxIsExistsElement(errorTextCell))
   errorTextCell.innerHTML = _aspxEncodeHtml(this.errorText);
 },
 ValidateWithPatterns: function() {
  if (this.validationPatterns.length > 0) {
   var value = this.GetValue();
   for (var i = 0; i < this.validationPatterns.length; i++) {
    var validator = this.validationPatterns[i];
    if (!validator.EvaluateIsValid(value)) {
     this.SetIsValid(false, true );
     this.SetErrorText(validator.errorText, true );
     return;
    }
   }
  }
 },
 OnSpecialKeyDown: function(evt){
  this.RaiseKeyDown(evt);
  var handler = this.keyDownHandlers[evt.keyCode];
  if(handler) 
   return this[handler](evt);
  return false;
 },
 OnSpecialKeyPress: function(evt){
  this.RaiseKeyPress(evt);
  var handler = this.keyPressHandlers[evt.keyCode];
  if(handler) 
   return this[handler](evt);
  if(__aspxNetscapeFamily || __aspxOpera){
   if(evt.keyCode == ASPxKey.Enter)
    return this.enterProcessed;
  }
  return false;
 },
 OnSpecialKeyUp: function(evt){
  this.RaiseKeyUp(evt);
  var handler = this.keyUpHandlers[evt.keyCode];
  if(handler) 
   return this[handler](evt);
  return false;
 },
 OnKeyDown: function(evt) {
  if(!this.specialKeyboardHandlingUsed)
   this.RaiseKeyDown(evt);
 },
 OnKeyPress: function(evt) {
  if(!this.specialKeyboardHandlingUsed)
   this.RaiseKeyPress(evt);
 },
 OnKeyUp: function(evt) {
  if(!this.specialKeyboardHandlingUsed)
   this.RaiseKeyUp(evt);
 },
 RaiseKeyDown: function(evt){
  if(!this.KeyDown.IsEmpty()){
   var args = new ASPxClientEditKeyEventArgs(evt);
   this.KeyDown.FireEvent(this, args);
  }
 },
 RaiseKeyPress: function(evt){
  if(!this.KeyPress.IsEmpty()){
   var args = new ASPxClientEditKeyEventArgs(evt);
   this.KeyPress.FireEvent(this, args);
  }
 },
 RaiseKeyUp: function(evt){
  if(!this.KeyUp.IsEmpty()){
   var args = new ASPxClientEditKeyEventArgs(evt);
   this.KeyUp.FireEvent(this, args);
  }
 },
 RaiseFocus: function(){
  if(!this.GotFocus.IsEmpty()){
   var args = new ASPxClientEventArgs();
   this.GotFocus.FireEvent(this, args);
  }
 },
 RaiseLostFocus: function(){
  if(!this.LostFocus.IsEmpty()){
   var args = new ASPxClientEventArgs();
   this.LostFocus.FireEvent(this, args);
  }
 },
 RaiseValidation: function() {
  if(this.customValidationEnabled && !this.Validation.IsEmpty()) {
   var currentValue = this.GetValue();
   var args = new ASPxClientEditValidationEventArgs(currentValue, this.errorText, this.GetIsValid());
   this.Validation.FireEvent(this, args);
   this.SetErrorText(args.errorText, true );
   this.SetIsValid(args.isValid, true );
   if(args.value != currentValue)
    this.SetValue(args.value);
  }
 },
 RaiseValueChanged: function(){
  var processOnServer = this.isPostBackAllowed();
  if(!this.ValueChanged.IsEmpty()){
   var args = new ASPxClientProcessingModeEventArgs(processOnServer);
   this.ValueChanged.FireEvent(this, args);
   processOnServer = args.processOnServer;
  }
  return processOnServer;  
 },
 isPostBackAllowed: function() {
  return this.autoPostBack;
 },
 RequireStyleDecoration: function() {
  this.styleDecoration = new ASPxClientEditStyleDecoration(this);
  this.PopulateStyleDecorationPostfixes();
 }, 
 PopulateStyleDecorationPostfixes: function() {
  this.styleDecoration.AddPostfix("");
 },
 Focus: function(){
  this.SetFocus();
 },
 GetIsValid: function(){
  if((ASPxIdent.IsASPxClientRadioButtonList(this) || _aspxIsExistsElement(this.GetInputElement())) &&
   (this.display == ASPxErrorFrameDisplay.None || _aspxIsExistsElement(this.GetExternalTable())  ))
   return this.isValid;
  else
   return true;
 },
 GetErrorText: function(){
  return this.errorText;
 },
 SetIsValid: function(isValid, validating){
  if (this.customValidationEnabled) {
   this.isValid = isValid;
   this.UpdateErrorFrameAndFocus(false );
   this.UpdateClientValidationState();
   if(!validating)
    this.UpdateValidationSummaries(ASPxValidationType.PersonalViaScript);
  }
 },
 SetErrorText: function(errorText, validating){
  if (this.customValidationEnabled) {
   this.errorText = errorText;
   this.UpdateErrorFrameAndFocus(false );
   this.UpdateClientValidationState();
   if(!validating)
    this.UpdateValidationSummaries(ASPxValidationType.PersonalViaScript);
  }
 },
 Validate: function(){
  this.ParseValue();
  this.OnValidation(ASPxValidationType.PersonalViaScript);
 }
});
ASPxClientEdit.focusedEditorName = "";
ASPxClientEdit.GetFocusedEditor = function(){
 var focusedEditor = aspxGetControlCollection().Get(ASPxClientEdit.focusedEditorName);
 if(focusedEditor && !focusedEditor.focused){
  ASPxClientEdit.SetFocusedEditor(null);
  focusedEditor = null;
 }
 return focusedEditor;
}
ASPxClientEdit.SetFocusedEditor = function(editor){
 ASPxClientEdit.focusedEditorName = editor ? editor.name : "";
}
ASPxClientEdit.ClearEditorsInContainer = function(container, validationGroup, clearInvisibleEditors) {
 __aspxInvalidEditorToBeFocused = null;
 _aspxProcessEditorsInContainer(container, _aspxClearProcessingProc, _aspxClearChoiceCondition, validationGroup, clearInvisibleEditors, true );
 ASPxClientEdit.ClearExternalControlsInContainer(container, validationGroup, clearInvisibleEditors);
}
ASPxClientEdit.ClearEditorsInContainerById = function(containerId, validationGroup, clearInvisibleEditors) {
 var container = document.getElementById(containerId);
 this.ClearEditorsInContainer(container, validationGroup, clearInvisibleEditors);
}
ASPxClientEdit.ClearGroup = function(validationGroup, clearInvisibleEditors) {
 return this.ClearEditorsInContainer(null, validationGroup, clearInvisibleEditors);
}
ASPxClientEdit.ValidateEditorsInContainer = function(container, validationGroup, validateInvisibleEditors) {
 var summaryCollection;
 if(typeof(ASPxClientValidationSummary) != "undefined") {
  summaryCollection = aspxGetClientValidationSummaryCollection();
  summaryCollection.AllowNewErrorsAccepting(validationGroup);
 }
 var validationResult = _aspxProcessEditorsInContainer(container, _aspxValidateProcessingProc, _aspxValidateChoiceCondition, validationGroup, validateInvisibleEditors,
  false );
 validationResult.isValid = ASPxClientEdit.ValidateExternalControlsInContainer(container, validationGroup, validateInvisibleEditors) && validationResult.isValid;
 if(typeof(aspxGetGlobalEvents) != "undefined") {
  if(typeof(validateInvisibleEditors) == "undefined")
   validateInvisibleEditors = false;
  if(typeof(validationGroup) == "undefined")
   validationGroup = null;
  validationResult.isValid = aspxGetGlobalEvents().OnValidationCompleted(container, validationGroup,
   validateInvisibleEditors, validationResult.isValid, validationResult.firstInvalid, validationResult.firstVisibleInvalid);
 }
 if(summaryCollection)
  summaryCollection.ForbidNewErrorsAccepting(validationGroup);
 return validationResult.isValid;
}
ASPxClientEdit.ValidateEditorsInContainerById = function(containerId, validationGroup, validateInvisibleEditors) {
 var container = document.getElementById(containerId);
 return this.ValidateEditorsInContainer(container, validationGroup, validateInvisibleEditors);
}
ASPxClientEdit.ValidateGroup = function(validationGroup, validateInvisibleEditors) {
 return this.ValidateEditorsInContainer(null, validationGroup, validateInvisibleEditors);
}
ASPxClientEdit.AreEditorsValid = function(containerOrContainerId, validationGroup, checkInvisibleEditors) {
 var container = typeof(containerOrContainerId) == "string" ? document.getElementById(containerOrContainerId) : containerOrContainerId;
 var checkResult = _aspxProcessEditorsInContainer(container, _aspxEditorsValidProcessingProc, _aspxEditorsValidChoiceCondition, validationGroup,
  checkInvisibleEditors, false );
 checkResult.isValid = ASPxClientEdit.AreExternalControlsValidInContainer(containerOrContainerId, validationGroup, checkInvisibleEditors) && checkResult.isValid;
 return checkResult.isValid;
}
ASPxClientEdit.AreExternalControlsValidInContainer = function(containerId, validationGroup, validateInvisibleEditors) {
 if (typeof(ASPxClientHtmlEditor) != "undefined")
  return ASPxClientHtmlEditor.AreEditorsValidInContainer(containerId, validationGroup, validateInvisibleEditors);
 return true;
}
ASPxClientEdit.ClearExternalControlsInContainer = function(containerId, validationGroup, validateInvisibleEditors) {
 if (typeof(ASPxClientHtmlEditor) != "undefined")
  return ASPxClientHtmlEditor.ClearEditorsInContainer(containerId, validationGroup, validateInvisibleEditors);
 return true;
}
ASPxClientEdit.ValidateExternalControlsInContainer = function(containerId, validationGroup, validateInvisibleEditors) {
 if (typeof(ASPxClientHtmlEditor) != "undefined")
  return ASPxClientHtmlEditor.ValidateEditorsInContainer(containerId, validationGroup, validateInvisibleEditors);
 return true;
}
ASPxClientEditKeyEventArgs = _aspxCreateClass(ASPxClientEventArgs, {
 constructor: function(htmlEvent) {
  this.constructor.prototype.constructor.call(this);
  this.htmlEvent = htmlEvent;
 }
});
ASPxClientEditValidationEventArgs = _aspxCreateClass(ASPxClientEventArgs, {
 constructor: function(value, errorText, isValid) {
  this.constructor.prototype.constructor.call(this);
  this.errorText = errorText;
  this.isValid = isValid;
  this.value = value;
 }
});
function aspxEGotFocus(name){
 var edit = aspxGetControlCollection().Get(name); 
 if(edit != null)
  edit.OnFocus();
}
function aspxELostFocus(name){
 var edit = aspxGetControlCollection().Get(name);
 if(edit != null) 
  edit.OnLostFocus();
}
function aspxESGotFocus(name){
 var edit = aspxGetControlCollection().Get(name); 
 if(edit != null)
  edit.OnSpecialFocus();
}
function aspxESLostFocus(name){
 var edit = aspxGetControlCollection().Get(name);
 if(edit == null)
  return;
 if(edit.UseDelayedSpecialFocus())
  edit.specialFocusTimer = window.setTimeout(function() { edit.OnSpecialLostFocus(); }, 30);
 else
  edit.OnSpecialLostFocus();
}
function aspxEValueChanged(name){
 var edit = aspxGetControlCollection().Get(name);
 if(edit != null)
  edit.OnValueChanged();
}
_aspxAttachEventToDocument("mousedown", aspxEMouseDown);
function aspxEMouseDown(evt) {
 var editor = ASPxClientEdit.GetFocusedEditor();
 var evtSource = _aspxGetEventSource(evt);
 if (editor != null && editor.IsEditorElement(evtSource) && !editor.IsElementBelongToInputElement(evtSource))
  editor.ForceRefocusEditor();
}
_aspxAttachEventToDocument(__aspxNetscapeFamily ? "DOMMouseScroll" : "mousewheel", aspxEMouseWheel);
function aspxEMouseWheel(evt) {
 var editor = ASPxClientEdit.GetFocusedEditor();
 if (editor != null && _aspxIsExistsElement(editor.GetMainElement()) && editor.focused && editor.receiveGlobalMouseWheel)
  editor.OnMouseWheel(evt);
}
function aspxKBSIKeyDown(name, evt){
 var control = aspxGetControlCollection().Get(name);
 if(control != null){
  var isProcessed = control.OnSpecialKeyDown(evt);
  if(isProcessed)
   return _aspxPreventEventAndBubble(evt);
 }
}
function aspxKBSIKeyPress(name, evt){
 var control = aspxGetControlCollection().Get(name);
 if(control != null){
  var isProcessed = control.OnSpecialKeyPress(evt);
  if(isProcessed)
   return _aspxPreventEventAndBubble(evt);
 }
}
function aspxKBSIKeyUp(name, evt){
 var control = aspxGetControlCollection().Get(name);
 if(control != null){
  var isProcessed = control.OnSpecialKeyUp(evt);
  if(isProcessed)
   return _aspxPreventEventAndBubble(evt);
 }
}
function aspxEKeyDown(name, evt){
 var edit = aspxGetControlCollection().Get(name);
 if(edit != null)
  edit.OnKeyDown(evt);
}
function aspxEKeyPress(name, evt){
 var edit = aspxGetControlCollection().Get(name);
 if(edit != null)
  edit.OnKeyPress(evt);
}
function aspxEKeyUp(name, evt){
 var edit = aspxGetControlCollection().Get(name);
 if(edit != null)
  edit.OnKeyUp(evt);
}
ASPxValidationResult = _aspxCreateClass(null, {
 constructor: function(isValid, firstInvalid, firstVisibleInvalid) {
  this.isValid = isValid;
  this.firstInvalid = firstInvalid;
  this.firstVisibleInvalid = firstVisibleInvalid;
 }
});
function _aspxProcessEditorsInContainer(container, processingProc, choiceCondition, validationGroup, processInvisibleEditors, processDisabledEditors) {
 var allProcessedSuccessfull = true;
 var firstInvalid = null;
 var firstVisibleInvalid = null;
 var invalidEditorToBeFocused = null;
 aspxGetControlCollection().ForEachControl(function(control) {
  if (ASPxIdent.IsASPxClientEdit(control) && (processDisabledEditors || control.GetEnabled())) {
   var mainElement = control.GetMainElement();
   if (mainElement &&
    (container == null || _aspxGetIsParent(container, mainElement)) &&
    (processInvisibleEditors || control.IsVisible()) &&
    choiceCondition(control, validationGroup)) {
    var isSuccess = processingProc(control);
    if(!isSuccess) {
     allProcessedSuccessfull = false;
     if(firstInvalid == null)
      firstInvalid = control;
     var isVisible = control.IsVisible();
     if(isVisible && firstVisibleInvalid == null)
      firstVisibleInvalid = control;
     if (control.setFocusOnError && invalidEditorToBeFocused == null && isVisible)
      invalidEditorToBeFocused = control;
    }
   }
  }
 }, this);
 if (invalidEditorToBeFocused != null)
  invalidEditorToBeFocused.SetFocus();
 return new ASPxValidationResult(allProcessedSuccessfull, firstInvalid, firstVisibleInvalid);
}
function _aspxClearChoiceCondition(edit, validationGroup) {
 return !_aspxIsExists(validationGroup) || (edit.validationGroup == validationGroup);
}
function _aspxValidateChoiceCondition(edit, validationGroup) {
 return _aspxClearChoiceCondition(edit, validationGroup) && edit.customValidationEnabled;
}
function _aspxEditorsValidChoiceCondition(edit, validationGroup) {
 return _aspxValidateChoiceCondition(edit, validationGroup);
}
function _aspxClearProcessingProc(edit) {
 edit.SetValue(null);
 edit.SetIsValid(true);
 return true;
}
function _aspxValidateProcessingProc(edit) {
 edit.OnValidation(ASPxValidationType.MassValidation);
 return edit.GetIsValid();
}
function _aspxEditorsValidProcessingProc(edit) {
 return edit.GetIsValid();
}
ASPxCheckEditElementHelper = _aspxCreateClass(ASPxCheckableElementHelper, {
 AttachToMainElement: function(internalCheckBox) {
  ASPxCheckableElementHelper.prototype.AttachToMainElement.call(this, internalCheckBox);
  this.AttachToLabelElement(this.GetLabelElement(internalCheckBox.container), internalCheckBox);
 },
 AttachToLabelElement: function(labelElement, internalCheckBox) {
  var _this = this;
  if(labelElement) {
   _aspxAttachEventToElement(labelElement, "click", 
    function (evt) { 
     _this.InvokeClick(internalCheckBox, evt);
    }
   );
   _aspxAttachEventToElement(labelElement, "mousedown",
    function (evt) {
     internalCheckBox.Refocus();
    }
   );
  }
 },
 GetLabelElement: function(container) {
  return _aspxGetChildByTagName(container, "LABEL", 0);
 }
});
ASPxCheckEditElementHelper.Instance = new ASPxCheckEditElementHelper();
var __aspxTEInputSuffix = "_I";
var __aspxTERawInputSuffix = "_Raw";
var __aspxPasteCheckInterval = 50;
ASPxEditorStretchedInputElementsManager = _aspxCreateClass(null, {
 constructor: function() {
  this.targetEditorNames = { };
 },
 Initialize: function() {
  this.InitializeTargetEditorsList();
 },
 InitializeTargetEditorsList: function() {
  aspxGetControlCollection().ForEachControl(function(control) {
   if(this.targetEditorNames[control.name])
    return;
   if(ASPxIdent.IsASPxClientTextEdit(control) && control.WidthCorrectionRequired()) {
    var inputElement = control.GetInputElement();
    if(inputElement && _aspxIsWidthSetInPercentage(inputElement.style.width))
     this.targetEditorNames[control.name] = true;
   }
  }, this);
 },
 HideInputElementsExceptOf: function(exceptedEditor) {
  var collection = aspxGetControlCollection();
  for(var editorName in this.targetEditorNames) {
   if(typeof(editorName) != "string")
    continue;
   var editor = collection.Get(editorName);
   if(!ASPxIdent.IsASPxClientEdit(editor)) continue;
   if(editor && editor != exceptedEditor) {
    var input = editor.GetInputElement();
    if(input) {
     var existentSavedDisplay = input._dxSavedDisplayAttr;
     if(!_aspxIsExists(existentSavedDisplay)) {
      input._dxSavedDisplayAttr = input.style.display;
      input.style.display = "none";
     }
    }
   }   
  }
 },
 ShowInputElements: function() {
  var collection = aspxGetControlCollection();
  for(var editorName in this.targetEditorNames) {
   if(typeof(editorName) != "string")
    continue;
   var editor = collection.Get(editorName);
   if(!ASPxIdent.IsASPxClientEdit(editor)) continue;
   if(editor) {
    var input = editor.GetInputElement();
    if(input) {
     var savedDisplay = input._dxSavedDisplayAttr;
     if(_aspxIsExists(savedDisplay)) {
      input.style.display = savedDisplay;
      _aspxRemoveAttribute(input, "_dxSavedDisplayAttr");
     }
    }
   }
  }
 }
});
var __aspxEditorStretchedInputElementsManager = null;
function _aspxGetEditorStretchedInputElementsManager() {
 if(!__aspxEditorStretchedInputElementsManager)
  __aspxEditorStretchedInputElementsManager = new ASPxEditorStretchedInputElementsManager();
 return __aspxEditorStretchedInputElementsManager;
}
ASPxClientTextEdit = _aspxCreateClass(ASPxClientEdit, {
 constructor: function(name) {
  this.constructor.prototype.constructor.call(this, name);      
  this.isASPxClientTextEdit = true;
  this.nullText = "";
  this.escCount = 0;
  this.raiseValueChangedOnEnter = true;
  this.autoResizeWithContainer = false;
  this.lastChangedValue = null;
  this.maskInfo = null;  
  this.maskValueBeforeUserInput = "";
  this.maskPasteTimerID = -1;
  this.maskPasteLock = false;    
  this.maskPasteCounter = 0;
  this.maskTextBeforePaste = "";    
  this.maskHintHtml = "";
  this.maskHintTimerID = -1;
  this.displayFormat = null;
  this.TextChanged = new ASPxClientEvent();
 },
 Initialize: function(){
  this.SaveChangedValue();
  ASPxClientEdit.prototype.Initialize.call(this);
  if(__aspxWebKitFamily)  
   this.CorrectMainElementWhiteSpaceStyle();
 },
 InlineInitialize: function(){
  ASPxClientEdit.prototype.InlineInitialize.call(this);
  if(this.maskInfo != null)
   this.InitMask();
  var postHandler = aspxGetPostHandler();
  postHandler.PostFinalization.removeHandlerByControlName(this.name);
  postHandler.PostFinalization.AddHandler(this.OnPost, this);
 },
  CorrectMainElementWhiteSpaceStyle: function() {
  var inputElement = this.GetInputElement();
  if(inputElement && inputElement.parentNode) {
   if(this.IsElementHasWhiteSpaceStyle(inputElement.parentNode))
    inputElement.parentNode.style.whiteSpace = "normal";
  }
 },
 IsElementHasWhiteSpaceStyle: function(element) {
  var currentStyle = _aspxGetCurrentStyle(element);
  return currentStyle.whiteSpace == "nowrap" || currentStyle.whiteSpace == "pre";  
 },
 FindInputElement: function(){
  return this.isNative ? this.GetMainElement() : _aspxGetElementById(this.name + __aspxTEInputSuffix);
 },
 GetRawInputElement: function() {
  return _aspxGetElementById(this.name + __aspxTERawInputSuffix);
 },
 DecodeRawInputValue: function(value) {
  return value;
 },
 SetRawInputValue: function(value){
  this.GetRawInputElement().value = value;
 },
 SyncRawInputValue: function() {
  if(this.maskInfo != null)
   this.SetRawInputValue(this.maskInfo.GetValue());
  else
   this.SetRawInputValue(this.GetInputElement().value);
 },
 HasTextDecorators: function() {
  return this.nullText != "" || this.displayFormat != null;
 },
 CanApplyTextDecorators: function(){
  return !this.focused;
 },
 GetDecoratedText: function(value) {
  var isNull = value == null || value === "";
  if(isNull && this.nullText != "")
   return this.nullText;
  if(this.displayFormat != null)
   return ASPxFormatter.Format(this.displayFormat, value);
  if(this.maskInfo != null)
   return this.maskInfo.GetText();
  if(value == null)
   return "";
  return value;
 },
 ToggleTextDecoration: function() {
  if(this.readOnly) return;
  if(!this.HasTextDecorators()) return;
  if(this.focused) {
   var input = this.GetInputElement();
   var oldValue = input.value;
   var sel = _aspxGetSelectionInfo(input);
   this.ToggleTextDecorationCore();
   if(oldValue != input.value) {
    if(sel.startPos == 0 && sel.endPos == oldValue.length)
     sel.endPos = input.value.length;
    else
     sel.endPos = sel.startPos;
    _aspxSetInputSelection(input, sel.startPos, sel.endPos);
   }
  } else {
   this.ToggleTextDecorationCore();
  }
 },
 ToggleTextDecorationCore: function() {
  if(this.maskInfo != null) {   
   this.ApplyMaskInfo(false);
  } else {
   var input = this.GetInputElement();
   var rawValue = this.GetRawInputElement().value;
   var value = this.CanApplyTextDecorators() ? this.GetDecoratedText(rawValue) : rawValue;
   if(input.value != value)
    input.value = value;
  }
 },
 PopulateStyleDecorationPostfixes: function() {
  ASPxClientEdit.prototype.PopulateStyleDecorationPostfixes.call(this);
  this.styleDecoration.AddPostfix(__aspxTEInputSuffix);
 },
 GetValue: function() {
  var value = null;
  if(this.maskInfo != null)
   value = this.maskInfo.GetValue();
  else if(this.HasTextDecorators())
   value = this.GetRawInputElement().value;
  else
   value = this.GetInputElement().value;
  return (value == "" && this.convertEmptyStringToNull) ? null : value;
 },
 SetValue: function(value) {
  if(value == null) value = "";
  if(this.maskInfo != null) {
   this.maskInfo.SetValue(value);
   this.ApplyMaskInfo(false);
   this.SavePrevMaskValue();
  } 
  else if(this.HasTextDecorators()) {
   this.SetRawInputValue(value);
   this.GetInputElement().value = this.CanApplyTextDecorators() ? this.GetDecoratedText(value) : value;
  }
  else
   this.GetInputElement().value = value;
  if(this.styleDecoration)
   this.styleDecoration.Update();   
  this.SaveChangedValue();   
 },
 CollapseControl: function(checkSizeCorrectedFlag) {
  if (checkSizeCorrectedFlag && this.sizeCorrectedOnce)
   return;
  var mainElement = this.GetMainElement();
  if (!_aspxIsExistsElement(mainElement))
   return;
  if (this.WidthCorrectionRequired())
   this.GetInputElement().style.width = "0";
 },
 CorrectEditorWidth: function() {
  var inputElement = this.GetInputElement();
  var stretchedInputsManager = _aspxGetEditorStretchedInputElementsManager();
  var currentAciveElement = null;
  if (this.IsRestoreActiveElementAfterWidthCorrection()) 
   currentAciveElement = _aspxGetActiveElement();
  try {
   stretchedInputsManager.HideInputElementsExceptOf(this);
   _aspxSetOffsetWidth(inputElement, _aspxGetClearClientWidth(_aspxFindOffsetParent(inputElement)) - this.GetInputWidthCorrection());
  } finally {
   stretchedInputsManager.ShowInputElements();
  }
  if (this.IsRestoreActiveElementAfterWidthCorrection()) 
   this.RestoreActiveElement(currentAciveElement);
 },
 UnstretchInputElement: function(){
  var inputElement = this.GetInputElement();
  var mainElement = this.GetMainElement();
  var mainElementCurStyle = _aspxGetCurrentStyle(mainElement);
  if (_aspxIsExistsElement(mainElement) && _aspxIsExistsElement(inputElement) && _aspxIsExists(mainElementCurStyle) && 
   inputElement.style.width == "100%" &&
   (mainElementCurStyle.width == "" || mainElementCurStyle.width == "auto"))
   inputElement.style.width = "";
 },
 RestoreActiveElement: function(activeElement) {
  if (activeElement && activeElement.setActive && activeElement.tagName != "IFRAME")
   activeElement.setActive();
 },
 IsRestoreActiveElementAfterWidthCorrection: function() {
  return __aspxIE && __aspxBrowserVersion <= 7;
 },
 RaiseValueChangedEvent: function() {
  var processOnServer = ASPxClientEdit.prototype.RaiseValueChangedEvent.call(this);
  processOnServer = this.RaiseTextChanged(processOnServer);
  return processOnServer;
 },
 GetInputWidthCorrection: function(){
  return 0;
 },
 InitMask: function() {
  var raw = String(this.GetRawInputElement().value);  
  this.SetValue(raw.length ? this.DecodeRawInputValue(raw) : this.maskInfo.GetValue());
  this.validationPatterns.unshift(new ASPxMaskValidationPattern(this.maskInfo.errorText, this.maskInfo));
  this.maskPasteTimerID = _aspxSetInterval("aspxMaskPasteTimerProc('" + this.name + "')", __aspxPasteCheckInterval);
 },
 SavePrevMaskValue: function() {
  this.maskValueBeforeUserInput = this.maskInfo.GetValue();
 },
 FillMaskInfo: function() {
  var input = this.GetInputElement();
  if(!input) return; 
  var sel = _aspxGetSelectionInfo(input);
  this.maskInfo.SetCaret(sel.startPos, sel.endPos - sel.startPos);  
 },
 ApplyMaskInfo: function(applyCaret) {
  this.SyncRawInputValue();
  var input = this.GetInputElement();
  var text = this.GetMaskDisplayText();
  this.maskTextBeforePaste = text;
  if(input.value != text)
   input.value = text;
  if(applyCaret)
   _aspxSetInputSelection(input, this.maskInfo.caretPos, this.maskInfo.caretPos + this.maskInfo.selectionLength);
 },
 GetMaskDisplayText: function() {
  if(!this.focused && this.HasTextDecorators())
   return this.GetDecoratedText(this.maskInfo.GetValue());
  return this.maskInfo.GetText();
 },
 ShouldCancelMaskKeyProcessing: function(htmlEvent, keyDownInfo) {
  return htmlEvent.returnValue === false;
 }, 
 HandleMaskKeyDown: function(evt) {
  var keyInfo = _aspxMaskManager.CreateKeyInfoByEvent(evt);
  _aspxMaskManager.keyCancelled = this.ShouldCancelMaskKeyProcessing(evt, keyInfo);
  if(_aspxMaskManager.keyCancelled) {
   _aspxPreventEvent(evt);
   return;
  }
  this.maskPasteLock = true;
  this.FillMaskInfo();  
  var canHandle = _aspxMaskManager.CanHandleControlKey(keyInfo);   
  _aspxMaskManager.savedKeyDownKeyInfo = keyInfo;
  if(canHandle) {   
   _aspxMaskManager.OnKeyDown(this.maskInfo, keyInfo);
   this.ApplyMaskInfo(true);
   _aspxPreventEvent(evt);
  }
  _aspxMaskManager.keyDownHandled = canHandle;
  this.maskPasteLock = false;
  this.UpdateMaskHintHtml();
 },
 HandleMaskKeyPress: function(evt) {
  var keyInfo = _aspxMaskManager.CreateKeyInfoByEvent(evt);
  _aspxMaskManager.keyCancelled = _aspxMaskManager.keyCancelled || this.ShouldCancelMaskKeyProcessing(evt, _aspxMaskManager.savedKeyDownKeyInfo);
  if(_aspxMaskManager.keyCancelled) {
   _aspxPreventEvent(evt);
   return;
  }
  this.maskPasteLock = true;  
  var printable = _aspxMaskManager.savedKeyDownKeyInfo != null && _aspxMaskManager.IsPrintableKeyCode(_aspxMaskManager.savedKeyDownKeyInfo);
  if(printable) {
   _aspxMaskManager.OnKeyPress(this.maskInfo, keyInfo);
   this.ApplyMaskInfo(true);
  }
  if(printable || _aspxMaskManager.keyDownHandled)   
   _aspxPreventEvent(evt); 
  this.maskPasteLock = false;
  this.UpdateMaskHintHtml();
 },
 MaskPasteTimerProc: function() {
  if(this.maskPasteLock) return;
  this.maskPasteCounter++;
  var inputElement = this.inputElement;
  if(!inputElement || this.maskPasteCounter > 40) {
   this.maskPasteCounter = 0;
   inputElement = this.GetInputElement();
  if(!_aspxIsExistsElement(inputElement)) {
   this.maskPasteTimerID = _aspxClearInterval(this.maskPasteTimerID);
   return;  
  }
  }
  if(this.maskTextBeforePaste != inputElement.value && this.maskInfo != null) {
   this.maskInfo.ProcessPaste(inputElement.value, _aspxGetSelectionInfo(inputElement).endPos);
   this.ApplyMaskInfo(true);
  }
 },
 BeginShowMaskHint: function() {  
  if(!this.readOnly && this.maskHintTimerID == -1)
   this.maskHintTimerID = window.setInterval(aspxMaskHintTimerProc, 500);
 },
 EndShowMaskHint: function() {
  window.clearInterval(this.maskHintTimerID);
  this.maskHintTimerID = -1;
 },
 MaskHintTimerProc: function() {  
  if(this.maskInfo) {
   this.FillMaskInfo();
   this.UpdateMaskHintHtml();
  } else {
   this.EndShowMaskHint();
  }
 },
 UpdateMaskHintHtml: function() {  
  var hint =  this.GetMaskHintElement();
  if(!_aspxIsExistsElement(hint))
   return;
  var html = _aspxMaskManager.GetHintHtml(this.maskInfo);
  if(html == this.maskHintHtml)
   return;
  if(html != "") {
   var mainElement = this.GetMainElement();
   if(_aspxIsExistsElement(mainElement)) {
    hint.innerHTML = html;
    hint.style.position = "absolute";  
    hint.style.left = _aspxGetAbsoluteX(mainElement) + "px";
    hint.style.top = (_aspxGetAbsoluteY(mainElement) + mainElement.offsetHeight + 2) + "px";
    hint.style.display = "block";    
   }   
  } else {
   hint.style.display = "none";
  }
  this.maskHintHtml = html;
 },
 HideMaskHint: function() {
  var hint =  this.GetMaskHintElement();
  if(_aspxIsExistsElement(hint))
   hint.style.display = "none";
  this.maskHintHtml = "";
 },
 GetMaskHintElement: function() {
  return _aspxGetElementById(this.name + "_MaskHint");
 },
 OnMouseWheel: function(evt){
  if(this.readOnly || this.maskInfo == null) return;
  this.FillMaskInfo();
  _aspxMaskManager.OnMouseWheel(this.maskInfo, _aspxGetWheelDelta(evt) < 0 ? -1 : 1);
  this.ApplyMaskInfo(true);
  _aspxPreventEvent(evt);
  this.UpdateMaskHintHtml();
 }, 
 OnBrowserWindowResize: function(evt) {
  if(!this.autoResizeWithContainer)
   this.AdjustControl();
 },
 IsValueChanged: function() {
    return this.GetValue() != this.lastChangedValue; 
 },
 OnKeyDown: function(evt) {        
  if(__aspxIE && _aspxGetKeyCode(evt) == ASPxKey.Esc) {   
   if(++this.escCount > 1) {
    _aspxPreventEvent(evt);
    return;
   }
  } else 
   this.escCount = 0;
  ASPxClientEdit.prototype.OnKeyDown.call(this, evt);
  if(!this.IsRaiseStandardOnChange(evt)) {
   if(!this.readOnly && this.maskInfo != null)
    this.HandleMaskKeyDown(evt);
  }
 },
 OnKeyPress: function(evt) {
  ASPxClientEdit.prototype.OnKeyPress.call(this, evt);
  if(!this.readOnly && this.maskInfo != null && !this.IsRaiseStandardOnChange(evt))
   this.HandleMaskKeyPress(evt);
  if(this.NeedOnKeyEventEnd(evt, true))
   this.OnKeyEventEnd(evt);
 },
 OnKeyUp: function(evt) {
  if (__aspxFirefox && !this.focused && _aspxGetKeyCode(evt) === ASPxKey.Tab)
   return;
  if(this.NeedOnKeyEventEnd(evt, false)) 
   this.OnKeyEventEnd(evt);
  ASPxClientEdit.prototype.OnKeyUp.call(this, evt);
 },
 NeedOnKeyEventEnd: function(evt, isKeyPress) { 
  var handleKeyPress = this.maskInfo != null && evt.keyCode == ASPxKey.Enter;
  return handleKeyPress == isKeyPress;
 },
 OnKeyEventEnd: function(evt){
  if(!this.readOnly) {
   if(this.IsRaiseStandardOnChange(evt))
    this.RaiseStandardOnChange();
   if(this.HasTextDecorators())
    this.SyncRawInputValue();
  }
 },
 IsRaiseStandardOnChange: function(evt){
  return !this.specialKeyboardHandlingUsed && this.raiseValueChangedOnEnter && evt.keyCode == ASPxKey.Enter;
 },
 GetFocusSelectAction: function() {
  if(this.maskInfo)
   return "start";
  return "all"; 
 },
 OnFocusCore: function() {
  var wasLocked = this.IsFocusEventsLocked();
  if(!this.GetEnabled()){
   var inputElement = this.GetInputElement();
   if(inputElement) 
    inputElement.blur();
   return;
  }
  ASPxClientEdit.prototype.OnFocusCore.call(this);
  if(this.maskInfo != null) {
   this.SavePrevMaskValue();
   this.BeginShowMaskHint();
  }
  if(!wasLocked)
   this.ToggleTextDecoration();
 },
 OnLostFocusCore: function() {
  var wasLocked = this.IsFocusEventsLocked();
  ASPxClientEdit.prototype.OnLostFocusCore.call(this);
  if(this.maskInfo != null) {
   this.EndShowMaskHint();
   this.HideMaskHint();   
   if(this.maskInfo.ApplyFixes(null))
    this.ApplyMaskInfo(false);
   this.RaiseStandardOnChange();
  }
  if(!wasLocked)
   this.ToggleTextDecoration();
  this.escCount = 0;
 },
 OnValueChanged: function() { 
  if(this.maskInfo != null) {
   if(this.maskInfo.GetValue() == this.maskValueBeforeUserInput) 
    return;
   this.SavePrevMaskValue();
  }
  if(this.HasTextDecorators())
   this.SyncRawInputValue();
  if(!this.IsValueChanged()) return;
  this.SaveChangedValue(); 
  ASPxClientEdit.prototype.OnValueChanged.call(this);
 }, 
 OnTextChanged: function() {
 },
 SaveChangedValue: function() {
  this.lastChangedValue = this.GetValue();
 },
 RaiseStandardOnChange: function(){
  var element = this.GetInputElement();
  if(element && element.onchange) {
   element.onchange({ target: this.GetInputElement() });
  }
 },
 RaiseTextChanged: function(processOnServer){
  if(!this.TextChanged.IsEmpty()){
   var args = new ASPxClientProcessingModeEventArgs(processOnServer);
   this.TextChanged.FireEvent(this, args);
   processOnServer = args.processOnServer;
  }
  return processOnServer;  
 },
 GetText: function(){
  if(this.maskInfo != null) {
   return this.maskInfo.GetText();
  } else {
   var value = this.GetValue();
   return value != null ? value : "";
  }
 },
 SetText: function (value){
  if(this.maskInfo != null) {
   this.maskInfo.SetText(value);
   this.ApplyMaskInfo(false);
   this.SavePrevMaskValue();
  } else {
   this.SetValue(value);
  }
 },
 SelectAll: function() {
  this.SetSelection(0, -1, false);
 },
 SetCaretPosition: function(pos) {
  var inputElement = this.GetInputElement();
  _aspxSetCaretPosition(inputElement, pos);
 },
 SetSelection: function(startPos, endPos, scrollToSelection) { 
  var inputElement = this.GetInputElement();
  _aspxSetSelection(inputElement, startPos, endPos, scrollToSelection);
 },
 ChangeEnabledAttributes: function(enabled){
  var inputElement = this.GetInputElement();
  if(inputElement){
   this.ChangeInputEnabledAttributes(inputElement, _aspxChangeAttributesMethod(enabled), enabled);
   if(this.specialKeyboardHandlingUsed)
    this.ChangeSpecialInputEnabledAttributes(inputElement, _aspxChangeEventsMethod(enabled));
   this.ChangeInputEnabled(inputElement, enabled, this.readOnly);
  }
 },
 ChangeEnabledStateItems: function(enabled){
  if(!this.isNative) {
   var sc = aspxGetStateController();
   sc.SetElementEnabled(this.GetMainElement(), enabled);
   sc.SetElementEnabled(this.GetInputElement(), enabled);
  }
 },
 ChangeInputEnabled: function(element, enabled, readOnly){
  if(this.UseReadOnlyForDisabled())
   element.readOnly = !enabled || readOnly;
  else
   element.disabled = !enabled;
 },
 ChangeInputEnabledAttributes: function(element, method, enabled){
  if(enabled && __aspxWebKitFamily && element.tabIndex == -1)
   element.tabIndex = null;
  method(element, "tabIndex");
  if(!enabled) element.tabIndex = -1;
  method(element, "onclick");
  if(!this.NeedFocusCorrectionWhenDisabled())
   method(element, "onfocus");
  method(element, "onblur");
  method(element, "onkeydown");
  method(element, "onkeypress");
  method(element, "onkeyup");
 },
 UseReadOnlyForDisabled: function(){
  return (__aspxIE || __aspxOpera) && !this.isNative;
 },
 NeedFocusCorrectionWhenDisabled: function(){
  return __aspxIE && !this.isNative;
 },
 OnPost: function() {
  if(this.GetEnabled() || !this.UseReadOnlyForDisabled())
    return;
  var inputElement = this.GetInputElement();
  if(inputElement) {
   inputElement.disabled = true;
   window.setTimeout(function() {
    inputElement.disabled = false;
   }.aspxBind(this), 0);
  }
 }
});
ASPxIdent.IsASPxClientTextEdit = function(obj) {
 return !!obj.isASPxClientTextEdit;
};
ASPxMaskValidationPattern = _aspxCreateClass(ASPxValidationPattern, {
 constructor: function(errorText, maskInfo) {
  this.constructor.prototype.constructor.call(this, errorText);
  this.maskInfo = maskInfo;
 },
 EvaluateIsValid: function(value) {
  return this.maskInfo.IsValid();
 }
});
ASPxClientTextBoxBase = _aspxCreateClass(ASPxClientTextEdit, {
 constructor: function(name) {
  this.constructor.prototype.constructor.call(this, name);
  this.sizingConfig.allowSetHeight = false;
  this.sizingConfig.adjustControl = true;
 }
});
ASPxClientTextBox = _aspxCreateClass(ASPxClientTextBoxBase, {
 constructor: function(name) {
  this.constructor.prototype.constructor.call(this, name);
  this.isASPxClientTextBox = true;
 }
});
ASPxClientTextBox.Cast = ASPxClientControl.Cast;
ASPxIdent.IsASPxClientTextBox = function(obj) {
 return !!obj.isASPxClientTextBox;
};
var __aspxMMinHeight = 34;
ASPxClientMemo = _aspxCreateClass(ASPxClientTextEdit, { 
 constructor: function(name) {
  this.constructor.prototype.constructor.call(this, name);        
  this.isASPxClientMemo = true;
  this.raiseValueChangedOnEnter = false;
 },
 CollapseControl: function(checkSizeCorrectedFlag) {
  if (checkSizeCorrectedFlag && this.sizeCorrectedOnce)
   return;
  var mainElement = this.GetMainElement();
  var inputElement = this.GetInputElement();
  if (!_aspxIsExistsElement(mainElement) || !_aspxIsExistsElement(inputElement))
   return;
  ASPxClientTextEdit.prototype.CollapseControl.call(this, checkSizeCorrectedFlag);
  var mainElementCurStyle = _aspxGetCurrentStyle(mainElement);
  if (this.heightCorrectionRequired && mainElement && inputElement) {
   if (mainElement.style.height == "100%" || mainElementCurStyle.height == "100%") {
    mainElement.style.height = "0";
    mainElement.wasCollapsed = true;
   }
   inputElement.style.height = "0";
  }
 },
 CorrectEditorHeight: function() {
  var mainElement = this.GetMainElement();
  if(mainElement.wasCollapsed) {
   mainElement.wasCollapsed = null;
   _aspxSetOffsetHeight(mainElement, _aspxGetClearClientHeight(_aspxFindOffsetParent(mainElement)));
  }
  if(!this.isNative) {
   var inputElement = this.GetInputElement();
   var inputClearClientHeight = _aspxGetClearClientHeight(_aspxFindOffsetParent(inputElement));
   if(__aspxIE) {
    inputClearClientHeight -= 2;
    var calculatedMainElementStyle = _aspxGetCurrentStyle(mainElement);
    inputClearClientHeight += _aspxPxToInt(calculatedMainElementStyle.borderTopWidth) + _aspxPxToInt(calculatedMainElementStyle.borderBottomWidth);
   }
   if(inputClearClientHeight < __aspxMMinHeight)
    inputClearClientHeight = __aspxMMinHeight;
   _aspxSetOffsetHeight(inputElement, inputClearClientHeight);
   mainElement.style.height = "100%";
  }
 },
 SetWidth: function(width) {
  this.constructor.prototype.SetWidth.call(this, width);
  if(__aspxIE)
   this.AdjustControl();
 },
 SetHeight: function(height) {
  this.GetInputElement().style.height = "1px";
  this.constructor.prototype.SetHeight.call(this, height);
  this.GetInputElement().style.height = this.GetMainElement().clientHeight + "px";
 },
 ClearErrorFrameElementsStyles: function() {
  var textarea = this.GetInputElement();
  if(!textarea)
   return;
  var scrollBarPosition = textarea.scrollTop;
  ASPxClientTextEdit.prototype.ClearErrorFrameElementsStyles.call(this);
  if(__aspxFirefox)
   textarea.scrollTop = scrollBarPosition;
 },
 AllowPreventingDefaultEnterBehavior: function() {
  return false; 
 }
});
ASPxClientMemo.Cast = ASPxClientControl.Cast;
ASPxIdent.IsASPxClientMemo = function(obj) {
 return !!obj.isASPxClientMemo;
};
ASPxClientButtonEditBase = _aspxCreateClass(ASPxClientTextBoxBase, {
 constructor: function(name) {
  this.constructor.prototype.constructor.call(this, name);        
  this.allowUserInput = true;
  this.allowMouseWheel = true;
  this.buttonCount = 0;
  this.ButtonClick = new ASPxClientEvent();
 },
 GetInputWidthCorrection: function(){
  if(__aspxIE && __aspxBrowserVersion <= 7){
   var mainElement = this.GetMainElement();
   var cellSpacing = _aspxGetAttribute(mainElement, "cellSpacing");
   if(cellSpacing === "0")
    return 1;
  }
  return 0;
 },
 GetButton: function(number) {
  return this.GetChild("_B" + number);
 },
 ProcessInternalButtonClick: function(buttonIndex) {
  return false;
 },
 OnButtonClick: function(number){
  var processOnServer = this.RaiseButtonClick(number);
  if (!this.ProcessInternalButtonClick(number) && processOnServer)
   this.SendPostBack('BC:' + number);
 },
 OnKeyPress: function(evt) {
  if(this.allowUserInput)
   ASPxClientTextBoxBase.prototype.OnKeyPress.call(this, evt);
 },
 RaiseButtonClick: function(number){
  var processOnServer = this.autoPostBack || this.IsServerEventAssigned("ButtonClick");
  if(!this.ButtonClick.IsEmpty()){
   var args = new ASPxClientButtonEditClickEventArgs(processOnServer, number);
   this.ButtonClick.FireEvent(this, args);
   processOnServer = args.processOnServer;
  }
  return processOnServer;
 },
 ChangeEnabledAttributes: function(enabled){
  ASPxClientTextEdit.prototype.ChangeEnabledAttributes.call(this, enabled);
  for(var i = 0; i < this.buttonCount; i++){
   var element = this.GetButton(i);
   if(element) 
    this.ChangeButtonEnabledAttributes(element, _aspxChangeAttributesMethod(enabled));
  }
 },
 ChangeEnabledStateItems: function(enabled){
  ASPxClientTextEdit.prototype.ChangeEnabledStateItems.call(this, enabled);
  for(var i = 0; i < this.buttonCount; i++){
   var element = this.GetButton(i);
   if(element) 
    aspxGetStateController().SetElementEnabled(element, enabled);
  }
 },
 ChangeButtonEnabledAttributes: function(element, method){
  method(element, "onclick");
  method(element, "ondblclick");
  method(element, "onmousedown");
  method(element, "onmouseup");
 },
 ChangeInputEnabled: function(element, enabled, readOnly){
  ASPxClientTextEdit.prototype.ChangeInputEnabled.call(this, element, enabled, readOnly || !this.allowUserInput);
 }
});
ASPxClientButtonEdit = _aspxCreateClass(ASPxClientButtonEditBase, {
});
ASPxClientButtonEdit.Cast = ASPxClientControl.Cast;
ASPxClientButtonEditClickEventArgs = _aspxCreateClass(ASPxClientProcessingModeEventArgs, {
 constructor: function(processOnServer, buttonIndex){
  this.constructor.prototype.constructor.call(this, processOnServer);
  this.buttonIndex = buttonIndex;
 }
});
function aspxETextChanged(name) { 
 var edit = aspxGetControlCollection().Get(name);
 if(edit != null) edit.OnTextChanged(); 
}
function aspxBEClick(name,number){
 var edit = aspxGetControlCollection().Get(name);
 if(edit != null) edit.OnButtonClick(number);
}
function aspxMaskPasteTimerProc(name){
 var edit = aspxGetControlCollection().Get(name);
 if(edit != null && edit.maskInfo) 
  edit.MaskPasteTimerProc();
}
function aspxMaskHintTimerProc() {
 var focusedEditor = ASPxClientEdit.GetFocusedEditor();
 if(focusedEditor != null && _aspxIsFunction(focusedEditor.MaskHintTimerProc))
  focusedEditor.MaskHintTimerProc();
}
function _aspxSetFocusToTextEditWithDelay(name) {
 _aspxSetTimeout(function() {
  var edit = aspxGetControlCollection().Get(name);
  if(!edit)
   return;
  __aspxIE ? edit.SetCaretPosition(0) : edit.SetFocus();
 }, 500);
}
/*# using DevExpress.Web.ASPxClasses.Scripts; #*/
/*# namespace DevExpress.Web.ASPxLoadingPanel.Scripts #*/

/*# public class ASPxClientLoadingPanel : ASPxClientControl #*/
ASPxClientLoadingPanel = _aspxCreateClass(ASPxClientControl, {
    constructor: function(name) {
        this.constructor.prototype.constructor.call(this, name);
        
        this.containerElementID = "";
        this.containerElement = null;
        this.horizontalOffset = 0;
        this.verticalOffset = 0;
        
        this.isTextEmpty = false;
        this.showImage = true;

        this.shown = false;
        this.currentoffsetElement = null;
        this.currentX = null;
        this.currentY = null;
    },
    
    Initialize: function(){
        if(this.containerElementID != "")
            this.containerElement = _aspxGetElementById(this.containerElementID);
        this.constructor.prototype.Initialize.call(this);
    },
    SetCurrentShowArguments: function(offsetElement, x, y){
        if(offsetElement == null) 
            offsetElement = this.containerElement;
        if(offsetElement && !_aspxIsValidElement(offsetElement))
            offsetElement = _aspxGetElementById(offsetElement.id);
        if(offsetElement == null) 
            offsetElement = document.body;
            
        this.currentoffsetElement = offsetElement;
        this.currentX = x;
        this.currentY = y;
    },
    ResetCurrentShowArguments: function(){
        this.currentoffsetElement = null;
        this.currentX = null;
        this.currentY = null;
    },
    SetLoadingPanelPosAndSize: function(){
        var element = this.GetMainElement();
        this.SetLoadingPanelLocation( this.currentoffsetElement, element, this.currentX, this.currentY, this.horizontalOffset, this.verticalOffset);
    },
    SetLoadingDivPosAndSize: function(){
        var element = this.GetLoadingDiv();
        if(element != null){
            _aspxSetElementDisplay(element, true);
            this.SetLoadingDivBounds(this.currentoffsetElement, element);
        }
    },
    ShowInternal: function(offsetElement, x, y){
        this.SetCurrentShowArguments(offsetElement, x, y);
            
        var element = this.GetMainElement();
        _aspxSetElementDisplay(element, true);
        this.SetLoadingPanelPosAndSize();
        this.SetLoadingDivPosAndSize();
        this.shown = true;
    },
    /*# public void Show(){ return; } #*/
    Show: function(){
        this.ShowInternal(null);
    },
    /*# public void ShowInElement(object htmlElement){ return; } #*/
    ShowInElement: function(htmlElement){
        if(htmlElement)
            this.ShowInternal(htmlElement);
    },
    /*# public void ShowInElementByID(string id){ return; } #*/
    ShowInElementByID: function(id){
        var htmlElement = _aspxGetElementById(id);
        this.ShowInElement(htmlElement);
    },
    /*# public void ShowAtPos(int x, int y){ return; } #*/
    ShowAtPos: function(x, y){
        this.ShowInternal(null, x, y);
    },
    /*# public void SetText(string text) { } #*/
    SetText: function(text){
        this.isTextEmpty = text == null || text == "";
        this.GetTextLabel().innerHTML = this.isTextEmpty ? "&nbsp;" : text;
    },
    /*# public string GetText() { return ""; } #*/
    GetText: function() {
        return this.isTextEmpty ? "" : this.GetTextLabel().innerHTML;
    },
    /*# public void Hide(){ return; } #*/
    Hide: function(){
        var element = this.GetMainElement();
        _aspxSetElementDisplay(element, false);
        element = this.GetLoadingDiv();
        if(element != null) {
            _aspxSetStyleSize(element, 1, 1);// B150515
            _aspxSetElementDisplay(element, false);
        }
        this.ResetCurrentShowArguments();
        this.shown = false;
    },

    GetTextLabel: function(){
        return this.GetChild("_TL");
    },
    GetVisible: function(){
        return _aspxGetElementDisplay(this.GetMainElement());
    },
    SetVisible: function(visible){
        if(visible && !this.IsVisible())
            this.Show();
        else if(!visible && this.IsVisible())
            this.Hide();
    },
    OnBrowserWindowResizeInternal: function(){
        if(this.shown){
            this.SetLoadingPanelPosAndSize();
            this.SetLoadingDivPosAndSize();
        }
    }
});
/*# public static new ASPxClientLoadingPanel Cast(object obj){ return null; } #*/
ASPxClientLoadingPanel.Cast = ASPxClientControl.Cast;
// DragHelper
var __aspxDragHelper = null;

ASPxClientDragHelper = _aspxCreateClass(null, {
    constructor: function(e, root, clone){
        if(__aspxDragHelper != null) __aspxDragHelper.cancelDrag();
        this.dragArea = 5;
        this.clickX = _aspxGetEventX(e);
        this.clickY = _aspxGetEventY(e);

        this.centerClone = false;
        this.cachedCloneWidth = -1;
        this.cachedCloneHeight = -1;
        this.cachedOriginalX = -1;
        this.cachedOriginalY = -1;

        this.canDrag = true; 
        if(typeof(root) == "string") 
            root = _aspxGetParentByTagName(_aspxGetEventSource(e), root);
        this.obj = root && root != null ? root : _aspxGetEventSource(e);
        this.clone = clone;
        this.dragObj = null; 
        this.additionalObj = null;
        //events
        this.onDoClick = null;
        this.onEndDrag = null;
        this.onCancelDrag = null;
        this.onDragDivCreating = null;
        this.onCloneCreating = null;
        this.onCloneCreated = null;
        
        this.dragDiv = null;
        __aspxDragHelper = this;
        this.clearSelectionOnce = false;
    },    
    drag: function(e) {
        if(!this.canDrag) return;
        _aspxClearSelection();
        if(!this.isDragging()) {
            if(!this.isOutOfDragArea(e)) 
                return;
            this.startDragCore(e);
        }
        if(__aspxIE && !_aspxGetIsLeftButtonPressed(e)) {
            this.cancelDrag(e);
            return;
        }
        if(!__aspxIE)
            _aspxSetElementSelectionEnabled(document.body, false);
        this.dragCore(e);
    },
    startDragCore: function(e) {        
        this.dragObj = this.clone != true ? this.obj : this.createClone(e);
    },
    dragCore: function(e) {    
        this.updateDragDivPosition(e);
    },
    endDrag: function(e) {    
        if(!this.isDragging() && !this.isOutOfDragArea(e)) {
            if(this.onDoClick)
                this.onDoClick(this);
        } else {
            if(this.onEndDrag)
                this.onEndDrag(this);
        }
        this.cancelDrag();
    },
    cancelDrag: function() {
        if(this.dragDiv != null) {
            document.body.removeChild(this.dragDiv);
            this.dragDiv = null;
        }
        if(this.onCancelDrag)
            this.onCancelDrag(this);
        __aspxDragHelper = null;
        if(!__aspxIE)
            _aspxSetElementSelectionEnabled(document.body, true);
    },
    isDragging: function() {       
        return this.dragObj != null;
    },
    updateDragDivPosition: function(e) {
        if(this.centerClone) {
            this.dragDiv.style.left = _aspxGetEventX(e) - this.cachedCloneWidth / 2 + "px";
            this.dragDiv.style.top = _aspxGetEventY(e) - this.cachedCloneHeight / 2 + "px";
        } else {
            this.dragDiv.style.left = this.cachedOriginalX + _aspxGetEventX(e) - this.clickX + "px";
            this.dragDiv.style.top = this.cachedOriginalY + _aspxGetEventY(e) - this.clickY + "px";
        }
    },
    createClone: function(e) {
        this.dragDiv = document.createElement("div");
        if(this.onDragDivCreating)
            this.onDragDivCreating(this, this.dragDiv);
                
        var clone = this.creatingClone();        
        this.dragDiv.appendChild(clone);
        document.body.appendChild(this.dragDiv);

        this.dragDiv.style.position = "absolute";       
        this.dragDiv.style.cursor = "move";
        this.dragDiv.style.borderStyle = "none";
        this.dragDiv.style.padding = "0";
        this.dragDiv.style.margin = "0";
        this.dragDiv.style.backgroundColor = "transparent";
        this.dragDiv.style.zIndex = 20000; //TODO
             
        if(this.onCloneCreated)
            this.onCloneCreated(clone);
        
        this.cachedCloneWidth = clone.offsetWidth;
        this.cachedCloneHeight = clone.offsetHeight;

        if(!this.centerClone) {        
            this.cachedOriginalX = _aspxGetAbsoluteX(this.obj);
            this.cachedOriginalY = _aspxGetAbsoluteY(this.obj);
        }

        this.dragDiv.style.width = this.cachedCloneWidth + "px";
        this.dragDiv.style.height = this.cachedCloneHeight + "px";
        this.updateDragDivPosition(e);


        return this.dragDiv;
    },
    creatingClone: function() {
        var clone = this.obj.cloneNode(true);
        if(!this.onCloneCreating) return clone;
        return this.onCloneCreating(clone);
    },
    addElementToDragDiv: function(element) {
        if(this.dragDiv == null) return;
        this.additionalObj = element.cloneNode(true);
        this.additionalObj.style.visibility = "visible";
        this.additionalObj.style.display = "";
        this.additionalObj.style.top = "";
        this.dragDiv.appendChild(this.additionalObj);
    },
    removeElementFromDragDiv: function() {
        if(this.additionalObj == null || this.dragDiv == null) return;
        this.dragDiv.removeChild(this.additionalObj);
        this.additionalObj = null;
    },
    isOutOfDragArea: function(e) {
        return Math.max(
            Math.abs(_aspxGetEventX(e) - this.clickX), 
            Math.abs(_aspxGetEventY(e) - this.clickY)
        ) >= this.dragArea;
    }
});

function DragHelper_onmouseup(e) {
    if(__aspxDragHelper != null) {
        __aspxDragHelper.endDrag(e);
        return true;
    }
}
function DragHelper_onmousemove(e) {
    if(__aspxDragHelper != null && !(__aspxTouchUI && ASPxClientTouchUI.isGesture)) {
        __aspxDragHelper.drag(e);
        if(ASPxClientTouchUI.isTouchEvent(e)) {
            e.preventDefault();
            ASPxClientTouchUI.preventScrollOnEvent(e);
        }
        return true;
    }
}
function DragHelper_onkeydown(e) {
    if(!__aspxDragHelper) return;
    if(e.keyCode == ASPxKey.Esc)
        __aspxDragHelper.cancelDrag();
    return true;
}
function DragHelper_onkeyup(e) {
    if (!__aspxDragHelper) return;
    if(e.keyCode == ASPxKey.Esc && __aspxWebKitFamily)//B182720
        __aspxDragHelper.cancelDrag();
    return true;
}

function DragHelper_onselectstart(e) {
    var drag = __aspxDragHelper;
    if(drag && (drag.canDrag || drag.clearSelectionOnce)) {
        _aspxClearSelection();
        drag.clearSelectionOnce = false;
        return false;
    }
}

_aspxAttachEventToDocument(ASPxClientTouchUI.touchMouseUpEventName, DragHelper_onmouseup);
_aspxAttachEventToDocument(ASPxClientTouchUI.touchMouseMoveEventName, DragHelper_onmousemove);
_aspxAttachEventToDocument("keydown", DragHelper_onkeydown);
_aspxAttachEventToDocument("keyup", DragHelper_onkeyup);
_aspxAttachEventToDocument("selectstart", DragHelper_onselectstart);

// CursorTargets
var __aspxCursorTargets = null;

ASPxClientCursorTargets = _aspxCreateClass(null, {
    constructor: function() {
        this.list = [];
        this.starttargetElement = null;
        this.starttargetTag = 0;
        this.oldtargetElement = null;
        this.oldtargetTag = 0;
        this.targetElement = null;
        this.targetTag = 0;
        this.x = 0;
        this.y = 0;
        this.removedX = 0;
        this.removedY = 0;
        this.removedWidth = 0;
        this.removedHeight = 0;
        //events
        this.onTargetCreated = null;
        this.onTargetChanging = null;
        this.onTargetChanged = null;
        this.onTargetAdding = null;
        this.onTargetAllowed = null;
        __aspxCursorTargets = this;
    },
    addElement: function(element) {
        if(!this.canAddElement(element)) return null;
        var target = new ASPxClientCursorTarget(element);
        this.onTargetCreated && this.onTargetCreated(this, target);
        this.list.push(target);
        return target;
    },
    removeElement: function(element) {
        for(var i = 0; i < this.list.length; i++) {
            if(this.list[i].element == element) {
                this.list.splice(i, 1);
                return;
            }
        }
    },
    addParentElement: function(parent, child) {
        var target = this.addElement(parent);
        if(target != null) {
            target.targetElement = child;
        }
        return target;
    },
    RegisterTargets: function(element, idPrefixArray) {
        this.addFunc = this.addElement;
        this.RegisterTargetsCore(element, idPrefixArray);
    },
    UnregisterTargets: function(element, idPrefixArray) {
        this.addFunc = this.removeElement;
        this.RegisterTargetsCore(element, idPrefixArray);
    },
    RegisterTargetsCore: function(element, idPrefixArray) {
        if(element == null) return;
        for(var i = 0; i < idPrefixArray.length; i++)
            this.RegisterTargetCore(element, idPrefixArray[i]);
    },
    RegisterTargetCore: function(element, idPrefix) {
        if(!_aspxIsExists(element.id)) return;
        if(element.id.indexOf(idPrefix) > -1)
            this.addFunc(element);
        for(var i = 0; i < element.childNodes.length; i++)
            this.RegisterTargetCore(element.childNodes[i], idPrefix);
    },
    canAddElement: function(element) {
        if(element == null || !_aspxGetElementDisplay(element))
            return false;
        for(var i = 0; i < this.list.length; i++) {
            if(this.list[i].targetElement == element) return false;
        }
        if(this.onTargetAdding != null && !this.onTargetAdding(this, element)) return false;
        return element.style.visibility != "hidden";
    },
    removeInitialTarget: function(x, y) {
        var el = this.getTarget(x + _aspxGetDocumentScrollLeft(), y + _aspxGetDocumentScrollTop());
        if(el == null) return;
        this.removedX = _aspxGetAbsoluteX(el);
        this.removedY = _aspxGetAbsoluteY(el);
        this.removedWidth = el.offsetWidth;
        this.removedHeight = el.offsetHeight;
    },
    getTarget: function(x, y) {
        for(var i = 0; i < this.list.length; i++) {
            var record = this.list[i];
            if(record.contains(x, y)) {
                if(!this.onTargetAllowed || this.onTargetAllowed(record.targetElement, x, y))
                    return record.targetElement;
            }
        }
        return null;
    },
    targetChanged: function(element, tag) {
        this.targetElement = element;
        this.targetTag = tag;
        if(this.onTargetChanging)
            this.onTargetChanging(this);
        if(this.oldtargetElement != this.targetElement || this.oldtargetTag != this.targetTag) {
            if(this.onTargetChanged)
                this.onTargetChanged(this);
            this.oldtargetElement = this.targetElement;
            this.oldtargetTag = this.targetTag;
        }
    },
    cancelChanging: function() {
        this.targetElement = this.oldtargetElement;
        this.targetTag = this.oldtargetTag;
    },
    isLeftPartOfElement: function() {
        if(this.targetElement == null) return true;
        var left = this.x - this.targetElementX();
        return left < this.targetElement.offsetWidth / 2;
    },
    isTopPartOfElement: function() {
        if(this.targetElement == null) return true;
        var top = this.y - this.targetElementY();
        return top < this.targetElement.offsetHeight / 2;
    },
    targetElementX: function() {
        return this.targetElement != null ? _aspxGetAbsoluteX(this.targetElement) : 0;
    },
    targetElementY: function() {
        return this.targetElement != null ? _aspxGetAbsoluteY(this.targetElement) : 0;
    },
    onmousemove: function(e) {
        this.doTargetChanged(e);
    },
    onmouseup: function(e) {
        this.doTargetChanged(e);
        __aspxCursorTargets = null;
    },
    doTargetChanged: function(e) {
        this.x = _aspxGetEventX(e);
        this.y = _aspxGetEventY(e);
        if(this.inRemovedBounds(this.x, this.y)) return;
        this.targetChanged(this.getTarget(this.x, this.y), 0);
    },
    inRemovedBounds: function(x, y) {
        if(this.removedWidth == 0) return false;
        return x > this.removedX && x < (this.removedX + this.removedWidth) &&
            y > this.removedY && y < (this.removedY + this.removedHeight);
    }
});

ASPxClientCursorTarget = _aspxCreateClass(null, {
    constructor: function(element) {
        this.element = element;
        this.targetElement = element;
        this.absoluteX = _aspxGetAbsoluteX(element);
        this.absoluteY = _aspxGetAbsoluteY(element);
    },
    contains: function(x, y) {
        return x >= this.absoluteX && x <= this.absoluteX + this.GetElementWidth() &&
            y >= this.absoluteY && y <= this.absoluteY + this.GetElementHeight();
    },
    GetElementWidth: function() {
        return this.element.offsetWidth;
    },
    GetElementHeight: function() {
        return this.element.offsetHeight;
    }
});

function CursorTarget_onmouseup(e) {
    if(__aspxCursorTargets != null) {
        __aspxCursorTargets.onmouseup(e);
        return true;
    }
}

function CursorTarget_onmousemove(e) {
    if(__aspxCursorTargets != null) {
        __aspxCursorTargets.onmousemove(e);
        return true;
    }
}

_aspxAttachEventToDocument(ASPxClientTouchUI.touchMouseUpEventName, CursorTarget_onmouseup);
_aspxAttachEventToDocument(ASPxClientTouchUI.touchMouseMoveEventName, CursorTarget_onmousemove);


ASPxClientTreeList = _aspxCreateClass(ASPxClientControl, {
 constructor: function(name) {
  this.constructor.prototype.constructor.call(this, name);
  this.elementCache = { };  
  this.rowIdPrefix = this.name + "_" + this.RowIDSuffix;
  this.focusedKey = null;
  this.dragHelper = new ASPxClientTreeListDragHelper(this);
  this.lpTimer = -1;
  this.selectionDiff = { };
  this.syncLock = false;
  this.callbackHandlersPool = [ ];
  this.kbdHelper = null;
  this.selectionStartKey = null;
  this.internalCheckBoxCollection = null;
  this.enableFocusedNode = false;
  this.lpDelay = 300;  
  this.lpDisable = false;
  this.focusSendsCallback = false;
  this.selectionSendsCallback = false;
  this.recursiveSelection = false;
  this.columns = [ ];
  this.expandCollapseAction = this.ExpandCollapseAction.Button;
  this.focusOnExpandCollapse = true;
  this.confirmDeleteMsg = null;
  this.allowStylizeEditingNode = false;
  this.enableKeyboard = false;
  this.accessKey = null;
  this.checkBoxImageProperties = null;
  this.icbFocusedStyle = [];
  this.showRoot = false;
  this.maxVisibleLevel = -1;
  this.visibleColumnCount = 0;
  this.rowCount = 0;
  this.editingKey = null;
  this.isNewNodeEditing = false;
  this.pageIndex = -1;
  this.pageSize = -1;
  this.pageCount = 1;
  this.FocusedNodeChanged = new ASPxClientEvent();
  this.SelectionChanged = new ASPxClientEvent();
  this.CustomizationWindowCloseUp = new ASPxClientEvent();
  this.CustomDataCallback = new ASPxClientEvent();  
  this.NodeClick = new ASPxClientEvent();
  this.NodeDblClick = new ASPxClientEvent();
  this.ContextMenu = new ASPxClientEvent();
  this.StartDragNode = new ASPxClientEvent();
  this.EndDragNode = new ASPxClientEvent();  
  this.CustomButtonClick = new ASPxClientEvent();
  this.NodeFocusing = new ASPxClientEvent();
  this.NodeExpanding = new ASPxClientEvent();
  this.NodeCollapsing = new ASPxClientEvent();
 },
 InlineInitialize: function() {
  ASPxClientControl.prototype.InlineInitialize.call(this);
  this.RefreshArmatureRow();
  if(this.enableKeyboard) {
   this.kbdHelper = new ASPxTreeListKbdHelper(this);
   this.kbdHelper.Init();
   ASPxKbdHelper.RegisterAccessKey(this);
  }
  if(this.checkBoxImageProperties) 
   this.CreateInternalCheckBoxCollection();
 },
 CreateInternalCheckBoxCollection: function() {
  if(!this.internalCheckBoxCollection)
   this.internalCheckBoxCollection = new ASPxCheckBoxInternalCollection(this.checkBoxImageProperties, true);
  else
   this.internalCheckBoxCollection.SetImageProperties(this.checkBoxImageProperties);
  this.CompleteInternalCheckBoxCollection();
 },
 CompleteInternalCheckBoxCollection: function() {
  var container = this.GetUpdatableCell();
  var selectAllCheck = this.FindSelectAllCheckBox();
  var icbInputElements = this.FindSelectionCheckBoxes(container);
  this.internalCheckBoxCollection.Clear();
  for(var i = 0; i < icbInputElements.length; i++)
   this.AddInternalCheckBoxToCollection(icbInputElements[i]);
  if(selectAllCheck)
   this.AddSelectAllCheckBoxToCollection(selectAllCheck);
 },
 AddInternalCheckBoxToCollection: function(icbInputElement) {
  var instance = this;
  var row = this.FindDataRow(icbInputElement);
  var internalCheckBox = this.internalCheckBoxCollection.Add(row.id, icbInputElement);
  internalCheckBox.CreateFocusDecoration(this.icbFocusedStyle);
  internalCheckBox.SetEnabled(this.GetEnabled());
  internalCheckBox.readOnly = this.readOnly;
  internalCheckBox.CheckedChanged.AddHandler(
   function(s, e) {
    if(instance.IsNodeDragDropEnabled()) 
     instance.OnNodeSelecting(_aspxGetEventSource(e));
    else
     instance.OnRowCheckBoxClick(e);
   }
  );
 },
 AddSelectAllCheckBoxToCollection: function(selectAllCheckInput) {
  var instance = this;
  var selectAllInternalCheckBox = this.internalCheckBoxCollection.Add(selectAllCheckInput.id, selectAllCheckInput);
  selectAllInternalCheckBox.CreateFocusDecoration(this.icbFocusedStyle);
  selectAllInternalCheckBox.SetEnabled(this.GetEnabled());
  selectAllInternalCheckBox.readOnly = this.readOnly;
  selectAllInternalCheckBox.CheckedChanged.AddHandler(
   function(s, e) {
    instance.OnSelectingAll(s.GetChecked());
   }
  );
 },
 IsNodeDragDropEnabled: function() {
  return !!this.GetDataTable().onmousedown;
 },
 OnNodeSelecting: function(check) { 
  this.OnNodeSelectingCore(check);  
  if(this.RaiseSelectionChanged())
   this.SendDummyCommand();  
 },
 OnNodeSelectingCore: function(check) {
  var row = this.FindDataRow(check);  
  if(!_aspxIsExistsElement(row)) return;
  var nodeKey = this.GetNodeKeyByRow(row);   
  if(this.selectionDiff[nodeKey])
   delete this.selectionDiff[nodeKey];
  else
   this.selectionDiff[nodeKey] = 1;   
  this.PersistSelectionDiff();    
  this.UpdateRowStyle(nodeKey);  
 },
 OnSelectingAll: function(state) {
  var input = this.GetSelectAllMarkInput();
  if(!_aspxIsExistsElement(input))
   return;
  input.value = state ? "A" : "N";  
  this.SendDummyCommand();
  this.RaiseSelectionChanged();
 },
 OnFocusingNode: function(key, htmlEvent) {  
  var prevKey = this.GetFocusedNodeKey();
  if(prevKey != key && this.RaiseNodeFocusing(key, htmlEvent)) {
   this.SetFocusedNodeKey(key);
   return this.RaiseFocusedNodeChanged();
  }
  return false;
 },
 OnDataTableMouseDown: function(e) { 
  if(this.syncLock) return;
  if(!_aspxGetIsLeftButtonPressed(e)) return;
  e = _aspxGetEvent(e);
  var row = this.FindDataRow(_aspxGetEventSource(e));
  if(!_aspxIsExistsElement(row))
   return;
  var helper = this.dragHelper;  
  var canDrag = !this.IsEditing();  
  if(canDrag) {
   var nodeKey = this.GetNodeKeyByRow(row);
   var targets = this.GetAllDataRows();
   var header = this.GetHeaderRow();
   if(_aspxIsExistsElement(header))
    targets.push(header);
   canDrag = this.RaiseStartDragNode(nodeKey, e, targets);
   if(canDrag)
    helper.CreateNodeTargets(targets, row);
  }
  var drag = helper.CreateNodeDrag(row, e, canDrag);
 },
 OnDataTableClick: function(e) {
  if(this.syncLock) return;
  e = _aspxGetEvent(e);
  var source = _aspxGetEventSource(e);
  var sourceIsIndent = this.FindIndentCell(source) != null;
  var sourceIsCommandCell = this.FindCommandCell(source) != null;
  var row = this.FindDataRow(source);
  if(!_aspxIsExistsElement(row))
   return;
  var nodeKey = this.GetNodeKeyByRow(row);
  if(!sourceIsIndent && !sourceIsCommandCell) {
   if(!this.RaiseNodeClick(nodeKey, e))  
    return;
  }
  var tag = source.tagName;
  var className = source.className;
  this.selectionStartKey = nodeKey;
  if(tag == "IMG") {
   if(className.indexOf(this.ExpandButtonClassName) > -1) {
    if(this.enableFocusedNode && this.focusOnExpandCollapse)
     this.OnFocusingNode(nodeKey, e);
    if(this.RaiseNodeExpanding(nodeKey, e))
     this.ExpandNode(nodeKey);    
    return;
   }
   if(className.indexOf(this.CollapseButtonClassName) > -1) {
    if(this.enableFocusedNode && this.focusOnExpandCollapse)
     this.OnFocusingNode(nodeKey, e);
    if(this.RaiseNodeCollapsing(nodeKey, e))
     this.CollapseNode(nodeKey);
    return;   
   }
  }
  if(!sourceIsIndent) {     
   var processOnServer = this.enableFocusedNode ? this.OnFocusingNode(nodeKey, e) : false;
   if(!sourceIsCommandCell 
    && this.expandCollapseAction == this.ExpandCollapseAction.NodeClick 
    && this.TryExpandCollapse(nodeKey, row))
    return;    
   if(processOnServer)
    this.SendDummyCommand();
  }
 },
 OnRowCheckBoxClick: function(e) {
  if(!this.IsNodeDragDropEnabled()) {
   var source = _aspxGetEventSource(e);
   var row = this.FindDataRow(source);
   if(!_aspxIsExistsElement(row))
    return;
   var nodeKey = this.GetNodeKeyByRow(row);
   if(this.enableFocusedNode)
    this.OnFocusingNode(nodeKey, e);
   this.OnNodeSelecting(source);
  }
 },
 OnDataTableDblClick: function(e) {
  if(this.syncLock) return;
  e = _aspxGetEvent(e);  
  var source = _aspxGetEventSource(e);
  if(this.FindIndentCell(source) != null)
   return;  
  var row = this.FindDataRow(source);
  if(!_aspxIsExistsElement(row))
   return;
  var nodeKey = this.GetNodeKeyByRow(row);
  if(!this.IsEditing())
   _aspxClearSelection();    
  if(!this.RaiseNodeDblClick(nodeKey, e))
   return;
  if(this.expandCollapseAction == this.ExpandCollapseAction.NodeDblClick)
   this.TryExpandCollapse(nodeKey, row);
 },
 TryExpandCollapse: function(nodeKey, row) {
  if(nodeKey && nodeKey == this.editingKey)
   return;
  var state = this.GetNodeState(nodeKey, row);
  if(state == "Expanded") {
   this.CollapseNode(nodeKey);
   return true;
  } else if(state == "Collapsed") {
   this.ExpandNode(nodeKey);
   return true;
  }
  return false;
 },  
 OnHeaderMouseDown: function(element, e) { 
  if(this.syncLock) return;
  if(!_aspxGetIsLeftButtonPressed(e)) return;
  var canDrag = element.id.indexOf(this.DragAndDropTargetMark) > -1;
  var drag = this.dragHelper.CreateHeaderDrag(element, e, canDrag);
  this.dragHelper.CreateHeaderTargets(drag, e);  
 },
 OnHeaderClick: function(element, shiftKey, ctrlKey) {
  if(this.syncLock) return;
  var index = this.GetLastNumberOfId(element);
  var column = this.GetColumnByIndex(index);
  if(column != null && column.canSort)
   this.SendSortCommand(index, ctrlKey ? "none" : "", !shiftKey && !ctrlKey);
 },
 OnColumnMoving: function(sourceIndex, targetIndex, before) {    
  this.SendCommand("MoveColumn", [sourceIndex, targetIndex, before]);
 },
 OnNodeDeleting: function(nodeKey) {
  if(this.confirmDeleteMsg != null && !confirm(this.confirmDeleteMsg))
   return;
  this.DeleteNode(nodeKey);
 },
 OnContextMenu: function(objectType, objectKey, htmlEvent) {
  var e = new ASPxClientTreeListContextMenuEventArgs(objectType, objectKey, htmlEvent);
  this.RaiseContextMenu(e);
  return e.cancel;
 }, 
 DoCallback: function(result) {
  ASPxClientControl.prototype.DoCallback.call(this, result);
  this.syncLock = false;
 }, 
 OnCallback: function(result) {
  this.ProcessCallbackResult(result);
  this.RefreshArmatureRow();
 },
 OnCallbackError: function(result, data) {
  if(result != "") {
   this.ShowPopupEditForm();
   var cell = this.GetErrorCell();
   if(_aspxIsExistsElement(cell)) {
    _aspxSetElementDisplay(cell.parentNode, true);
    _aspxSetInnerHtml(cell, result);
   } 
   else 
    alert(result);
  }
 },
 SendCommand: function(command, args) {
  if(this.syncLock)
   return;   
  this.SerializeEditorValues();
  this.HidePopupEditForm();
  var id = this.CommandId[command];
  this.ShowLoadingPanel();  
  var monoArg = args ? ([id].concat(args)).join(this.SeparatorToken) : id;
  if(this.callBack && this.CanCreateCallback()) {   
   this.PurgeCaches();
   this.syncLock = true;
   this.CreateCallback(monoArg, command);
  } else 
   this.SendPostBack(monoArg);  
 },
 SendDummyCommand: function(sync) {
  this.SendCommand("Dummy");
  if(!sync)
   this.syncLock = false; 
 },
 SendSortCommand: function(columnIndex, order, reset) {
  this.SendCommand("Sort", [columnIndex, order, reset]);
 }, 
 SendPagerCommand: function(arg, fromKbd) {
  var list = [ arg ];
  if(fromKbd) list.push("k");
  this.SendCommand("Pager", list);
 },
 SendAsyncCommand: function(command, args) {
  if(!this.callBack) return;
  var monoArg = [this.CommandId[command], args].join(this.SeparatorToken);
  this.CreateCallback(monoArg, command);
 },
 SendGetNodeValuesCommand: function(handler, mode, nodeKey, fieldNames) {
  if(fieldNames === null) fieldNames = "";
  var index = this.GetCallbackHandlerIndex(handler);
  var monoArg = ([index, mode, this.EscapeNodeKey(nodeKey)].concat(fieldNames)).join(this.SeparatorToken);
  this.SendAsyncCommand("GetNodeValues", monoArg);  
 },
 HidePopupEditForm: function() {
  var popup = this.GetPopupEditForm();
  if(popup)
   popup.Hide();
 },
 ShowPopupEditForm: function() { 
  var popup = this.GetPopupEditForm();
  if(popup && !popup.IsVisible())
   popup.Show();
 },
 ShowLoadingPanel: function() {
  if(this.lpDisable || this.lpTimer > -1)
   return;
  this.HideLoadingPanel();
  this.HideLoadingDiv();
  this.CreateLoadingDiv(this.GetUpdatableCell());   
  if(this.lpDelay > 10) {
   var js = "aspxTLShowLoadingPanel('" + this.name + "')";
   this.lpTimer = _aspxSetTimeout(js, this.lpDelay);
  } else {
   this.ShowLoadingPanelCore();
  }    
 },
 ShowLoadingPanelCore: function() {
  this.ClearLoadingPanelTimer();
  this.GetLoadingDiv().style.cursor = "wait";
  this.CreateLoadingPanelWithAbsolutePosition(this.GetUpdatableCell());
 },
 ClearLoadingPanelTimer: function() {
  this.lpTimer = _aspxClearTimer(this.lpTimer);  
 },
 HideLoadingPanel: function() {
  this.ClearLoadingPanelTimer();
  this.constructor.prototype.HideLoadingPanel.call(this);
 },
 ProcessCallbackResult: function(resultObj) {
  if(resultObj.customData) {   
   if(_aspxIsExists(resultObj.handler)) {
    var index = parseInt(resultObj.handler);
    var handler = this.callbackHandlersPool[index];
    this.callbackHandlersPool[index] = null;
    handler(resultObj.data);
   } else {
    this.RaiseCustomDataCallback(resultObj.arg, resultObj.data);
   }
   return;
  }      
  this.GetCallbackStateInput().value = resultObj.state;
  if(_aspxIsExists(resultObj.fkey))
   this.SetFocusedNodeKeyInternal(resultObj.fkey);
  var selectionInput = this.GetSelectionInput();
  if(_aspxIsExistsElement(selectionInput))
   selectionInput.value = "";
  var selectAllMarkInput = this.GetSelectAllMarkInput();
  if(_aspxIsExistsElement(selectAllMarkInput))
   selectAllMarkInput.value = "";
  if(_aspxIsExists(resultObj.pi))
   this.pageIndex = resultObj.pi;
  if(_aspxIsExists(resultObj.ps))
   this.pageSize = resultObj.ps;
  if(_aspxIsExists(resultObj.pc))
   this.pageCount = resultObj.pc;
  if(resultObj.cp) {   
   for(var name in resultObj.cp)
    this[name] = resultObj.cp[name];
  }
  if(_aspxIsExists(resultObj.partial))
   this.ProcessPartialCallbackResult(resultObj);
  else
   this.ProcessFullCallbackResult(resultObj);
  if(this.checkBoxImageProperties)
   this.CreateInternalCheckBoxCollection();
  this.maxVisibleLevel = resultObj.level;
  this.visibleColumnCount = resultObj.visColCount;
  this.rowCount = resultObj.rows;
  this.editingKey = _aspxIsExists(resultObj.editingKey) ? resultObj.editingKey : null;
  this.isNewNodeEditing = _aspxIsExists(resultObj.newNode);
 }, 
 ProcessPartialCallbackResult: function(resultObj) {
  this.UpdateFirstDataCellSpans(resultObj.level);
  var row = this.GetRowByNodeKey(resultObj.partial);
  if(!_aspxIsExistsElement(row))
   return;
  if(resultObj.remove)
   this.KillNextRows(row, resultObj.remove);
  var uid = "";
  var cell = this.GetUpdatableCell();
  var html = cell.innerHTML;
  do {
   uid = this.GenerateUID();
  } while(html.indexOf(uid) > -1);
  var placeholder = document.createTextNode(uid);  
  row.parentNode.insertBefore(placeholder, row);
  this.DestroyHtmlRow(row);  
  this.HideLoadingDiv();
  this.HideLoadingPanel();
  var data = resultObj.data;
  data = data.replace('$\'', '$$$$\''); 
  html = cell.innerHTML.replace(/<script(.|\s)*?\/script>/ig, "");  
  html = html.replace(uid, data);
  _aspxSetInnerHtml(cell, html);
 },
 ProcessFullCallbackResult: function(resultObj) {
  _aspxSetInnerHtml(this.GetUpdatableCell(), resultObj.data);
 },
 GetCallbackStateInput:   function() { return this.GetCachedElementById("STATE"); },
 GetFocusedKeyInput:    function() { return this.GetCachedElementById("FKey"); },
 GetSelectionInput:    function() { return this.GetCachedElementById("Sel"); },
 GetSelectAllMarkInput:   function() { return this.GetCachedElementById("SAM"); },
 GetEditorValuesInput:   function() { return this.GetCachedElementById("EV"); },
 GetDataTable:     function() { return this.GetCachedElementById("D"); },
 GetUpdatableCell:    function() { return this.GetCachedElementById("U"); },   
 GetStyleTable:     function() { return this.GetCachedElementById("ST"); },
 GetDragAndDropArrowDownImage: function() { return this.GetCachedElementById("DAD"); },
 GetDragAndDropArrowUpImage:  function() { return this.GetCachedElementById("DAU"); },
 GetDragAndDropHideImage:  function() { return this.GetCachedElementById("DH"); },
 GetDragAndDropNodeImage:  function() { return this.GetCachedElementById("DN"); },
 GetErrorCell:       function() { return this.GetCachedElementById(this.GetPopupEditForm() ? this.PopupEditFormSuffix + "_Error" : "Error"); },
 GetHeaderRow:     function() { return this.GetCachedElementById("HDR"); },
 GetCustomizationWindow: function() { 
  return aspxGetControlCollection().Get(this.name + this.GetCustomizationWindowSuffix()); 
 },
 GetCustomizationWindowElement: function() {
  var win = this.GetCustomizationWindow();
  return win ? win.GetWindowElement(-1) : null;  
 },
 GetPopupEditForm: function() { 
  return aspxGetControlCollection().Get(this.name + "_" + this.PopupEditFormSuffix); 
 },
 GetHeaderSuffix: function() { return this.DragAndDropTargetMark + "H-"; },
 GetCustomizationWindowSuffix: function() { return this.DragAndDropTargetMark + "CW"; },
 GetEmptyHeaderSuffix: function() { return this.DragAndDropTargetMark + "EH"; }, 
 CreateColumn: function(index, name, fieldName, canSort, showInCw) {
  var column = new ASPxClientTreeListColumn(index, name, fieldName);  
  column.canSort = canSort;
  column.showInCw = showInCw;
  this.columns.push(column);
 },
 FindColumn: function(id) {
  if(!_aspxIsExists(id)) return null;
  if(id.__dxColumnObject)
   return id;
  if(typeof id == "number")
   return this.GetColumnByIndex(id);
  var result = this.GetColumnByName(id);
  if(result == null)
   result = this.GetColumnByFieldName(id);
  return result;
 },
 UpdateRowStyle: function(nodeKey) {
  if(!this.allowStylizeEditingNode && nodeKey == this.editingKey)
   return;
  var row = this.GetRowByNodeKey(nodeKey);
  if(!_aspxIsExistsElement(row))
   return;
  var isFocused = this.focusedKey == nodeKey;
  var isSelected = this.IsRowSelected(row);
  if(isFocused) {
   this.ApplyRowStyle(row, 0);
  } else if(isSelected) {
   this.ApplyRowStyle(row, 1);
  } else {  
   var index = row.rowIndex;
   this.ApplyRowStyle(row, 2 + index);
  }
 }, 
 ApplyRowStyle: function(row, index) {
  var styledCells = this.GetStyleTable().rows[0].cells;
  var max = styledCells.length - 1;
  if(index > max)
   index = max; 
  row.className = styledCells[index].className;
  row.style.cssText = styledCells[index].innerHTML;
 },
 GetNodeKeyByRow: function(row) {
  return this.UnescapeNodeKey(row.id.substr(this.rowIdPrefix.length));
 },
 GetRowByNodeKey: function(nodeKey) {   
  var id = this.RowIDSuffix + this.EscapeNodeKey(nodeKey);  
  return this.GetCachedElementById(id);  
 },
 EscapeNodeKey: function(value) {
  return String(value).replace(/[^A-Za-z0-9]/g, function(match) { 
   return "_" + match.charCodeAt(0) + "_";
  });
 },
 UnescapeNodeKey: function(value) {
  return value.replace(/_\d+_/g, function(match) { 
   return String.fromCharCode(match.substr(1, match.length - 2));
  });
 },
 GetAllDataRows: function() {
  var result = [ ];
  var rows = this.GetDataTable().rows;
  for(var i = 0; i < rows.length; i++) {
   var row = rows[i];   
   if(!this.IsElementDataRow(row)) continue;
   result.push(row);
  }
  return result;
 },  
 IsElementEmptyHeader: function(element) {
  return element.id == this.name + this.GetEmptyHeaderSuffix();
 },
 IsElementDataRow: function(element) {
  return element.tagName == "TR" && element.id.indexOf(this.rowIdPrefix) == 0;
 }, 
 IsElementIndentCell: function(element) {
  return element.className.indexOf("dxtl__I") > -1;
 }, 
 IsElementCommandCell: function(element) {
  return element.className.indexOf("dxtl__cc") > -1;
 }, 
 FindDataRow:  function(element) { return this.FindElementUpwardsCore(element, this.IsElementDataRow); },
 FindIndentCell:  function(element) { return this.FindElementUpwardsCore(element, this.IsElementIndentCell); },
 FindCommandCell: function(element) { return this.FindElementUpwardsCore(element, this.IsElementCommandCell); },
 FindElementUpwardsCore: function(startElement, matchEvaluator) {
  var dataTable = this.GetDataTable();
  var element = startElement;
  while(_aspxIsExistsElement(element) && element != dataTable) {
   if(matchEvaluator.call(this, element))
    return element;
   element = element.parentNode;
  }
  return null;  
 },
 IsRowSelected: function(row) {
  var check = this.FindSelectionCheck(row);
  if(!_aspxIsExistsElement(check))
   return null;
  var internalCheckBox = this.internalCheckBoxCollection.Get(row.id);
  return internalCheckBox.GetChecked();
 },
 FindSelectionCheck: function(row) {
  return this.FindSelectionCheckBoxes(row)[0];
 },
 FindSelectionCheckBoxes: function(container) {
  var elements = container.getElementsByTagName("INPUT");
  var result = [];
  for(var i = 0; i < elements.length; i++) {
   if(_aspxGetParentByPartialClassName(elements[i], this.SelectionCellClassName))
    result.push(elements[i]);
  }
  return result;
 },
 FindSelectAllCheckBox: function() {
  return this.GetChild(this.SelectAllCheckID);
 },
 PersistSelectionDiff: function() {
  var input = this.GetSelectionInput();
  if(!_aspxIsExistsElement(input))
   return;
  var list = [ ];
  for(var key in this.selectionDiff)
   list.push(this.EscapeNodeKey(key));
  input.value = list.join(this.SeparatorToken);
 },
 UpdateFirstDataCellSpans: function(newMaxVisibleLevel) {
  if(this.maxVisibleLevel == newMaxVisibleLevel) 
   return;
  var rows = this.GetDataTable().rows;
  var spanDiff = newMaxVisibleLevel - this.maxVisibleLevel;
  for(var i = 0; i < rows.length; i++) {
   var row = rows[i];
   var tempCell;
   var firstDataCell;
   var tempCell = row.cells[row.cells.length - 1];
   if(tempCell.colSpan > 1)
    firstDataCell = tempCell; 
   else 
    firstDataCell = row.cells[row.cells.length - this.GetColumnCellCount()];
   var newSpan = firstDataCell.colSpan + spanDiff;
   if(newSpan > 0)
    firstDataCell.colSpan = newSpan;
  }
 },
 KillNextRows: function(row, count) {  
  while(count-- > 0) {
   var rowToKill = row.nextSibling;
   if(!_aspxIsExistsElement(rowToKill))
    break;   
   if(rowToKill.nodeType != 1) { 
    count++;
    _aspxRemoveElement(rowToKill);
   } else {
    this.DestroyHtmlRow(rowToKill);
   }   
  }
 },
 DestroyHtmlRow: function(row) {
  for(var i = row.cells.length - 1; i >= 0; i--)
   row.cells[i].innerHTML = "";
  _aspxRemoveElement(row);  
 },
 SetFocusedNodeKeyInternal: function(key) {
  this.focusedKey = key;
  this.GetFocusedKeyInput().value = key;
 }, 
 GetLastNumberOfId: function(element) {  
  var matches = element.id.match(/\d+/g);
  if(matches != null) {
   var count = matches.length;
   if(count > 0)
    return parseInt(matches[count - 1], 10);
  }
  return -1;
 },
 GetCachedElementById: function(id) {
  id = this.name + "_" + id;
  if(!_aspxIsExistsElement(this.elementCache[id]))
   this.elementCache[id] = _aspxGetElementById(id);
  return this.elementCache[id];
 },
 GenerateUID: function() {
  var result = "";
  for(var i = 0; i < 16; i++) {
   var num = Math.floor(10000 * (1 + Math.random()));
   result += num.toString(36);
  }
  return result;
 },
 PurgeCaches: function() {  
  this.elementCache = { };  
  this.focusedKey = null;
  this.selectionDiff = { };
 },
 GetColumnCellCount: function() {
  var count = this.visibleColumnCount;
  if(count < 1) count = 1; 
  return count;
 },
 GetCallbackHandlerIndex: function(handler) {
  for(var i = 0; i < this.callbackHandlersPool.length; i++) {
   if(this.callbackHandlersPool[i] == null) {
    this.callbackHandlersPool[i] = handler;
    return i;
   }
  }
  this.callbackHandlersPool.push(handler);
  return this.callbackHandlersPool.length - 1;
 },
 RefreshArmatureRow: function() {
  if(__aspxWebKitFamily || __aspxIE && __aspxBrowserVersion < 8)
   return;
  var id = this.name + "_ArmRow";
  var row = _aspxGetElementById(id);
  if(row) 
   _aspxRemoveElement(row);
  row = this.CreateArmatureRow();
  row.id = id;
  var dataTable = this.GetDataTable();
  if(dataTable.tBodies.length > 0)
   dataTable.tBodies[0].appendChild(row);
 },
 CreateArmatureRow: function() { 
  var row = document.createElement("TR");  
  var colSpan = this.maxVisibleLevel - 1;
  if(this.showRoot)
   colSpan++;
  if(this.FindSelectionCheck(this.GetDataTable()))
   colSpan++;
  if(colSpan > 0) {
   var indentSpaning = document.createElement("TD");
   row.appendChild(indentSpaning);
  indentSpaning.colSpan = colSpan;
  indentSpaning.style.padding = "0 1px";
  }
  var strut;
  for(var i = 1; i < this.GetColumnCellCount() + 1; i++) {
   var cell = document.createElement("TD");
   row.appendChild(cell);
   cell.style.padding = "0 1px";
   cell.style.whiteSpace = "normal";
   if(__aspxIE && __aspxBrowserVersion > 7) {
    if(!strut)
     strut = this.CreateArmatureRowStrut();
    cell.innerHTML = strut;
   }
  }
  return row;
 },
 CreateArmatureRowStrut: function() {
  var sb = [ "<div style=\"overflow: hidden; height: 0;\">" ];
  var count = 1000 / (this.GetColumnCellCount() + 1);
  for(var i = 0; i < count; i++)
   sb.push("&nbsp; ");
  sb.push("</div>");
  return sb.join("");
 },
 GetEditorObjects: function() {
  var list = [ ];
  var clientObjects = aspxGetControlCollection().elements;  
  for(var name in clientObjects) {
   if(name.indexOf(this.name) != 0)
    continue;
   var pos = name.indexOf(this.EditorSuffix);
   if(pos < 0 || name.indexOf("_", pos) > -1)
    continue;
   var obj = clientObjects[name];
   if(!obj.GetMainElement || !_aspxIsExistsElement(obj.GetMainElement()))
    continue;   
   list.push(obj);
  }
  return list;
 },
 SerializeEditorValues: function() {
  var editors = this.GetEditorObjects();
  var count = editors.length;
  var result = [ count ];      
  for(var i = 0; i < count; i++) {
   var columnIndex = this.GetEditorColumnIndex(editors[i]);
   var value = editors[i].GetValueString();
   var length = -1;
   if(!_aspxIsExists(value)) {
    value = "";
   } else {
    value = value.toString();
    length = value.length;
   }
   result.push(columnIndex);
   result.push(length);
   result.push(value);
  }
  this.GetEditorValuesInput().value = result.join(this.SeparatorToken);  
 },
 GetEditorColumnIndex: function(editorObject) {
  var name = editorObject.name;
  return name.substr(name.lastIndexOf(this.EditorSuffix) + this.EditorSuffix.length);
 },
 SeparatorToken: " ",
 RowIDSuffix: "R-",
 SelectAllCheckID: "_SelAll",
 EditorSuffix: "DXEDITOR",
 DragAndDropTargetMark: "_DX-DnD-",  
 ExpandButtonClassName: "dxtl__Expand",
 CollapseButtonClassName: "dxtl__Collapse",
 SelectionCellClassName: "dxtlSelectionCell",
 PopupEditFormSuffix: "PEF",
 CommandId: {
  Expand:    1,
  Collapse:   2,
  Pager:    3,
  CustomDataCallback: 4,
  MoveColumn:   5,
  Sort:    6,
  Dummy:    8,
  ExpandAll:   9,
  CollapseAll:  10,
  CustomCallback:  11,
  StartEdit:   12,
  UpdateEdit:   14,
  CancelEdit:   15,
  MoveNode:   16,
  DeleteNode:   17,
  StartEditNewNode: 18,
  GetNodeValues:  20
 }, 
 ExpandCollapseAction: {
  Button: 0,
  NodeClick: 1,
  NodeDblClick: 2
 },
 GetNodeValuesCommandMode: { 
  ByKey:    0,
  Visible:   1,
  SelectedAll:  2,
  SelectedVisible: 3
 },
 RaiseContextMenu: function(e) {
  if(!this.ContextMenu.IsEmpty())
   this.ContextMenu.FireEvent(this, e);
 },
 RaiseCustomButtonClick: function(nodeKey, buttonIndex, buttonID) {
  var handler = this.CustomButtonClick;
  if(handler.IsEmpty()) return false;
  handler.FireEvent(this, new ASPxClientTreeListCustomButtonEventArgs(nodeKey, buttonIndex, buttonID));
 },
 Focus: function() {
  if(this.kbdHelper)
   this.kbdHelper.Focus();
 },
 GetFocusedNodeKey: function() {
  if(!this.enableFocusedNode)
   return "";
  if(this.focusedKey === null)
   this.focusedKey = this.GetFocusedKeyInput().value;
  return this.focusedKey;
 },
 SetFocusedNodeKey: function(key) {
  if(!this.enableFocusedNode)
   return;
  var prevKey = this.GetFocusedNodeKey();  
  this.SetFocusedNodeKeyInternal(key);
  this.UpdateRowStyle(prevKey); 
  this.UpdateRowStyle(key);
 },
 RaiseNodeFocusing: function(nodeKey, htmlEvent) {
  if(this.NodeFocusing.IsEmpty()) return true;
  var args = new ASPxClientTreeListNodeEventArgs(nodeKey, htmlEvent);
  this.NodeFocusing.FireEvent(this, args);
  return !args.cancel;
 }, 
 RaiseFocusedNodeChanged: function() {
  var processOnServer = false;
  if(!this.FocusedNodeChanged.IsEmpty()) {
   var args = new ASPxClientProcessingModeEventArgs(processOnServer);
   this.FocusedNodeChanged.FireEvent(this, args);
   processOnServer = args.processOnServer;   
  }
  return this.focusSendsCallback || processOnServer;
 },
 GetNodeCheckState: function(nodeKey) {
  var row = this.GetRowByNodeKey(nodeKey);
  if(!_aspxIsExistsElement(row))
   return null;
  if(this.FindSelectionCheck(row)) {
   var internalCheckBox = this.internalCheckBoxCollection.Get(row.id);
   if(internalCheckBox)
    return internalCheckBox.GetCurrentCheckState();
  }
  return null;
 },
 SetNodeCheckState: function(nodeKey, checkState) {
  var row = this.GetRowByNodeKey(nodeKey);
  var newInputKey = ASPxClientCheckBoxInputKey[checkState];
  if(!_aspxIsExistsElement(row) || !newInputKey)
   return;   
  var check = this.FindSelectionCheck(row);
  if(!_aspxIsExistsElement(check))
   return;
  var internalCheckBox = this.internalCheckBoxCollection.Get(row.id);
  if(internalCheckBox.GetCurrentInputKey() == newInputKey)
   return;
  internalCheckBox.SetValue(newInputKey);
  this.OnNodeSelectingCore(check);
 },
 RaiseSelectionChanged: function() {
  var processOnServer = false;
  if(!this.SelectionChanged.IsEmpty()) {
   var args = new ASPxClientProcessingModeEventArgs(processOnServer);
   this.SelectionChanged.FireEvent(this, args);
   processOnServer = args.processOnServer;
  }
  return this.selectionSendsCallback || processOnServer;
 },
 IsNodeSelected: function(nodeKey) {
  var row = this.GetRowByNodeKey(nodeKey);
  if(row) {
   var nodeCheckState = this.GetNodeCheckState(nodeKey);
   if(nodeCheckState)
    return nodeCheckState === ASPxClientCheckBoxCheckState.Checked;
  }
  return null;
 },
 SelectNode: function(nodeKey, state) { 
  if(!_aspxIsExists(state)) 
   state = true;   
  this.SetNodeCheckState(nodeKey, state ? ASPxClientCheckBoxCheckState.Checked : ASPxClientCheckBoxCheckState.Unchecked);
 },
 GetVisibleSelectedNodeKeys: function() {
  var rows = this.GetAllDataRows();
  var result = [ ];
  for(var i = 0; i < rows.length; i++) {
   var key = this.GetNodeKeyByRow(rows[i]);
   if(this.IsNodeSelected(key))
    result.push(key);
  }
  return result;
 }, 
 IsCustomizationWindowVisible: function() {
  var win = this.GetCustomizationWindow();
  return win != null && win.IsVisible();
 },
 ShowCustomizationWindow: function(htmlElement) {
  var win = this.GetCustomizationWindow();
  if(win == null)
   return;
  if(!_aspxIsExistsElement(htmlElement))
   htmlElement = this.GetMainElement();
  win.ShowAtElement(htmlElement);
 },
 HideCustomizationWindow: function() {
  var win = this.GetCustomizationWindow();
  if(win != null)
   win.Hide();
 },
 RaiseCustomizationWindowCloseUp: function() {
  if(!this.CustomizationWindowCloseUp.IsEmpty())
   this.CustomizationWindowCloseUp.FireEvent(this, { } );
 },
 PerformCustomCallback: function(arg) {
  this.PerformCallback(arg);  
 },
 PerformCallback: function(args) {
  this.SendCommand("CustomCallback", [args]);
 },
 PerformCustomDataCallback: function(arg) {
  this.SendAsyncCommand("CustomDataCallback", arg);
 },
 RaiseCustomDataCallback: function(arg, result) {
  if(!this.CustomDataCallback.IsEmpty()) {
   var e = new ASPxClientTreeListCustomDataCallbackEventArgs(arg, result);
   this.CustomDataCallback.FireEvent(this, e);
  }  
 },
 GetNodeValues: function(nodeKey, fieldNames, onCallback) {
  this.SendGetNodeValuesCommand(onCallback, this.GetNodeValuesCommandMode.ByKey, nodeKey, fieldNames);
 }, 
 GetVisibleNodeValues: function(fieldNames, onCallback) {
  this.SendGetNodeValuesCommand(onCallback, this.GetNodeValuesCommandMode.Visible, "", fieldNames);
 },
 GetSelectedNodeValues: function(fieldNames, onCallback, visibleOnly) {
  var mode = visibleOnly 
   ? this.GetNodeValuesCommandMode.SelectedVisible 
   : this.GetNodeValuesCommandMode.SelectedAll; 
  this.SendGetNodeValuesCommand(onCallback, mode, "", fieldNames);
 },  
 GoToPage: function(index) {
  if(index < -1)
   return;
  this.SendPagerCommand("PN" + index);
 },
 PrevPage: function(fromKbd) {
  this.SendPagerCommand("PBP", fromKbd);
 }, 
 NextPage: function(fromKbd) {
  this.SendPagerCommand("PBN", fromKbd);
 },
 GetPageIndex: function(){
  return this.pageIndex;
 },
 GetPageCount: function(){
  return this.pageCount;
 },
 GetNodeState: function(nodeKey, row) {  
  if(!row)
   row = this.GetRowByNodeKey(nodeKey);
  if(!_aspxIsExistsElement(row))
   return "NotFound";
  var children = row.getElementsByTagName("IMG");
  for(var i = 0; i < children.length; i++) {
   var name = children[i].className;
   if(name.indexOf(this.ExpandButtonClassName) > -1)
    return "Collapsed";
   if(name.indexOf(this.CollapseButtonClassName) > -1)
    return "Expanded";
  }
  return "Child";
 }, 
 ExpandAll: function() {
  this.SendCommand("ExpandAll");
 },
 CollapseAll: function() {
  this.SendCommand("CollapseAll");
 },
 ExpandNode: function(key) {
  this.SendCommand("Expand", [key]);
 },
 CollapseNode: function(key) {
  this.SendCommand("Collapse", [key]);
 },
 GetVisibleNodeKeys: function() {
  var rows = this.GetAllDataRows();
  var result = [ ];
  for(var i = 0; i < rows.length; i++)
   result.push(this.GetNodeKeyByRow(rows[i]));
  return result;
 },
 GetNodeHtmlElement: function(nodeKey) {
  return this.GetRowByNodeKey(nodeKey);
 },  
 RaiseNodeClick: function(nodeKey, htmlEvent) {
  if(this.NodeClick.IsEmpty()) return true;
  var e = new ASPxClientTreeListNodeEventArgs(nodeKey, htmlEvent);
  this.NodeClick.FireEvent(this, e);
  return !e.cancel;  
 },
 RaiseNodeDblClick: function(nodeKey, htmlEvent) {
  if(this.NodeDblClick.IsEmpty()) return true;
  var e = new ASPxClientTreeListNodeEventArgs(nodeKey, htmlEvent);
  this.NodeDblClick.FireEvent(this, e);
  return !e.cancel;
 },
 RaiseNodeExpanding: function(nodeKey, htmlEvent) {
  if(!this.NodeExpanding.IsEmpty()) {
   var e = new ASPxClientTreeListNodeEventArgs(nodeKey, htmlEvent);
   this.NodeExpanding.FireEvent(this, e);
   return !e.cancel;
  }
  return true;
 },
 RaiseNodeCollapsing: function(nodeKey, htmlEvent) {
  if(!this.NodeCollapsing.IsEmpty()) {
   var e = new ASPxClientTreeListNodeEventArgs(nodeKey, htmlEvent);
   this.NodeCollapsing.FireEvent(this, e);
   return !e.cancel;
  }
  return true;
 },
 RaiseStartDragNode: function(nodeKey, htmlEvent, targets) {
  if(this.StartDragNode.IsEmpty()) return true;
  var e = new ASPxClientTreeListStartDragNodeEventArgs(nodeKey, htmlEvent, targets);
  this.StartDragNode.FireEvent(this, e);
  return !e.cancel;
 },
 RaiseEndDragNode: function(nodeKey, htmlEvent, targetElement) {
  if(this.EndDragNode.IsEmpty()) return true;
  var e = new ASPxClientTreeListEndDragNodeEventArgs(nodeKey, htmlEvent, targetElement);
  this.EndDragNode.FireEvent(this, e);
  return !e.cancel;
 },
 GetVisibleColumnCount: function() {
  return this.visibleColumnCount;
 }, 
 GetColumnCount: function() {
  return this.columns.length;
 },
 GetColumnByIndex: function(index) {
  for(var i = 0; i < this.columns.length; i++) {
   if(this.columns[i].index == index)
    return this.columns[i];
  }
  return null;
 }, 
 GetColumnByName: function(name) {
  if(name == "")
   return null;
  for(var i = 0; i < this.columns.length; i++) {
   if(this.columns[i].name == name)
    return this.columns[i];
  }
  return null;
 },
 GetColumnByFieldName: function(fieldName) {
  if(fieldName == "")
   return null;
  for(var i = 0; i < this.columns.length; i++) {
   if(this.columns[i].fieldName == fieldName)
    return this.columns[i];
  }
  return null;
 },
 SortBy: function(columnId, order, reset) {
  var column = this.FindColumn(columnId);
  if(column == null)
   return;
  if(!_aspxIsExists(order)) order = "";
  if(!_aspxIsExists(reset)) reset = true;
  this.SendSortCommand(column.index, order, reset);
 },
 StartEdit: function(nodeKey) {
  this.SendCommand("StartEdit", [nodeKey]);
 },
 UpdateEdit: function() {
  if(!this.IsEditing()) return;
  var editors = this.GetEditorObjects();  
  for(var i = 0; i < editors.length; i++) {
   var editor = editors[i];
   editor.Validate();
   if(!editor.GetIsValid()) {
    if(editor.setFocusOnError)
     editor.Focus();
    return;
   }
  }
  this.SendCommand("UpdateEdit");
 },
 CancelEdit: function() {
  if(!this.IsEditing()) return;
  this.SendCommand("CancelEdit");
 },
 IsEditing: function() { 
  return this.editingKey != null || this.isNewNodeEditing;
 },
 GetEditingNodeKey: function() { 
  return this.editingKey; 
 },
 MoveNode: function(nodeKey, parentNodeKey) {
  this.SendCommand("MoveNode", [this.EscapeNodeKey(nodeKey), this.EscapeNodeKey(parentNodeKey)]);
 },
 DeleteNode: function(nodeKey) {
  this.SendCommand("DeleteNode", [nodeKey]);
 },
 StartEditNewNode: function(parentNodeKey) {
  if(!_aspxIsExists(parentNodeKey))
   parentNodeKey = "";
  this.SendCommand("StartEditNewNode", [parentNodeKey]);
 },
 GetEditor: function(columnId) {
  var column = this.FindColumn(columnId);
  if(column == null) return null;
  var editors = this.GetEditorObjects();
  for(var i = 0; i < editors.length; i++) {
   if(column.index == this.GetEditorColumnIndex(editors[i]))
    return editors[i];
  }
  return null;
 },
 GetEditValue: function(columnId) {
  var editor = this.GetEditor(columnId);
  if(editor == null) return null;
  return editor.GetValue();
 },
 SetEditValue: function(columnId, value) {
  var editor = this.GetEditor(columnId);
  if(editor != null)
   editor.SetValue(value);
 },
 FocusEditor: function(columnId) {
  var editor = this.GetEditor(columnId);
  if(editor && editor.SetFocus)
   editor.SetFocus();
 }
});
ASPxClientTreeList.Cast = ASPxClientControl.Cast;
ASPxClientTreeListDragHelper = _aspxCreateClass(null, {
 constructor: function(treeList)  {
  this.treeList = treeList;  
 },
 CreateHeaderDrag: function(element, e, canDrag) {  
  e = _aspxGetEvent(e);
  var drag = new ASPxClientDragHelper(e, element, true);  
  drag.centerClone = true;
  drag.canDrag = canDrag;
  drag.ctrl = e.ctrlKey;
  drag.shift = e.shiftKey;
  drag.treeListHelper = this;  
  drag.onDoClick = this.OnHeaderClick;
  drag.onCloneCreating = this.OnHeaderCloneCreating;
  drag.onEndDrag = this.OnHeaderEndDrag;
  drag.onCancelDrag = this.OnHeaderCancelDrag;
  return drag;  
 },
 CreateHeaderTargets: function(drag, e) {
  if(!drag.canDrag)
   return;
  var targets = new ASPxClientCursorTargets();    
  targets.obj = drag.obj;
  targets.treeListHelper = this;
  targets.onTargetChanging = this.OnHeaderTargetChanging; 
  targets.onTargetChanged = this.OnHeaderTargetChanged;
  var tree = this.treeList;  
  targets.RegisterTargets(tree.GetDataTable().rows[0],
   [ tree.GetEmptyHeaderSuffix(), tree.GetHeaderSuffix() ]);
  var cw = tree.GetCustomizationWindowElement();
  if(cw != null) {
   var index = this.treeList.GetLastNumberOfId(drag.obj);
   var columnObj = this.treeList.FindColumn(index);
   if(columnObj && columnObj.showInCw)
    targets.RegisterTargets(cw, [ tree.GetCustomizationWindowSuffix() ]);
  }
 }, 
 OnHeaderClick: function(drag) {
  var treeList = drag.treeListHelper.treeList; 
  treeList.OnHeaderClick(drag.obj, drag.shift, drag.ctrl);
 },
 OnHeaderCloneCreating: function(clone) { 
  clone.colSpan = 1; 
  ASPxClientTreeListDragHelper.RestoreElementBorder(clone);  
  var table = document.createElement("table");
  table.cellSpacing = 0;
  var row = table.insertRow(-1);
  row.appendChild(clone);
  table.style.width = Math.min(200, this.obj.offsetWidth) + "px";
  table.style.opacity = 0.80;
  table.style.filter = "alpha(opacity=80)"; 
  if(_aspxIsElementRightToLeft(this.obj))
   table.dir = "rtl";
  return table;
 },  
 OnHeaderEndDrag: function(drag) {
  if(drag.targetElement == null) 
   return;  
  var treeList = drag.treeListHelper.treeList;
  var sourceIndex = treeList.GetLastNumberOfId(drag.obj);
  var targetIndex;
  var cwElement = treeList.GetCustomizationWindowElement();
  if(cwElement && drag.targetElement.id == cwElement.id) {
   targetIndex = -1;
  } else if(treeList.IsElementEmptyHeader(drag.targetElement)) {
   targetIndex = 0;
  } else {
   targetIndex = treeList.GetLastNumberOfId(drag.targetElement);
   if(sourceIndex == targetIndex)
    return;
  }
  var before = drag.targetTag;
  if(treeList.rtl)
   before = !before;
  treeList.OnColumnMoving(sourceIndex, targetIndex, before);
 },  
 OnHeaderCancelDrag: function(drag) {
  if(drag.canDrag)
   drag.treeListHelper.HideHeaderDragImages();
 },
 OnHeaderTargetChanging: function(targets) {
  targets.targetTag = targets.isLeftPartOfElement();
 },  
 OnHeaderTargetChanged: function(targets) { 
  if(__aspxDragHelper == null) 
   return;
  var helper = targets.treeListHelper;
  var element = targets.targetElement;
  helper.HideHeaderDragImages();
  if(element && element != __aspxDragHelper.obj) {   
   __aspxDragHelper.targetElement = element;
   __aspxDragHelper.targetTag = targets.targetTag;   
   var left = _aspxGetAbsoluteX(element);
   if(!targets.targetTag) {
    var brother = element;
    do {
     var brother = helper.treeList.rtl ? brother.previousSibling : brother.nextSibling;
    } while(brother && brother.nodeType != 1);
    if(brother)
     left = _aspxGetAbsoluteX(brother);
    else
     left += element.offsetWidth;
   }
   if(element == helper.treeList.GetCustomizationWindowElement()) {
    var hideImage = helper.treeList.GetDragAndDropHideImage();
    hideImage.style.top = "";
    __aspxDragHelper.addElementToDragDiv(hideImage);
   } else {
    helper.SetHeaderDragImagesPosition(element, left);
   }
  } else {
   __aspxDragHelper.targetElement = null;
  }
 },
 SetHeaderDragImagesPosition: function(element, left) {
  this.ShowHeaderDragImages();
  var arrowDown = this.treeList.GetDragAndDropArrowDownImage();
  var arrowUp = this.treeList.GetDragAndDropArrowUpImage();
  _aspxSetAbsoluteX(arrowDown, Math.ceil(left - arrowDown.offsetWidth / 2));
  _aspxSetAbsoluteX(arrowUp, Math.ceil(left - arrowUp.offsetWidth / 2));
  var top = _aspxGetAbsoluteY(element);
  _aspxSetAbsoluteY(arrowDown, top - arrowDown.offsetHeight);
  _aspxSetAbsoluteY(arrowUp, top + element.offsetHeight);
 },
 HideHeaderDragImages: function() {
  this.SetHeaderDragImagesVisibility("hidden");
  if(__aspxDragHelper != null)
   __aspxDragHelper.removeElementFromDragDiv();  
 },
 ShowHeaderDragImages: function() {
  this.SetHeaderDragImagesVisibility("visible");
 },
 SetHeaderDragImagesVisibility: function(value) {
  this.treeList.GetDragAndDropArrowDownImage().style.visibility = value;
  this.treeList.GetDragAndDropArrowUpImage().style.visibility = value;
 },
 CreateNodeDrag: function(row, e, canDrag) {
  e = _aspxGetEvent(e);
  var drag = new ASPxClientDragHelper(e, row, true);
  drag.__treeList = this.treeList;
  drag.__savedHtmlEvent = e;  
  drag.canDrag = canDrag;
  drag.onCloneCreating = this.OnNodeCloneCreating;
  drag.onCancelDrag = this.OnNodeCancelDrag;
  drag.onEndDrag = this.OnNodeEndDrag;
  drag.onDoClick = this.OnNodeClick;
  return drag;
 },
 CreateNodeTargets: function(targetElements, sourceElement) {
  var targets = new ASPxClientCursorTargets();
  targets.__treeList = this.treeList;
  for(var i = 0; i < targetElements.length; i++) {
   if(targetElements[i] == sourceElement) continue;
   targets.list.push(new ASPxClientCursorTarget(targetElements[i]));
  }
  targets.onTargetChanged = this.OnNodeTargetChanged;
 },
 OnNodeCloneCreating: function(row) {
  var treeList = __aspxDragHelper.__treeList;
  var table = document.createElement("table");
  table.cellSpacing = 0;  
  var tbody = document.createElement("tbody");
  table.appendChild(tbody);
  tbody.appendChild(row);
  var list = [ ];
  var thr = row.cells.length - treeList.GetColumnCellCount();
  var originalRow = __aspxDragHelper.obj;
  var removedWidth = 0;
  for(var i = 0; i < row.cells.length; i++) {
   var cell = row.cells[i];
   var originalCell = originalRow.cells[i];
   if(i < thr) {
    list.push(cell);
    removedWidth += originalCell.offsetWidth;
   } else {
    ASPxClientTreeListDragHelper.RestoreElementBorder(cell, "top");
    ASPxClientTreeListDragHelper.RestoreElementBorder(cell, "bottom");
    if(i == thr)
     ASPxClientTreeListDragHelper.RestoreElementBorder(cell, "left");
    if(i == row.cells.length - 1)
     ASPxClientTreeListDragHelper.RestoreElementBorder(cell, "right");
    cell.style.width = originalCell.offsetWidth - 
     _aspxGetLeftRightBordersAndPaddingsSummaryValue(originalCell) + "px";
   }    
  }
  for(var i = 0; i < list.length; i++)
   row.removeChild(list[i]);
  table.width = (originalRow.offsetWidth - removedWidth).toString() + "px";
  table.style.marginLeft = removedWidth + "px";
  table.style.opacity = 0.80;
  table.style.filter = "alpha(opacity=80)";
  return table;
 },
 OnNodeTargetChanged: function(targets) {
  if(__aspxDragHelper == null) return;
  var element = targets.targetElement;
  var hasTarget = _aspxIsExistsElement(element);
  targets.__treeList.dragHelper.SetNodeImageVisibility(hasTarget, element);
  __aspxDragHelper.targetElement = hasTarget ? targets.targetElement : null;
 },
 OnNodeCancelDrag: function(drag) {
  drag.__treeList.dragHelper.SetNodeImageVisibility(false);
 },
 OnNodeEndDrag: function(drag) {  
  if(drag.targetElement == null) 
   return;
  var sourceRow = drag.obj;
  var targetElement = drag.targetElement;
  if(sourceRow == targetElement)
   return;
  var treeList = drag.__treeList;
  var nodeKey = treeList.GetNodeKeyByRow(sourceRow);  
  if(!treeList.RaiseEndDragNode(nodeKey, drag.__savedHtmlEvent, targetElement))
   return;    
  if(treeList.IsElementDataRow(targetElement)) {
   var parentKey = treeList.GetNodeKeyByRow(targetElement);
   treeList.MoveNode(nodeKey, parentKey);
  } else if(targetElement == treeList.GetHeaderRow()) {
   treeList.MoveNode(nodeKey, "");
  } else {
   alert("Unprocessed custom target id=" + targetElement.id);
  }
 },
 OnNodeClick: function(drag) {
  drag.__treeList.OnDataTableClick(drag.__savedHtmlEvent);
 }, 
 SetNodeImageVisibility: function(visible, element) {
  if(element == document.body)
   visible = false;
  var img = this.treeList.GetDragAndDropNodeImage();
  img.style.visibility = visible ? "visible" : "hidden";
  if(!visible) return;
  if(element.cells && element.cells.length > 0) {   
   for(var i = element.cells.length - 1; i >= 0; i--) {
    if(element.cells[i].className.indexOf("dxtl__I") > -1) {    
     element = element.cells[1 + i];
     break;
    }
   }
  }
  _aspxSetAbsoluteX(img, _aspxGetAbsoluteX(element) - img.offsetWidth + 4);
  _aspxSetAbsoluteY(img, _aspxGetAbsoluteY(element) + Math.floor(0.5 * (element.clientHeight - img.clientHeight)));
 }
});
ASPxClientTreeListDragHelper.RestoreElementBorder = function(element, borderPart) {
 var ruleName = borderPart ? "border-" + borderPart + "-style" : "border-style";
 element.style.cssText += ";" + ruleName + ": solid!important;";
};
ASPxTreeListKbdHelper = _aspxCreateClass(ASPxKbdHelper, {
 HandleKeyDown: function(e) {
  var tree = this.control;
  var row = tree.GetRowByNodeKey(tree.GetFocusedNodeKey());
  var busy = tree.syncLock;
  var key = _aspxGetKeyCode(e);
  if(tree.rtl) {
   if(key == ASPxKey.Left)
    key = ASPxKey.Right;
   else if(key == ASPxKey.Right)
    key = ASPxKey.Left;
  }
  switch(key) {
   case ASPxKey.Down:
    if(!busy)
     this.TryMoveFocusDown(row, e.shiftKey);
    return true;
   case ASPxKey.Up:
    if(!busy)
     this.TryMoveFocusUp(row, e.shiftKey);
    return true;
   case ASPxKey.Right:
    if(!busy) {
     if(!this.TryExpand(row))
      this.TryMoveFocusDown(row, e.shiftKey);
    }
    return true;
   case ASPxKey.Left:
    if(!busy) {
     if(!this.TryCollapse(row))
      this.TryMoveFocusUp(row, e.shiftKey);
    }
    return true;
   case ASPxKey.PageDown:
    if(e.shiftKey) {
     if(!busy && tree.pageIndex < tree.pageCount - 1)
      tree.NextPage();
     return true; 
    }
    break;
   case ASPxKey.PageUp:
    if(e.shiftKey) {
     if(!busy && tree.pageIndex > 0)
      tree.PrevPage();
     return true; 
    }
    break;         
  }
  return false;
 },
 HandleKeyPress: function(e) {
  var tree = this.control;
  var key = tree.GetFocusedNodeKey();
  var busy = tree.syncLock;
  switch(_aspxGetKeyCode(e)) {
   case ASPxKey.Space:   
    if(!busy) {
     var state = tree.IsNodeSelected(key);
     if(state != null) {
      tree.SelectNode(key, !state);
      if(tree.RaiseSelectionChanged())
       tree.SendDummyCommand(true);
     }      
    }
    return true;
    case 43:   
    if(!busy)
     this.TryExpand(tree.GetRowByNodeKey(key));
    return true;
    case 45:    
    if(!busy)
     this.TryCollapse(tree.GetRowByNodeKey(key));
    return true;    
  }
  return false;
 },
 TryMoveFocusDown: function(row, select) {
  var tree = this.control;
  var nextRow = this.GetSiblingRow(row, 1);
  if(nextRow) {
   var processOnServer = tree.OnFocusingNode(tree.GetNodeKeyByRow(nextRow), {});
   if(select && !tree.recursiveSelection) {
    this.TrySelectNodes(row, nextRow);
   } else {
    tree.selectionStartKey = null;
   }
   if(processOnServer)
    tree.SendDummyCommand(true);
  } else if(tree.pageIndex > -1 && tree.pageIndex < tree.pageCount - 1) {
   tree.NextPage(true);
  }
 },
 TryMoveFocusUp: function(row, select) {
  var tree = this.control; 
  var prevRow = this.GetSiblingRow(row, -1);
  if(prevRow) {
   var processOnServer = tree.OnFocusingNode(tree.GetNodeKeyByRow(prevRow), {});
   if(select && !tree.recursiveSelection) {
    this.TrySelectNodes(row, prevRow);
   } else {
    tree.selectionStartKey = null;
   }
   if(processOnServer)
    tree.SendDummyCommand(true);
  } else if(tree.pageIndex > 0) {
   tree.PrevPage(true);
  } 
 },
 TryExpand: function(row) {
  var tree = this.control;
  if(tree.GetNodeState(null, row) == "Collapsed") {
   tree.ExpandNode(tree.GetNodeKeyByRow(row));
   return true;
  }
  return false;
 },
 TryCollapse: function(row) {
  var tree = this.control;
  if(tree.GetNodeState(null, row) == "Expanded") {
   tree.CollapseNode(tree.GetNodeKeyByRow(row));
   return true;
  }
  return false;
 },
 GetSiblingRow: function(row, offset) {
  var i = 0;
  while(i < Math.abs(offset)) {
   row = offset < 0 ? row.previousSibling : row.nextSibling;
   if(!row)
    return null;
   if(row.id == this.control.name + "_ArmRow")
    return null;
   if(row.nodeType != 1 || !this.control.IsElementDataRow(row))
    continue;
   i++;
  }
  return row;
 },
 TrySelectNodes: function(startRow, endRow) {
  var tree = this.control;
  if(tree.selectionStartKey != null)
   startRow = tree.GetRowByNodeKey(tree.selectionStartKey) || startRow;  
  tree.selectionStartKey = tree.GetNodeKeyByRow(startRow);
  if(!tree.FindSelectionCheck(tree.GetDataTable()))
   return ;
  var rows = tree.GetAllDataRows();
  var inside = false;
  var changed = false;
  for(var i = 0; i < rows.length; i++) {
   var hit = rows[i] == startRow || rows[i] == endRow;   
   if(hit && !inside) {
    inside = true;
    hit = false;
   }
   var key = tree.GetNodeKeyByRow(rows[i]);
   if(tree.IsNodeSelected(key) != inside)
    changed = true;
   tree.SelectNode(key, inside);
   if(inside && (hit || startRow == endRow))
    inside = false;
  }
  if(changed) {
   if(tree.RaiseSelectionChanged())
    tree.SendDummyCommand(true);
  }
 }   
});
function aspxTLPager(name, arg) {
 var treeList = aspxGetControlCollection().Get(name);
 if(treeList != null)
  treeList.SendPagerCommand(arg);
}
function aspxTLClick(name, e) {
 var treeList = aspxGetControlCollection().Get(name);
 if(treeList)
  treeList.OnDataTableClick(e);
}
function aspxTLDblClick(name, e) {
 var treeList = aspxGetControlCollection().Get(name);
 if(treeList)
  treeList.OnDataTableDblClick(e);
}
function aspxTLHeaderDown(name, element, e) {
 var treeList = aspxGetControlCollection().Get(name);
 if(treeList)
  treeList.OnHeaderMouseDown(element, e);
}
function aspxTLShowLoadingPanel(name) {
 var treeList = aspxGetControlCollection().Get(name);
 if(treeList)
  treeList.ShowLoadingPanelCore();
}
function aspxTLCWCloseUp(name) {
 var treeList = aspxGetControlCollection().Get(name);
 if(treeList)
  treeList.RaiseCustomizationWindowCloseUp();
}
function aspxTLMouseDown(name, e) {
 var treeList = aspxGetControlCollection().Get(name);
 if(treeList)
  treeList.OnDataTableMouseDown(e);
}
function aspxTLStartEdit(name, key) {
 var treeList = aspxGetControlCollection().Get(name);
 if(treeList)
  treeList.StartEdit(key); 
}
function aspxTLStartEditNewNode(name, parentKey) {
 var treeList = aspxGetControlCollection().Get(name);
 if(treeList)
  treeList.StartEditNewNode(parentKey); 
}
function aspxTLDeleteNode(name, key) {
 var treeList = aspxGetControlCollection().Get(name);
 if(treeList)
  treeList.OnNodeDeleting(key); 
}
function aspxTLUpdateEdit(name) {
 var treeList = aspxGetControlCollection().Get(name);
 if(treeList)
  treeList.UpdateEdit(); 
}
function aspxTLCancelEdit(name) {
 var treeList = aspxGetControlCollection().Get(name);
 if(treeList)
  treeList.CancelEdit(); 
}
function aspxTLCustomButton(name, nodeKey, index, id) {
 var treeList = aspxGetControlCollection().Get(name);
 if(treeList)
  treeList.RaiseCustomButtonClick(nodeKey, index, id);
}
function aspxTLMenu(name, objectType, objectKey, htmlEvent) {
 var treeList = aspxGetControlCollection().Get(name);
 if(treeList)
  return treeList.OnContextMenu(objectType, objectKey, htmlEvent);
 return true;
}
function aspxTLSort(name, columnIndex) {
 var treeList = aspxGetControlCollection().Get(name);
 if(treeList)
  treeList.SortBy(columnIndex);
}
function aspxTLExpand(name, nodeKey) {
 var treeList = aspxGetControlCollection().Get(name);
 if(treeList) {
  if(treeList.enableFocusedNode && treeList.focusOnExpandCollapse)
   treeList.OnFocusingNode(nodeKey, null);
  treeList.ExpandNode(nodeKey);
 }
}
function aspxTLCollapse(name, nodeKey) {
 var treeList = aspxGetControlCollection().Get(name);
 if(treeList) {
  if(treeList.enableFocusedNode && treeList.focusOnExpandCollapse)
   treeList.OnFocusingNode(nodeKey, null); 
  treeList.CollapseNode(nodeKey);
 }
}
ASPxClientTreeListColumn = _aspxCreateClass(null, { 
 constructor: function(index, name, fieldName) {
  this.index = index;
  this.name = name;
  this.fieldName = fieldName;
  this.canSort = false; 
  this.showInCw = true;   
 },
 __dxColumnObject: true
});
ASPxClientTreeListCustomDataCallbackEventArgs = _aspxCreateClass(ASPxClientEventArgs, {
 constructor: function(arg, result) {
  this.constructor.prototype.constructor.call(this);
  this.arg = arg;
  this.result = result;
 }
});
ASPxClientTreeListNodeEventArgs = _aspxCreateClass(ASPxClientEventArgs, {
 constructor: function(nodeKey, htmlEvent) {
  this.constructor.prototype.constructor.call(this);
  this.nodeKey = nodeKey;
  this.htmlEvent = htmlEvent;
  this.cancel = false;  
 }
});
ASPxClientTreeListContextMenuEventArgs = _aspxCreateClass(ASPxClientEventArgs, {
 constructor: function(objectType, objectKey, htmlEvent) {
  this.constructor.prototype.constructor.call(this);
  this.objectType = objectType;
  this.objectKey = objectKey;
  this.htmlEvent = htmlEvent;
  this.cancel = false;   
 }
});
ASPxClientTreeListStartDragNodeEventArgs = _aspxCreateClass(ASPxClientTreeListNodeEventArgs, {
 constructor: function(nodeKey, htmlEvent, targets) {
  this.constructor.prototype.constructor.call(this, nodeKey, htmlEvent);
  this.targets = targets;  
 }
});
ASPxClientTreeListEndDragNodeEventArgs = _aspxCreateClass(ASPxClientTreeListNodeEventArgs, {
 constructor: function(nodeKey, htmlEvent, targetElement) {
  this.constructor.prototype.constructor.call(this, nodeKey, htmlEvent);
  this.targetElement = targetElement;
 } 
});
ASPxClientTreeListCustomButtonEventArgs = _aspxCreateClass(ASPxClientEventArgs, {
 constructor: function(nodeKey, buttonIndex, buttonID) {
  this.constructor.prototype.constructor.call(this);
  this.nodeKey = nodeKey;
  this.buttonIndex = buttonIndex;
  this.buttonID = buttonID;
 } 
});

/*# using DevExpress.Web.ASPxClasses.Scripts; #*/
/*# namespace DevExpress.Web.ASPxCallbackPanel.Scripts #*/

/*# public class ASPxClientCallbackPanel : ASPxClientControl #*/
ASPxClientCallbackPanel = _aspxCreateClass(ASPxClientControl, {
    constructor: function (name) {
        this.constructor.prototype.constructor.call(this, name);

        this.allowMultipleCallbacks = false;
        this.touchUIScroller = null;
        this.animationProcessing = false;
        this.inCallback = false;
        this.resposedContent = null;
        this.enableAnimation = false;
        this.hideContentOnCallback = true;
        this.isLoadingPanelTextEmpty = false;

        /*# public event ASPxClientBeginCallbackEventHandler BeginCallback{ add{} remove{}}#*/
        /*# public event ASPxClientEndCallbackEventHandler EndCallback{ add{} remove{}}#*/
        /*# public event ASPxClientCallbackErrorEventHandler CallbackError{ add{} remove{}}#*/
    },
    Initialize: function () {
        this.touchUIScroller = ASPxClientTouchUI.makeScrollableIfRequired(this.GetMainElement());
    },
    GetContentElement: function () {
        var element = this.GetMainElement();
        return element.tagName == "TABLE" ? element.rows[0].cells[0] : element;
    },

    DoCallback: function (result) {
        this.inCallback = false;
        this.resposedContent = result;
        if (!this.enableAnimation || !this.animationProcessing)
            ASPxClientControl.prototype.DoCallback.call(this, result);
    },

    OnCallback: function (result) {
        _aspxSetInnerHtml(this.GetContentElement(), result);
        if (this.touchUIScroller)
            this.touchUIScroller.ChangeElement(this.GetMainElement());
    },
    DoEndCallback: function () {
        if (this.enableAnimation) {
            this.ShowResult(this.resposedContent);
        }
        else
            ASPxClientControl.prototype.DoEndCallback.call(this);
    },

    /*Animation*/
    HideContent: function () {
        var mainElement = this.GetMainElement();
        this.animationProcessing = true;
        ASPxAnimationHelper.fadeOut(mainElement, ASPxClientCallbackPanel.DURATION_TIME, this.HideContentComplete.aspxBind(this));
    },
    HideContentComplete: function () {
        var mainElement = this.GetMainElement();
        if (__aspxSafari) {
            _aspxSetElementOpacity(mainElement, 0);
            _aspxSetElementVisibility(mainElement, false);
        }
        this.animationProcessing = false;

        if (this.inCallback) {
            this.ShowLoadingPanel();
            _aspxSetElementVisibility(mainElement, false);
            _aspxSetElementOpacity(mainElement, 1);

            if (this.GetLoadingPanelElement()) {
                var clone = _aspxGetElementById(this.GetLoadingPanelElement().id + "V");
                if (clone)
                    _aspxSetElementVisibility(clone, true);
            }

        } else { ASPxClientControl.prototype.DoCallback.call(this, this.resposedContent); }
    },
    ShowResult: function (result) {
        var mainElement = this.GetMainElement();
        _aspxSetElementOpacity(mainElement, 0); /*need kill pannel*/

        _aspxSetElementVisibility(mainElement, true);
        ASPxAnimationHelper.fadeIn(mainElement, ASPxClientCallbackPanel.DURATION_TIME, this.ShowResultComplete.aspxBind(this));
    },
    ShowResultComplete: function () {
        if (__aspxOpera) { /*fix opera redraw bug*/
            var position = document.body.style.position;
            document.body.style.position = 'relative';
            window.setTimeout(function () {
                document.body.style.position = position;
            }, 0);
        }
        //B188427
        if (__aspxIE && __aspxBrowserVersion < 9) {
            var mainElement = this.GetMainElement();
            if (mainElement.style.filter) {
                mainElement.style.filter = "";
            }
        }

        ASPxClientControl.prototype.DoEndCallback.call(this);
    },
    ShowLoadingPanel: function () {
        var element = this.GetContentElement();
        var mainElement = (element.tagName == "TD") ? this.GetMainElement() : element;
        
        this.CreateLoadingDiv(element);
        if(!this.hideContentOnCallback)
            this.CreateLoadingPanelWithAbsolutePosition(element, mainElement);
        else
            this.CreateLoadingPanelInsideContainer(element, true, true, false);
    },
    /*# public void PerformCallback(string parameter) {} #*/
    PerformCallback: function (parameter) {
        this.CreateCallback(parameter);
    },
    CreateCallback: function (arg, command, callbackInfo) {
        if (this.CanCreateCallback()) {
            this.inCallback = true;
            if (!this.enableAnimation)
                this.ShowLoadingPanel();
            else
                this.HideContent();
        }
        ASPxClientControl.prototype.CreateCallback.call(this, arg, command);
    },
    GetLoadingPanelTextLabelID: function () {
        return this.name + "_TL";
    },
    GetLoadingPanelTextLabel: function () {
        return _aspxGetElementById(this.GetLoadingPanelTextLabelID());
    },
    /*# public string GetLoadingPanelText() {return "";} #*/
    GetLoadingPanelText: function () {
        var textLabel = this.GetLoadingPanelTextLabel();
        if(textLabel && !this.isLoadingPanelTextEmpty)
            return textLabel.innerHTML;
        return "";
    },
    /*# public void SetLoadingPanelText(string loadingPanelText) {} #*/
    SetLoadingPanelText: function (text) {
        this.isLoadingPanelTextEmpty = text == null || text == "";
        var textLabel = this.GetLoadingPanelTextLabel();
        if(textLabel)
            textLabel.innerHTML = this.isLoadingPanelTextEmpty ? "&nbsp;" : text;
    },
    /*# public string GetContentHtml(){ return ""; } #*/
    GetContentHtml: function () {
        return this.GetContentElement().innerHTML;
    },
    /*# public void SetContentHtml(string html){ } #*/
    SetContentHtml: function (html) {
        this.GetContentElement().innerHTML = html;
    }
    /*# public void SetEnabled(bool enabled){ return; } #*/
    /*# public bool GetEnabled(){ return true; } #*/
});
/*# public static new ASPxClientCallbackPanel Cast(object obj){ return null; } #*/
ASPxClientCallbackPanel.DURATION_TIME = 500;
ASPxClientCallbackPanel.Cast = ASPxClientControl.Cast;
/*# using DevExpress.Web.ASPxClasses.Scripts; #*/
/*# namespace DevExpress.Web.ASPxHiddenField.Scripts #*/

/*# public class ASPxClientHiddenField : ASPxClientControl #*/
ASPxClientHiddenField = _aspxCreateClass(ASPxClientControl, {
    constructor: function(name) {
        this.constructor.prototype.constructor.call(this, name);
        
        // Initialized by the server
        this.syncWithServer = true;
        this.properties = { };
        this.typeInfoTable = { };
        this.typeNameTable = [ ];
        
        this.allowMultipleCallbacks = false;
        /*# public event ASPxClientBeginCallbackEventHandler BeginCallback{ add{} remove{}} #*/
        /*# public event ASPxClientEndCallbackEventHandler EndCallback{ add{} remove{}} #*/
        /*# public event ASPxClientCallbackErrorEventHandler CallbackError{ add{} remove{}} #*/
    },
    
    // Initialization
    InlineInitialize: function() {
        if(this.syncWithServer) {
            var postHandler = aspxGetPostHandler();
            postHandler.PostFinalization.removeHandlerByControlName(this.name);
            postHandler.PostFinalization.AddHandler(this.OnPost, this);
        }
    },
    
    // Elements Access
    GetInputElement: function() {
        if(this.inputElement == null)
            this.inputElement = document.getElementById(this.name + ASPxClientHiddenField.InputElementIDSuffix);
        return this.inputElement;
    },
    
    // Synchronization
    OnPost: function() {
        var inputElement = this.GetInputElement();
        if(inputElement) {
            var serializedData = _aspxGetHiddenFieldSerializer().Serialize(this);
            inputElement.value = this.EscapeSpecialCharacters(
                _aspxEncodeHtml(serializedData)
            );
        }
    },
    EscapeSpecialCharacters: function(str) {
        str = str.replace(/\\/g, "\\\\");
        var specialChars = {};
        for(var i = 0; i < str.length; i++) {
            var char = str.charAt(i);
            var charCode = char.charCodeAt(0);
            if(charCode < 32) {
                var hexCharCode = charCode.toString(16);
                specialChars[char] = "\\u" + "0000".substr(0, 4 - hexCharCode.length) + hexCharCode;
            }
        }
        for(var ch in specialChars)
            str = str.replace(new RegExp(ch, "g"), specialChars[ch]);
        return str;
    },
    
    // Callback
    /*# public void PerformCallback(string parameter) { } #*/
    PerformCallback: function(parameter) {
        this.CreateCallback(parameter);
    },
    OnCallback: function(result) {
        var callbackMarkupContainer = this.GetCallbackMarkupContainer();
        _aspxSetInnerHtml(callbackMarkupContainer, result);
    },
    GetCallbackMarkupContainer: function() {
        var callbackMarkupContainer = _aspxGetElementById(this.GetCallbackMarkupContainerID());
        if(!callbackMarkupContainer) {
            callbackMarkupContainer = this.CreateCallbackMarkupContainer();
            document.body.appendChild(callbackMarkupContainer);
        }
        return callbackMarkupContainer;
    },
    GetCallbackMarkupContainerID: function() {
        return this.name + ASPxClientHiddenField.CallbackMarkupContainerIDSuffix;
    },
    CreateCallbackMarkupContainer: function() {
        var callbackMarkupContainer = document.createElement("DIV");
        _aspxSetElementDisplay(callbackMarkupContainer, false);
        callbackMarkupContainer.id = this.GetCallbackMarkupContainerID();
        return callbackMarkupContainer;
    },
    // API
    /*# public void Add(string propertyName, object propertyValue) { } #*/
    Add: function(propertyName, propertyValue) {
        var existentPropertyValue = this.Get(propertyName);
        if(typeof(existentPropertyValue) == "undefined")
            this.Set(propertyName, propertyValue);
        else
            alert("A property with the name '" + propertyName + "' has already been added.");
        
    },
    /*# public object Get(string propertyName) { return null; } #*/
    Get: function(propertyName) {
        var safeName = this.GetTopLevelPropertySafeName(propertyName);
        return this.properties[safeName];
    },
    /*# public void Set(string propertyName, object propertyValue) { } #*/
    Set: function(propertyName, propertyValue) {
        var safeName = this.GetTopLevelPropertySafeName(propertyName);
        if(typeof(propertyValue) == "undefined")
            this.Remove(propertyName);
        else
            this.properties[safeName] = propertyValue;
    },
    /*# public void Remove(string propertyName) { } #*/
    Remove: function(propertyName) {
        var safeName = this.GetTopLevelPropertySafeName(propertyName);
        delete this.properties[safeName];
        ASPxTypeInfoHelper.RemoveTypeInfoBranch(this.typeInfoTable, safeName);
    },
    /*# public void Clear() { } #*/
    Clear: function() {
        this.properties = { };
        this.typeInfoTable = { };
        this.typeNameTable = [ ];
    },
    /*# public bool Contains(string propertyName) { return false; } #*/
    Contains: function(propertyName) {
        var safeTopLevelPropertyName = this.GetTopLevelPropertySafeName(propertyName);
        for(var key in this.properties) {
            if(key == safeTopLevelPropertyName)
                return true;
        }
        return false;
    },

    // Utils
    GetTopLevelPropertySafeName: function(propertyName) {
        return ASPxClientHiddenField.TopLevelKeyPrefix + propertyName;
    }
});
/*# public static new ASPxClientHiddenField Cast(object obj){ return null; } #*/
ASPxClientHiddenField.Cast = ASPxClientControl.Cast;

ASPxClientHiddenField.InputElementIDSuffix = "_I";
ASPxClientHiddenField.CallbackMarkupContainerIDSuffix = "_D";
ASPxClientHiddenField.TopLevelKeyPrefix = "dxp";

ASPxTypeInfoHelper = _aspxCreateClass(null, {
    constructor: function() {
        this.minUnknownTypeIndex = 1024;
        this.clientTypeConstructors = [
            null,
            Number,
            String,
            Date,
            Boolean,
            RegExp,
            Array,
            Object,
            Function
        ];
        this.clientTypeConstructorIndices = { };
        for(var i = 1; i < this.clientTypeConstructors.length; i++)
            this.clientTypeConstructorIndices[this.clientTypeConstructors[i]] = i;
    },
    
    // Public
    EnsureTypeInfoTableCompliant: function(value, typeInfoTable, typeInfoKey) {
        if(typeInfoKey == "")
            return;
        var typeCode = typeInfoTable[typeInfoKey];
        if(typeof(typeCode) != "undefined") {
            if(!this.IsValueTypeInfoCompliant(value, typeCode))
                ASPxTypeInfoHelper.RemoveTypeInfoBranch(typeInfoTable, typeInfoKey);
            else
                return;
        }
        typeCode = this.CreateTypeCode(value);
        if(typeof(typeCode) != "undefined")
            typeInfoTable[typeInfoKey] = typeCode;
        else
            delete typeInfoTable[typeInfoKey];
    },
    IsAtomValue: function(value, typeCode) {
        return typeCode == 0 || !(this.IsListValue(value, typeCode) || this.IsDictionaryValue(value, typeCode));
    },
    IsListValue: function(value, typeCode) {
        return this.IsKnownTypeCode(typeCode) ? this.GetConstructor(typeCode) === Array : value.constructor === Array;
    },
    IsDictionaryValue: function(value, typeCode) {
        return this.IsKnownTypeCode(typeCode) ? this.GetConstructor(typeCode) === Object : value.constructor === Object;
    },
    GetArrayTypeCode: function() {
        return this.clientTypeConstructorIndices[Array] << 1;
    },
    GetStringTypeCode: function() {
        return this.clientTypeConstructorIndices[String] << 1;
    },
    IsStringTypeCode: function(typeCode) {
        return typeCode == this.GetStringTypeCode();
    },
    
    // Private
    IsValueTypeInfoCompliant: function(value, typeCode) {
        if(this.IsKnownTypeCode(typeCode))
            return value != null ? value.constructor === this.GetConstructor(typeCode) : this.IsNullable(typeCode);
        else
            return value == null || value.constructor === Array || value.constructor === Object;
    },
    CreateTypeCode: function(value) {
        if(value == null)
            return 1; /* Nullable with unknown ctor */
        var clientTypeIndex = this.clientTypeConstructorIndices[value.constructor];
        var lowerBit = Number(
            clientTypeIndex == this.clientTypeConstructorIndices[RegExp] ||
            clientTypeIndex == this.clientTypeConstructorIndices[Array] ||
            clientTypeIndex == this.clientTypeConstructorIndices[Object]
        );
        return typeof(clientTypeIndex) != "undefined" ? ((clientTypeIndex << 1) + lowerBit) : void(0);
    },
    IsNullable: function(typeCode) {
        return (typeCode & 1) > 0;
    },
    GetConstructor: function(typeCode) {
        return this.clientTypeConstructors[(typeCode >>> 1) & 7];
    },
    IsKnownTypeCode: function(typeCode) {
        return typeCode < this.minUnknownTypeIndex;
    }
});
ASPxTypeInfoHelper.RemoveTypeInfoBranch = function(typeInfoTable, typeInfoKeyPrefix) {
        for(var key in typeInfoTable) {
            if(key.indexOf(typeInfoKeyPrefix) == 0)
                delete typeInfoTable[key];
        }
};

ASPxHiddenFieldSerializer = _aspxCreateClass(null, {
    constructor: function() {
        this.typeInfoHelper = new ASPxTypeInfoHelper();
        this.separator = "|";
        this.sentinel = "#";
        this.charCodes = this.CreateCharCodeList([ "a", "z", "0", "9", "_", "$" ]);        
    },
    Serialize: function(hiddenField) {
        var sb = [ ];
        this.SerializeCore(hiddenField.typeNameTable, "", sb, null, null, null, false);
        this.SerializeCore(hiddenField.properties, "", sb, hiddenField.typeInfoTable, hiddenField.typeNameTable, ASPxClientHiddenField.TopLevelKeyPrefix, true);
        return sb.join("");
    },
    SerializeCore: function(value, pathInPropertiesTree, serializedData, typeInfoTable, typeNameTable, keyNamePrefix, validateKeys) {
        var metaTablesDefined = typeInfoTable != null && typeNameTable != null;
        var typeCode = null;
        if(metaTablesDefined) {
            // Properties are being serialized
            this.typeInfoHelper.EnsureTypeInfoTableCompliant(value, typeInfoTable, pathInPropertiesTree);
            typeCode = typeInfoTable[pathInPropertiesTree];
        } else {
            // Metatable itself is being serialized, so it's either a metatable (array) or its item (string)
            typeCode = value.constructor === Array ?
                this.typeInfoHelper.GetArrayTypeCode() : this.typeInfoHelper.GetStringTypeCode();
        }
        if(typeof(typeCode) != "undefined")
            serializedData.push(typeCode);
        serializedData.push(this.separator);
        if(typeof(typeCode) == "undefined" || this.typeInfoHelper.IsDictionaryValue(value, typeCode)) {
            for(var key in value) {
                var serializableKey = key;
                if(keyNamePrefix.length > 0)
                    serializableKey = serializableKey.slice(keyNamePrefix.length);
                if(validateKeys)
                    this.AssertKeyIsValid(serializableKey);
                serializedData.push(serializableKey);
                serializedData.push(this.separator);
                this.SerializeCore(value[key], pathInPropertiesTree.length > 0 ? (pathInPropertiesTree + this.separator + key) : key,
                    serializedData, typeInfoTable, typeNameTable, "", validateKeys);   
            }
            serializedData.push(this.sentinel);
        } else if(this.typeInfoHelper.IsListValue(value, typeCode)) {
            for(var i = 0; i < value.length; i++)
                this.SerializeCore(value[i], pathInPropertiesTree.length > 0 ? (pathInPropertiesTree + this.separator + i) : i,
                    serializedData, typeInfoTable, typeNameTable, "", validateKeys);
            serializedData.push(this.sentinel);
        } else if(this.typeInfoHelper.IsAtomValue(value, typeCode))
            this.SerializeAtomValue(value, serializedData, typeCode);
    },
    SerializeAtomValue: function(value, sb, typeCode) {
        var valueStr = this.SerializeAtomValueCore(value, typeCode);
        sb.push(valueStr.length.toString());
        sb.push(this.separator);
        sb.push(valueStr);
    },
    SerializeAtomValueCore: function(value, typeCode) {
        var isString = this.typeInfoHelper.IsStringTypeCode(typeCode);
        if(value == null)
            return isString ? "0" : "";
        else {
            if(isString) {
                return "1" + value.replace(/\r/g, ""); // Q239689 & B200946
            } else {
                var ctor = value.constructor;
                if(ctor === String /* (Char) */)
                    return value;
                else if(ctor === Boolean)
                    return value ? "1" : "0";
                else if(ctor === Number)
                    return value.toString();
                else if(ctor === Date)
                    return String(_aspxToLocalTime(value).valueOf());
                else if(ctor === RegExp) {
                    var options = "";
                    if(value.ignoreCase)
                        options += "i";
                    if(value.multiline)
                        options += "m";
                    return options + "," + value.source;
                }
            }
        }
        alert("Unable to serialize value " + value.toString() + " (Constructor: " + value.constructor.toString() + ").");
    },
    
    // Utils
    AssertKeyIsValid: function(key) {
        if(!key)
            alert("Empty key.");
    },
    CreateCharCodeList: function(chars) {
        var charCodes = { };
        for(var i = 0; i < chars.length; i++) {
            var ch = chars[i];
            charCodes[ch] = ch.charCodeAt(0);
        }
        return charCodes;
    },
    IsLowercaseLetterCharCode: function(charCode) {
        return charCode >= this.charCodes["a"] && charCode <= this.charCodes["z"];
    },
    IsLowercaseLetterOrDigitCharCode: function(charCode) {
        if(this.IsLowercaseLetterCharCode(charCode))
            return true;
        else
            return charCode >= this.charCodes["0"] && charCode <= this.charCodes["9"];
    }
});

function _aspxGetHiddenFieldSerializer() {
    if(!window.__aspxHiddenFieldSerializer)
        window.__aspxHiddenFieldSerializer = new ASPxHiddenFieldSerializer();
    return window.__aspxHiddenFieldSerializer;
}

/*# using DevExpress.Web.ASPxClasses.Scripts; #*/
/*# namespace DevExpress.Web.ASPxTimer.Scripts #*/

/*# public class ASPxClientTimer : ASPxClientControl #*/
ASPxClientTimer = _aspxCreateClass(ASPxClientControl, {
    constructor: function(name) {
        this.constructor.prototype.constructor.call(this, name);
        
        this.interval = 60000;
        this.clientEnabled = true;
        this.timerID = -1;
        
        /*# public event ASPxClientProcessingModeEventHandler Tick { add{} remove{} }#*/                    
        this.Tick = new ASPxClientEvent();
    },    
    Initialize: function() {
        if (this.clientEnabled)
            this.Start();                    
        this.constructor.prototype.Initialize.call(this);
    },
    
    GetStateInputElement: function(index){
        return _aspxGetElementById(this.name + "S");
    },        
    
    Start: function() {        
        this.Stop();
        this.timerID = _aspxSetInterval("aspxTTick(\"" + this.name + "\")", this.interval);
    },
    Stop: function() {         
        if(this.timerID == -1) return;
        this.timerID = _aspxClearInterval(this.timerID);
    },    
    DoTick: function() {        
        var processOnServer = this.RaiseTick();               
        if(processOnServer)
            this.SendPostBack("TICK");
    },    
    GetStateString: function(){
        return (this.clientEnabled ? "1" : "0") + ";" + this.interval;
    },
    UpdateState: function() {
        var element = this.GetStateInputElement();
        if (element != null) 
            element.value = this.GetStateString();
    },
    // API
    RaiseTick: function() {
        var processOnServer = this.IsServerEventAssigned("Tick");
        if(!this.Tick.IsEmpty()) {
            var args = new ASPxClientProcessingModeEventArgs(processOnServer);
            this.Tick.FireEvent(this, args);
            processOnServer = args.processOnServer;
        }
        return processOnServer;
    },

    /*# public bool GetEnabled() { return false; } #*/
    GetEnabled: function() {
        return this.clientEnabled;
    },
    /*# public void SetEnabled(bool enabled) { } #*/
    SetEnabled: function(enabled) {    
        if (enabled == this.clientEnabled) return;
         if (enabled)
            this.Start();
         else 
            this.Stop();                    
         this.clientEnabled = enabled;
         this.UpdateState();
    },
    /*# public int GetInterval() { return 0; } #*/
    GetInterval: function() {
        return this.interval;
    },
    /*# public void SetInterval(int interval) { } #*/
    SetInterval: function(interval) {
        if (interval < 1) return;
        this.interval = interval;    
        if (this.clientEnabled) {
            this.Stop();
            this.Start();
        }                    
        this.UpdateState();
    }
});
/*# public static new ASPxClientTimer Cast(object obj){ return null; } #*/
ASPxClientTimer.Cast = ASPxClientControl.Cast;

function aspxTTick(name){
    var timer = aspxGetControlCollection().Get(name);
    if(timer != null) timer.DoTick();
}

