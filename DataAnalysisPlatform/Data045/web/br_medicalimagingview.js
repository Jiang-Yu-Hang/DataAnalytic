/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:11:57.7
*/
gx.evt.autoSkip=!1;gx.define("br_medicalimagingview",!1,function(){var n,t;this.ServerClass="br_medicalimagingview";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV10BR_MedicalImagingID=gx.fn.getIntegerValue("vBR_MEDICALIMAGINGID",",");this.AV11LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS");this.AV12SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE");this.AV8TabCode=gx.fn.getControlValue("vTABCODE")};this.e144r2_client=function(){return this.executeServerEvent("'DOBACK'",!1,null,!1,!1)};this.e114r2_client=function(){return this.executeServerEvent("TABS.TABCHANGED",!1,null,!0,!0)};this.e154r2_client=function(){return this.executeServerEvent("'GENERAL'",!1,null,!1,!1)};this.e164r2_client=function(){return this.executeServerEvent("'BR_MEDICALIMAGING_DIAG'",!1,null,!1,!1)};this.e174r2_client=function(){return this.executeServerEvent("'MEDICALIMAGE'",!1,null,!1,!1)};this.e184r2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e194r2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,20,21,23,24,25,28,29,31,32,33,36,37,39,40,41,43,44,45,46,47,48,49,50,51,52,53,54];this.GXLastCtrlId=54;this.TABSContainer=gx.uc.getNew(this,18,0,"gx.ui.controls.Tab","TABSContainer","Tabs","TABS");t=this.TABSContainer;t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("ActivePage","Activepage","","int");t.setDynProp("ActivePageControlName","Activepagecontrolname","","char");t.setProp("PageCount","Pagecount",3,"num");t.setProp("Class","Class","ViewTab Tab","str");t.setProp("HistoryManagement","Historymanagement",!0,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});t.addEventHandler("TabChanged",this.e114r2_client);this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"BTNBACK",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"UNNAMEDTABLEVIEWCONTAINER",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"TXTTABTITLE",format:0,grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"",grid:0};n[20]={id:20,fld:"GENERAL_TITLE",format:0,grid:0};n[21]={id:21,fld:"",grid:0};n[23]={id:23,fld:"UNNAMEDTABLEGENERAL",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[28]={id:28,fld:"BR_MEDICALIMAGING_DIAG_TITLE",format:0,grid:0};n[29]={id:29,fld:"",grid:0};n[31]={id:31,fld:"UNNAMEDTABLEBR_MEDICALIMAGING_DIAG",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[36]={id:36,fld:"MEDICALIMAGE_TITLE",format:0,grid:0};n[37]={id:37,fld:"",grid:0};n[39]={id:39,fld:"UNNAMEDTABLEMEDICALIMAGE",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"UNNAMEDTABLETABSCONTAINER",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"CELL_GENERAL",grid:0};n[48]={id:48,fld:"BTNGENERAL",grid:0};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"CELL_BR_MEDICALIMAGING_DIAG",grid:0};n[51]={id:51,fld:"BTNBR_MEDICALIMAGING_DIAG",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"CELL_MEDICALIMAGE",grid:0};n[54]={id:54,fld:"BTNMEDICALIMAGE",grid:0};this.AV10BR_MedicalImagingID=0;this.AV8TabCode="";this.A225BR_MedicalImagingID=0;this.AV11LoadAllTabs=!1;this.AV12SelectedTabCode="";this.Events={e144r2_client:["'DOBACK'",!0],e114r2_client:["TABS.TABCHANGED",!0],e154r2_client:["'GENERAL'",!0],e164r2_client:["'BR_MEDICALIMAGING_DIAG'",!0],e174r2_client:["'MEDICALIMAGE'",!0],e184r2_client:["ENTER",!0],e194r2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"AV10BR_MedicalImagingID",fld:"vBR_MEDICALIMAGINGID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV8TabCode",fld:"vTABCODE",pic:"",hsh:!0}],[]];this.EvtParms.START=[[{av:"A225BR_MedicalImagingID",fld:"BR_MEDICALIMAGINGID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV10BR_MedicalImagingID",fld:"vBR_MEDICALIMAGINGID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV8TabCode",fld:"vTABCODE",pic:"",hsh:!0},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""}],[{ctrl:"FORM",prop:"Caption"},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"this.TABSContainer.ActivePageControlName",ctrl:"TABS",prop:"ActivePageControlName"},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING_DIAG","Visible")',ctrl:"CELL_BR_MEDICALIMAGING_DIAG",prop:"Visible"},{ctrl:"BR_MEDICALIMAGING_DIAGWC"},{av:'gx.fn.getCtrlProperty("CELL_MEDICALIMAGE","Visible")',ctrl:"CELL_MEDICALIMAGE",prop:"Visible"},{ctrl:"MEDICALIMAGEWC"}]];this.EvtParms.LOAD=[[],[]];this.EvtParms["'DOBACK'"]=[[{av:"AV10BR_MedicalImagingID",fld:"vBR_MEDICALIMAGINGID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[]];this.EvtParms["TABS.TABCHANGED"]=[[{av:"this.TABSContainer.ActivePageControlName",ctrl:"TABS",prop:"ActivePageControlName"},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV10BR_MedicalImagingID",fld:"vBR_MEDICALIMAGINGID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING_DIAG","Visible")',ctrl:"CELL_BR_MEDICALIMAGING_DIAG",prop:"Visible"},{ctrl:"BR_MEDICALIMAGING_DIAGWC"},{av:'gx.fn.getCtrlProperty("CELL_MEDICALIMAGE","Visible")',ctrl:"CELL_MEDICALIMAGE",prop:"Visible"},{ctrl:"MEDICALIMAGEWC"}]];this.EvtParms["'GENERAL'"]=[[{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV10BR_MedicalImagingID",fld:"vBR_MEDICALIMAGINGID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING_DIAG","Visible")',ctrl:"CELL_BR_MEDICALIMAGING_DIAG",prop:"Visible"},{ctrl:"BR_MEDICALIMAGING_DIAGWC"},{av:'gx.fn.getCtrlProperty("CELL_MEDICALIMAGE","Visible")',ctrl:"CELL_MEDICALIMAGE",prop:"Visible"},{ctrl:"MEDICALIMAGEWC"}]];this.EvtParms["'BR_MEDICALIMAGING_DIAG'"]=[[{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV10BR_MedicalImagingID",fld:"vBR_MEDICALIMAGINGID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING_DIAG","Visible")',ctrl:"CELL_BR_MEDICALIMAGING_DIAG",prop:"Visible"},{ctrl:"BR_MEDICALIMAGING_DIAGWC"},{av:'gx.fn.getCtrlProperty("CELL_MEDICALIMAGE","Visible")',ctrl:"CELL_MEDICALIMAGE",prop:"Visible"},{ctrl:"MEDICALIMAGEWC"}]];this.EvtParms["'MEDICALIMAGE'"]=[[{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV10BR_MedicalImagingID",fld:"vBR_MEDICALIMAGINGID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING_DIAG","Visible")',ctrl:"CELL_BR_MEDICALIMAGING_DIAG",prop:"Visible"},{ctrl:"BR_MEDICALIMAGING_DIAGWC"},{av:'gx.fn.getCtrlProperty("CELL_MEDICALIMAGE","Visible")',ctrl:"CELL_MEDICALIMAGE",prop:"Visible"},{ctrl:"MEDICALIMAGEWC"}]];this.setVCMap("AV10BR_MedicalImagingID","vBR_MEDICALIMAGINGID",0,"int",18,0);this.setVCMap("AV11LoadAllTabs","vLOADALLTABS",0,"boolean",4,0);this.setVCMap("AV12SelectedTabCode","vSELECTEDTABCODE",0,"char",50,0);this.setVCMap("AV8TabCode","vTABCODE",0,"char",50,0);this.Initialize();this.setComponent({id:"GENERALWC",GXClass:null,Prefix:"W0026",lvl:1});this.setComponent({id:"BR_MEDICALIMAGING_DIAGWC",GXClass:null,Prefix:"W0034",lvl:1});this.setComponent({id:"MEDICALIMAGEWC",GXClass:null,Prefix:"W0042",lvl:1})});gx.createParentObj(br_medicalimagingview)