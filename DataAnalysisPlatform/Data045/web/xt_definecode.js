/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:7:37.13
*/
gx.evt.autoSkip=!1;gx.define("xt_definecode",!1,function(){var n,t;this.ServerClass="xt_definecode";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7XT_DefineCodeID=gx.fn.getIntegerValue("vXT_DEFINECODEID",",");this.AV13Insert_XT_DefindcodeTypeID=gx.fn.getIntegerValue("vINSERT_XT_DEFINDCODETYPEID",",");this.A431XT_TypeCode=gx.fn.getControlValue("XT_TYPECODE");this.A432XT_TenantCode=gx.fn.getControlValue("XT_TENANTCODE");this.A510XT_DefineCodeIntialType=gx.fn.getIntegerValue("XT_DEFINECODEINTIALTYPE",",");this.AV15Pgmname=gx.fn.getControlValue("vPGMNAME");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV11TrnContext=gx.fn.getControlValue("vTRNCONTEXT")};this.Valid_Xt_definecodeid=function(){try{var n=gx.util.balloon.getNew("XT_DEFINECODEID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Xt_definecodename=function(){try{var n=gx.util.balloon.getNew("XT_DEFINECODENAME");if(this.AnyError=0,""==this.A168XT_DefineCodeName)try{n.setError("数据字典名称是必须填写的。");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Xt_defindcodetypeid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Xt_defindcodetypeid",["gx.num.urlDecimal(gx.O.A165XT_DefindcodeTypeID,',','.')","gx.O.A166XT_DefindcodeTypeName"],["A166XT_DefindcodeTypeName"]),!0};this.e120n2_client=function(){return this.executeServerEvent("AFTER TRN",!0,null,!1,!1)};this.e130n24_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e140n24_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48];this.GXLastCtrlId=48;this.DVPANEL_TABLEATTRIBUTESContainer=gx.uc.getNew(this,16,0,"BootstrapPanel","DVPANEL_TABLEATTRIBUTESContainer","Dvpanel_tableattributes","DVPANEL_TABLEATTRIBUTES");t=this.DVPANEL_TABLEATTRIBUTESContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Width","Width","100%","str");t.setProp("Height","Height","100","str");t.setProp("AutoWidth","Autowidth",!1,"bool");t.setProp("AutoHeight","Autoheight",!0,"bool");t.setProp("Cls","Cls","PanelCard_BaseColor","str");t.setProp("ShowHeader","Showheader",!0,"bool");t.setProp("Title","Title","数据字典信息","str");t.setProp("Collapsible","Collapsible",!1,"bool");t.setProp("Collapsed","Collapsed",!1,"bool");t.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");t.setProp("IconPosition","Iconposition","left","str");t.setProp("AutoScroll","Autoscroll",!1,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"TABLECONTENT",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};n[18]={id:18,fld:"LAYOUT_TABLEATTRIBUTES",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"TABLEATTRIBUTES",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Xt_definecodename,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_DEFINECODENAME",gxz:"Z168XT_DefineCodeName",gxold:"O168XT_DefineCodeName",gxvar:"A168XT_DefineCodeName",ucs:[],op:[25],ip:[25],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A168XT_DefineCodeName=n)},v2z:function(n){n!==undefined&&(gx.O.Z168XT_DefineCodeName=n)},v2c:function(){gx.fn.setControlValue("XT_DEFINECODENAME",gx.O.A168XT_DefineCodeName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A168XT_DefineCodeName=this.val())},val:function(){return gx.fn.getControlValue("XT_DEFINECODENAME")},nac:gx.falseFn};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Xt_defindcodetypeid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_DEFINDCODETYPEID",gxz:"Z165XT_DefindcodeTypeID",gxold:"O165XT_DefindcodeTypeID",gxvar:"A165XT_DefindcodeTypeID",ucs:[],op:[30,35],ip:[35,30],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A165XT_DefindcodeTypeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z165XT_DefindcodeTypeID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("XT_DEFINDCODETYPEID",gx.O.A165XT_DefindcodeTypeID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A165XT_DefindcodeTypeID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("XT_DEFINDCODETYPEID",",")},nac:function(){return this.Gx_mode=="INS"&&!(0==this.AV13Insert_XT_DefindcodeTypeID)}};this.declareDomainHdlr(30,function(){});n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_DEFINDCODETYPENAME",gxz:"Z166XT_DefindcodeTypeName",gxold:"O166XT_DefindcodeTypeName",gxvar:"A166XT_DefindcodeTypeName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A166XT_DefindcodeTypeName=n)},v2z:function(n){n!==undefined&&(gx.O.Z166XT_DefindcodeTypeName=n)},v2c:function(){gx.fn.setControlValue("XT_DEFINDCODETYPENAME",gx.O.A166XT_DefindcodeTypeName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A166XT_DefindcodeTypeName=this.val())},val:function(){return gx.fn.getControlValue("XT_DEFINDCODETYPENAME")},nac:gx.falseFn};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"BTNTRN_ENTER",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"BTNTRN_CANCEL",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};n[46]={id:46,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Xt_definecodeid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_DEFINECODEID",gxz:"Z167XT_DefineCodeID",gxold:"O167XT_DefineCodeID",gxvar:"A167XT_DefineCodeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A167XT_DefineCodeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z167XT_DefineCodeID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("XT_DEFINECODEID",gx.O.A167XT_DefineCodeID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A167XT_DefineCodeID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("XT_DEFINECODEID",",")},nac:gx.falseFn};this.declareDomainHdlr(46,function(){});n[47]={id:47,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_DEFINECODEORDER",gxz:"Z171XT_DefineCodeOrder",gxold:"O171XT_DefineCodeOrder",gxvar:"A171XT_DefineCodeOrder",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A171XT_DefineCodeOrder=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z171XT_DefineCodeOrder=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("XT_DEFINECODEORDER",gx.O.A171XT_DefineCodeOrder,0)},c2v:function(){this.val()!==undefined&&(gx.O.A171XT_DefineCodeOrder=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("XT_DEFINECODEORDER",",")},nac:gx.falseFn};n[48]={id:48,fld:"PROMPT_165",grid:24};this.A168XT_DefineCodeName="";this.Z168XT_DefineCodeName="";this.O168XT_DefineCodeName="";this.A165XT_DefindcodeTypeID=0;this.Z165XT_DefindcodeTypeID=0;this.O165XT_DefindcodeTypeID=0;this.A166XT_DefindcodeTypeName="";this.Z166XT_DefindcodeTypeName="";this.O166XT_DefindcodeTypeName="";this.A167XT_DefineCodeID=0;this.Z167XT_DefineCodeID=0;this.O167XT_DefineCodeID=0;this.A171XT_DefineCodeOrder=0;this.Z171XT_DefineCodeOrder=0;this.O171XT_DefineCodeOrder=0;this.AV8WWPContext={UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""};this.AV9IsAuthorized=!1;this.AV15Pgmname="";this.AV11TrnContext={CallerObject:"",CallerOnDelete:!1,CallerURL:"",TransactionName:"",Attributes:[]};this.AV16GXV1=0;this.AV13Insert_XT_DefindcodeTypeID=0;this.AV14TrnContextAtt={AttributeName:"",AttributeValue:""};this.AV7XT_DefineCodeID=0;this.AV12WebSession={};this.A167XT_DefineCodeID=0;this.A165XT_DefindcodeTypeID=0;this.A168XT_DefineCodeName="";this.A166XT_DefindcodeTypeName="";this.A171XT_DefineCodeOrder=0;this.A431XT_TypeCode="";this.A432XT_TenantCode="";this.A510XT_DefineCodeIntialType=0;this.Gx_mode="";this.Events={e120n2_client:["AFTER TRN",!0],e130n24_client:["ENTER",!0],e140n24_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7XT_DefineCodeID",fld:"vXT_DEFINECODEID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[]];this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7XT_DefineCodeID",fld:"vXT_DEFINECODEID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"A167XT_DefineCodeID",fld:"XT_DEFINECODEID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV13Insert_XT_DefindcodeTypeID",fld:"vINSERT_XT_DEFINDCODETYPEID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"A431XT_TypeCode",fld:"XT_TYPECODE",pic:""},{av:"A432XT_TenantCode",fld:"XT_TENANTCODE",pic:""},{av:"A510XT_DefineCodeIntialType",fld:"XT_DEFINECODEINTIALTYPE",pic:"ZZZ9"}],[]];this.EvtParms.START=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV15Pgmname",fld:"vPGMNAME",pic:""}],[{av:"AV8WWPContext",fld:"vWWPCONTEXT",pic:""},{av:"AV9IsAuthorized",fld:"vISAUTHORIZED",pic:""},{av:"AV11TrnContext",fld:"vTRNCONTEXT",pic:""},{av:"AV16GXV1",fld:"vGXV1",pic:"99999999"},{av:"AV14TrnContextAtt",fld:"vTRNCONTEXTATT",pic:""},{av:"AV13Insert_XT_DefindcodeTypeID",fld:"vINSERT_XT_DEFINDCODETYPEID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:'gx.fn.getCtrlProperty("XT_DEFINECODEID","Visible")',ctrl:"XT_DEFINECODEID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("XT_DEFINECODEORDER","Visible")',ctrl:"XT_DEFINECODEORDER",prop:"Visible"}]];this.EvtParms["AFTER TRN"]=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV11TrnContext",fld:"vTRNCONTEXT",pic:""}],[]];this.setPrompt("PROMPT_165",[30]);this.EnterCtrl=["BTNTRN_ENTER"];this.setVCMap("AV7XT_DefineCodeID","vXT_DEFINECODEID",0,"int",18,0);this.setVCMap("AV13Insert_XT_DefindcodeTypeID","vINSERT_XT_DEFINDCODETYPEID",0,"int",18,0);this.setVCMap("A431XT_TypeCode","XT_TYPECODE",0,"svchar",40,0);this.setVCMap("A432XT_TenantCode","XT_TENANTCODE",0,"svchar",40,0);this.setVCMap("A510XT_DefineCodeIntialType","XT_DEFINECODEINTIALTYPE",0,"int",4,0);this.setVCMap("AV15Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.setVCMap("AV11TrnContext","vTRNCONTEXT",0,"WWPBaseObjectsWWPTransactionContext",0,0);this.Initialize()});gx.createParentObj(xt_definecode)