/* ASPx Demos patcher */
form.Form { position: relative; z-index: 0; }
form.Form .s-page { width: 989px; }

div.GreyBar {
	position: relative;
	background-color: #4a4a4a;
}
div.Content {
	width: 1080px;
	margin: 0px auto;
	/*overflow: hidden;*/
}
div.TOCv3 div.TopBar {
	height: 25px;
	color: White;
	overflow: visible;
	z-index: 2;
}
div.TOCv3 div.TopBar a,
div.TOCv3 div.TopBar span {
	color: White;
	text-decoration: none;
	margin-top: 4px;
	font-size: 12px;
	line-height: 14px;
}
div.TOCv3 div.TopBar div.ItemSeparator {
	width: 1px;
	height: 14px;
	background-color: #777777;
	overflow: hidden;
	margin: 5px 10px 6px 10px;
}
div.TOCv3 div.TopBar a.DownloadMyProducts {
	display: inline-block;
	position: relative;
	padding-left: 20px;
}
div.TOCv3 div.TopBar a.DownloadMyProducts span {
	position: absolute;
    margin: 0px;
    padding: 0px;
    line-height: normal;
	left: 0px;
	top: 0px;
	display: block;
	background-image: url(/DXR.axd?r=9999_32-jrPMg);
	background-position: -350px -70px;
	background-repeat: no-repeat;
	width: 15px;
	height: 15px;
	overflow: hidden;
}

div.TOCv3 div.TopBar a:hover {
	text-decoration: underline;
}

/* CORE CSS */
.b-securezone { background-image: url('/DXR.axd?r=9999_4-jrPMg'); background-color: White; background-repeat: repeat-x; }
.h-no-indent { margin: 0!important; padding: 0!important; }
.h-absolute { position: absolute; }
.h-clear { content: "."; display: block; height: 0; clear: both; visibility: hidden; font-size: 0px!important; }
.h-both { clear: both; }
.h-nowrap { white-space: nowrap!important; }
.h-box { display: inline-block; }
.h-hand, .h-hand span { cursor: pointer!important; cursor: hand!important; }
.h-reset-width { width: auto!important; }
.h-clear-bottom-margin { margin-bottom: 0px!important; }

.s-page { width: 949px; }
.s-header { width: 100%; height: 27px; }
.s-100 { width: 100%; }
.s-menu { width: 100%; }

