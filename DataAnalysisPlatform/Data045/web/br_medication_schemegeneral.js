/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:5:10.43
*/
gx.evt.autoSkip=!1;gx.define("br_medication_schemegeneral",!0,function(n){this.ServerClass="br_medication_schemegeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Br_medication_schemeid=function(){try{var n=gx.util.balloon.getNew("BR_MEDICATION_SCHEMEID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e13502_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e14502_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36];this.GXLastCtrlId=36;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLE",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"TRANSACTIONDETAIL_TABLEATTRIBUTES",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"",grid:0};t[14]={id:14,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_CHEM_NAME",gxz:"Z305BR_Medication_Chem_Name",gxold:"O305BR_Medication_Chem_Name",gxvar:"A305BR_Medication_Chem_Name",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A305BR_Medication_Chem_Name=n)},v2z:function(n){n!==undefined&&(gx.O.Z305BR_Medication_Chem_Name=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_CHEM_NAME",gx.O.A305BR_Medication_Chem_Name,0)},c2v:function(){this.val()!==undefined&&(gx.O.A305BR_Medication_Chem_Name=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_CHEM_NAME")},nac:gx.falseFn};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"decimal",len:15,dec:5,sign:!1,pic:"ZZZZZZZZZ.ZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_CHEM_CYCLE",gxz:"Z306BR_Medication_Chem_Cycle",gxold:"O306BR_Medication_Chem_Cycle",gxvar:"A306BR_Medication_Chem_Cycle",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A306BR_Medication_Chem_Cycle=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z306BR_Medication_Chem_Cycle=gx.fn.toDecimalValue(n,",","."))},v2c:function(){gx.fn.setDecimalValue("BR_MEDICATION_CHEM_CYCLE",gx.O.A306BR_Medication_Chem_Cycle,5,".");typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A306BR_Medication_Chem_Cycle=this.val())},val:function(){return gx.fn.getDecimalValue("BR_MEDICATION_CHEM_CYCLE",",",".")},nac:gx.falseFn};this.declareDomainHdlr(18,function(){});t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_CHEM_LINE",gxz:"Z307BR_Medication_Chem_Line",gxold:"O307BR_Medication_Chem_Line",gxvar:"A307BR_Medication_Chem_Line",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A307BR_Medication_Chem_Line=n)},v2z:function(n){n!==undefined&&(gx.O.Z307BR_Medication_Chem_Line=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_CHEM_LINE",gx.O.A307BR_Medication_Chem_Line,0)},c2v:function(){this.val()!==undefined&&(gx.O.A307BR_Medication_Chem_Line=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_CHEM_LINE")},nac:gx.falseFn};t[23]={id:23,fld:"",grid:0};t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"UNNAMEDTABLEBR_MEDICATION_CHEM_DETAIL",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,fld:"TEXTBLOCKBR_MEDICATION_CHEM_DETAIL",format:0,grid:0};t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_CHEM_DETAIL",gxz:"Z313BR_Medication_Chem_Detail",gxold:"O313BR_Medication_Chem_Detail",gxvar:"A313BR_Medication_Chem_Detail",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A313BR_Medication_Chem_Detail=n)},v2z:function(n){n!==undefined&&(gx.O.Z313BR_Medication_Chem_Detail=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_CHEM_DETAIL",gx.O.A313BR_Medication_Chem_Detail,0)},c2v:function(){this.val()!==undefined&&(gx.O.A313BR_Medication_Chem_Detail=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_CHEM_DETAIL")},nac:gx.falseFn};t[32]={id:32,fld:"",grid:0};t[33]={id:33,fld:"",grid:0};t[34]={id:34,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};t[35]={id:35,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_medication_schemeid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_SCHEMEID",gxz:"Z296BR_Medication_SchemeID",gxold:"O296BR_Medication_SchemeID",gxvar:"A296BR_Medication_SchemeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A296BR_Medication_SchemeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z296BR_Medication_SchemeID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_SCHEMEID",gx.O.A296BR_Medication_SchemeID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A296BR_Medication_SchemeID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_MEDICATION_SCHEMEID",",")},nac:gx.falseFn};this.declareDomainHdlr(35,function(){});t[36]={id:36,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATIONID",gxz:"Z119BR_MedicationID",gxold:"O119BR_MedicationID",gxvar:"A119BR_MedicationID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A119BR_MedicationID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z119BR_MedicationID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICATIONID",gx.O.A119BR_MedicationID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A119BR_MedicationID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_MEDICATIONID",",")},nac:gx.falseFn};this.declareDomainHdlr(36,function(){});this.A305BR_Medication_Chem_Name="";this.Z305BR_Medication_Chem_Name="";this.O305BR_Medication_Chem_Name="";this.A306BR_Medication_Chem_Cycle=0;this.Z306BR_Medication_Chem_Cycle=0;this.O306BR_Medication_Chem_Cycle=0;this.A307BR_Medication_Chem_Line="";this.Z307BR_Medication_Chem_Line="";this.O307BR_Medication_Chem_Line="";this.A313BR_Medication_Chem_Detail="";this.Z313BR_Medication_Chem_Detail="";this.O313BR_Medication_Chem_Detail="";this.A296BR_Medication_SchemeID=0;this.Z296BR_Medication_SchemeID=0;this.O296BR_Medication_SchemeID=0;this.A119BR_MedicationID=0;this.Z119BR_MedicationID=0;this.O119BR_MedicationID=0;this.A305BR_Medication_Chem_Name="";this.A306BR_Medication_Chem_Cycle=0;this.A307BR_Medication_Chem_Line="";this.A313BR_Medication_Chem_Detail="";this.A296BR_Medication_SchemeID=0;this.A119BR_MedicationID=0;this.Events={e13502_client:["ENTER",!0],e14502_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"AV16Pgmname",fld:"vPGMNAME",pic:""},{av:"AV8BR_Medication_SchemeID",fld:"vBR_MEDICATION_SCHEMEID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV13BR_MedicationID",fld:"vBR_MEDICATIONID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[]];this.EvtParms.LOAD=[[],[{av:'gx.fn.getCtrlProperty("BR_MEDICATION_SCHEMEID","Visible")',ctrl:"BR_MEDICATION_SCHEMEID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Visible")',ctrl:"BR_MEDICATIONID",prop:"Visible"}]];this.Initialize()})