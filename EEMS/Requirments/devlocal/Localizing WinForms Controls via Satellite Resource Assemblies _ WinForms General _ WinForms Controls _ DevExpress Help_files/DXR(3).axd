var _constSSLCookieName = "SSL";
var _wsIsESCAttached = false;
var _wsIsWindowClosingByAction = false;
var _wsIsWindowClosingByUser = false;
var _wsOpenModalWindows = new Array();
var _wsPostAction = null;
var _wsPostActionDescription = null;
var _wsCancelAction = null;
var _wsSourcePageSecured = null;
var _wsPopupWindowCallback = false;

function _wsGetIfHasOpenModalWindows() { return _wsOpenModalWindows.length > 0; }
function _wsPushOpenModalWindow(wnd) { ASPxClientUtils.ArrayInsert(_wsOpenModalWindows, wnd, 0); }
function _wsPopOpenModalWindow() { if (_wsGetIfHasOpenModalWindows()) ASPxClientUtils.ArrayRemoveAt(_wsOpenModalWindows, 0); }
function _wsCloseTopModalWindow() {
    if (!_wsGetIfHasOpenModalWindows()) return null;
    var wnd = _wsOpenModalWindows[0];
    HideModalWindow(wnd.popupControl, wnd.name);
}
/* Closing modal windows by ESC */
function _wsAttachESCOnInit(s, args) {
    if (!_wsIsESCAttached) {
        ASPxClientUtils.AttachEventToElement(document, "keydown", _wsDocumentKeyDown); // ESC
        _wsIsESCAttached = true;
    }
}
function _wsDocumentKeyDown(evt) {
    if (ASPxClientUtils.GetKeyCode(evt) == 27) {
        _wsIsWindowClosingByUser = true;
        // if modal window
        if (_wsGetIfHasOpenModalWindows()) {
            _wsCloseTopModalWindow();
        } else {
            ASPxClientPopupControl.GetPopupControlCollection().HideAllWindows();
        }
        return false;
    }
    return true;
}

