/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:48:2.77
*/
gx.evt.autoSkip=!1;gx.define("webpanel2",!1,function(){this.ServerClass="webpanel2";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.e11a62_client=function(){return this.executeServerEvent("'TEST1'",!1,null,!1,!1)};this.e12a62_client=function(){return this.executeServerEvent("'TEST2'",!1,null,!1,!1)};this.e13a62_client=function(){return this.executeServerEvent("'GENERATE'",!1,null,!1,!1)};this.e15a62_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e16a62_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,5,7,10,12,15,17,18,19,20,21];this.GXLastCtrlId=21;n[2]={id:2,fld:"TABLE1",grid:0};n[5]={id:5,fld:"TEXTBLOCK1",format:0,grid:0};n[7]={id:7,lvl:0,type:"svchar",len:400,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVCONTENT",gxz:"ZV5vContent",gxold:"OV5vContent",gxvar:"AV5vContent",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV5vContent=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5vContent=n)},v2c:function(){gx.fn.setControlValue("vVCONTENT",gx.O.AV5vContent,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV5vContent=this.val())},val:function(){return gx.fn.getControlValue("vVCONTENT")},nac:gx.falseFn};n[10]={id:10,fld:"TEXTBLOCK2",format:0,grid:0};n[12]={id:12,lvl:0,type:"svchar",len:400,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVCONTENT1",gxz:"ZV6vContent1",gxold:"OV6vContent1",gxvar:"AV6vContent1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6vContent1=n)},v2z:function(n){n!==undefined&&(gx.O.ZV6vContent1=n)},v2c:function(){gx.fn.setControlValue("vVCONTENT1",gx.O.AV6vContent1,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6vContent1=this.val())},val:function(){return gx.fn.getControlValue("vVCONTENT1")},nac:gx.falseFn};n[15]={id:15,fld:"TEXTBLOCK3",format:0,grid:0};n[17]={id:17,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVPASSWORD",gxz:"ZV7vPassword",gxold:"OV7vPassword",gxvar:"AV7vPassword",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7vPassword=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7vPassword=n)},v2c:function(){gx.fn.setControlValue("vVPASSWORD",gx.O.AV7vPassword,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7vPassword=this.val())},val:function(){return gx.fn.getControlValue("vVPASSWORD")},nac:gx.falseFn};n[18]={id:18,fld:"BUTTON1",grid:0};n[19]={id:19,fld:"BUTTON2",grid:0};n[20]={id:20,fld:"BUTTON3",grid:0};n[21]={id:21,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vEN_KEY",gxz:"ZV15en_key",gxold:"OV15en_key",gxvar:"AV15en_key",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV15en_key=n)},v2z:function(n){n!==undefined&&(gx.O.ZV15en_key=n)},v2c:function(){gx.fn.setControlValue("vEN_KEY",gx.O.AV15en_key,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV15en_key=this.val())},val:function(){return gx.fn.getControlValue("vEN_KEY")},nac:gx.falseFn};this.AV5vContent="";this.ZV5vContent="";this.OV5vContent="";this.AV6vContent1="";this.ZV6vContent1="";this.OV6vContent1="";this.AV7vPassword="";this.ZV7vPassword="";this.OV7vPassword="";this.AV15en_key="";this.ZV15en_key="";this.OV15en_key="";this.AV5vContent="";this.AV6vContent1="";this.AV7vPassword="";this.AV15en_key="";this.Events={e11a62_client:["'TEST1'",!0],e12a62_client:["'TEST2'",!0],e13a62_client:["'GENERATE'",!0],e15a62_client:["ENTER",!0],e16a62_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms["'TEST1'"]=[[{av:"AV5vContent",fld:"vVCONTENT",pic:""}],[{av:"AV6vContent1",fld:"vVCONTENT1",pic:""}]];this.EvtParms["'TEST2'"]=[[{av:"AV5vContent",fld:"vVCONTENT",pic:""}],[{av:"AV6vContent1",fld:"vVCONTENT1",pic:""}]];this.EvtParms["'GENERATE'"]=[[],[{av:"AV15en_key",fld:"vEN_KEY",pic:""}]];this.Initialize()});gx.createParentObj(webpanel2)