/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:39:7.51
*/
gx.evt.autoSkip=!1;gx.define("view_lastest_patient_info",!1,function(){this.ServerClass="view_lastest_patient_info";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_View_lpi_br_information_id=function(){return gx.ajax.validSrvEvt("dyncall","Valid_View_lpi_br_information_id",["gx.num.urlDecimal(gx.O.A520VIEW_LPI_BR_Information_ID,',','.')","gx.O.A519VIEW_LPI_BR_Information_PatientNo",'gx.date.urlDateTime(gx.O.A521VIEW_LPI_BR_Encounter_AdmitDate,"ANSI")',"gx.O.A522VIEW_LPI_BR_Demographics_Sex",'gx.date.urlDate(gx.O.A523VIEW_LPI_BR_Demographics_BirthDate,"ANSI")',"gx.O.A524VIEW_LPI_BR_Demographics_Ethnic"],["A519VIEW_LPI_BR_Information_PatientNo","A521VIEW_LPI_BR_Encounter_AdmitDate","A522VIEW_LPI_BR_Demographics_Sex","A523VIEW_LPI_BR_Demographics_BirthDate","A524VIEW_LPI_BR_Demographics_Ethnic","Gx_mode","Z520VIEW_LPI_BR_Information_ID","Z519VIEW_LPI_BR_Information_PatientNo","Z521VIEW_LPI_BR_Encounter_AdmitDate","Z522VIEW_LPI_BR_Demographics_Sex","Z523VIEW_LPI_BR_Demographics_BirthDate","Z524VIEW_LPI_BR_Demographics_Ethnic",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.Valid_View_lpi_br_encounter_admitdate=function(){try{var n=gx.util.balloon.getNew("VIEW_LPI_BR_ENCOUNTER_ADMITDATE");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.A521VIEW_LPI_BR_Encounter_AdmitDate)==0||new gx.date.gxdate(this.A521VIEW_LPI_BR_Encounter_AdmitDate).compare(gx.date.ymdhmstot(1753,01,01,00,00,00))>=0))try{n.setError("鍩烿IEW_LPI_BR_Encounter_Admit Date瓒呯晫");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_View_lpi_br_demographics_birthdate=function(){try{var n=gx.util.balloon.getNew("VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.A523VIEW_LPI_BR_Demographics_BirthDate)==0||new gx.date.gxdate(this.A523VIEW_LPI_BR_Demographics_BirthDate).compare(gx.date.ymdtod(1753,01,01))>=0))try{n.setError("鍩烿IEW_LPI_BR_Demographics_Birth Date瓒呯晫");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e111o71_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e121o71_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62];this.GXLastCtrlId=62;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"TABLEMAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLE",format:0,grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"BTN_FIRST",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"BTN_PREVIOUS",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"BTN_NEXT",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"BTN_LAST",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"BTN_SELECT",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_View_lpi_br_information_id,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_LPI_BR_INFORMATION_ID",gxz:"Z520VIEW_LPI_BR_Information_ID",gxold:"O520VIEW_LPI_BR_Information_ID",gxvar:"A520VIEW_LPI_BR_Information_ID",ucs:[],op:[53,48,43,38,33],ip:[53,48,43,38,33,28],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A520VIEW_LPI_BR_Information_ID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z520VIEW_LPI_BR_Information_ID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("VIEW_LPI_BR_INFORMATION_ID",gx.O.A520VIEW_LPI_BR_Information_ID,0)},c2v:function(){this.val()!==undefined&&(gx.O.A520VIEW_LPI_BR_Information_ID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("VIEW_LPI_BR_INFORMATION_ID",",")},nac:gx.falseFn};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,lvl:0,type:"svchar",len:4e3,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_LPI_BR_INFORMATION_PATIENTNO",gxz:"Z519VIEW_LPI_BR_Information_PatientNo",gxold:"O519VIEW_LPI_BR_Information_PatientNo",gxvar:"A519VIEW_LPI_BR_Information_PatientNo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A519VIEW_LPI_BR_Information_PatientNo=n)},v2z:function(n){n!==undefined&&(gx.O.Z519VIEW_LPI_BR_Information_PatientNo=n)},v2c:function(){gx.fn.setControlValue("VIEW_LPI_BR_INFORMATION_PATIENTNO",gx.O.A519VIEW_LPI_BR_Information_PatientNo,0)},c2v:function(){this.val()!==undefined&&(gx.O.A519VIEW_LPI_BR_Information_PatientNo=this.val())},val:function(){return gx.fn.getControlValue("VIEW_LPI_BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_View_lpi_br_encounter_admitdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_LPI_BR_ENCOUNTER_ADMITDATE",gxz:"Z521VIEW_LPI_BR_Encounter_AdmitDate",gxold:"O521VIEW_LPI_BR_Encounter_AdmitDate",gxvar:"A521VIEW_LPI_BR_Encounter_AdmitDate",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[38],ip:[38],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A521VIEW_LPI_BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z521VIEW_LPI_BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("VIEW_LPI_BR_ENCOUNTER_ADMITDATE",gx.O.A521VIEW_LPI_BR_Encounter_AdmitDate,0)},c2v:function(){this.val()!==undefined&&(gx.O.A521VIEW_LPI_BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("VIEW_LPI_BR_ENCOUNTER_ADMITDATE")},nac:gx.falseFn};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,lvl:0,type:"svchar",len:4e3,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_LPI_BR_DEMOGRAPHICS_SEX",gxz:"Z522VIEW_LPI_BR_Demographics_Sex",gxold:"O522VIEW_LPI_BR_Demographics_Sex",gxvar:"A522VIEW_LPI_BR_Demographics_Sex",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A522VIEW_LPI_BR_Demographics_Sex=n)},v2z:function(n){n!==undefined&&(gx.O.Z522VIEW_LPI_BR_Demographics_Sex=n)},v2c:function(){gx.fn.setControlValue("VIEW_LPI_BR_DEMOGRAPHICS_SEX",gx.O.A522VIEW_LPI_BR_Demographics_Sex,0)},c2v:function(){this.val()!==undefined&&(gx.O.A522VIEW_LPI_BR_Demographics_Sex=this.val())},val:function(){return gx.fn.getControlValue("VIEW_LPI_BR_DEMOGRAPHICS_SEX")},nac:gx.falseFn};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_View_lpi_br_demographics_birthdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE",gxz:"Z523VIEW_LPI_BR_Demographics_BirthDate",gxold:"O523VIEW_LPI_BR_Demographics_BirthDate",gxvar:"A523VIEW_LPI_BR_Demographics_BirthDate",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[48],ip:[48],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A523VIEW_LPI_BR_Demographics_BirthDate=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z523VIEW_LPI_BR_Demographics_BirthDate=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE",gx.O.A523VIEW_LPI_BR_Demographics_BirthDate,0)},c2v:function(){this.val()!==undefined&&(gx.O.A523VIEW_LPI_BR_Demographics_BirthDate=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE")},nac:gx.falseFn};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,lvl:0,type:"svchar",len:4e3,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC",gxz:"Z524VIEW_LPI_BR_Demographics_Ethnic",gxold:"O524VIEW_LPI_BR_Demographics_Ethnic",gxvar:"A524VIEW_LPI_BR_Demographics_Ethnic",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A524VIEW_LPI_BR_Demographics_Ethnic=n)},v2z:function(n){n!==undefined&&(gx.O.Z524VIEW_LPI_BR_Demographics_Ethnic=n)},v2c:function(){gx.fn.setControlValue("VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC",gx.O.A524VIEW_LPI_BR_Demographics_Ethnic,0)},c2v:function(){this.val()!==undefined&&(gx.O.A524VIEW_LPI_BR_Demographics_Ethnic=this.val())},val:function(){return gx.fn.getControlValue("VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC")},nac:gx.falseFn};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"BTN_ENTER",grid:0};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"BTN_CANCEL",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"BTN_DELETE",grid:0};this.A520VIEW_LPI_BR_Information_ID=0;this.Z520VIEW_LPI_BR_Information_ID=0;this.O520VIEW_LPI_BR_Information_ID=0;this.A519VIEW_LPI_BR_Information_PatientNo="";this.Z519VIEW_LPI_BR_Information_PatientNo="";this.O519VIEW_LPI_BR_Information_PatientNo="";this.A521VIEW_LPI_BR_Encounter_AdmitDate=gx.date.nullDate();this.Z521VIEW_LPI_BR_Encounter_AdmitDate=gx.date.nullDate();this.O521VIEW_LPI_BR_Encounter_AdmitDate=gx.date.nullDate();this.A522VIEW_LPI_BR_Demographics_Sex="";this.Z522VIEW_LPI_BR_Demographics_Sex="";this.O522VIEW_LPI_BR_Demographics_Sex="";this.A523VIEW_LPI_BR_Demographics_BirthDate=gx.date.nullDate();this.Z523VIEW_LPI_BR_Demographics_BirthDate=gx.date.nullDate();this.O523VIEW_LPI_BR_Demographics_BirthDate=gx.date.nullDate();this.A524VIEW_LPI_BR_Demographics_Ethnic="";this.Z524VIEW_LPI_BR_Demographics_Ethnic="";this.O524VIEW_LPI_BR_Demographics_Ethnic="";this.A520VIEW_LPI_BR_Information_ID=0;this.A519VIEW_LPI_BR_Information_PatientNo="";this.A521VIEW_LPI_BR_Encounter_AdmitDate=gx.date.nullDate();this.A522VIEW_LPI_BR_Demographics_Sex="";this.A523VIEW_LPI_BR_Demographics_BirthDate=gx.date.nullDate();this.A524VIEW_LPI_BR_Demographics_Ethnic="";this.Events={e111o71_client:["ENTER",!0],e121o71_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.Initialize()});gx.createParentObj(view_lastest_patient_info)