function _wsSetSSLCookie(wndName, postAction, postActionDescription, cancelAction) {
    var postActionString = (typeof postAction != 'undefined' && postAction != null) ? postAction : '';
    var postActionDescriptionString = (typeof postActionDescription != 'undefined' && postActionDescription != null) ? postActionDescription : '';
    var cancelActionString = (typeof cancelAction != 'undefined' && cancelAction != null) ? cancelAction : '';
    _wsSetSessionCookie(_constSSLCookieName, wndName + "^" + _wsGetIsCurrentPageSecured() + "^" + postActionString + "^" + postActionDescriptionString + "^" + cancelActionString);
}
function _wsGetSSLCookieObject() {
    var sslCookieValue = ASPxClientUtils.GetCookie('SSL');
    if (sslCookieValue == null || sslCookieValue == '') return null;
    var cookieParams = sslCookieValue.split("^");
    var sslObject = new Object();
    sslObject.WindowName = cookieParams[0];
    sslObject.IsSourcePageSecured = !cookieParams[1];
    sslObject.PostAction = cookieParams[2];
    sslObject.PostActionDescription = cookieParams[3];
    sslObject.CancelAction = cookieParams[4];
    return sslObject;
}
function _wsSetSessionCookie(name, value) {
    var cookieDomain = _wsGetCookieDomain();
    var cookieString = escape(name) + "=" + escape(value.toString()) + "; path=/;";
    if (cookieDomain != "") {
        cookieString += " domain=" + cookieDomain;
    }
    document.cookie = cookieString;
}
function _wsGetCookie(name) {
    name = escape(name);
    var cookies = document.cookie.split(';');
    for (var i = 0; i < cookies.length; i++) {
        var cookie = _wsTrim(cookies[i]);
        if (cookie.indexOf(name + "=") == 0)
            return unescape(cookie.substring(name.length + 1, cookie.length));
        else if (cookie.indexOf(name + ";") == 0 || cookie === name)
            return "";
    }
    return null;
}
function _wsTrimStart(str) {
    var re = /\s*((\S+\s*)*)/;
    return str.replace(re, "$1");
}
function _wsTrimEnd(str) {
    var re = /((\s*\S+)*)\s*/;
    return str.replace(re, "$1");
}
function _wsTrim(str) {
    return _wsTrimStart(_wsTrimEnd(str));
}
function _wsRemoveSSLCookie() { _wsRemoveCookie(_constSSLCookieName); }
function _wsRemoveCookie(cookieName) {
    var cookieDomain = _wsGetCookieDomain();
    var cookieString = escape(cookieName) + "=; path=/; expires=Thu, 01-Jan-1970 00:00:01 GMT;";
    if (cookieDomain != "") {
        cookieString += " domain=" + cookieDomain;
    }
    document.cookie = cookieString;
}
function _wsGetCookieDomain() {
    var host = document.location.host;
    if (host.indexOf(".") >= 0) { // not localhost
        var hostParts = host.split(".");
        if (hostParts.length >= 2) {
            return "." + hostParts[hostParts.length - 2] + "." + hostParts[hostParts.length - 1];
        }
    }
    return "";
}
function _wsSwitchToHttps() {
    var href = document.location.href;
    var host = document.location.host;
    if (host.indexOf(".") >= 0) { // not localhost
        var hostParts = host.split(".");
        if (hostParts.length == 2) {
            host = "www." + hostParts[0] + "." + hostParts[1];
            href = href.replace("://" + document.location.host, "://" + host);
        }
    }
    href = href.replace(/^http:/, "https:");
    document.location.replace(href);
}
function _wsGetIsCurrentPageSecured() { return document.location.protocol == "https:"; }
function _wsShowACWindowWithPostAction(wndName, shouldBeSecured, postAction, postActionDescription, cancelAction) {
    _wsHideAllAccountWindows();
    if (shouldBeSecured && !_wsGetIsCurrentPageSecured()) {
        _wsSetSSLCookie(wndName, postAction, postActionDescription, cancelAction);
        _wsSwitchToHttps();
    } else {
        _wsPostAction = postAction;
        _wsPostActionDescription = postActionDescription;
        _wsCancelAction = cancelAction;
        _wsSourcePageSecured = _wsGetSSLCookieObject() == null;
        if (AccountController.GetWindowByName(wndName) == null) {
            _wsRemoveSSLCookie();
            ReloadPage()
            return;
        }
        ShowModalWindow(AccountController, wndName);
    }
}
function _wsHideAllAccountWindows() {
    for (var i = 0; i < AccountController.GetWindowCount(); i++) {
        if (AccountController.IsWindowVisible(AccountController.GetWindow(i))) {
            AccountController.HideWindow(AccountController.GetWindow(i));
        }
    }
}
/* Account Menu */
function _wsAccountMenuClick(s, o) {
    var wndName = o.item.name;
    if (wndName == null || wndName == '' || o.item.GetNavigateUrl() != '') return;
    var isSecured = false;
    switch (wndName) {
        case "LG": case "RG":case "FP":case "PF":case "CP":case "CE":case "AE": isSecured = true; break;
    }
    _wsShowACWindowWithPostAction(wndName, isSecured);
}
function _wsCommonWindowOnPopupCore(popup, wndName) {
    return _wsCommonWindowOnPopupCore2(popup, eval("cbp" + wndName));
}
function _wsCommonWindowOnPopupCore2(popup, cbp) {
    var wnd = popup.GetWindowByName(cbp.cpWindow);
    _wsSaveDocumentScrollPosition(wnd);
    if (typeof cbp.cpWindowTitle == 'undefined') {
        cbp.cpWindowTitle = wnd.GetHeaderText();
    }
    if (wnd.GetHeaderImageUrl() == '') {
    	wnd.SetHeaderText(GetLocalizedString("tLoading"));
    }
    cbp.GetMainElement().innerHTML = ''
    cbp.GetMainElement().style.width = '';
    cbp.GetMainElement().style.height = '100px';
    popup.SetWindowSize(wnd, 300, 0);
    popup.UpdateWindowPosition(wnd);
    return cbp;
}
function _wsAccountMenuWindowPopup(popup, o) {
    var cbp = _wsCommonWindowOnPopupCore(popup, o.window.name);
    var cmdLoadWithPostAction = "Load";
    cmdLoadWithPostAction += "^" + (typeof _wsPostAction != 'undefined' && _wsPostAction != null ? _wsPostAction : '');
    cmdLoadWithPostAction += "^" + (typeof _wsPostActionDescription != 'undefined' && _wsPostActionDescription != null ? _wsPostActionDescription : '');
    cmdLoadWithPostAction += "^" + (typeof _wsCancelAction != 'undefined' && _wsCancelAction != null ? _wsCancelAction : '');
    _wsPostAction = null;
    _wsPostActionDescription = null;
    _wsCancelAction = null;
    cbp.PerformCallback(cmdLoadWithPostAction);
}
function _wsCommonPopupWindowClosing(s, o) {
    if (_wsPopupWindowCallback) o.cancel = true; // prevent window closing on callback
}
function _wsCommonPopupWindowCloseUp(s, o) {
    _wsPopOpenModalWindow();
    eval("var cbp = cbp" + o.window.name);
    cbp.cpLoaded = null;
    if (_wsIsWindowClosingByUser && !_wsGetIfHasPostAction(cbp)) {
        _wsIsWindowClosingByUser = false;
        if (!_wsGetIfHasOpenModalWindows()) {
            var sslObj = _wsGetSSLCookieObject();
            _wsRemoveSSLCookie();
            var isRedirectedOnCancelAction = false;
            if (_wsGetIfHasCancelAction(cbp)) {
                cbp.cpAction = cbp.cpCancelAction;
                cbp.cpCancelAction = null;
                isRedirectedOnCancelAction = _wsProcessPostActions(cbp, o.window, false);
            }
            if (sslObj != null && !isRedirectedOnCancelAction) ReloadPage();
        }
    } else {
        if (!_wsIsWindowClosingByAction) {
            _wsProcessPostActions(cbp, o.window, false);
        }
        _wsIsWindowClosingByAction = false;
    }
    _wsRestoreDocumentScrollPosition(o.window);
}
function _wsSaveDocumentScrollPosition(openingWindow) {
    openingWindow.savedScrollTop = ASPxClientUtils.GetDocumentScrollTop();
    openingWindow.savedScrollLeft = ASPxClientUtils.GetDocumentScrollLeft();
}
function _wsRestoreDocumentScrollPosition(closingWindow) {
    var scrollTop = closingWindow.savedScrollTop != 'undefined' ? closingWindow.savedScrollTop : 0;
    var scrollLeft = closingWindow.savedScrollLeft != 'undefined' ? closingWindow.savedScrollLeft : 0;
    window.scrollTo(scrollLeft, scrollTop);
}
function _wsCommonPopupCloseButtonClick(popup, args) {
    _wsIsWindowClosingByUser = true;
    var windows = popup.cpCloseButtonEnabledWindows.split(";");
    for (var i = 0; i < windows.length; i++) {
        if (windows[i] == args.window.name) {
            popup.HideWindow(args.window);
            return;
        }
    }    
}
function _wsWindowCallbackPanelBeginCallback(s, o) {
    _wsPopupWindowCallback = true;
    _wsSetLoadingImageStyle(s, (typeof s.cpLoaded != 'undefined' && s.cpLoaded != null));
    _callback_DisableEditors(s, o);
    if (typeof s.cpAccountWindow != undefined && _wsGetSSLCookieObject() == null && _wsSourcePageSecured != null && !_wsSourcePageSecured) {
        WebForm_DoCallback = function() { }; // resetting global DoCallback to prevent posting
        ReloadPage();
    }
}
function _wsModalWindowCallbackComplete(cbp, o) {
    _wsPopupWindowCallback = false;
    var popup = eval(eval("cbp.cpPopup"));
    var wnd = popup.GetWindowByName(cbp.cpWindow);

    __CommonWindowCallbackComplete(wnd, cbp);
    _wsProcessPostActions(cbp, wnd, true);
}
function _wsPopupWindowCallbackComplete(wnd, panel) {
    __CommonWindowCallbackComplete(wnd, panel);
}
function __CommonWindowCallbackComplete(window, panel) {
    panel.GetMainElement().disabled = false;
    var popup = window.popupControl;
    if (popup.IsWindowVisible(window)) {
        panel.GetMainElement().style.display = '';
        panel.GetMainElement().style.height = 'auto';
        panel.GetMainElement().style.overflow = 'auto';
        panel.GetMainElement().style.overflowX = 'hidden';
        if (typeof panel.cpContentWidth != 'undefined' && panel.cpContentWidth != '') {
            panel.GetMainElement().style.width = panel.cpContentWidth;
        } else {
            panel.GetMainElement().style.width = 'auto';
            if (typeof panel.cpWindowWidth != 'undefined') {
                window.popupControl.SetWindowSize(window, panel.cpWindowWidth, 0);
            }
        }
        if (typeof panel.cpWindowTitle != 'undefined') {
            window.SetHeaderText(panel.cpWindowTitle);
        }
        popup.UpdateWindowPosition(window);
        FixHiddenEditorsElements(panel.GetMainElement());
    }
}
function _wsSetLoadingImageStyle(loadingPanel, isContentPresent) {
    var border = isContentPresent? 'solid 1px #989aa4' : ''
    loadingPanel.GetLoadingPanelElement().style.border = border;
}

