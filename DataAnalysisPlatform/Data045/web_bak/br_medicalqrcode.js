/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:46:7.72
*/
gx.evt.autoSkip=!1;gx.define("br_medicalqrcode",!1,function(){this.ServerClass="br_medicalqrcode";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV5iBR_MedicalImagingID=gx.fn.getIntegerValue("vIBR_MEDICALIMAGINGID",",")};this.e126t2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e146t1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,6,9,10];this.GXLastCtrlId=10;n[2]={id:2,fld:"TABLE1",grid:0};n[6]={id:6,lvl:0,type:"bits",len:1024,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vCODE",gxz:"ZV12code",gxold:"OV12code",gxvar:"AV12code",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12code=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12code=n)},v2c:function(){gx.fn.setMultimediaValue("vCODE",gx.O.AV12code,gx.O.AV20Code_GXI)},c2v:function(){gx.O.AV20Code_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV12code=this.val())},val:function(){return gx.fn.getBlobValue("vCODE")},val_GXI:function(){return gx.fn.getControlValue("vCODE_GXI")},gxvar_GXI:"AV20Code_GXI",nac:gx.falseFn};n[9]={id:9,fld:"BUTTON1",grid:0};n[10]={id:10,fld:"BUTTON2",grid:0};this.AV20Code_GXI="";this.AV12code="";this.ZV12code="";this.OV12code="";this.AV12code="";this.AV5iBR_MedicalImagingID=0;this.Events={e126t2_client:["ENTER",!0],e146t1_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"AV5iBR_MedicalImagingID",fld:"vIBR_MEDICALIMAGINGID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[]];this.EvtParms.START=[[{av:"AV5iBR_MedicalImagingID",fld:"vIBR_MEDICALIMAGINGID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[{ctrl:"EMBPAGE1",prop:"Source"}]];this.EvtParms.ENTER=[[],[]];this.EnterCtrl=["BUTTON1"];this.setVCMap("AV5iBR_MedicalImagingID","vIBR_MEDICALIMAGINGID",0,"int",18,0);this.Initialize()});gx.createParentObj(br_medicalqrcode)