.a-header { background: #3A4C79; }
.a-header-demos { background: #191f31; }
.s-footer { width: 100%; }
.i-footer { margin: 50px 10px 0px 10px; }
.i-footer-menu { margin: 5px 0px 0px 0px; }
.i-menu-footer li { display: inline; }
.i-menu-footer { margin: 0px 0px 0px 0px; }
.i-menu-footer-item { padding: 3px 0px 4px 0px; }
.f-menu-footer { font: 8pt Verdana; color: #B6D3F9; }
.f-menu-footer-link { font: 8pt Verdana; color: #0C3C8C; display: inline; text-decoration: none; }
.v-menu-footer-separator span { color: #3A4C79; padding: 3px 9px 4px 9px; background-image: url('/DXR.axd?r=9999_23-jrPMg'); background-repeat: no-repeat; background-position: center center; }
.mFooterSeparator { background-image: url('/DXR.axd?r=9999_23-jrPMg'); background-repeat: no-repeat; background-position: center center; }

.i-page { margin: 0 auto; padding: 0 auto; padding-bottom: 8px; }
.i-product-item-image img { margin: 0px 10px 0px 0px!important; }
.i-product-item-demos-image img { margin: 0px 6px 0px 0px!important; }
.i-demos-item-link { display: block; margin: 0px 0px 0px 0px; }
.i-demos-item-name { display: block; margin: 0px 0px 0px 0px; }
.i-header { margin: 3px 10px 4px 10px; }
.i-header-menu-left { margin-left: 22px; }
.i-header-menu-rss { margin-left: 15px; }
.i-header-cart { margin-left: 15px; }
.i-header-menu-right { margin-right: 16px!important; margin-top: 2px!important; }
.i-menu { margin: 17px 10px 11px 10px; }
.i-menu-inner { margin-top: 7px; }
.i-menu-header { margin: 0px 0px 0px 0px; padding: 0px 0px 0px 0px; }
.i-menu-header li { display: inline!important; }
.i-menu-header-item { padding: 3px 0px 4px 0px; display: inline-block!important; }
.i-menu-header-item-demos { padding-left: 3px; display: inline-block; }
.i-menu-header-item-demos img { margin-bottom: 2px; }
.i-search { margin-left: 3px; margin-right: 0px; margin-top: 1px; }
.i-search-left { margin-left: 3px; margin-right: 0px; margin-top: 1px; }
.i-search input { background-color: #3A4C79; border: 0px none; padding: 0px 0px 0px 0px; }
.i-menu-account-separator { padding: 2px 13px 4px 13px!important; font: 9pt Verdana; }

.f-light { font-size: 8pt; font-family: Verdana; color: #494B50; }
a.f-light { font-size: 8pt; font-family: Verdana; color: #0C3C8C; }
.f-light-demos { font: 8pt Verdana; color: #494B50!important; }
.f-link-demos { font: 8pt Verdana; color: #0C3C8C!important; }
.f-link-demos:hover { color: #0C3C8C!important; }
.f-menu-header { font: 8pt Verdana; color: #B6D3F9; }
.f-menu-header-link, .f-menu-header-link:link, .f-menu-header-link:visited { font: 8pt Verdana; color: #B6D3F9; text-decoration: none; }
.f-menu-header-link:hover { font: 8pt Verdana; color: White; text-decoration: underline; }
.f-menu-header-link-demos { text-decoration: none!important; }
.f-menu-header-link-demos:hover { text-decoration: none!important; }
.f-menu-header-item { font: 8pt Verdana; color: White!important; display: inline-block; }
.f-copyright { font: 8pt Verdana; color: #656A7E; }

.l-page { margin-right: -5px; }
.l-box { float: left; margin: 0 5px 5px 0; }
.l-container { width: 100%; }
.l-container:after, .c-container:after { content: "."; display: block; height: 0; clear: both; visibility: hidden; }

.c-container { /* width: 100%; */  } 
.c-cell { float: left;  }

/* ------------------------------------> POSITION <------------------------------------ */
.p-left { text-align: left; }
.p-center { text-align: center; }
.p-right { text-align: right; }
.p-f-left { float: left; }
.p-f-center { margin-left: auto!important; margin-right: auto!important; }
.p-f-right { float: right; }
.p-top { vertical-align: top; }

.v-root-layer { right: 0%; width: 150%!important; z-index: -1; }
li.v-menu-header-separator span, span.v-menu-header-separator { 
    color: #3A4C79; 
    padding: 3px 5px 4px 5px; 
    display: inline-block; 
    background-image: url('/DXR.axd?r=9999_22-jrPMg');
    background-repeat: no-repeat; 
    background-position: center center; 
}
div.InfoBar {
	background-color: #F7941E;
	color: White;
	text-align: center;
	font-size: 8pt;
	padding: 6px 0px;
}
div.s-InfoBar {
	height: 45px;
}
/* ACCOUNT/RSS MENU CSS */
/* -- ASPxMenu -- */
.dxmControl_AM
{
	font: 8pt Verdana;
	color: #B6D3F9;
}
.dxmControl_AM a, .dxmMenu_AM a, .dxmSubMenu_AM a
{
	color: #B6D3F9;
}
.dxmControl_AM a:hover
{
	text-decoration: none;
}
.dxmSubMenuItem_AM a, .dxmSubMenuItem_AM a:hover, .dxmSubMenuItem_AM a:visited
{
	color: #B6D3F9;
	text-decoration: none;
}
.dxmSubMenuItemHover_AM a
{
	color: #3A4C79!important;
}
.dxmMenuItemWithPopOutImage_AM img, .dxmMenuItemHoverWithPopOutImage_AM img, .dxmMenuItemSelectedWithPopOutImage_AM img
{
    margin-top: 4px;
    margin-bottom: 1px;
}
.dxmMenu_AM
{
	font: 8pt Verdana;
	color: #B6D3F9;
	background-color: #3A4C79;
	border-style: none;
	padding: 0px 0px 0px 0px;
}
.a-header-demos .dxmMenu_AM 
{
	background-color: #191f31;
}
.dxmMenuSeparator_AM
{
	width: 1px!important;
	height: 12px!important;
	background-color: #657BA6;
	margin: 1px 15px 0px 15px;
}
.dxmMenuItem_AM, .dxmMenuItemWithImage_AM, .dxmMenuItemWithPopOutImage_AM, .dxmMenuItemWithImageWithPopOutImage_AM
{
	font: 8pt Verdana;
	color: #B6D3F9;
	
	/*white-space: nowrap;*/
	text-decoration: none;
}

.dxmMenuItemHover_AM, .dxmMenuItemHoverWithImage_AM, .dxmMenuItemHoverWithPopOutImage_AM, .dxmMenuItemHoverWithImageWithPopOutImage_AM
{
	color: White!important;
}

.dxmMenuItem_AM, .dxmMenuItemWithImage_AM, .dxmMenuItemWithPopOutImage_AM, .dxmMenuItemWithImageWithPopOutImage_AM
{
	padding-top: 3px!important;
	padding-right: 0px;
	padding-bottom: 4px!important;
	padding-left: 0px;	
}
.dxmMenuItemWithImage_AM, .dxmMenuItemWithImageWithPopOutImage_AM {
	padding-top: 2px!important;
	padding-bottom: 5px!important;
}

.dxmMenuItemHover_AM, .dxmMenuItemHoverWithImage_AM, .dxmMenuItemHoverWithPopOutImage_AM, .dxmMenuItemHoverWithImageWithPopOutImage_AM
{
	padding-top: 3px!important;
	padding-right: 0px;
	padding-bottom: 4px!important;
	padding-left: 0px;	
}
.dxmMenuItemHoverWithImage_AM, .dxmMenuItemHoverWithImageWithPopOutImage_AM {
	padding-top: 2px!important;
	padding-bottom: 5px!important;
}

.dxmSubMenu_AM
{
	font: 8pt Verdana;
	color: #B6D3F9;
	background-color: White;
	border: Solid 1px #B9BDC3;
	padding: 0px 0px 0px 0px;
}
.dxmSubMenuSeparator_AM
{
	width: 100%!important;
	height: 1px!important;
	background-color: #D1D2D7;
}
.dxmSubMenuItem_AM, .dxmSubMenuItem_AM span, .dxmSubMenuItem_AM a
{
	font: 8pt Verdana;
	color: #1A3D76!important;
	/*white-space: nowrap;*/
}
.dxmSubMenuItem_AM
{
	padding-top: 3px;
	padding-right: 33px;
	padding-bottom: 4px;
	padding-left: 9px;	
}
.dxmSubMenuItemHover_AM
{
	background-color: #C6DAF6;
	color: #3A4C79!important;
}
.dxmSubMenuBorderCorrector_AM
{
    position: absolute;
    border: 0px;
	padding: 0px;
}
/* Disabled */
.dxmDisabled_AM
{
	color: #93a1a4;
	cursor: default;
}

/* Search TextBox */
.v-searchbox {
    font: 8pt Verdana;
	background-color: White;
	color: #131313;	
}
.v-searchbox .dxeEditArea {
    font: 8pt Verdana;
    background-color: White;
    height: auto;
}
@media screen and (-webkit-min-device-pixel-ratio:0) 
{ 
    .v-searchbox .dxeEditArea {
        height: 14px!important;
    }
}

/* -- ASPxSiteMapControl -- */
.dxsmControl_DX a
{
    color: #0C3C8C; 
    text-decoration: none;
}
.dxsmControl_DX a:hover
{
    text-decoration: underline;
}
.dxsmControl_DX a:visited
{
    color: #8C0C54;
}

.dxsmControl_DX 
{	
	color: #0C3C8C;
	font-family: Verdana, Arial;
	font-size: 8pt;
	border: 0px;	
	text-decoration: none;
}
/* - Category Level - */
.dxsmCategoryLevel_DX, .dxsmCategoryLevel_DX a
{
    color: #131313; /*#B6D3F9*/
	/*background-color: #DFE3EB;*/
    font-weight: bold;
    font-size: 11pt;
    font-family: Verdana;
    text-decoration: none;
    padding: 0px 0px 5px 0px; 
    margin: 2px 0px 0px 0px;
    /*border-bottom: Solid 1px #B9BABF;*/
}
.dxsmCategoryLevel_DX
{
    white-space: nowrap;
    padding: 0px 0px 0px 0px;
    display: none;
}
 /*flow layout*/
.dxsmLevelCategoryFlow_DX, .dxsmLevelCategoryFlow_DX a
{
	color: #131313;
    font-weight: bold;
    font-size: 8pt;
    font-family: Verdana;
    text-decoration: none;
}
/* - Level 0 - */
.dxsmLevel0_DX, .dxsmLevel0_DX a, .dxsmLevel0Categorized_DX a, .dxsmLevel0Categorized_DX
{
    color: #0C3C8C;
    text-decoration: none;
	font-weight: normal;
    font-size: 8pt;
	font-family: Verdana, Arial;
    text-decoration: none;
}
.dxsmLevel0_DX, .dxsmLevel0Categorized_DX
{
    /*white-space: nowrap;*/
    padding: 0px 0px 1px 0px;
}
.dxsmLevel0_DX
{
    padding: 0px 0px 1px 0px;
}

 /*flow layout*/
.dxsmLevel0Flow_DX, .dxsmLevel0Flow_DX a, .dxsmLevel0CategorizedFlow_DX a, .dxsmLevel0CategorizedFlow_DX
{
    color: #0C3C8C;    
    font-family: Verdana, Verdana, Arial;	
    font-weight: normal;
    font-size: 8pt;
	text-decoration: underline;
}
.dxsmLevel0Flow_DX
{
    padding: 0px 0px 0px 0px;    
}
.dxsmLevel0Flow_DX
{
    text-decoration: none;    
}

/* - Level 1 - */
.dxsmLevel1_DX, .dxsmLevel1_DX a, .dxsmLevel1Categorized_DX a, .dxsmLevel1Categorized_DX
{    
    color: #0C3C8C;  
    font-size: 8pt;
	font-family: Verdana, Arial;
    text-decoration: none;    
}
.dxsmLevel1_DX, .dxsmLevel1Categorized_DX
{
    white-space: nowrap;  
    padding: 0px 0px 0px 0px;
}

/*flow layout*/
.dxsmLevel1Flow_DX, .dxsmLevel1Flow_DX a, .dxsmLevel1CategorizedFlow_DX, .dxsmLevel1CategorizedFlow_DX a
{    
    color: #0C3C8C;    
    font-family: Verdana, Verdana, Arial;	
    font-size: 8pt;
	text-decoration: underline;
}
.dxsmLevel1Flow_DX
{
    text-decoration: none;
    padding: 0px 0px 0px 0px;
}

/* - Level 2 - */
.dxsmLevel2_DX, .dxsmLevel2_DX a, .dxsmLevel2Categorized_DX a, .dxsmLevel2Categorized_DX
{    
    color: #0C3C8C;
    font-size: 8pt;
	font-family: Verdana, Arial;
    text-decoration: none;    
}
.dxsmLevel2_DX, .dxsmLevel2Categorized_DX
{
    white-space: nowrap;
    padding: 0px 0px 0px 0px;    
}
/*flow layout*/
.dxsmLevel2Flow_DX, .dxsmLevel2Flow_DX a
{
    color: #0C3C8C;
    font-size: 8pt;    
    font-family: Verdana, Verdana, Arial;	
	text-decoration:underline;    
}
.dxsmLevel2Flow_DX
{
    padding: 0px 0px 0px 0px;
}
/* - Level 3 - */
.dxsmLevel3_DX, .dxsmLevel3_DX a
{    
    color: #0C3C8C;
    font-size: 8pt;
	font-family: Verdana, Arial;
    text-decoration: none;    
}
.dxsmLevel3_DX
{
    white-space: nowrap;        
    padding: 0px 0px 0px 0px;    
}
/*flow layout*/
.dxsmLevel3Flow_DX, .dxsmLevel3Flow_DX a
{    
    color: #0C3C8C;
    font-size: 8pt;
    font-family: Verdana, Verdana, Arial;	
	text-decoration: underline;    
}
/* - Level 4 - */
.dxsmLevel4_DX, .dxsmLevel4_DX a
{    
    color: #0C3C8C;
    font-size: 8pt;
	font-family: Verdana, Arial;
    text-decoration: none;    
}
.dxsmLevel4_DX
{
    white-space: nowrap;
    padding: 0px 0px 0px 0px;    
}
/*flow layout*/
.dxsmLevel4Flow_DX, .dxsmLevel4Flow_DX a
{
    color: #0C3C8C;
    font-family: Verdana, Verdana, Arial;	
    font-size: 8pt;
	text-decoration: underline;        
}
.dxsmLevel4Flow_DX
{
    padding: 0px 0px 0px 0px;        
}
/* - Other Levels - */
.dxsmLevelOther_DX
{    
    color: #0C3C8C;
    font-size: 8pt;
	font-family: Verdana, Arial;
    text-decoration: none;    
}
.dxsmLevelOther_DX
{
    white-space: nowrap;
    padding: 0px 0px 0px 0px;            
}
/*flow layout*/
.dxsmLevelOtherFlow_DX, .dxsmLevelOtherFlow_DX a
{
    color: #0C3C8C;
    font-family: Verdana, Verdana, Arial;	
    font-size: 8pt;
	text-decoration: underline;            
}
/* Disabled */
.dxsmDisabled_DX
{
	color: #808080;
	cursor: default;
}

/* -- ASPxPopupControl -- */
.dxpcControl_DX
{
	font-size: 8pt;
	font-family: Verdana, Verdana, Arial;
	cursor: default;
	color: #131313;
	border: Solid 10px #dfe3eb;
	padding: 0px;
}
.dxpcControlSimpleBorder_DX {
    border: Solid 1px #B9BDC3!important; /* #1E2D55 */
}

.dxpcControl_DX a
{
	color: #0C3C8C; text-decoration: none;
}
.dxpcControl_DX a:hover
{
    text-decoration: underline;
}
.dxpcControl_DX a:visited
{
    color: #8C0C54;
}
.dxpcCloseButton_DX
{
	padding: 0px 0px 0px 0px;
	cursor: hand;
}
.dxpcCloseButtonHover_DX
{
}
.dxpcContent_DX input {
    /*padding: 0px 0px 0px 0px;
    margin: 0px 0px 0px 0px;
    
    width: auto;
    */
    font-size: 8pt;
    font-family: Verdana;
}
.dxpcContent_DX
{
	color: #131313;
	font-size: 8pt;
	font-family: Verdana, Verdana, Arial;
	white-space: normal;
	border-width: 0px;
    /* vertical-align: top; */
	padding: 8px 10px 8px 10px;
	background-color: White;
}
.dxpcContentAuthWindows_DX
{
	padding: 0px;
}
.dxpcFooter_DX
{
	background-color: #E9ECF3;
	padding: 0px 5px 0px 5px;
}
.dxpcHeader_DX
{
    font-size: 12pt;
    font-family: Verdana, Verdana, Arial;
	color: #293B6B;
	background-color: #DFE3EB;
}
.dxpcHeader_DX td.dxpc
{
    font-size: 12pt;
    font-family: Verdana, Verdana, Arial;
	color: #293B6B;
	white-space: nowrap;
	font-weight: normal;
	padding: 6px 0px 0px 0px;
}
.dxpcHeader_DX_Simple td.dxpc
{
	padding-right: 50px!important;
}
/*
.dxpcHeader_DX_Simple .dxpc {
	padding-bottom: 7px!important;
	border-bottom: solid 1px #B9BABF;
}
*/
.dxpcModalBackground_DX
{
	background-color: Black;
	opacity: 0.75;
	filter:progid:DXImageTransform.Microsoft.Alpha(Style=0, Opacity=75);
}
.dxpcModalBackgroundHidden_DX {
    display: none!important;
}
/* Disabled */
.dxpcDisabled_DX
{
	color: #bcaab0;
	cursor: default;
}

/* -- ASPxCallbackPanel -- */
.dxcpLoadingPanel_DX, .dxcpLoadingPanelWithContent_DX
{
	/* border: Solid 1px #989AA4; */
	background-color: White;
	font: 8pt Verdana;
	color: #131313;
}
.dxcpLoadingPanel_DX td.dx, .dxcpLoadingPanelWithContent_DX td.dx
{
	white-space: nowrap;
	text-align: center;
	padding: 5px 5px 5px 5px;
}
.dxcpLoadingDiv_DX
{
/*
	background-color: #333333;
	opacity: 0.5;
	filter:progid:DXImageTransform.Microsoft.Alpha(Style=0, Opacity=50);
*/
}
/* Disabled */
.dxcpDisabled_DX
{
	color: #bcaab0;
	cursor: default;
}
.dxeCheckboxFixPaddings td {
    /*padding: 0px!important;*/
}
.dxeCheckboxFixPaddings input {
    padding-top: 0px;
    padding-left: 0px;
    padding-bottom: 0px;
    margin-left: 0px;
}
/* ASPxEditor */
.dxeBase_DX, .dxeBase_SC, .dxeBase
{
	font-size: 8pt!important;
	font-family: Verdana!important;
	color: #131313;/*!important;*/
}
/* #6E7481 */

/* -- ErrorFrame -- */
.dxeErrorCell_DX, .dxeErrorCell_DX td,
.dxeErrorCell_SC, .dxeErrorCell_SC td
{
    font-family: Verdana;
    font-size: 8pt;
	color: Red;
}
.dxeErrorCell_DX, .dxeErrorCell_SC
{ 
	padding-left: 4px;
	padding-right:5px;
}
.dxeErrorFrameWithoutError_DX, .dxeErrorFrameWithoutError_SC
{
    border: 1px solid Red;
}
.dxeErrorFrameWithoutError_DX .dxeControlsCell_DX,
.dxeErrorFrameWithoutError_SC .dxeControlsCell_SC 
{
    padding: 2px;
}

.dxeButtonEdit_DX, .dxeButtonEdit_SC
{
    /*background-color: #E2ECFA;*/
    border-top: Solid 1px #B9BABF;
    border-left: Solid 1px #B9BABF;
    color: #131313;
    width: 170px;
    border-collapse: separate!important;
}
.dxeButtonEdit_DX td.dxic, .dxeButtonEdit_SC td.dxic
{
    padding: 0px 2px 0px 1px;
}
.dxeEditArea_DX, .dxeEditArea_SC
{
	font: 8pt Verdana;
}
.dxeTextBox_DX, .dxeMemo_DX, .dxeTextBox_SC, .dxeMemo_SC
{
	/* B38634 */
    /*background-color: #E2ECFA;*/
    border-left: Solid 1px #B9BABF;
	border-top: Solid 1px #B9BABF;
}
.dxeMemo_DX textarea, .dxeMemo_SC textarea {
    /*background-color: #E2ECFA;*/
}
.dxeTextBox_DX td.dxic, .dxeTextBox_SC td.dxic
{
	width: 100%;
    padding: 1px 2px;
}

/* -- Hyperlink -- */
.dxeHyperlink
{
    font-size: 8pt!important; /* check links on upgrades */
}
.dxeHyperlink, .dxeHyperlink_DX, .dxeHyperlink_SC
{
    font-family: Verdana!important; /* check links on upgrades */
    /*font-size: 9pt;*/
    font-weight: normal;
}
a.dxeHyperlink, a.dxeHyperlink:link, a.dxeHyperlink_DX:link, a.dxeHyperlink_SC:link
{
    color: #0C3C8C; 
    text-decoration: none;
}
a.dxeHyperlink:hover, a.dxeHyperlink:hover span, a.dxeHyperlink_DX:hover, a.dxeHyperlink_SC:hover
{
    text-decoration: underline;
}
a.dxeHyperlink:visited, a.dxeHyperlink_DX:visited, a.dxeHyperlink_SC:visited
{
    color: #8C0C54!important;
}

/* -- Button -- */
.dxbButton_DX, .dxbButton_SC
{	
  	color: #24325C;
  	font-weight: normal;
	font-size: 8pt;
	font-family: Verdana;				    
	vertical-align: middle;	 		
	border: Solid 1px #3E4C6D;	
	background: #CAD7ED url('/DXR.axd?r=9999_12-jrPMg') top;
    background-repeat: repeat-x;
    padding: 1px 1px 1px 1px;
	cursor: pointer;
	cursor: hand;
}
.dxbButtonHover_DX, .dxbButtonHover_SC
{
  	color: #24325C;        
	background: #DAE6F9 url('/DXR.axd?r=9999_13-jrPMg') top;
    background-repeat: repeat-x;
	border: Solid 1px #3E4C6D;	
}
.dxbButtonChecked_DX, .dxbButtonChecked_SC
{
    color: #24325C;
	background-image: none;
	background-color: #BAC8E1;
}
.dxbButtonPressed_DX, .dxbButtonPressed_SC
{
  	color: #24325C;        
	background-image: none;
	background-color: #BAC8E1;
}
.dxbButton_DX div.dxb, .dxbButton_SC div.dxb
{    
    padding: 2px 28px 2px 28px;
	border: 0px;
}
.dxbButton_DX div.dxbf, .dxbButton_SC div.dxbf
{     
    padding: 1px 27px 1px 27px;
	border: dotted 1px black;		
}
.dxbButton_DX div.dxb table,
.dxbButton_SC div.dxb table
{    
  	color: #000000;    
	font-size: 8pt;
	font-family: Verdana;				    
}
.dxbButton_DX div.dxb td.dxb,
.dxbButton_SC div.dxb td.dxb
{    
    background-color: transparent!important;
    background-image: url('')!important;
    border-width: 0px!important;
    padding: 0px!important;
}
/* -- BrowseButton -- */
.dxucBrowseButton_DX
{
  	color: #24325C;
  	font-weight: normal;
	font-size: 8pt;
	font-family: Verdana, Tahoma, Arial;
	vertical-align: middle;
	border: Solid 1px #3E4C6D;
	background: #CAD7ED url('/DXR.axd?r=9999_12-jrPMg') top;
    background-repeat: repeat-x;
    padding: 3px 28px;
	cursor: hand;
}
.dxucBrowseButton_DX a
{
  	color: #24325C;
}
/* Disabled */
.dxbDisabled_DX, .dxbDisabled_SC
{
    border-color: #3E4C6D;
    background-image: url('')!important;
    background-color: #D5E1F5;
	color: #9CA5C0;
	cursor: default;
}
.dxbDisabled_DX td.dxb,
.dxbDisabled_SC td.dxb
{
	color: #9CA5C0;
}
/* -- Buttons -- */
.dxeButtonEditButton_DX, .dxeCalendarButton_DX,
.dxeSpinIncButton_DX, .dxeSpinDecButton_DX,
.dxeSpinLargeIncButton_DX, .dxeSpinLargeDecButton_DX,
.dxeButtonEditButton_SC, .dxeCalendarButton_SC,
.dxeSpinIncButton_SC, .dxeSpinDecButton_SC,
.dxeSpinLargeIncButton_SC, .dxeSpinLargeDecButton_SC
{	
	vertical-align: middle;
	cursor: pointer;
	cursor: hand;
} 
.dxeButtonEditButton_DX, .dxeCalendarButton_DX, .dxeButtonEditButton_DX td.dx, .dxeCalendarButton_DX td.dx,
.dxeSpinIncButton_DX, .dxeSpinDecButton_DX, .dxeSpinLargeIncButton_DX, .dxeSpinLargeDecButton_DX,
.dxeSpinIncButton_DX td.dx, .dxeSpinDecButton_DX td.dx, .dxeSpinLargeIncButton_DX td.dx, .dxeSpinLargeDecButton_DX td.dx,
.dxeButtonEditButton_SC, .dxeCalendarButton_SC, .dxeButtonEditButton_SC td.dx, .dxeCalendarButton_SC td.dx,
.dxeSpinIncButton_SC, .dxeSpinDecButton_SC, .dxeSpinLargeIncButton_SC, .dxeSpinLargeDecButton_SC,
.dxeSpinIncButton_SC td.dx, .dxeSpinDecButton_SC td.dx, .dxeSpinLargeIncButton_SC td.dx, .dxeSpinLargeDecButton_SC td.dx
{	
    font-family: Verdana;
    font-size: 11px;        
    font-weight: normal;
	text-align: center;
	white-space: nowrap;
} 
.dxeButtonEditButton_DX,
.dxeSpinIncButton_DX, .dxeSpinDecButton_DX, .dxeSpinLargeIncButton_DX, .dxeSpinLargeDecButton_DX,
.dxeButtonEditButton_SC,
.dxeSpinIncButton_SC, .dxeSpinDecButton_SC, .dxeSpinLargeIncButton_SC, .dxeSpinLargeDecButton_SC
{
    padding: 0px 2px 0px 3px; /* Indents */
    /* background-color: #E2ECFA; */
}
.dxeButtonEditButton_DX table.dxbebt,
.dxeSpinIncButton_DX table.dxbebt, .dxeSpinDecButton_DX table.dxbebt, 
.dxeSpinLargeIncButton_DX table.dxbebt, .dxeSpinLargeDecButton_DX table.dxbebt,
.dxeButtonEditButton_SC table.dxbebt,
.dxeSpinIncButton_SC table.dxbebt, .dxeSpinDecButton_SC table.dxbebt, 
.dxeSpinLargeIncButton_SC table.dxbebt, .dxeSpinLargeDecButton_SC table.dxbebt
{
	width: 10px;
}
/* -- Pressed -- */
.dxeCalendarButtonPressed_DX, .dxeButtonEditButtonPressed_DX,
.dxeSpinIncButtonPressed_DX, .dxeSpinDecButtonPressed_DX, .dxeSpinLargeIncButtonPressed_DX,
.dxeSpinLargeDecButtonPressed_DX,
.dxeCalendarButtonPressed_SC, .dxeButtonEditButtonPressed_SC,
.dxeSpinIncButtonPressed_SC, .dxeSpinDecButtonPressed_SC, .dxeSpinLargeIncButtonPressed_SC,
.dxeSpinLargeDecButtonPressed_SC
{
	background-color: #A3B3CE!important;
}
/* -- Hover -- */
.dxeCalendarButtonHover_DX, .dxeButtonEditButtonHover_DX,
.dxeSpinIncButtonHover_DX, .dxeSpinDecButtonHover_DX, .dxeSpinLargeIncButtonHover_DX, .dxeSpinLargeDecButtonHover_DX,
.dxeCalendarButtonHover_SC, .dxeButtonEditButtonHover_SC,
.dxeSpinIncButtonHover_SC, .dxeSpinDecButtonHover_SC, .dxeSpinLargeIncButtonHover_SC, .dxeSpinLargeDecButtonHover_SC
{
    background-color: #CAD7ED!important;
}
.dxeButtonEdit_DX .dxeEditArea, .dxeButtonEdit_DX td.dxic,
.dxeButtonEdit_SC .dxeEditArea, .dxeButtonEdit_SC td.dxic
{
	width: 100%;
}

/* -- ListBox -- */
.dxeListBox_DX, .dxeListBox_SC
{
	background-color: White;
	border: Solid 1px #8E9098;
    font-family: Verdana;
    font-size: 8pt;
    width: 70px;
    height: 109px;
}
.dxeListBox_DX div.dxlbd, .dxeListBox_SC div.dxlbd
{
    height: 107px;
}
.dxeListBoxItemRow_DX, .dxeListBoxItemRow_SC
{
    cursor: default;
}
.dxeListBoxItem_DX, .dxeListBoxItem_SC
{
    font-family: Verdana;
    font-size: 8pt;
    padding: 3px 5px 4px 5px;
    white-space: nowrap;
    text-align: left;
    color: #131313;
    font-weight: normal;
}

.dxeListBox_DX td.dxeI, .dxeListBox_DX td.dxeIM, .dxeListBox_DX .dxeHIC,
.dxeListBox_SC td.dxeI, .dxeListBox_SC td.dxeIM, .dxeListBox_SC .dxeHIC
{
    border-right-width: 0px!important;
}
.dxeListBox_DX td.dxeIM,
.dxeListBox_SC td.dxeIM
{
    width: 0;
}
.dxeListBox_DX td.dxeT,
.dxeListBox_SC td.dxeT 
{
    width: 100%;
    border-left-width: 0px!important;
    padding-left: 0px!important;
}
.dxeListBox_DX td.dxeFTM, .dxeListBox_DX td.dxeTM, .dxeListBox_DX td.dxeLTM, .dxeListBox_DX .dxeHFC, .dxeListBox_DX .dxeHC, .dxeListBox_DX .dxeHLC,
.dxeListBox_SC td.dxeFTM, .dxeListBox_SC td.dxeTM, .dxeListBox_SC td.dxeLTM, .dxeListBox_SC .dxeHFC, .dxeListBox_SC .dxeHC, .dxeListBox_SC .dxeHLC
{
    overflow: hidden;
}
.dxeListBox_DX td.dxeFTM, .dxeListBox_DX td.dxeTM,
.dxeListBox_SC td.dxeFTM, .dxeListBox_SC td.dxeTM
{
    border-right-width: 0px!important;
}
.dxeListBox_DX td.dxeFTM, .dxeListBox_DX td.dxeTM, .dxeListBox_DX .dxeHFC, .dxeListBox_DX .dxeHC,
.dxeListBox_SC td.dxeFTM, .dxeListBox_SC td.dxeTM, .dxeListBox_SC .dxeHFC, .dxeListBox_SC .dxeHC
{
    padding-right: 6px!important;
}
.dxeListBox_DX td.dxeLTM, .dxeListBox_DX td.dxeTM, .dxeListBox_DX .dxeHC, .dxeListBox_DX .dxeHLC,
.dxeListBox_SC td.dxeLTM, .dxeListBox_SC td.dxeTM, .dxeListBox_SC .dxeHC, .dxeListBox_SC .dxeHLC
{
    padding-left: 6px!important;
}
.dxeListBox_DX td.dxeLTM, .dxeListBox_DX td.dxeTM,
.dxeListBox_SC td.dxeLTM, .dxeListBox_SC td.dxeTM
{
    border-left: 1px solid #cfcfcf !important;
}
.dxeListBox_DX td.dxeIM, .dxeListBox_DX td.dxeFTM, .dxeListBox_DX td.dxeTM, .dxeListBox_DX td.dxeLTM,
.dxeListBox_SC td.dxeIM, .dxeListBox_SC td.dxeFTM, .dxeListBox_SC td.dxeTM, .dxeListBox_SC td.dxeLTM
{
    border-bottom: solid 1px #cfcfcf;
}
.dxeListBoxItemHover_DX, .dxeListBoxItemHover_SC        /* inherits dxeListBoxItem */
{
    background-color: #E2ECFA;
    /*background-color: #C6DAF6;*/
}
.dxeListBoxItemSelected_DX, .dxeListBoxItemSelected_SC     /* inherits dxeListBoxItem */
{    
    background-color: #CAD7ED;
}

/*Header*/
.dxeListBox_DX .dxeHD, 
.dxeListBox_SC .dxeHD
{
    background-color: #dcdcdc;
    border-bottom: solid 1px #A0A0A0;
}
.dxeListBox_DX .dxeHC, .dxeListBox_DX .dxeHLC,
.dxeListBox_SC .dxeHC, .dxeListBox_SC .dxeHLC
{
    border-left: solid 1px #A0A0A0;
}
.dxeListBox_DX .dxeHIC, .dxeListBox_DX .dxeHFC,
.dxeListBox_SC .dxeHIC, .dxeListBox_SC .dxeHFC
{
    border-left:1px solid #dcdcdc;
}
.dxeListBox_DX .dxeHFC, .dxeListBox_DX .dxeHC,
.dxeListBox_SC .dxeHFC, .dxeListBox_SC .dxeHC
{
    border-right-width:0;
}
.dxeListBox_DX .dxeHLC,
.dxeListBox_SC .dxeHLC
{
    border-right: solid 1px #dcdcdc;
}
.dxeLoadingDiv_DX, .dxeLoadingDiv_SC
{
    cursor: wait;
}
.dxeLoadingPanel_DX, .dxeLoadingPanel_SC
{
	font: 8pt Verdana;
	color: #303030;
}
.dxeLoadingPanel_DX td.dx, .dxeLoadingPanel_SC td.dx
{
	white-space: nowrap;
	text-align: center;
	padding: 12px 12px 12px 12px;
}

.dxeReadOnly_DX, .dxeReadOnly_SC
{
    
}
/* Disabled */
.dxeDisabled_DX, .dxeDisabled_DX td.dxe,
.dxeDisabled_SC, .dxeDisabled_SC td.dxe
{
	color: #ACACAC;
	cursor: default;
}
table.dxeDisabled_DX, table.dxeDisabled_SC
{
	background-color: #F3F5F9!important;
	border-color: #CCCDD1!important;
}
input.dxeDisabled_DX, input.dxeDisabled_SC
{
	background-color: #F3F5F9!important;
}
.dxeBase_DX.dxeDisabled_DX, .dxeBase_SC.dxeDisabled_SC
{
	background-color: White!important;
	border: None 0px!important;
}
input.dxeReadOnly_DX, input.dxeReadOnly_SC
{
	background-color: #F3F5F9!important;
}
table.dxeReadOnly_DX, table.dxeReadOnly_SC
{
	background-color: #F3F5F9!important;
	border-color: #CCCDD1!important;
}
.dxeBase_DX.dxeReadOnly_DX, .dxeBase_SC.dxeReadOnly_SC
{
	background-color: White!important;
	border: None 0px!important;
}
.dxeReadOnly_DX .dxeEditArea_DX, .dxeReadOnly_SC  .dxeEditArea_SC
{
	background-color: #F3F5F9!important;
}
a.dxeDisabled_DX:hover, a.dxeDisabled_SC:hover
{
    color: #acacac;
}
.dxeButtonDisabled_DX, .dxeButtonDisabled_DX td.dxe,
.dxeButtonDisabled_SC, .dxeButtonDisabled_SC td.dxe
{
	border-color: #c3c3c3;
	color: #808080;
	cursor: default;
}

/* ASPxPopupControl */
.dxpcHeader_DX_Simple .dxpc, .dxpcHeader_DX_Simple .dxpcCloseButton_DX {
	padding-bottom: 5px!important;
	border-bottom: solid 1px #B9BABF;
}

/* Alternate Emails CSS Classes */
.v-licenses-grid-column {
    border-left: Solid 1px #DCDCDF;
    border-right: Solid 1px #DCDCDF;
}
.v-licenses-grid-simple-column {
    border-left: Solid 1px #DCDCDF;
}
.v-licenses-grid-header-column {
    border-bottom: Solid 1px #DCDCDF;
    font-weight: normal;
    font: 8pt Verdana;
    padding: 4px 12px 3px 12px;
}
.v-licenses-grid-cell {
    padding: 5px 12px 3px 12px;
}

div.v-alternate-emails {
    margin-top: 13px;
    padding: 13px 0px 9px 29px;
}
div.v-alternate-emails table {
    width: 100%;
    border-collapse: collapse;
    margin: 0px;
    padding: 0px;
}
td.v-alternate-email {
    padding: 0px 10px 3px 10px!important;
}
td.v-alternate-action {
    padding: 3px 9px 3px 0px!important;
    padding-right: 10px;
    border-right: solid 1px #b9babf;
    vertical-align: top;
}
td.v-alternate-notifications {
    border-left: solid 1px #b9babf;
    padding: 0px 0px 0px 10px!important;
    vertical-align: top;
    white-space: nowrap;
}
/* popup window form */
div.FormContentArea {
    padding: 30px 40px 40px 40px;
}
table.FormActionArea {
    background-color: #E9ECF3;
    padding: 0px;
    margin: 0px;
    border: none;
    border-collapse: collapse;
    width: 100%;
    overflow: hidden;
}
table.FormActionArea td.Indicator {
    width: 0%;
    padding: 9px 0px 8px 8px
}
table.FormActionArea td.Description {
    width: 100%;
    padding: 9px 10px 8px 8px;
    font-style: italic;
}
table.FormActionArea td.Button {
    width: 0%;
    padding: 14px 13px 14px 0px;
}
table.FormActionArea td.LastButton {
    padding: 14px 10px 14px 10px;
}

table.v-form-table {
    margin: 0px;
    padding: 0px;
    width: 100%;
    border-collapse: collapse;
}
table.v-form-table tr.spacer td, table.v-form-table tr.spacer-small td {
    padding: 0px;
}
table.v-form-table tr.spacer td div {
    height: 8px;
    width: 0px;
    overflow: hidden;
}
table.v-form-table tr.spacer-small td div {
    height: 5px;
    width: 0px;
    overflow: hidden;
}
table.v-form-table tr.separator td {
    padding: 0px;
}
table.v-form-table tr.separator td div {
    height: 17px;
    width: 0px;
    overflow: hidden;
}
table.v-form-table td.caption {
    white-space: nowrap;
    width: 0%;
    padding: 2px 8px 0px 0px;
    vertical-align: top;
}
table.v-form-table tr td.caption span.required {
    color: #b30202;
}
table.v-form-table td.subform {
    width: 100%;
    padding: 0px;
}
table.v-form-table td.field {
    padding: 0px;
    /*white-space: nowrap; - causes textbox width bug in webkit*/
    vertical-align: top;
}
table.v-form-table td.textfield {
    padding: 2px 8px 0px 0px;
}

table.v-form-table td.notrequiredfield {
    padding-right: 27px;
}
table.v-form-table tr.field-description td {
    padding: 2px 0px 3px 0px;
    text-align: left;
    color: #70727a;
    font-style: italic;
    font-size: 10px;
}
table.v-form-table td.text {
    padding: 14px 0px 11px 0px;
}
div.RequiredFieldInfo {
    padding: 0px 40px 14px 40px;
    color: #70727a;
    font-style: italic;
    font-size: 11px;
}
div.RequiredFieldInfo span {
    color: #b30202;
}

/* Text Data Table */
table.TextDataTable {
    border: none;
    padding: 0px;
    margin: 0px;
    border-collapse: collapse;
}
table.TextDataTable td, table.TextDataTable th {
    padding: 0px;
    margin: 0px;
    padding-bottom: 6px;
}
table.TextDataTable th {
    font-weight: normal;
    padding-right: 10px!important;
    color: #70727a;
    font-style: italic;
    white-space: nowrap;
    text-align: left;
}
div.TextDataTableHeader {
    margin-left: -6px;
    margin-bottom: 13px;
    padding-top: 8px;
}
div.TextDataTableHeader span {
    padding: 2px 6px 3px 6px;
    background-color: #ecdeec;
}
/* Not available */
div.NotAvailable {
    margin-top: 70px;
    margin-bottom: 110px;
}
td.NotAvailableImage {
    padding-right: 20px;
}
div.NotAvailableTitle {
    font-size: 32px;
    margin-bottom: 5px;
}
/* ------------------------------------> Developer Express CSS v9.1 (data) <------------------------------------ */

/* ------------------------------------> CONTENT <------------------------------------ */
.l-data h1, .l-data h2, .l-data h3, .l-data h4, .l-data h5 { font: Verdana; color: #131313; padding: 0px; margin: 0px; }
.l-data a h1, .l-data a h2, .l-data a h3, .l-data a h4, .l-data a h5 { color: #0C3C8C; }
.l-data a:visited h1, .l-data a:visited h2, .l-data a:visited h3, .l-data a:visited h4, .l-data a:visited h5 { color: #8C0C54; }
.l-data h1  {
    font-family: Verdana;
	font-weight: normal; 
	font-size: 250%; 
	border-bottom: Solid 1px #B9BABF; 
	padding: 5px 0px 5px 0px; 
	margin: 12px 0px 12px 0px;
}
.s-content-landing .l-data h1  {
	font-size: 190%;
	border-bottom: Solid 1px #B9BABF; 
	padding: 21px 0px 4px 0px; 
	margin: 12px 0px 12px 0px;
	border-bottom: Solid 1px #B9BABF; 
}
.l-data h2 {
    font-family: Verdana;
	font-weight: normal;
	font-size: 220%;
	padding-top: 16px;
	padding-bottom: 16px;
}
.l-data h2.underline {
    font-family: Verdana;
	font-weight: normal;
	font-size: 220%;
	padding: 5px 0px 7px 0px; 
	margin: 12px 0px 12px 0px;
	border-bottom: Solid 1px #B9BABF; 
}
.l-data div.h1 h2 {
    font-family: Verdana;
	font-weight: normal; 
	font-size: 250%; 
	padding: 5px 0px 5px 0px; 
	margin: 0px 0px 8px 0px;
	font-size: 32px;
}
.l-data h3 {
    font-family: Verdana;
	font-weight: normal;
	font-size: 190%;
	padding-top: 16px;
	padding-bottom: 16px;
}
.l-data h3.underline {
	padding-top: 16px;
	padding-bottom: 0px;
	margin: 12px 0px 12px 0px;
}
.l-data h3.underline span {
    font-family: Verdana;
	font-weight: normal;
	/* font-size: 190%; */
	padding: 0px 40px 4px 0px;
	border-bottom: Solid 1px #B9BABF; 
	display: inline-block;
}
.l-data h4 {
    font-family: Verdana;
	font-weight: normal;
	font-size: 160%;
	padding: 0px 0px 4px 0px;
}
.l-data h4.highlight span {
    font-family: Verdana;
	font-weight: normal;
	font-size: 160%;
	padding: 4px 6px 4px 6px;
	left: -6px;
	z-index: 1000!important;
	position: relative;
	background-color: #ECDEEC;
	display: inline;
}
.l-data h4.underline span {
    font-family: Verdana;
	font-weight: normal;
	font-size: 11pt;
	padding: 0px 40px 4px 0px;
	margin: 4px 0px 6px 0px;
	border-bottom: Solid 1px #B9BABF; 
	display: inline-block;
}
.l-data h5 {
    font-family: Verdana;
	font-weight: normal;
	font-size: 130%;
	padding: 0px 0px 1px 0px;
}
.l-data i { line-height: 150%; }

.em { font-style: italic; }
.l-data strong, .strong { font-weight: bold; }


/* lists */
.l-data ul {
	padding: 0px;
	margin: 0px;
	list-style-type: none;
}
.l-data ul.list {
	margin-left: 20px;
	margin-top: 0px;
}
.l-data ul.no-indent {
	margin-left: 0px;
}
.l-data li {
	margin: 0px;
	padding: 0px;
	background-image: url('/DXR.axd?r=9999_19-jrPMg');
	background-repeat: no-repeat;
	background-position: left 6px;
	padding-left: 15px;
	margin-bottom: 4px;
}
.l-data ul ul {
	margin-left: 24px;
	margin-bottom: 0px;
}

/* [nignatov] Fix trouble with embeded ASPxHtmlEditor in .l-data container */
.l-data .dxmLite_DevEx li {
	background-image: none;
	margin-bottom: auto;
}
.l-data .dxmLite_DevEx li.dxm-separator,
.l-data .dxmLite_DevEx li.dxm-spacing
{
	padding-left: 0px;
}
/* [nignatov] Fix trouble with embeded ASPxHtmlEditor in .l-data container */

/* list without bullets */
.l-data ul.style-none { list-style-type: none; }
.l-data ul.style-none li { padding-left: 0px!important; background-image: url('')!important; }

.icons a, .icon { padding: 1px 0 1px 20px; background-repeat: no-repeat; background-position: left center; }

.l-data p, .l-data ul, .l-data ol, .l-data dl, blockquote, pre, hr { margin: 0px 0px 16px 0px; padding: 0px 0px 0px 0px; line-height: 150%; }

.l-data div.code { margin-bottom: 16px; }

/* ------------------------------------> IMAGE <------------------------------------ */
.l-data img.null-image { padding: 0!important; border: none!important; margin: 0!important; }

/* ------------------------------------> FORM <------------------------------------ */
a img { border: none!important; text-decoration: none!important; }

/* Demos Popup */
.v-demos-popup-fake-image-container { 
    border-right: Solid 1px #B9BDC3; 
    padding: 3px 28px 0px 12px;
    margin-bottom: 12px;
}
.v-demos-popup-description { padding: 1px 0px 18px 0px; }

.a-banner { background: #1A2044 url('/DXR.axd?r=9999_2-jrPMg') repeat-x left top; }
.a-banner-short { background: #1A2044 url('/DXR.axd?r=9999_3-jrPMg') repeat-x left top; }
.s-banner { width: 100%; height: 274px; }
.s-banner-short { width: 100%; height: 90px; }
.i-banner-titleimage { margin: 0px 0px 0px 40px; }
.i-banner-bannerimage { margin: 0px 43px 0px 75px; }
.i-banner-header { margin: 45px 30px 10px 5px; }
.i-banner-header-short { margin: 0px 45px 0px 5px; }
.i-banner-details { margin: 15px 0px 0px 0px; }

.statesList td.dxeLTM, .statesList td.dxeTM {
    border-left-width: 0px!important;
    border-left-style: none!important;
}
.statesList .dxeHD {
    overflow: hidden;
    height: 0;
    background-color: #dcdcdc;
    border-bottom: solid 0px #A0A0A0;
}

/* Floating Contact Panel */
div.ContactPanel 
{
	background-color: White;
	position: fixed;
	right: 0px;
	font-family: Verdana;
	font-size: 11px;
	color: #8aa1d7;
	top: 263px;
	-moz-box-shadow:0px 0px 15px rgba(0, 0, 0, 0.25);
	-webkit-box-shadow:0px 0px 15px rgba(0, 0, 0, 0.25);
	box-shadow:0px 0px 15px rgba(0, 0, 0, 0.25);
	padding: 3px 0px 3px 3px;
}
div.ContactPanel div.Header {
	background-color: #202c56;
	color: #95b0ed;
	text-align: center;
	padding: 6px 19px 6px 19px;
}
div.ContactPanel div.ChatArea 
{
	background-color: #2b4072;
	text-align: center;
	padding: 11px;
}
div.ContactPanel div.InfoArea 
{
	background-color: #aac6ed;
	color: #202c56;
	padding: 14px 13px 14px 13px;
}
div.ContactPanel a 
{
	color: #202c56;
	text-decoration: none;
}
div.ContactPanel a:hover 
{
	text-decoration: underline;
}
div.ContactPanel a.IconLink 
{
	display: block;
	background-position: left;
	background-repeat: no-repeat;
	padding-left: 25px;
	padding-top: 4px;
	height: 20px;
}
div.ContactPanel a.IconLink.FAQ 
{
	background-image: url('/DXR.axd?r=9999_10-jrPMg');
}
div.ContactPanel a.IconLink.EULA 
{
	background-image: url('/DXR.axd?r=9999_9-jrPMg');
}
div.ContactPanel a.IconLink.TV
{
	background-image: url('/DXR.axd?r=9999_11-jrPMg');
}
div.ContactPanel span.Hide 
{
	position: absolute;
	display: block;
	background-color: #2b4072;
	color: White;
	margin: 3px auto 0 auto;
	width: 30px;
	background-image: url('/DXR.axd?r=9999_6-jrPMg');
	background-position: right top;
	background-repeat: no-repeat;
	padding-left: 12px;
	padding-top: 4px;
	padding-right: 19px;
	padding-bottom: 6px;
	cursor: pointer;
}
div.ShowContactPanel 
{
	display: block;
	background-image: url('/DXR.axd?r=9999_7-jrPMg');
	background-repeat: no-repeat;
	width: 61px;
	height: 79px;
	position: fixed;
	right: 0px;
	top: 550px;
	cursor: pointer;
}
table.lpStaticButton 
{
	margin: 0 auto;
}
tr.lpPoweredBy 
{
	display: none;
}