// PostAction types
// empty - default behaviour of control
// Close - close window (default dependant)
// Redirect:url - redirect to url
// Call:function - calls some function
// ReloadCall:function - calls some function after reload
function _wsGetIfHasPostAction(cbp) {
    return typeof cbp.cpAction != 'undefined' && cbp.cpAction != null && cbp.cpAction != '';
}
function _wsGetIfHasCancelAction(cbp) {
    return typeof cbp.cpCancelAction != 'undefined' && cbp.cpCancelAction != null && cbp.cpCancelAction != '';
}
function _wsProcessPostActions(cbp, wnd, skipDelayed) {
    if(!_wsGetIfHasPostAction(cbp)) return false;
    var actions = cbp.cpAction.split('^');
    var hasRedirect = false;
    for (var i = 0; i < actions.length; i++) {
        if (skipDelayed && actions[i] == 'DelayedClose') return false;
        if (_wsPerformPostAction(actions[i], wnd)) {
            hasRedirect = true;
        }
    }
    cbp.cpAction = null;
    return hasRedirect;
}
function _wsPerformPostAction(action, window) {
    _wsRemoveSSLCookie();
    if (typeof action == 'undefined' || action == '') return false;
    if (action == "Close" && window != null) {
        _wsIsWindowClosingByAction = true;
        window.popupControl.HideWindow(window);
    }
    if (action == "Reload") {
        ReloadPage();
        return true;
    }
    if (action.indexOf("Redirect:") == 0) {
        document.location.href = action.replace("Redirect:", "");
        return true;
    }
    if (action.indexOf("Call:") == 0) {
        eval("var result = " + action.replace("Call:", ""));
        if (typeof result != 'undefined') return result;
    }
    if (action.indexOf("ReloadCall:") == 0) {
        _wsSetSessionCookie('PostAction', action.replace("ReloadCall:", ""));
        ReloadPage();
        return true;
    }
    return false;
}

