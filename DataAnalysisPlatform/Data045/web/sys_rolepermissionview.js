/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:16:35.0
*/
gx.evt.autoSkip=!1;gx.define("sys_rolepermissionview",!1,function(){var n,t;this.ServerClass="sys_rolepermissionview";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV12LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS");this.AV13SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE");this.AV10SYS_RolePermissionRoleID=gx.fn.getControlValue("vSYS_ROLEPERMISSIONROLEID");this.AV11SYS_RolePermissionPermissionCode=gx.fn.getControlValue("vSYS_ROLEPERMISSIONPERMISSIONCODE");this.AV8TabCode=gx.fn.getControlValue("vTABCODE");this.AV10SYS_RolePermissionRoleID=gx.fn.getControlValue("vSYS_ROLEPERMISSIONROLEID");this.AV11SYS_RolePermissionPermissionCode=gx.fn.getControlValue("vSYS_ROLEPERMISSIONPERMISSIONCODE");this.AV12LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS");this.AV13SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE")};this.s112_client=function(){gx.fn.setCtrlProperty("CELL_GENERAL","Visible",!0);(this.AV12LoadAllTabs||this.AV13SelectedTabCode==""||this.AV13SelectedTabCode=="General")&&(this.createWebComponent("Generalwc","SYS_RolePermissionGeneral",[this.AV10SYS_RolePermissionRoleID,this.AV11SYS_RolePermissionPermissionCode]),gx.fn.setCtrlProperty("TXTTABTITLE","Caption","General"),(this.AV13SelectedTabCode==""||this.AV13SelectedTabCode=="General")&&gx.fn.setCtrlProperty("CELL_GENERAL","Visible",!1))};this.e148c1_client=function(){return this.clearMessages(),this.AV13SelectedTabCode=this.TABSContainer.ActivePageControlName,this.AV12LoadAllTabs=!1,this.s112_client(),this.refreshOutputs([{av:"AV13SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV12LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"}]),gx.$.Deferred().resolve()};this.e118c1_client=function(){return this.clearMessages(),this.TABSContainer.SelectTab(1),this.AV13SelectedTabCode="General",this.AV12LoadAllTabs=!1,this.s112_client(),this.refreshOutputs([{av:"AV13SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV12LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"}]),gx.$.Deferred().resolve()};this.e158c2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e168c2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,20,21,23,24,25,27,28,29,30,31,32];this.GXLastCtrlId=32;this.TABSContainer=gx.uc.getNew(this,18,0,"gx.ui.controls.Tab","TABSContainer","Tabs","TABS");t=this.TABSContainer;t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("ActivePage","Activepage","","int");t.setDynProp("ActivePageControlName","Activepagecontrolname","","char");t.setProp("PageCount","Pagecount",1,"num");t.setProp("Class","Class","ViewTab Tab","str");t.setProp("HistoryManagement","Historymanagement",!0,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});t.addEventHandler("TabChanged",this.e148c1_client);this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"WORKWITHLINK",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"UNNAMEDTABLEVIEWCONTAINER",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"TXTTABTITLE",format:0,grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"",grid:0};n[20]={id:20,fld:"GENERAL_TITLE",format:0,grid:0};n[21]={id:21,fld:"",grid:0};n[23]={id:23,fld:"UNNAMEDTABLEGENERAL",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"UNNAMEDTABLETABSCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"CELL_GENERAL",grid:0};n[32]={id:32,fld:"BTNGENERAL",grid:0};this.AV10SYS_RolePermissionRoleID="00000000-0000-0000-0000-000000000000";this.AV11SYS_RolePermissionPermissionCode="";this.AV8TabCode="";this.A445SYS_RolePermissionPermissionCode="";this.A444SYS_RolePermissionRoleID="00000000-0000-0000-0000-000000000000";this.AV12LoadAllTabs=!1;this.AV13SelectedTabCode="";this.Events={e158c2_client:["ENTER",!0],e168c2_client:["CANCEL",!0],e148c1_client:["TABS.TABCHANGED",!1],e118c1_client:["'GENERAL'",!1]};this.EvtParms.REFRESH=[[{av:"AV10SYS_RolePermissionRoleID",fld:"vSYS_ROLEPERMISSIONROLEID",pic:"",hsh:!0},{av:"AV11SYS_RolePermissionPermissionCode",fld:"vSYS_ROLEPERMISSIONPERMISSIONCODE",pic:"",hsh:!0},{av:"AV8TabCode",fld:"vTABCODE",pic:"",hsh:!0}],[]];this.EvtParms.START=[[{av:"A444SYS_RolePermissionRoleID",fld:"SYS_ROLEPERMISSIONROLEID",pic:""},{av:"AV10SYS_RolePermissionRoleID",fld:"vSYS_ROLEPERMISSIONROLEID",pic:"",hsh:!0},{av:"A445SYS_RolePermissionPermissionCode",fld:"SYS_ROLEPERMISSIONPERMISSIONCODE",pic:""},{av:"AV11SYS_RolePermissionPermissionCode",fld:"vSYS_ROLEPERMISSIONPERMISSIONCODE",pic:"",hsh:!0},{av:"AV8TabCode",fld:"vTABCODE",pic:"",hsh:!0},{av:"AV12LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV13SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""}],[{av:'gx.fn.getCtrlProperty("WORKWITHLINK","Link")',ctrl:"WORKWITHLINK",prop:"Link"},{ctrl:"FORM",prop:"Caption"},{av:"AV13SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"this.TABSContainer.ActivePageControlName",ctrl:"TABS",prop:"ActivePageControlName"},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"}]];this.EvtParms.LOAD=[[],[]];this.EvtParms["TABS.TABCHANGED"]=[[{av:"this.TABSContainer.ActivePageControlName",ctrl:"TABS",prop:"ActivePageControlName"},{av:"AV12LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV13SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV10SYS_RolePermissionRoleID",fld:"vSYS_ROLEPERMISSIONROLEID",pic:"",hsh:!0},{av:"AV11SYS_RolePermissionPermissionCode",fld:"vSYS_ROLEPERMISSIONPERMISSIONCODE",pic:"",hsh:!0}],[{av:"AV13SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV12LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"}]];this.EvtParms["'GENERAL'"]=[[{av:"AV12LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV13SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV10SYS_RolePermissionRoleID",fld:"vSYS_ROLEPERMISSIONROLEID",pic:"",hsh:!0},{av:"AV11SYS_RolePermissionPermissionCode",fld:"vSYS_ROLEPERMISSIONPERMISSIONCODE",pic:"",hsh:!0}],[{av:"AV13SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV12LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:"CELL_GENERAL",prop:"Visible"},{ctrl:"GENERALWC"},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:"TXTTABTITLE",prop:"Caption"}]];this.setVCMap("AV12LoadAllTabs","vLOADALLTABS",0,"boolean",4,0);this.setVCMap("AV13SelectedTabCode","vSELECTEDTABCODE",0,"char",50,0);this.setVCMap("AV10SYS_RolePermissionRoleID","vSYS_ROLEPERMISSIONROLEID",0,"guid",16,0);this.setVCMap("AV11SYS_RolePermissionPermissionCode","vSYS_ROLEPERMISSIONPERMISSIONCODE",0,"svchar",64,0);this.setVCMap("AV8TabCode","vTABCODE",0,"char",50,0);this.setVCMap("AV10SYS_RolePermissionRoleID","vSYS_ROLEPERMISSIONROLEID",0,"guid",16,0);this.setVCMap("AV11SYS_RolePermissionPermissionCode","vSYS_ROLEPERMISSIONPERMISSIONCODE",0,"svchar",64,0);this.setVCMap("AV12LoadAllTabs","vLOADALLTABS",0,"boolean",4,0);this.setVCMap("AV13SelectedTabCode","vSELECTEDTABCODE",0,"char",50,0);this.Initialize();this.setComponent({id:"GENERALWC",GXClass:null,Prefix:"W0026",lvl:1})});gx.createParentObj(sys_rolepermissionview)