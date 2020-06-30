/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:12:43.27
*/
gx.evt.autoSkip=!1;gx.define("br_pathologyview",!1,function(){var n,t;this.ServerClass="br_pathologyview";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV10BR_PathologyID=gx.fn.getIntegerValue("vBR_PATHOLOGYID",",");this.A226BR_PathologyID=gx.fn.getIntegerValue("BR_PATHOLOGYID",",");this.AV11LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS");this.AV12SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE");this.AV8TabCode=gx.fn.getControlValue("vTABCODE")};this.e145b2_client=function(){return this.executeServerEvent("'DOBACK'",!1,null,!1,!1)};this.e115b2_client=function(){return this.executeServerEvent("TABS.TABCHANGED",!1,null,!0,!0)};this.e155b2_client=function(){return this.executeServerEvent("'GENERAL'",!1,null,!1,!1)};this.e165b2_client=function(){return this.executeServerEvent("'BR_PATHOLOGY_SPECIMEN'",!1,null,!1,!1)};this.e175b2_client=function(){return this.executeServerEvent("'BR_PATHOLOGY_DIAG'",!1,null,!1,!1)};this.e185b2_client=function(){return this.executeServerEvent("'BR_PATHOLOGY_OTHER'",!1,null,!1,!1)};this.e195b2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e205b2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,20,21,23,24,25,28,29,31,32,33,36,37,39,40,41,44,45,47,48,49,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65];this.GXLastCtrlId=65;this.TABSContainer=gx.uc.getNew(this,18,0,"gx.ui.controls.Tab","TABSContainer","Tabs","TABS");t=this.TABSContainer;t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("ActivePage","Activepage","","int");t.setDynProp("ActivePageControlName","Activepagecontrolname","","char");t.setProp("PageCount","Pagecount",4,"num");t.setProp("Class","Class","ViewTab Tab","str");t.setProp("HistoryManagement","Historymanagement",!0,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});t.addEventHandler("TabChanged",this.e115b2_client);this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"BTNBACK",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"UNNAMEDTABLEVIEWCONTAINER",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"TXTTABTITLE",format:0,grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"",grid:0};n[20]={id:20,fld:"GENERAL_TITLE",format:0,grid:0};n[21]={id:21,fld:"",grid:0};n[23]={id:23,fld:"UNNAMEDTABLEGENERAL",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[28]={id:28,fld:"BR_PATHOLOGY_SPECIMEN_TITLE",format:0,grid:0};n[29]={id:29,fld:"",grid:0};n[31]={id:31,fld:"UNNAMEDTABLEBR_PATHOLOGY_SPECIMEN",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[36]={id:36,fld:"BR_PATHOLOGY_DIAG_TITLE",format:0,grid:0};n[37]={id:37,fld:"",grid:0};n[39]={id:39,fld:"UNNAMEDTABLEBR_PATHOLOGY_DIAG",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[44]={id:44,fld:"BR_PATHOLOGY_OTHER_TITLE",format:0,grid:0};n[45]={id:45,fld:"",grid:0};n[47]={id:47,fld:"UNNAMEDTABLEBR_PATHOLOGY_OTHER",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"UNNAMEDTABLETABSCONTAINER",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"CELL_GENERAL",grid:0};n[56]={id:56,fld:"BTNGENERAL",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"CELL_BR_PATHOLOGY_SPECIMEN",grid:0};n[59]={id:59,fld:"BTNBR_PATHOLOGY_SPECIMEN",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"CELL_BR_PATHOLOGY_DIAG",grid:0};n[62]={id:62,fld:"BTNBR_PATHOLOGY_DIAG",grid:0};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"CELL_BR_PATHOLOGY_OTHER",grid:0};n[65]={id:65,fld:"BTNBR_PATHOLOGY_OTHER",grid:0};this.AV10BR_PathologyID=0;this.AV8TabCode="";this.A226BR_PathologyID=0;this.AV11LoadAllTabs=!1;this.AV12SelectedTabCode="";this.Events={e145b2_client:["'DOBACK'",!0],e115b2_client:["TABS.TABCHANGED",!0],e155b2_client:["'GENERAL'",!0],e165b2_client:["'BR_PATHOLOGY_SPECIMEN'",!0],e175b2_client:["'BR_PATHOLOGY_DIAG'",!0],e185b2_client:["'BR_PATHOLOGY_OTHER'",!0],e195b2_client:["ENTER",!0],e205b2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"AV10BR_PathologyID",fld:"vBR_PATHOLOGYID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV8TabCode",fld:"vTABCODE",pic:"",hsh:!0}],[]];this.EvtParms.START=[[{av:"A226BR_PathologyID",fld:"BR_PATHOLOGYID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV10BR_PathologyID",fld:"vBR_PATHOLOGYID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV8TabCode",fld:"vTABCODE",pic:"",hsh:!0},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""}],[{ctrl:"FORM",prop:"Caption"},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"this.TABSContainer.ActivePageControlName",ctrl:"TABS",prop:"ActivePageControlName"},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_SPECIMEN","Visible")',ctrl:"CELL_BR_PATHOLOGY_SPECIMEN",prop:"Visible"},{ctrl:"BR_PATHOLOGY_SPECIMENWC"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_DIAG","Visible")',ctrl:"CELL_BR_PATHOLOGY_DIAG",prop:"Visible"},{ctrl:"BR_PATHOLOGY_DIAGWC"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_OTHER","Visible")',ctrl:"CELL_BR_PATHOLOGY_OTHER",prop:"Visible"},{ctrl:"BR_PATHOLOGY_OTHERWC"}]];this.EvtParms.LOAD=[[],[]];this.EvtParms["'DOBACK'"]=[[{av:"AV10BR_PathologyID",fld:"vBR_PATHOLOGYID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[]];this.EvtParms["TABS.TABCHANGED"]=[[{av:"this.TABSContainer.ActivePageControlName",ctrl:"TABS",prop:"ActivePageControlName"},{av:"A226BR_PathologyID",fld:"BR_PATHOLOGYID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV10BR_PathologyID",fld:"vBR_PATHOLOGYID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""}],[{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_SPECIMEN","Visible")',ctrl:"CELL_BR_PATHOLOGY_SPECIMEN",prop:"Visible"},{ctrl:"BR_PATHOLOGY_SPECIMENWC"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_DIAG","Visible")',ctrl:"CELL_BR_PATHOLOGY_DIAG",prop:"Visible"},{ctrl:"BR_PATHOLOGY_DIAGWC"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_OTHER","Visible")',ctrl:"CELL_BR_PATHOLOGY_OTHER",prop:"Visible"},{ctrl:"BR_PATHOLOGY_OTHERWC"}]];this.EvtParms["'GENERAL'"]=[[{av:"A226BR_PathologyID",fld:"BR_PATHOLOGYID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV10BR_PathologyID",fld:"vBR_PATHOLOGYID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""}],[{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_SPECIMEN","Visible")',ctrl:"CELL_BR_PATHOLOGY_SPECIMEN",prop:"Visible"},{ctrl:"BR_PATHOLOGY_SPECIMENWC"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_DIAG","Visible")',ctrl:"CELL_BR_PATHOLOGY_DIAG",prop:"Visible"},{ctrl:"BR_PATHOLOGY_DIAGWC"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_OTHER","Visible")',ctrl:"CELL_BR_PATHOLOGY_OTHER",prop:"Visible"},{ctrl:"BR_PATHOLOGY_OTHERWC"}]];this.EvtParms["'BR_PATHOLOGY_SPECIMEN'"]=[[{av:"A226BR_PathologyID",fld:"BR_PATHOLOGYID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV10BR_PathologyID",fld:"vBR_PATHOLOGYID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""}],[{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_SPECIMEN","Visible")',ctrl:"CELL_BR_PATHOLOGY_SPECIMEN",prop:"Visible"},{ctrl:"BR_PATHOLOGY_SPECIMENWC"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_DIAG","Visible")',ctrl:"CELL_BR_PATHOLOGY_DIAG",prop:"Visible"},{ctrl:"BR_PATHOLOGY_DIAGWC"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_OTHER","Visible")',ctrl:"CELL_BR_PATHOLOGY_OTHER",prop:"Visible"},{ctrl:"BR_PATHOLOGY_OTHERWC"}]];this.EvtParms["'BR_PATHOLOGY_DIAG'"]=[[{av:"A226BR_PathologyID",fld:"BR_PATHOLOGYID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV10BR_PathologyID",fld:"vBR_PATHOLOGYID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""}],[{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_SPECIMEN","Visible")',ctrl:"CELL_BR_PATHOLOGY_SPECIMEN",prop:"Visible"},{ctrl:"BR_PATHOLOGY_SPECIMENWC"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_DIAG","Visible")',ctrl:"CELL_BR_PATHOLOGY_DIAG",prop:"Visible"},{ctrl:"BR_PATHOLOGY_DIAGWC"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_OTHER","Visible")',ctrl:"CELL_BR_PATHOLOGY_OTHER",prop:"Visible"},{ctrl:"BR_PATHOLOGY_OTHERWC"}]];this.EvtParms["'BR_PATHOLOGY_OTHER'"]=[[{av:"A226BR_PathologyID",fld:"BR_PATHOLOGYID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV10BR_PathologyID",fld:"vBR_PATHOLOGYID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""}],[{av:"AV12SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_SPECIMEN","Visible")',ctrl:"CELL_BR_PATHOLOGY_SPECIMEN",prop:"Visible"},{ctrl:"BR_PATHOLOGY_SPECIMENWC"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_DIAG","Visible")',ctrl:"CELL_BR_PATHOLOGY_DIAG",prop:"Visible"},{ctrl:"BR_PATHOLOGY_DIAGWC"},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY_OTHER","Visible")',ctrl:"CELL_BR_PATHOLOGY_OTHER",prop:"Visible"},{ctrl:"BR_PATHOLOGY_OTHERWC"}]];this.setVCMap("AV10BR_PathologyID","vBR_PATHOLOGYID",0,"int",18,0);this.setVCMap("A226BR_PathologyID","BR_PATHOLOGYID",0,"int",18,0);this.setVCMap("AV11LoadAllTabs","vLOADALLTABS",0,"boolean",4,0);this.setVCMap("AV12SelectedTabCode","vSELECTEDTABCODE",0,"char",50,0);this.setVCMap("AV8TabCode","vTABCODE",0,"char",50,0);this.Initialize();this.setComponent({id:"GENERALWC",GXClass:null,Prefix:"W0026",lvl:1});this.setComponent({id:"BR_PATHOLOGY_SPECIMENWC",GXClass:null,Prefix:"W0034",lvl:1});this.setComponent({id:"BR_PATHOLOGY_DIAGWC",GXClass:null,Prefix:"W0042",lvl:1});this.setComponent({id:"BR_PATHOLOGY_OTHERWC",GXClass:null,Prefix:"W0050",lvl:1})});gx.createParentObj(br_pathologyview)