// Auth Controls Cross-Project public methods
function PerformLogin(postAction, postActionDescription, cancelAction) {
    if (!IsLoggedIn) {
        _wsShowACWindowWithPostAction("LG", true, postAction, postActionDescription, cancelAction);
    } else {
        _wsPerformPostAction(postAction, null);
    }
}
function PerformRegister(postAction, postActionDescription, cancelAction) {
    if (!IsLoggedIn) {
        _wsShowACWindowWithPostAction("RG", true, postAction, postActionDescription, cancelAction);
    } else {
        _wsPerformPostAction(postAction, null);
    }
}
function UpdateCaptchaImage(captchaImageId) {
    var captchaImg = document.getElementById(captchaImageId);
    if (typeof captchaImg == 'undefined' || captchaImg == null) return;
    var path = captchaImg.src.split('?');
    captchaImg.src = path[0] + "?" + new Date().getMilliseconds();
}
function PerformPasswordRecovery(postAction, postActionDescription, cancelAction) {
    if (!IsLoggedIn) {
        _wsShowACWindowWithPostAction("FP", true, postAction, postActionDescription, cancelAction);
    } else {
        _wsPerformPostAction(postAction, null);
    }
}
function PerformChangeProfile(postAction, postActionDescription, cancelAction) {
    if (IsLoggedIn) {
        _wsShowACWindowWithPostAction("PF", true, postAction, postActionDescription, cancelAction);
    } else {
        _wsPerformPostAction(postAction, null);
    }
}
function PerformChangeEmail(postAction, postActionDescription, cancelAction) {
    if (IsLoggedIn) {
        _wsShowACWindowWithPostAction("CE", true, postAction, postActionDescription, cancelAction);
    } else {
        _wsPerformPostAction(postAction, null);
    }
}
function PerformChangePassword(postAction, postActionDescription, cancelAction) {
    if (IsLoggedIn) {
        _wsShowACWindowWithPostAction("CP", true, postAction, postActionDescription, cancelAction);
    } else {
        _wsPerformPostAction(postAction, null);
    }
}
function PerformManageAlternameEmails(postAction, postActionDescription, cancelAction) {
    if (IsLoggedIn) {
        _wsShowACWindowWithPostAction("AE", true, postAction, postActionDescription, cancelAction);
    } else {
        _wsPerformPostAction(postAction, null);
    }
}
function PerformNotificationsManagement(postAction, postActionDescription, cancelAction) {
    if (IsLoggedIn) {
        _wsShowACWindowWithPostAction("NM", false, postAction, postActionDescription, cancelAction);
    } else {
        _wsPerformPostAction(postAction, null);
    }
}
function PerformFreeProductRegistration(postAction, postActionDescription) {
    _wsShowACWindowWithPostAction('FRP', false, postAction, postActionDescription);
}
function ShowPrivacyPolicy() {
    ShowModalWindow(AccountController, "PP");
}
function ShowMultiLicenseDiscounts() {
    ShowModalWindow(AccountController, "MLD");
}
function ShowSetPassword(postAction) {
    _wsShowACWindowWithPostAction("SETP", true, postAction, null, "Call:LoadAppBasePage()");
}
function ShowModalWindow(pc, wndName) {
    var wnd = pc.GetWindowByName(wndName);
    _wsPushOpenModalWindow(wnd);
    pc.ShowWindow(wnd);
}
function HideModalWindow(pc, wndName) {
    pc.HideWindow(pc.GetWindowByName(wndName));
}
function ReloadPage() {
    _wsRemoveSSLCookie();
    _wsSetSessionCookie("Hash", document.location.hash);
    if (typeof IsPostback != 'undefined' && IsPostback) {
        document.location = document.location;
    } else {
        document.location.reload();
    }
}
function LoadAppBasePage() {
    if (typeof AppBaseUrl == 'undefined' || AppBaseUrl == '') {
        ReloadPage();
    } else {
        _wsRemoveSSLCookie();
        _wsSetSessionCookie("Hash", document.location.hash);
        document.location = AppBaseUrl;
    }
    return true;
}
// Used in Renderers/Popup.cs only
function _wsShowPopupWindow(popup, args) { 
    var cbp = eval(popup.name + '_cp_' + args.window.index);
    if (popup.cpEnableCallbacks && (popup.cpSendCallbackIfLoaded || (typeof (cbp.cpLoaded) == 'undefined' || !cbp.cpLoaded))) {
        _wsCommonWindowOnPopupCore2(popup, cbp);
        cbp.PerformCallback('');
    } else {
        _wsPopupWindowCallbackComplete(args.window, cbp);
    }
}

