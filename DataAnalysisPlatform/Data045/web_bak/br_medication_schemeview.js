/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:42:21.7
*/
gx.evt.autoSkip=!1;gx.define("br_medication_schemeview",!1,function(){var n,t;this.ServerClass="br_medication_schemeview";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV16BR_MedicationID=gx.fn.getIntegerValue("vBR_MEDICATIONID",",");this.A296BR_Medication_SchemeID=gx.fn.getIntegerValue("BR_MEDICATION_SCHEMEID",",");this.AV10BR_Medication_SchemeID=gx.fn.getIntegerValue("vBR_MEDICATION_SCHEMEID",",");this.A119BR_MedicationID=gx.fn.getIntegerValue("BR_MEDICATIONID",",");this.AV11LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS");this.AV12SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE");this.AV8TabCode=gx.fn.getControlValue("vTABCODE");this.AV16BR_MedicationID=gx.fn.getIntegerValue("vBR_MEDICATIONID",",")};this.e114y1_client=function(){return this.clearMessages(),this.call("br_medicationview.aspx",[this.AV16BR_MedicationID,"BR_Medication_Scheme"]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e124y2_client=function(){return this.executeServerEvent("TABS.TABCHANGED",!1,null,!0,!0)};this.e154y2_client=function(){return this.executeServerEvent("'GENERAL'",!1,null,!1,!1)};this.e164y2_client=function(){return this.executeServerEvent("'BR_MEDICATION_DETAIL'",!1,null,!1,!1)};this.e174y2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e184y2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,20,21,23,24,25,28,29,31,32,33,35,36,37,38,39,40,41,42,43];this.GXLastCtrlId=43;this.TABSContainer=gx.uc.getNew(this,18,0,"gx.ui.controls.Tab","TABSContainer","Tabs","TABS");t=this.TABSContainer;t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("ActivePage","Activepage","","int");t.setDynProp("ActivePageControlName","Activepagecontrolname","","char");t.setProp("PageCount","Pagecount",2,"num");t.setProp("Class","Class","ViewTab Tab","str");t.setProp("HistoryManagement","Historymanagement",!0,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});t.addEventHandler("TabChanged",this.e124y2_client);this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"BTNBACK",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"UNNAMEDTABLEVIEWCONTAINER",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"TXTTABTITLE",format:0,grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"",grid:0};n[20]={id:20,fld:"GENERAL_TITLE",format:0,grid:0};n[21]={id:21,fld:"",grid:0};n[23]={id:23,fld:"UNNAMEDTABLEGENERAL",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[28]={id:28,fld:"BR_MEDICATION_DETAIL_TITLE",format:0,grid:0};n[29]={id:29,fld:"",grid:0};n[31]={id:31,fld:"UNNAMEDTABLEBR_MEDICATION_DETAIL",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"UNNAMEDTABLETABSCONTAINER",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"CELL_GENERAL",grid:0};n[40]={id:40,fld:"BTNGENERAL",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"CELL_BR_MEDICATION_DETAIL",grid:0};n[43]={id:43,fld:"BTNBR_MEDICATION_DETAIL",grid:0};this.AV10BR_Medication_SchemeID=0;this.AV16BR_MedicationID=0;this.AV8TabCode="";this.A119BR_MedicationID=0;this.A296BR_Medication_SchemeID=0;this.AV11LoadAllTabs=!1;this.AV12SelectedTabCode="";this.Events={e124y2_client:["TABS.TABCHANGED",!0],e154y2_client:["'GENERAL'",!0],e164y2_client:["'BR_MEDICATION_DETAIL'",!0],e174y2_client:["ENTER",!0],e184y2_client:["CANCEL",!0],e114y1_client:["'DOBACK'",!1]};this.EvtParms.REFRESH=[[{av:"AV16BR_MedicationID",fld:"vBR_MEDICATIONID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV10BR_Medication_SchemeID",fld:"vBR_MEDICATION_SCHEMEID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV8TabCode",fld:"vTABCODE",pic:"",hsh:!0}],[]];this.EvtParms.START=[[{av:"A296BR_Medication_SchemeID",fld:"BR_MEDICATION_SCHEMEID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV10BR_Medication_SchemeID",fld:"vBR_MEDICATION_SCHEMEID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"A119BR_MedicationID",fld:"BR_MEDICATIONID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV16BR_MedicationID",fld:"vBR_MEDICATIONID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV8TabCode",fld:"vTABCODE",pic:"",hsh:!0},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""}],[{ctrl:"FORM",prop:"Caption"},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"this.TABSContainer.ActivePageControlName",ctrl:"TABS",prop:"ActivePageControlName"},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION_DETAIL","Visible")',ctrl:"CELL_BR_MEDICATION_DETAIL",prop:"Visible"},{ctrl:"BR_MEDICATION_DETAILWC"}]];this.EvtParms.LOAD=[[],[]];this.EvtParms["'DOBACK'"]=[[{av:"AV16BR_MedicationID",fld:"vBR_MEDICATIONID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[]];this.EvtParms["TABS.TABCHANGED"]=[[{av:"this.TABSContainer.ActivePageControlName",ctrl:"TABS",prop:"ActivePageControlName"},{av:"A296BR_Medication_SchemeID",fld:"BR_MEDICATION_SCHEMEID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV10BR_Medication_SchemeID",fld:"vBR_MEDICATION_SCHEMEID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"A119BR_MedicationID",fld:"BR_MEDICATIONID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV16BR_MedicationID",fld:"vBR_MEDICATIONID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""}],[{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION_DETAIL","Visible")',ctrl:"CELL_BR_MEDICATION_DETAIL",prop:"Visible"},{ctrl:"BR_MEDICATION_DETAILWC"}]];this.EvtParms["'GENERAL'"]=[[{av:"A296BR_Medication_SchemeID",fld:"BR_MEDICATION_SCHEMEID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV10BR_Medication_SchemeID",fld:"vBR_MEDICATION_SCHEMEID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"A119BR_MedicationID",fld:"BR_MEDICATIONID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV16BR_MedicationID",fld:"vBR_MEDICATIONID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""}],[{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION_DETAIL","Visible")',ctrl:"CELL_BR_MEDICATION_DETAIL",prop:"Visible"},{ctrl:"BR_MEDICATION_DETAILWC"}]];this.EvtParms["'BR_MEDICATION_DETAIL'"]=[[{av:"A296BR_Medication_SchemeID",fld:"BR_MEDICATION_SCHEMEID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV10BR_Medication_SchemeID",fld:"vBR_MEDICATION_SCHEMEID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"A119BR_MedicationID",fld:"BR_MEDICATIONID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV16BR_MedicationID",fld:"vBR_MEDICATIONID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""}],[{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION_DETAIL","Visible")',ctrl:"CELL_BR_MEDICATION_DETAIL",prop:"Visible"},{ctrl:"BR_MEDICATION_DETAILWC"}]];this.setVCMap("AV16BR_MedicationID","vBR_MEDICATIONID",0,"int",18,0);this.setVCMap("A296BR_Medication_SchemeID","BR_MEDICATION_SCHEMEID",0,"int",18,0);this.setVCMap("AV10BR_Medication_SchemeID","vBR_MEDICATION_SCHEMEID",0,"int",18,0);this.setVCMap("A119BR_MedicationID","BR_MEDICATIONID",0,"int",18,0);this.setVCMap("AV11LoadAllTabs","vLOADALLTABS",0,"boolean",4,0);this.setVCMap("AV12SelectedTabCode","vSELECTEDTABCODE",0,"char",50,0);this.setVCMap("AV8TabCode","vTABCODE",0,"char",50,0);this.setVCMap("AV16BR_MedicationID","vBR_MEDICATIONID",0,"int",18,0);this.Initialize();this.setComponent({id:"GENERALWC",GXClass:null,Prefix:"W0026",lvl:1});this.setComponent({id:"BR_MEDICATION_DETAILWC",GXClass:null,Prefix:"W0034",lvl:1})});gx.createParentObj(br_medication_schemeview)