/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:46:48.65
*/
gx.evt.autoSkip=!1;gx.define("br_enteringreaptcheck",!1,function(){var n,t;this.ServerClass="br_enteringreaptcheck";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV8BR_Encounter_RefuseReasonID=gx.fn.getIntegerValue("vBR_ENCOUNTER_REFUSEREASONID",",");this.AV7BR_Encounter_RefuseReason=gx.fn.getControlValue("vBR_ENCOUNTER_REFUSEREASON");this.AV6BR_Encounter=gx.fn.getControlValue("vBR_ENCOUNTER");this.AV9Context=gx.fn.getControlValue("vCONTEXT");this.AV15tvflag=gx.fn.getControlValue("vTVFLAG")};this.e127g2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e157g1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,28,30,31,32,33,34];this.GXLastCtrlId=34;this.DVPANEL_TABLEATTRIBUTESContainer=gx.uc.getNew(this,10,0,"BootstrapPanel","DVPANEL_TABLEATTRIBUTESContainer","Dvpanel_tableattributes","DVPANEL_TABLEATTRIBUTES");t=this.DVPANEL_TABLEATTRIBUTESContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Width","Width","100%","str");t.setProp("Height","Height","100","str");t.setProp("AutoWidth","Autowidth",!1,"bool");t.setProp("AutoHeight","Autoheight",!0,"bool");t.setProp("Cls","Cls","PanelCard_BaseColor","str");t.setProp("ShowHeader","Showheader",!0,"bool");t.setProp("Title","Title","澶嶅涓嶉€氳繃","str");t.setProp("Collapsible","Collapsible",!0,"bool");t.setProp("Collapsed","Collapsed",!1,"bool");t.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");t.setProp("IconPosition","Iconposition","left","str");t.setProp("AutoScroll","Autoscroll",!1,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};n[12]={id:12,fld:"LAYOUT_TABLEATTRIBUTES",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"TABLEATTRIBUTES",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"UNNAMEDTABLE1",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,lvl:0,type:"svchar",len:300,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_REFUSEREASON_BR_ENCOUNTER_REFUSEREASON_FREASON",gxz:"ZV18GXV1",gxold:"OV18GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV1=n)},v2z:function(n){n!==undefined&&(gx.O.ZV18GXV1=n)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_REFUSEREASON_BR_ENCOUNTER_REFUSEREASON_FREASON",gx.O.GXV1,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV1=this.val())},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_REFUSEREASON_BR_ENCOUNTER_REFUSEREASON_FREASON")},nac:gx.falseFn};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"TABLEMERGEDENTER",grid:0};n[28]={id:28,fld:"BTNENTER",grid:0};n[30]={id:30,fld:"BTN_CANCEL",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};n[34]={id:34,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_REFUSEREASON_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE",gxz:"ZV19GXV2",gxold:"OV19GXV2",gxvar:"GXV2",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV2=gx.fn.toDatetimeValue(n,"Y4MD"))},v2z:function(n){n!==undefined&&(gx.O.ZV19GXV2=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_REFUSEREASON_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE",gx.O.GXV2,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV2=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("BR_ENCOUNTER_REFUSEREASON_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE")},nac:gx.falseFn};this.GXV1="";this.ZV18GXV1="";this.OV18GXV1="";this.GXV2=gx.date.nullDate();this.ZV19GXV2=gx.date.nullDate();this.OV19GXV2=gx.date.nullDate();this.GXV1="";this.GXV2=gx.date.nullDate();this.AV8BR_Encounter_RefuseReasonID=0;this.AV15tvflag="";this.AV7BR_Encounter_RefuseReason={BR_Encounter_RefuseReasonID:0,BR_EncounterID:0,BR_Encounter_RefuseReason_Reason:"",BR_Encounter_RefuseReason_NoApproveDate:gx.date.nullDate(),BR_Encounter_RefuseReason_Status:0,BR_Encounter_RefuseReason_Approver:"",BR_EncounterReason_IsApprove:!1,BR_Information_ID:0,BR_EncounterReason_vStatus:0,BR_Encounter_RefuseReason_FReason:"",BR_Encounter_RefuseReason_FApproveDate:gx.date.nullDate(),Mode:"",Initialized:0,BR_Encounter_RefuseReasonID_Z:0,BR_EncounterID_Z:0,BR_Encounter_RefuseReason_Reason_Z:"",BR_Encounter_RefuseReason_NoApproveDate_Z:gx.date.nullDate(),BR_Encounter_RefuseReason_Status_Z:0,BR_Encounter_RefuseReason_Approver_Z:"",BR_EncounterReason_IsApprove_Z:!1,BR_Information_ID_Z:0,BR_EncounterReason_vStatus_Z:0,BR_Encounter_RefuseReason_FReason_Z:"",BR_Encounter_RefuseReason_FApproveDate_Z:gx.date.nullDate()};this.AV6BR_Encounter={BR_EncounterID:0,BR_Encounter_EncID:0,BR_Encounter_Department:"",BR_Encounter_Department_Code:"",BR_Encounter_Departmentadm:"",BR_Encounter_Departmentadm_Code:"",BR_Encounter_Departmentdisch:"",BR_Encounter_Departmentdisch_Code:"",BR_Encounter_ENCType:"",BR_Encounter_ENCType_Code:"",BR_Encounter_AdmitDate:gx.date.nullDate(),BR_Encounter_AdmitSource:"",BR_Encounter_AdmitSource_Code:"",BR_Encounter_DischargeDate:gx.date.nullDate(),BR_Encounter_DischargeStatus:"",BR_Encounter_DischargeStatus_Code:"",BR_Encounter_Insurance:"",BR_Encounter_Insurance_Code:"",BR_Encounter_Status:0,BR_Information_ID:0,BR_Information_PatientNo:"",BAS_TenantTenantCode:"",BR_Encounter_CrtDate:gx.date.nullDate(),BR_Encounter_UpdDate:gx.date.nullDate(),BR_Encounter_CrtUser:"",BR_Encounter_CrtDisplayName:"",BR_Encounter_UpdUser:"",BR_Encounter_IsDLT:!1,BR_Encounter_SubmitUser:"",BR_Encounter_Reason:"",BR_Encounter_SubmitDate:gx.date.nullDate(),BR_Encounter_RecheckUser:"",BR_Encounter_FReason:"",BR_Encounter_RecheckDate:gx.date.nullDate(),BR_Encounter_Approver:"",BR_Encounter_ApproveDate:gx.date.nullDate(),BR_Encounter_IsRandApprove:!1,BR_Encounter_IsRandApprover:"",BR_Encounter_IsRandNoApprover:"",BR_Encounter_IsRandApproveDate:gx.date.nullDate(),BR_Encounter_IsRandNoApproveDate:gx.date.nullDate(),BR_Encounter_IsRandRecheck:!1,BR_Encounter_IsRandRecheckr:"",BR_Encounter_IsRandNoRecheckr:"",BR_Encounter_IsRandRecheckDate:gx.date.nullDate(),BR_Encounter_IsRandNoRecheckDate:gx.date.nullDate(),BR_Encounter_IsUpdate:!1,BR_Encounter_Datasource:0,EncounterIDEncrypt:"",Mode:"",Initialized:0,BR_EncounterID_Z:0,BR_Encounter_EncID_Z:0,BR_Encounter_Department_Z:"",BR_Encounter_Department_Code_Z:"",BR_Encounter_Departmentadm_Z:"",BR_Encounter_Departmentadm_Code_Z:"",BR_Encounter_Departmentdisch_Z:"",BR_Encounter_Departmentdisch_Code_Z:"",BR_Encounter_ENCType_Z:"",BR_Encounter_ENCType_Code_Z:"",BR_Encounter_AdmitDate_Z:gx.date.nullDate(),BR_Encounter_AdmitSource_Z:"",BR_Encounter_AdmitSource_Code_Z:"",BR_Encounter_DischargeDate_Z:gx.date.nullDate(),BR_Encounter_DischargeStatus_Z:"",BR_Encounter_DischargeStatus_Code_Z:"",BR_Encounter_Insurance_Z:"",BR_Encounter_Insurance_Code_Z:"",BR_Encounter_Status_Z:0,BR_Information_ID_Z:0,BR_Information_PatientNo_Z:"",BAS_TenantTenantCode_Z:"",BR_Encounter_CrtDate_Z:gx.date.nullDate(),BR_Encounter_UpdDate_Z:gx.date.nullDate(),BR_Encounter_CrtUser_Z:"",BR_Encounter_CrtDisplayName_Z:"",BR_Encounter_UpdUser_Z:"",BR_Encounter_IsDLT_Z:!1,BR_Encounter_SubmitUser_Z:"",BR_Encounter_Reason_Z:"",BR_Encounter_SubmitDate_Z:gx.date.nullDate(),BR_Encounter_RecheckUser_Z:"",BR_Encounter_FReason_Z:"",BR_Encounter_RecheckDate_Z:gx.date.nullDate(),BR_Encounter_Approver_Z:"",BR_Encounter_ApproveDate_Z:gx.date.nullDate(),BR_Encounter_IsRandApprove_Z:!1,BR_Encounter_IsRandApprover_Z:"",BR_Encounter_IsRandNoApprover_Z:"",BR_Encounter_IsRandApproveDate_Z:gx.date.nullDate(),BR_Encounter_IsRandNoApproveDate_Z:gx.date.nullDate(),BR_Encounter_IsRandRecheck_Z:!1,BR_Encounter_IsRandRecheckr_Z:"",BR_Encounter_IsRandNoRecheckr_Z:"",BR_Encounter_IsRandRecheckDate_Z:gx.date.nullDate(),BR_Encounter_IsRandNoRecheckDate_Z:gx.date.nullDate(),BR_Encounter_IsUpdate_Z:!1,BR_Encounter_Datasource_Z:0,EncounterIDEncrypt_Z:""};this.AV9Context={UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""};this.Events={e127g2_client:["ENTER",!0],e157g1_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"AV8BR_Encounter_RefuseReasonID",fld:"vBR_ENCOUNTER_REFUSEREASONID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[{av:"AV9Context",fld:"vCONTEXT",pic:""}]];this.EvtParms.START=[[{av:"AV8BR_Encounter_RefuseReasonID",fld:"vBR_ENCOUNTER_REFUSEREASONID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[{ctrl:"BR_ENCOUNTER_REFUSEREASON_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE",prop:"Visible"},{av:"AV6BR_Encounter",fld:"vBR_ENCOUNTER",pic:""}]];this.EvtParms.ENTER=[[{av:"AV8BR_Encounter_RefuseReasonID",fld:"vBR_ENCOUNTER_REFUSEREASONID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV7BR_Encounter_RefuseReason",fld:"vBR_ENCOUNTER_REFUSEREASON",pic:""},{av:"AV6BR_Encounter",fld:"vBR_ENCOUNTER",pic:""},{av:"AV9Context",fld:"vCONTEXT",pic:""}],[{av:"AV7BR_Encounter_RefuseReason",fld:"vBR_ENCOUNTER_REFUSEREASON",pic:""},{av:"AV6BR_Encounter",fld:"vBR_ENCOUNTER",pic:""},{av:"AV15tvflag",fld:"vTVFLAG",pic:""}]];this.EnterCtrl=["BTNENTER"];this.setVCMap("AV8BR_Encounter_RefuseReasonID","vBR_ENCOUNTER_REFUSEREASONID",0,"int",18,0);this.setVCMap("AV7BR_Encounter_RefuseReason","vBR_ENCOUNTER_REFUSEREASON",0,"BR_Encounter_RefuseReason",0,0);this.setVCMap("AV6BR_Encounter","vBR_ENCOUNTER",0,"BR_Encounter",0,0);this.setVCMap("AV9Context","vCONTEXT",0,"WWPBaseObjectsWWPContext",0,0);this.setVCMap("AV15tvflag","vTVFLAG",0,"svchar",40,0);this.addBCProperty("Br_encounter_refusereason",["BR_Encounter_RefuseReason_FReason"],this.GXValidFnc[22],"AV7BR_Encounter_RefuseReason");this.addBCProperty("Br_encounter_refusereason",["BR_Encounter_RefuseReason_FApproveDate"],this.GXValidFnc[34],"AV7BR_Encounter_RefuseReason");this.Initialize()});gx.createParentObj(br_enteringreaptcheck)