/* CallbackWindowUserControlBase.cs */
var _wsParamsOnLoad = null;
function _wsModalWindowPopupControlPopup(popup, o) {
    var cbp = _wsCommonWindowOnPopupCore(popup, o.window.name);
    PerformCallbackWithParams(cbp, "Load", _wsGetCustomCallbackParameters());
}
function _wsGetCustomCallbackParameters() {
    var result = _wsParamsOnLoad != null ? _wsParamsOnLoad : "";
    _wsResetParamsOnLoad();
    return result;
}
function _wsResetParamsOnLoad() {
    _wsParamsOnLoad = null;
}
/*
params:
Oid=xxx&Index=yyy
if parameter value is * - it's taken from cpParams
*/
function SetParamsOnLoad(value) {
    _wsParamsOnLoad = value;
}
function PerformCallbackWithParams(cbp, command, params) {
    var cmd = '';
    if (typeof command != 'undefined' && command != null) cmd = command;
    cmd += "?";
    if (typeof params != 'undefined' && params != null) {
        var newParams = '';
        // loading cpParams
        var cpParamsArray = new Array();
        if (typeof cbp.cpParams != 'undefined' && cbp.cpParams != null) {
            var cpParamsStoredArray = cbp.cpParams.split('&');
            for (var i = 0; i < cpParamsStoredArray.length; i++) {
                var cpParamPair = cpParamsStoredArray[i].split('=', 2);
                if (cpParamPair.length != 2) continue;
                cpParamsArray[cpParamPair[0]] = cpParamPair[1];
            }
        }

        var paramsArray = params.split('&');
        for (var i = 0; i < paramsArray.length; i++) {
            var paramPair = paramsArray[i].split('=', 2);
            if (paramPair.length != 2) continue; // invalid parameter
            if (paramPair[1] != '*') { // adding this parameter
                newParams += paramsArray[i] + "&";
                continue;
            }
            if (typeof cpParamsArray[paramPair[0]] != 'undefined') { // wildcard param - looking in cpParams
                newParams += paramPair[0] + "=" + cpParamsArray[paramPair[0]] + "&";
            }
        }
        if (newParams.lastIndexOf("&") == newParams.length - 1) {
            newParams = newParams.substr(0, newParams.length - 1);
        }
        cmd += newParams;
    } else {
        if (typeof cbp.cpParams != 'undefined' && cbp.cpParams != null) {
            cmd += cbp.cpParams;
        }
    }
    cbp.GetMainElement().disabled = true;
    cbp.PerformCallback(cmd);
}

