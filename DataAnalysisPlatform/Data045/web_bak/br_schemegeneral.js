/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:34:18.9
*/
gx.evt.autoSkip=!1;gx.define("br_schemegeneral",!0,function(n){this.ServerClass="br_schemegeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Br_schemeid=function(){try{var n=gx.util.balloon.getNew("BR_SCHEMEID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e136g2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e146g2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40];this.GXLastCtrlId=40;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLE",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"TRANSACTIONDETAIL_TABLEATTRIBUTES",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"",grid:0};t[14]={id:14,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_CHEM_REGIMENS",gxz:"Z328BR_Scheme_Chem_Regimens",gxold:"O328BR_Scheme_Chem_Regimens",gxvar:"A328BR_Scheme_Chem_Regimens",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A328BR_Scheme_Chem_Regimens=n)},v2z:function(n){n!==undefined&&(gx.O.Z328BR_Scheme_Chem_Regimens=n)},v2c:function(){gx.fn.setControlValue("BR_SCHEME_CHEM_REGIMENS",gx.O.A328BR_Scheme_Chem_Regimens,0)},c2v:function(){this.val()!==undefined&&(gx.O.A328BR_Scheme_Chem_Regimens=this.val())},val:function(){return gx.fn.getControlValue("BR_SCHEME_CHEM_REGIMENS")},nac:gx.falseFn};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_THERAPY_LINE",gxz:"Z329BR_Scheme_Therapy_Line",gxold:"O329BR_Scheme_Therapy_Line",gxvar:"A329BR_Scheme_Therapy_Line",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A329BR_Scheme_Therapy_Line=n)},v2z:function(n){n!==undefined&&(gx.O.Z329BR_Scheme_Therapy_Line=n)},v2c:function(){gx.fn.setControlValue("BR_SCHEME_THERAPY_LINE",gx.O.A329BR_Scheme_Therapy_Line,0)},c2v:function(){this.val()!==undefined&&(gx.O.A329BR_Scheme_Therapy_Line=this.val())},val:function(){return gx.fn.getControlValue("BR_SCHEME_THERAPY_LINE")},nac:gx.falseFn};t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"UNNAMEDTABLEBR_SCHEME_CHEM_CYCLE",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,fld:"",grid:0};t[24]={id:24,fld:"TEXTBLOCKBR_SCHEME_CHEM_CYCLE",format:0,grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,lvl:0,type:"decimal",len:15,dec:5,sign:!1,pic:"ZZZZZZZZZ.ZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_CHEM_CYCLE",gxz:"Z330BR_Scheme_Chem_Cycle",gxold:"O330BR_Scheme_Chem_Cycle",gxvar:"A330BR_Scheme_Chem_Cycle",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A330BR_Scheme_Chem_Cycle=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z330BR_Scheme_Chem_Cycle=gx.fn.toDecimalValue(n,",","."))},v2c:function(){gx.fn.setDecimalValue("BR_SCHEME_CHEM_CYCLE",gx.O.A330BR_Scheme_Chem_Cycle,5,".");typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A330BR_Scheme_Chem_Cycle=this.val())},val:function(){return gx.fn.getDecimalValue("BR_SCHEME_CHEM_CYCLE",",",".")},nac:gx.falseFn};this.declareDomainHdlr(27,function(){});t[28]={id:28,fld:"",grid:0};t[29]={id:29,fld:"UNNAMEDTABLEBR_SCHEME_CHEM_DETAIL",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"TEXTBLOCKBR_SCHEME_CHEM_DETAIL",format:0,grid:0};t[33]={id:33,fld:"",grid:0};t[34]={id:34,fld:"",grid:0};t[35]={id:35,lvl:0,type:"svchar",len:4e3,dec:0,sign:!1,ro:1,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_CHEM_DETAIL",gxz:"Z331BR_Scheme_Chem_Detail",gxold:"O331BR_Scheme_Chem_Detail",gxvar:"A331BR_Scheme_Chem_Detail",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A331BR_Scheme_Chem_Detail=n)},v2z:function(n){n!==undefined&&(gx.O.Z331BR_Scheme_Chem_Detail=n)},v2c:function(){gx.fn.setControlValue("BR_SCHEME_CHEM_DETAIL",gx.O.A331BR_Scheme_Chem_Detail,0)},c2v:function(){this.val()!==undefined&&(gx.O.A331BR_Scheme_Chem_Detail=this.val())},val:function(){return gx.fn.getControlValue("BR_SCHEME_CHEM_DETAIL")},nac:gx.falseFn};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"",grid:0};t[38]={id:38,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};t[39]={id:39,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_schemeid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEMEID",gxz:"Z327BR_SchemeID",gxold:"O327BR_SchemeID",gxvar:"A327BR_SchemeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A327BR_SchemeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z327BR_SchemeID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_SCHEMEID",gx.O.A327BR_SchemeID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A327BR_SchemeID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_SCHEMEID",",")},nac:gx.falseFn};this.declareDomainHdlr(39,function(){});t[40]={id:40,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A19BR_EncounterID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z19BR_EncounterID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A19BR_EncounterID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",",")},nac:gx.falseFn};this.declareDomainHdlr(40,function(){});this.A328BR_Scheme_Chem_Regimens="";this.Z328BR_Scheme_Chem_Regimens="";this.O328BR_Scheme_Chem_Regimens="";this.A329BR_Scheme_Therapy_Line="";this.Z329BR_Scheme_Therapy_Line="";this.O329BR_Scheme_Therapy_Line="";this.A330BR_Scheme_Chem_Cycle=0;this.Z330BR_Scheme_Chem_Cycle=0;this.O330BR_Scheme_Chem_Cycle=0;this.A331BR_Scheme_Chem_Detail="";this.Z331BR_Scheme_Chem_Detail="";this.O331BR_Scheme_Chem_Detail="";this.A327BR_SchemeID=0;this.Z327BR_SchemeID=0;this.O327BR_SchemeID=0;this.A19BR_EncounterID=0;this.Z19BR_EncounterID=0;this.O19BR_EncounterID=0;this.A328BR_Scheme_Chem_Regimens="";this.A329BR_Scheme_Therapy_Line="";this.A330BR_Scheme_Chem_Cycle=0;this.A331BR_Scheme_Chem_Detail="";this.A327BR_SchemeID=0;this.A19BR_EncounterID=0;this.Events={e136g2_client:["ENTER",!0],e146g2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"AV18Pgmname",fld:"vPGMNAME",pic:""},{av:"AV8BR_SchemeID",fld:"vBR_SCHEMEID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[]];this.EvtParms.LOAD=[[],[{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Visible")',ctrl:"BR_SCHEMEID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Visible")',ctrl:"BR_ENCOUNTERID",prop:"Visible"}]];this.Initialize()})