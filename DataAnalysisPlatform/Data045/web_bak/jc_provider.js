/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:37:5.87
*/
gx.evt.autoSkip=!1;gx.define("jc_provider",!1,function(){var n,t;this.ServerClass="jc_provider";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV13JC_ProviderID=gx.fn.getIntegerValue("vJC_PROVIDERID",",");this.AV14Pgmname=gx.fn.getControlValue("vPGMNAME");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV8TrnContext=gx.fn.getControlValue("vTRNCONTEXT")};this.Valid_Jc_providerid=function(){try{var n=gx.util.balloon.getNew("JC_PROVIDERID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Jc_providername=function(){try{var n=gx.util.balloon.getNew("JC_PROVIDERNAME");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e120k2_client=function(){return this.executeServerEvent("AFTER TRN",!0,null,!1,!1)};this.e130k21_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e140k21_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59];this.GXLastCtrlId=59;this.DVPANEL_TABLEATTRIBUTESContainer=gx.uc.getNew(this,16,0,"BootstrapPanel","DVPANEL_TABLEATTRIBUTESContainer","Dvpanel_tableattributes","DVPANEL_TABLEATTRIBUTES");t=this.DVPANEL_TABLEATTRIBUTESContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Width","Width","100%","str");t.setProp("Height","Height","100","str");t.setProp("AutoWidth","Autowidth",!1,"bool");t.setProp("AutoHeight","Autoheight",!0,"bool");t.setProp("Cls","Cls","PanelCard_BaseColor","str");t.setProp("ShowHeader","Showheader",!0,"bool");t.setProp("Title","Title","鍩虹淇℃伅","str");t.setProp("Collapsible","Collapsible",!1,"bool");t.setProp("Collapsed","Collapsed",!1,"bool");t.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");t.setProp("IconPosition","Iconposition","left","str");t.setProp("AutoScroll","Autoscroll",!1,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"TABLECONTENT",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};n[18]={id:18,fld:"LAYOUT_TABLEATTRIBUTES",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"TABLEATTRIBUTES",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Jc_providerid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERID",gxz:"Z87JC_ProviderID",gxold:"O87JC_ProviderID",gxvar:"A87JC_ProviderID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A87JC_ProviderID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z87JC_ProviderID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("JC_PROVIDERID",gx.O.A87JC_ProviderID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A87JC_ProviderID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("JC_PROVIDERID",",")},nac:gx.falseFn};this.declareDomainHdlr(25,function(){});n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,lvl:0,type:"svchar",len:200,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Jc_providername,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERNAME",gxz:"Z89JC_ProviderName",gxold:"O89JC_ProviderName",gxvar:"A89JC_ProviderName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A89JC_ProviderName=n)},v2z:function(n){n!==undefined&&(gx.O.Z89JC_ProviderName=n)},v2c:function(){gx.fn.setControlValue("JC_PROVIDERNAME",gx.O.A89JC_ProviderName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A89JC_ProviderName=this.val())},val:function(){return gx.fn.getControlValue("JC_PROVIDERNAME")},nac:gx.falseFn};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERSHORTNAME",gxz:"Z160JC_ProviderShortName",gxold:"O160JC_ProviderShortName",gxvar:"A160JC_ProviderShortName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A160JC_ProviderShortName=n)},v2z:function(n){n!==undefined&&(gx.O.Z160JC_ProviderShortName=n)},v2c:function(){gx.fn.setControlValue("JC_PROVIDERSHORTNAME",gx.O.A160JC_ProviderShortName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A160JC_ProviderShortName=this.val())},val:function(){return gx.fn.getControlValue("JC_PROVIDERSHORTNAME")},nac:gx.falseFn};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,lvl:0,type:"svchar",len:1024,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERADDRESSS",gxz:"Z161JC_ProviderAddresss",gxold:"O161JC_ProviderAddresss",gxvar:"A161JC_ProviderAddresss",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A161JC_ProviderAddresss=n)},v2z:function(n){n!==undefined&&(gx.O.Z161JC_ProviderAddresss=n)},v2c:function(){gx.fn.setControlValue("JC_PROVIDERADDRESSS",gx.O.A161JC_ProviderAddresss,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A161JC_ProviderAddresss=this.val())},val:function(){return gx.fn.getControlValue("JC_PROVIDERADDRESSS")},nac:gx.falseFn};this.declareDomainHdlr(40,function(){gx.fn.setCtrlProperty("JC_PROVIDERADDRESSS","Link",gx.fn.getCtrlProperty("JC_PROVIDERADDRESSS","Enabled")?"":"http://maps.google.com/maps?q="+encodeURIComponent(this.A161JC_ProviderAddresss))});n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERPHONE",gxz:"Z162JC_ProviderPhone",gxold:"O162JC_ProviderPhone",gxvar:"A162JC_ProviderPhone",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A162JC_ProviderPhone=n)},v2z:function(n){n!==undefined&&(gx.O.Z162JC_ProviderPhone=n)},v2c:function(){gx.fn.setControlValue("JC_PROVIDERPHONE",gx.O.A162JC_ProviderPhone,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A162JC_ProviderPhone=this.val())},val:function(){return gx.fn.getControlValue("JC_PROVIDERPHONE")},nac:gx.falseFn};this.declareDomainHdlr(45,function(){});n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"",grid:0};n[50]={id:50,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERUSER",gxz:"Z163JC_ProviderUser",gxold:"O163JC_ProviderUser",gxvar:"A163JC_ProviderUser",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A163JC_ProviderUser=n)},v2z:function(n){n!==undefined&&(gx.O.Z163JC_ProviderUser=n)},v2c:function(){gx.fn.setControlValue("JC_PROVIDERUSER",gx.O.A163JC_ProviderUser,0)},c2v:function(){this.val()!==undefined&&(gx.O.A163JC_ProviderUser=this.val())},val:function(){return gx.fn.getControlValue("JC_PROVIDERUSER")},nac:gx.falseFn};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"BTNTRN_ENTER",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"BTNTRN_CANCEL",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"BTNTRN_DELETE",grid:0};this.A87JC_ProviderID=0;this.Z87JC_ProviderID=0;this.O87JC_ProviderID=0;this.A89JC_ProviderName="";this.Z89JC_ProviderName="";this.O89JC_ProviderName="";this.A160JC_ProviderShortName="";this.Z160JC_ProviderShortName="";this.O160JC_ProviderShortName="";this.A161JC_ProviderAddresss="";this.Z161JC_ProviderAddresss="";this.O161JC_ProviderAddresss="";this.A162JC_ProviderPhone="";this.Z162JC_ProviderPhone="";this.O162JC_ProviderPhone="";this.A163JC_ProviderUser="";this.Z163JC_ProviderUser="";this.O163JC_ProviderUser="";this.AV7WWPContext={UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""};this.AV11IsAuthorized=!1;this.AV14Pgmname="";this.AV8TrnContext={CallerObject:"",CallerOnDelete:!1,CallerURL:"",TransactionName:"",Attributes:[]};this.AV13JC_ProviderID=0;this.AV9WebSession={};this.A87JC_ProviderID=0;this.A89JC_ProviderName="";this.A160JC_ProviderShortName="";this.A161JC_ProviderAddresss="";this.A162JC_ProviderPhone="";this.A163JC_ProviderUser="";this.Gx_mode="";this.Events={e120k2_client:["AFTER TRN",!0],e130k21_client:["ENTER",!0],e140k21_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV13JC_ProviderID",fld:"vJC_PROVIDERID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[]];this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV13JC_ProviderID",fld:"vJC_PROVIDERID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"A87JC_ProviderID",fld:"JC_PROVIDERID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[]];this.EvtParms.START=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV14Pgmname",fld:"vPGMNAME",pic:""}],[{av:"AV7WWPContext",fld:"vWWPCONTEXT",pic:""},{av:"AV11IsAuthorized",fld:"vISAUTHORIZED",pic:""},{av:"AV8TrnContext",fld:"vTRNCONTEXT",pic:""}]];this.EvtParms["AFTER TRN"]=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV8TrnContext",fld:"vTRNCONTEXT",pic:""}],[]];this.EnterCtrl=["BTNTRN_ENTER"];this.setVCMap("AV13JC_ProviderID","vJC_PROVIDERID",0,"int",18,0);this.setVCMap("AV14Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.setVCMap("AV8TrnContext","vTRNCONTEXT",0,"WWPBaseObjectsWWPTransactionContext",0,0);this.Initialize()});gx.createParentObj(jc_provider)