function _setEnabledEditorsInContainer(container, isEnabled) {
    aspxGetControlCollection().ForEachControl(function (control) {
        if (ASPxIdent.IsASPxClientControl(control)) {
            var mainElement = control.GetMainElement();
            if (ASPxClientUtils.IsExists(mainElement) && ASPxClientUtils.GetIsParent(container, mainElement)) {
                control.SetEnabled(isEnabled);
            }
        }
    });
}
function _callback_DisableEditors(s, o) {
    _setEnabledEditorsInContainer(s.GetMainElement(), false);
}
// Video Player
function StopVideo() {
    if (typeof (flowplayer) != 'undefined') {
        var player = flowplayer();
        if (player != null && typeof (player) != 'undefined') {
            if (player.isPlaying())
                player.pause();
            player.stop();
            player.stopBuffering();
        }
    }
}

// restoring hash if any
var urlHash = _wsGetCookie('Hash');
if (typeof urlHash != 'undefined' && urlHash != null && urlHash != '') document.location.hash = urlHash;
_wsRemoveCookie("Hash");

function _wsMenuItemClick(menuItem) {
    if(menuItem == null) return true;
    eval("var jsProperty = menuItem.menu.cp" + menuItem.GetText().replace(/[^a-zA-Z]/g, ''));
    if((jsProperty == 'undefined') || (jsProperty == null)) return true;
    var parameters = jsProperty.split('|');
    if((parameters.length >= 2) && (parameters[0] == "PerformLogin")) {
        var loginText = (parameters.length > 2) ? parameters[2] : '';
        PerformLogin(parameters[1] + ':' + menuItem.GetNavigateUrl(), loginText);
        return false;
    }
}
function _wsDisplayClientTime(utcYear, utcMonth, utcDay, utcHour, utcMinute, utcSecond, displayMode) {
    var m = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
    var date = new Date();
    date.setUTCFullYear(utcYear, utcMonth - 1, utcDay);
    date.setUTCHours(utcHour, utcMinute, utcSecond);
    displayMode = typeof displayMode == 'undefined' ? "Time" : displayMode;
    if (displayMode == "Time") {
        var hour = date.getHours();
        var isPM = hour >= 12;
        if (hour > 12) { hour -= 12; }
        var minutes = date.getMinutes().toString();
        if (minutes.length == 1) minutes = "0" + minutes;
        document.write(hour + ":" + minutes + " " + (isPM ? "PM" : "AM"))
        return;
    }
    if(displayMode == "Date") {
        var day = date.getDate().toString(); if (day.length == 1) day = "0" + day;
        document.write(day + "-" + m[date.getMonth()] + "-" + date.getFullYear());
        return;
    }
    if (displayMode == "TZ") {
        var offset = date.getTimezoneOffset();
        var hOffset = Math.floor(offset / 60);
        var mOffset = Math.abs(offset % 60);
        var result = "GMT";
        if (hOffset < 0) result += " +" + (-hOffset).toString();
        if (hOffset > 0) result += " " + (-hOffset).toString();
        if (mOffset != 0) result += ":" + mOffset;
        document.write(result);
    }
}
/* Fix hidden elements in editors - Opera tabindex bug */
function FixHiddenEditorsElements(container) {
    var containerElement = (typeof container != 'undefined') ? container : null;
    aspxGetControlCollection().ForEachControl(function(control) {
        if (control.UpdateErrorFrameAndFocus && (containerElement == null || (containerElement != null && ASPxClientUtils.GetIsParent(containerElement, control.GetMainElement())))) {
            if (typeof control.CorrectValidationFrame == 'undefined') {
                control.CorrectValidationFrame = function() {
                    var externalTable = this.GetExternalTable();
                    var errorCell = this.GetErrorCell();
                    if (externalTable != null && errorCell != null) {
                        errorCell.style.visibility = externalTable.style.visibility;
                        externalTable.style.visibility = "visible";
                    }
                }
                control.oldUpdateErrorFrameAndFocus = control.UpdateErrorFrameAndFocus;
                control.UpdateErrorFrameAndFocus = function(setFocusOnError, ignoreVisibilityCheck, isValid) {
                    this.oldUpdateErrorFrameAndFocus(setFocusOnError, ignoreVisibilityCheck, isValid);
                    this.CorrectValidationFrame();
                }
            }
            control.CorrectValidationFrame();
        }
    });
}
function StatesValidation(s, e, countriesControl, StateRequiredCountries) {
    var isStateness = false;
    if (StateRequiredCountries != null &&
        StateRequiredCountries.length > 0 &&
        countriesControl != null &&
        countriesControl.GetSelectedItem() != null &&
        countriesControl.GetSelectedItem().value != null) {
        var selectedCountry = countriesControl.GetSelectedItem().value.toLowerCase();
        for (var i = 0; i < StateRequiredCountries.length; i++) {
            if (StateRequiredCountries[i].toLowerCase() === selectedCountry) {
                isStateness = true;
                break;
            }
        }
    }
    e.isValid = isStateness ? s.GetSelectedIndex() > 0 : true;
   }
function __MultiByteValidator(s, o) {
   	var text = s.GetText();
   	for (var i = 0; i < text.length; i++) {
   		if (text.charCodeAt(i) > 255) {
   			o.isValid = false;
   			return;
   		}
   	}
}
function ResetValidators(s) {
    var container = s.GetMainElement();
    aspxGetControlCollection().ForEachControl(function(control) {
        if (ASPxIdent.IsASPxClientEdit(control)) {
            control.SetIsValid(true);
        }
    });
}
/* Localization */
var _wsLocalizationData = [];
_wsLocalizationData['tLoading'] = [];
_wsLocalizationData['tLoading'][''] = "Loading...";
_wsLocalizationData['tLoading']['ja'] = "読み込み中…";

function GetLocalizedString(resourceName) {
	var currentLang = PreferredLanguage || '';
	if (!_wsLocalizationData[resourceName]) return "";
	return _wsLocalizationData[resourceName][currentLang] || _wsLocalizationData[resourceName][''];
}
