/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:7:10.54
*/
gx.evt.autoSkip=!1;gx.define("br_procedure_surgeryinsert",!1,function(){var n,t;this.ServerClass="br_procedure_surgeryinsert";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV12BR_ProcedureID=gx.fn.getIntegerValue("vBR_PROCEDUREID",",");this.AV10BR_Procedure_Surgery=gx.fn.getControlValue("vBR_PROCEDURE_SURGERY")};this.e139e2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e159e1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41];this.GXLastCtrlId=41;this.DVPANEL_TABLEATTRIBUTESContainer=gx.uc.getNew(this,16,0,"BootstrapPanel","DVPANEL_TABLEATTRIBUTESContainer","Dvpanel_tableattributes","DVPANEL_TABLEATTRIBUTES");t=this.DVPANEL_TABLEATTRIBUTESContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Width","Width","100%","str");t.setProp("Height","Height","100","str");t.setProp("AutoWidth","Autowidth",!1,"bool");t.setProp("AutoHeight","Autoheight",!0,"bool");t.setProp("Cls","Cls","PanelCard_BaseColor","str");t.setProp("ShowHeader","Showheader",!0,"bool");t.setProp("Title","Title","鎵嬫湳淇℃伅","str");t.setProp("Collapsible","Collapsible",!1,"bool");t.setProp("Collapsed","Collapsed",!1,"bool");t.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");t.setProp("IconPosition","Iconposition","left","str");t.setProp("AutoScroll","Autoscroll",!1,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"TABLECONTENT",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};n[18]={id:18,fld:"LAYOUT_TABLEATTRIBUTES",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"TABLEATTRIBUTES",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_SURGERY_BR_PROCEDURE_SURGERY_NAME",gxz:"ZV20GXV1",gxold:"OV20GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV1=n)},v2z:function(n){n!==undefined&&(gx.O.ZV20GXV1=n)},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_SURGERY_BR_PROCEDURE_SURGERY_NAME",gx.O.GXV1,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV1=this.val())},val:function(){return gx.fn.getControlValue("BR_PROCEDURE_SURGERY_BR_PROCEDURE_SURGERY_NAME")},nac:gx.falseFn};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_SURGERY_BR_PROCEDURE_SURGERY_LOC",gxz:"ZV21GXV2",gxold:"OV21GXV2",gxvar:"GXV2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV2=n)},v2z:function(n){n!==undefined&&(gx.O.ZV21GXV2=n)},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_SURGERY_BR_PROCEDURE_SURGERY_LOC",gx.O.GXV2,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV2=this.val())},val:function(){return gx.fn.getControlValue("BR_PROCEDURE_SURGERY_BR_PROCEDURE_SURGERY_LOC")},nac:gx.falseFn};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"BTNENTER",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"BTNCANCEL",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};n[40]={id:40,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_SURGERY_BR_PROCEDURE_SURGERYID",gxz:"ZV22GXV3",gxold:"OV22GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV3=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV22GXV3=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_SURGERY_BR_PROCEDURE_SURGERYID",gx.O.GXV3,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV3=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_PROCEDURE_SURGERY_BR_PROCEDURE_SURGERYID",",")},nac:gx.falseFn};n[41]={id:41,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_SURGERY_BR_PROCEDUREID",gxz:"ZV23GXV4",gxold:"OV23GXV4",gxvar:"GXV4",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV4=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV23GXV4=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_SURGERY_BR_PROCEDUREID",gx.O.GXV4,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV4=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_PROCEDURE_SURGERY_BR_PROCEDUREID",",")},nac:gx.falseFn};this.GXV1="";this.ZV20GXV1="";this.OV20GXV1="";this.GXV2="";this.ZV21GXV2="";this.OV21GXV2="";this.GXV3=0;this.ZV22GXV3=0;this.OV22GXV3=0;this.GXV4=0;this.ZV23GXV4=0;this.OV23GXV4=0;this.GXV1="";this.GXV2="";this.GXV3=0;this.GXV4=0;this.AV12BR_ProcedureID=0;this.AV10BR_Procedure_Surgery={BR_Procedure_SurgeryID:0,BR_ProcedureID:0,BR_Procedure_Surgery_Name:"",BR_Procedure_Surgery_Loc:"",Mode:"",Initialized:0,BR_Procedure_SurgeryID_Z:0,BR_ProcedureID_Z:0,BR_Procedure_Surgery_Name_Z:"",BR_Procedure_Surgery_Loc_Z:""};this.Events={e139e2_client:["ENTER",!0],e159e1_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"AV12BR_ProcedureID",fld:"vBR_PROCEDUREID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[]];this.EvtParms.START=[[],[{ctrl:"BR_PROCEDURE_SURGERY_BR_PROCEDURE_SURGERYID",prop:"Visible"},{ctrl:"BR_PROCEDURE_SURGERY_BR_PROCEDUREID",prop:"Visible"}]];this.EvtParms.ENTER=[[{av:"AV12BR_ProcedureID",fld:"vBR_PROCEDUREID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV10BR_Procedure_Surgery",fld:"vBR_PROCEDURE_SURGERY",pic:""}],[{av:"AV10BR_Procedure_Surgery",fld:"vBR_PROCEDURE_SURGERY",pic:""}]];this.EnterCtrl=["BTNENTER"];this.setVCMap("AV12BR_ProcedureID","vBR_PROCEDUREID",0,"int",18,0);this.setVCMap("AV10BR_Procedure_Surgery","vBR_PROCEDURE_SURGERY",0,"BR_Procedure_Surgery",0,0);this.addBCProperty("Br_procedure_surgery",["BR_Procedure_Surgery_Name"],this.GXValidFnc[25],"AV10BR_Procedure_Surgery");this.addBCProperty("Br_procedure_surgery",["BR_Procedure_Surgery_Loc"],this.GXValidFnc[29],"AV10BR_Procedure_Surgery");this.addBCProperty("Br_procedure_surgery",["BR_Procedure_SurgeryID"],this.GXValidFnc[40],"AV10BR_Procedure_Surgery");this.addBCProperty("Br_procedure_surgery",["BR_ProcedureID"],this.GXValidFnc[41],"AV10BR_Procedure_Surgery");this.Initialize()});gx.createParentObj(br_procedure_surgeryinsert)