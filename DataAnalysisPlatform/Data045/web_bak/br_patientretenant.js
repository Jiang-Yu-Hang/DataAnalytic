/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:39:6.20
*/
gx.evt.autoSkip=!1;gx.define("br_patientretenant",!1,function(){this.ServerClass="br_patientretenant";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Br_information_id=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Br_information_id",["gx.num.urlDecimal(gx.O.A85BR_Information_ID,',','.')"],[]),!0};this.Valid_Bas_tenanttenantcode=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Bas_tenanttenantcode",["gx.num.urlDecimal(gx.O.A85BR_Information_ID,',','.')","gx.O.A360BAS_TenantTenantCode"],["Gx_mode","Z85BR_Information_ID","Z360BAS_TenantTenantCode",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.e111m64_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e121m64_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42];this.GXLastCtrlId=42;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"TABLEMAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLE",format:0,grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"BTN_FIRST",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"BTN_PREVIOUS",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"BTN_NEXT",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"BTN_LAST",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"BTN_SELECT",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_information_id,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_ID",gxz:"Z85BR_Information_ID",gxold:"O85BR_Information_ID",gxvar:"A85BR_Information_ID",ucs:[],op:[],ip:[28],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A85BR_Information_ID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z85BR_Information_ID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_INFORMATION_ID",gx.O.A85BR_Information_ID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A85BR_Information_ID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_INFORMATION_ID",",")},nac:gx.falseFn};this.declareDomainHdlr(28,function(){});n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,lvl:0,type:"svchar",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bas_tenanttenantcode,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BAS_TENANTTENANTCODE",gxz:"Z360BAS_TenantTenantCode",gxold:"O360BAS_TenantTenantCode",gxvar:"A360BAS_TenantTenantCode",ucs:[],op:[],ip:[33,28],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A360BAS_TenantTenantCode=n)},v2z:function(n){n!==undefined&&(gx.O.Z360BAS_TenantTenantCode=n)},v2c:function(){gx.fn.setControlValue("BAS_TENANTTENANTCODE",gx.O.A360BAS_TenantTenantCode,0)},c2v:function(){this.val()!==undefined&&(gx.O.A360BAS_TenantTenantCode=this.val())},val:function(){return gx.fn.getControlValue("BAS_TENANTTENANTCODE")},nac:gx.falseFn};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"BTN_ENTER",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"BTN_CANCEL",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"BTN_DELETE",grid:0};this.A85BR_Information_ID=0;this.Z85BR_Information_ID=0;this.O85BR_Information_ID=0;this.A360BAS_TenantTenantCode="";this.Z360BAS_TenantTenantCode="";this.O360BAS_TenantTenantCode="";this.A85BR_Information_ID=0;this.A360BAS_TenantTenantCode="";this.Events={e111m64_client:["ENTER",!0],e121m64_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.Initialize()});gx.createParentObj(br_patientretenant)