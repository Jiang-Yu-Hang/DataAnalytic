/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:7:39.13
*/
gx.evt.autoSkip=!1;gx.define("jc_providersecuser",!1,function(){this.ServerClass="jc_providersecuser";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Secuserid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Secuserid",["gx.O.A6SecUserId","gx.O.A14SecUserName"],["A14SecUserName"]),!0};this.Valid_Jc_providerid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Jc_providerid",["gx.O.A6SecUserId","gx.num.urlDecimal(gx.O.A87JC_ProviderID,',','.')","gx.O.A89JC_ProviderName"],["A14SecUserName","A89JC_ProviderName","Gx_mode","Z6SecUserId","Z87JC_ProviderID","Z14SecUserName","Z89JC_ProviderName",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.e110p26_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e120p26_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52];this.GXLastCtrlId=52;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"TABLEMAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLE",format:0,grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"BTN_FIRST",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"BTN_PREVIOUS",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"BTN_NEXT",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"BTN_LAST",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"BTN_SELECT",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Secuserid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERID",gxz:"Z6SecUserId",gxold:"O6SecUserId",gxvar:"A6SecUserId",ucs:[],op:[38],ip:[38,28],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A6SecUserId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z6SecUserId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("SECUSERID",gx.O.A6SecUserId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A6SecUserId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("SECUSERID",",")},nac:gx.falseFn};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Jc_providerid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERID",gxz:"Z87JC_ProviderID",gxold:"O87JC_ProviderID",gxvar:"A87JC_ProviderID",ucs:[],op:[43],ip:[43,33,28],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A87JC_ProviderID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z87JC_ProviderID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("JC_PROVIDERID",gx.O.A87JC_ProviderID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A87JC_ProviderID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("JC_PROVIDERID",",")},nac:gx.falseFn};this.declareDomainHdlr(33,function(){});n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERNAME",gxz:"Z14SecUserName",gxold:"O14SecUserName",gxvar:"A14SecUserName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A14SecUserName=n)},v2z:function(n){n!==undefined&&(gx.O.Z14SecUserName=n)},v2c:function(){gx.fn.setControlValue("SECUSERNAME",gx.O.A14SecUserName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A14SecUserName=this.val())},val:function(){return gx.fn.getControlValue("SECUSERNAME")},nac:gx.falseFn};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,lvl:0,type:"svchar",len:200,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERNAME",gxz:"Z89JC_ProviderName",gxold:"O89JC_ProviderName",gxvar:"A89JC_ProviderName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A89JC_ProviderName=n)},v2z:function(n){n!==undefined&&(gx.O.Z89JC_ProviderName=n)},v2c:function(){gx.fn.setControlValue("JC_PROVIDERNAME",gx.O.A89JC_ProviderName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A89JC_ProviderName=this.val())},val:function(){return gx.fn.getControlValue("JC_PROVIDERNAME")},nac:gx.falseFn};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"BTN_ENTER",grid:0};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"BTN_CANCEL",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"BTN_DELETE",grid:0};this.A6SecUserId=0;this.Z6SecUserId=0;this.O6SecUserId=0;this.A87JC_ProviderID=0;this.Z87JC_ProviderID=0;this.O87JC_ProviderID=0;this.A14SecUserName="";this.Z14SecUserName="";this.O14SecUserName="";this.A89JC_ProviderName="";this.Z89JC_ProviderName="";this.O89JC_ProviderName="";this.A6SecUserId=0;this.A87JC_ProviderID=0;this.A14SecUserName="";this.A89JC_ProviderName="";this.Events={e110p26_client:["ENTER",!0],e120p26_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.Initialize()});gx.createParentObj(jc_providersecuser)