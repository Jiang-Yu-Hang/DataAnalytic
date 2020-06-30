/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:34:32.55
*/
gx.evt.autoSkip=!1;gx.define("br_pathology_diaggeneral",!0,function(n){this.ServerClass="br_pathology_diaggeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Br_pathology_diagid=function(){try{var n=gx.util.balloon.getNew("BR_PATHOLOGY_DIAGID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e13592_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e14592_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57];this.GXLastCtrlId=57;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLE",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"TRANSACTIONDETAIL_TABLEATTRIBUTES",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"UNNAMEDTABLEBR_PATHOLOGY_DIAG_LOC",grid:0};t[13]={id:13,fld:"",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,fld:"TEXTBLOCKBR_PATHOLOGY_DIAG_LOC",format:0,grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_LOC",gxz:"Z277BR_Pathology_Diag_Loc",gxold:"O277BR_Pathology_Diag_Loc",gxvar:"A277BR_Pathology_Diag_Loc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A277BR_Pathology_Diag_Loc=n)},v2z:function(n){n!==undefined&&(gx.O.Z277BR_Pathology_Diag_Loc=n)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAG_LOC",gx.O.A277BR_Pathology_Diag_Loc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A277BR_Pathology_Diag_Loc=this.val())},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_DIAG_LOC")},nac:gx.falseFn};t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"UNNAMEDTABLEBR_PATHOLOGY_DIAG_ORGAN",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,fld:"TEXTBLOCKBR_PATHOLOGY_DIAG_ORGAN",format:0,grid:0};t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_ORGAN",gxz:"Z278BR_Pathology_Diag_Organ",gxold:"O278BR_Pathology_Diag_Organ",gxvar:"A278BR_Pathology_Diag_Organ",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A278BR_Pathology_Diag_Organ=n)},v2z:function(n){n!==undefined&&(gx.O.Z278BR_Pathology_Diag_Organ=n)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAG_ORGAN",gx.O.A278BR_Pathology_Diag_Organ,0)},c2v:function(){this.val()!==undefined&&(gx.O.A278BR_Pathology_Diag_Organ=this.val())},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_DIAG_ORGAN")},nac:gx.falseFn};t[27]={id:27,fld:"",grid:0};t[28]={id:28,fld:"",grid:0};t[29]={id:29,fld:"UNNAMEDTABLEBR_PATHOLOGY_DIAG_TUMORTYPE",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"TEXTBLOCKBR_PATHOLOGY_DIAG_TUMORTYPE",format:0,grid:0};t[33]={id:33,fld:"",grid:0};t[34]={id:34,fld:"",grid:0};t[35]={id:35,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_TUMORTYPE",gxz:"Z279BR_Pathology_Diag_TumorType",gxold:"O279BR_Pathology_Diag_TumorType",gxvar:"A279BR_Pathology_Diag_TumorType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A279BR_Pathology_Diag_TumorType=n)},v2z:function(n){n!==undefined&&(gx.O.Z279BR_Pathology_Diag_TumorType=n)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAG_TUMORTYPE",gx.O.A279BR_Pathology_Diag_TumorType,0)},c2v:function(){this.val()!==undefined&&(gx.O.A279BR_Pathology_Diag_TumorType=this.val())},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_DIAG_TUMORTYPE")},nac:gx.falseFn};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"UNNAMEDTABLEBR_PATHOLOGY_DIAG_TUMORSTAGE",grid:0};t[38]={id:38,fld:"",grid:0};t[39]={id:39,fld:"",grid:0};t[40]={id:40,fld:"TEXTBLOCKBR_PATHOLOGY_DIAG_TUMORSTAGE",format:0,grid:0};t[41]={id:41,fld:"",grid:0};t[42]={id:42,fld:"",grid:0};t[43]={id:43,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_TUMORSTAGE",gxz:"Z280BR_Pathology_Diag_TumorStage",gxold:"O280BR_Pathology_Diag_TumorStage",gxvar:"A280BR_Pathology_Diag_TumorStage",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A280BR_Pathology_Diag_TumorStage=n)},v2z:function(n){n!==undefined&&(gx.O.Z280BR_Pathology_Diag_TumorStage=n)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAG_TUMORSTAGE",gx.O.A280BR_Pathology_Diag_TumorStage,0)},c2v:function(){this.val()!==undefined&&(gx.O.A280BR_Pathology_Diag_TumorStage=this.val())},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_DIAG_TUMORSTAGE")},nac:gx.falseFn};t[44]={id:44,fld:"",grid:0};t[45]={id:45,fld:"",grid:0};t[46]={id:46,fld:"UNNAMEDTABLEBR_PATHOLOGY_DIAG_TUMORGRADE",grid:0};t[47]={id:47,fld:"",grid:0};t[48]={id:48,fld:"",grid:0};t[49]={id:49,fld:"TEXTBLOCKBR_PATHOLOGY_DIAG_TUMORGRADE",format:0,grid:0};t[50]={id:50,fld:"",grid:0};t[51]={id:51,fld:"",grid:0};t[52]={id:52,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_TUMORGRADE",gxz:"Z281BR_Pathology_Diag_TumorGrade",gxold:"O281BR_Pathology_Diag_TumorGrade",gxvar:"A281BR_Pathology_Diag_TumorGrade",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A281BR_Pathology_Diag_TumorGrade=n)},v2z:function(n){n!==undefined&&(gx.O.Z281BR_Pathology_Diag_TumorGrade=n)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAG_TUMORGRADE",gx.O.A281BR_Pathology_Diag_TumorGrade,0)},c2v:function(){this.val()!==undefined&&(gx.O.A281BR_Pathology_Diag_TumorGrade=this.val())},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_DIAG_TUMORGRADE")},nac:gx.falseFn};t[53]={id:53,fld:"",grid:0};t[54]={id:54,fld:"",grid:0};t[55]={id:55,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};t[56]={id:56,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_pathology_diagid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAGID",gxz:"Z276BR_Pathology_DiagID",gxold:"O276BR_Pathology_DiagID",gxvar:"A276BR_Pathology_DiagID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A276BR_Pathology_DiagID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z276BR_Pathology_DiagID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAGID",gx.O.A276BR_Pathology_DiagID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A276BR_Pathology_DiagID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGY_DIAGID",",")},nac:gx.falseFn};this.declareDomainHdlr(56,function(){});t[57]={id:57,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGYID",gxz:"Z226BR_PathologyID",gxold:"O226BR_PathologyID",gxvar:"A226BR_PathologyID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A226BR_PathologyID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z226BR_PathologyID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGYID",gx.O.A226BR_PathologyID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A226BR_PathologyID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGYID",",")},nac:gx.falseFn};this.declareDomainHdlr(57,function(){});this.A277BR_Pathology_Diag_Loc="";this.Z277BR_Pathology_Diag_Loc="";this.O277BR_Pathology_Diag_Loc="";this.A278BR_Pathology_Diag_Organ="";this.Z278BR_Pathology_Diag_Organ="";this.O278BR_Pathology_Diag_Organ="";this.A279BR_Pathology_Diag_TumorType="";this.Z279BR_Pathology_Diag_TumorType="";this.O279BR_Pathology_Diag_TumorType="";this.A280BR_Pathology_Diag_TumorStage="";this.Z280BR_Pathology_Diag_TumorStage="";this.O280BR_Pathology_Diag_TumorStage="";this.A281BR_Pathology_Diag_TumorGrade="";this.Z281BR_Pathology_Diag_TumorGrade="";this.O281BR_Pathology_Diag_TumorGrade="";this.A276BR_Pathology_DiagID=0;this.Z276BR_Pathology_DiagID=0;this.O276BR_Pathology_DiagID=0;this.A226BR_PathologyID=0;this.Z226BR_PathologyID=0;this.O226BR_PathologyID=0;this.A277BR_Pathology_Diag_Loc="";this.A278BR_Pathology_Diag_Organ="";this.A279BR_Pathology_Diag_TumorType="";this.A280BR_Pathology_Diag_TumorStage="";this.A281BR_Pathology_Diag_TumorGrade="";this.A276BR_Pathology_DiagID=0;this.A226BR_PathologyID=0;this.Events={e13592_client:["ENTER",!0],e14592_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"AV16Pgmname",fld:"vPGMNAME",pic:""},{av:"AV8BR_Pathology_DiagID",fld:"vBR_PATHOLOGY_DIAGID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[]];this.EvtParms.LOAD=[[],[{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAGID","Visible")',ctrl:"BR_PATHOLOGY_DIAGID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID","Visible")',ctrl:"BR_PATHOLOGYID",prop:"Visible"}]];this.Initialize()})