/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:55:37.28
*/
gx.evt.autoSkip=!1;gx.define("br_encountercheckcomorbidity",!0,function(n){this.ServerClass="br_encountercheckcomorbidity";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.A19BR_EncounterID=gx.fn.getIntegerValue("BR_ENCOUNTERID",",")};this.e133w2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e143w2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66];this.GXLastCtrlId=66;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"UNNAMEDTABLE1",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_BR_COMORBIDITY_HYPERTENSION",gxz:"ZV18GXV1",gxold:"OV18GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.GXV1=n)},v2z:function(n){n!==undefined&&(gx.O.ZV18GXV1=n)},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_BR_COMORBIDITY_HYPERTENSION",gx.O.GXV1)},c2v:function(){this.val()!==undefined&&(gx.O.GXV1=this.val())},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_BR_COMORBIDITY_HYPERTENSION")},nac:gx.falseFn};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_BR_COMORBIDITY_DIABETES",gxz:"ZV19GXV2",gxold:"OV19GXV2",gxvar:"GXV2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.GXV2=n)},v2z:function(n){n!==undefined&&(gx.O.ZV19GXV2=n)},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_BR_COMORBIDITY_DIABETES",gx.O.GXV2)},c2v:function(){this.val()!==undefined&&(gx.O.GXV2=this.val())},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_BR_COMORBIDITY_DIABETES")},nac:gx.falseFn};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,fld:"",grid:0};t[19]={id:19,fld:"",grid:0};t[20]={id:20,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_BR_COMORBIDITY_CHD",gxz:"ZV20GXV3",gxold:"OV20GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.GXV3=n)},v2z:function(n){n!==undefined&&(gx.O.ZV20GXV3=n)},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_BR_COMORBIDITY_CHD",gx.O.GXV3)},c2v:function(){this.val()!==undefined&&(gx.O.GXV3=this.val())},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_BR_COMORBIDITY_CHD")},nac:gx.falseFn};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,fld:"",grid:0};t[24]={id:24,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_BR_COMORBIDITY_HAPETITIS",gxz:"ZV21GXV4",gxold:"OV21GXV4",gxvar:"GXV4",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.GXV4=n)},v2z:function(n){n!==undefined&&(gx.O.ZV21GXV4=n)},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_BR_COMORBIDITY_HAPETITIS",gx.O.GXV4)},c2v:function(){this.val()!==undefined&&(gx.O.GXV4=this.val())},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_BR_COMORBIDITY_HAPETITIS")},nac:gx.falseFn};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,fld:"",grid:0};t[29]={id:29,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_BR_COMORBIDITY_TB",gxz:"ZV22GXV5",gxold:"OV22GXV5",gxvar:"GXV5",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.GXV5=n)},v2z:function(n){n!==undefined&&(gx.O.ZV22GXV5=n)},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_BR_COMORBIDITY_TB",gx.O.GXV5)},c2v:function(){this.val()!==undefined&&(gx.O.GXV5=this.val())},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_BR_COMORBIDITY_TB")},nac:gx.falseFn};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_BR_COMORBIDITY_KIDNEYDISEASE",gxz:"ZV23GXV6",gxold:"OV23GXV6",gxvar:"GXV6",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.GXV6=n)},v2z:function(n){n!==undefined&&(gx.O.ZV23GXV6=n)},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_BR_COMORBIDITY_KIDNEYDISEASE",gx.O.GXV6)},c2v:function(){this.val()!==undefined&&(gx.O.GXV6=this.val())},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_BR_COMORBIDITY_KIDNEYDISEASE")},nac:gx.falseFn};t[34]={id:34,fld:"",grid:0};t[35]={id:35,fld:"",grid:0};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"",grid:0};t[38]={id:38,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_BR_COMORBIDITY_SURGERYHISTORY",gxz:"ZV24GXV7",gxold:"OV24GXV7",gxvar:"GXV7",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.GXV7=n)},v2z:function(n){n!==undefined&&(gx.O.ZV24GXV7=n)},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_BR_COMORBIDITY_SURGERYHISTORY",gx.O.GXV7)},c2v:function(){this.val()!==undefined&&(gx.O.GXV7=this.val())},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_BR_COMORBIDITY_SURGERYHISTORY")},nac:gx.falseFn};t[39]={id:39,fld:"",grid:0};t[40]={id:40,fld:"",grid:0};t[41]={id:41,fld:"",grid:0};t[42]={id:42,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_BR_COMORBIDITY_INJURYHISTORY",gxz:"ZV25GXV8",gxold:"OV25GXV8",gxvar:"GXV8",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.GXV8=n)},v2z:function(n){n!==undefined&&(gx.O.ZV25GXV8=n)},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_BR_COMORBIDITY_INJURYHISTORY",gx.O.GXV8)},c2v:function(){this.val()!==undefined&&(gx.O.GXV8=this.val())},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_BR_COMORBIDITY_INJURYHISTORY")},nac:gx.falseFn};t[43]={id:43,fld:"",grid:0};t[44]={id:44,fld:"",grid:0};t[45]={id:45,fld:"",grid:0};t[46]={id:46,fld:"",grid:0};t[47]={id:47,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_BR_COMORBIDITY_BLOODHISTORY",gxz:"ZV26GXV9",gxold:"OV26GXV9",gxvar:"GXV9",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.GXV9=n)},v2z:function(n){n!==undefined&&(gx.O.ZV26GXV9=n)},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_BR_COMORBIDITY_BLOODHISTORY",gx.O.GXV9)},c2v:function(){this.val()!==undefined&&(gx.O.GXV9=this.val())},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_BR_COMORBIDITY_BLOODHISTORY")},nac:gx.falseFn};t[48]={id:48,fld:"",grid:0};t[49]={id:49,fld:"",grid:0};t[50]={id:50,fld:"",grid:0};t[51]={id:51,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_BR_COMORBIDITY_ALLERGY",gxz:"ZV27GXV10",gxold:"OV27GXV10",gxvar:"GXV10",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.GXV10=n)},v2z:function(n){n!==undefined&&(gx.O.ZV27GXV10=n)},v2c:function(){gx.fn.setComboBoxValue("BR_COMORBIDITY_BR_COMORBIDITY_ALLERGY",gx.O.GXV10)},c2v:function(){this.val()!==undefined&&(gx.O.GXV10=this.val())},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_BR_COMORBIDITY_ALLERGY")},nac:gx.falseFn};t[52]={id:52,fld:"",grid:0};t[53]={id:53,fld:"",grid:0};t[54]={id:54,fld:"UNNAMEDTABLEBR_COMORBIDITY_BR_COMORBIDITY_OTHERS",grid:0};t[55]={id:55,fld:"",grid:0};t[56]={id:56,fld:"",grid:0};t[57]={id:57,fld:"TEXTBLOCKBR_COMORBIDITY_BR_COMORBIDITY_OTHERS",format:0,grid:0};t[58]={id:58,fld:"",grid:0};t[59]={id:59,fld:"",grid:0};t[60]={id:60,lvl:0,type:"svchar",len:255,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_BR_COMORBIDITY_OTHERS",gxz:"ZV28GXV11",gxold:"OV28GXV11",gxvar:"GXV11",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV11=n)},v2z:function(n){n!==undefined&&(gx.O.ZV28GXV11=n)},v2c:function(){gx.fn.setControlValue("BR_COMORBIDITY_BR_COMORBIDITY_OTHERS",gx.O.GXV11,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV11=this.val())},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_BR_COMORBIDITY_OTHERS")},nac:gx.falseFn};t[61]={id:61,fld:"",grid:0};t[62]={id:62,fld:"",grid:0};t[63]={id:63,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};t[64]={id:64,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_BR_COMORBIDITYID",gxz:"ZV29GXV12",gxold:"OV29GXV12",gxvar:"GXV12",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV12=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV29GXV12=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_COMORBIDITY_BR_COMORBIDITYID",gx.O.GXV12,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV12=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_COMORBIDITY_BR_COMORBIDITYID",",")},nac:gx.falseFn};t[65]={id:65,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_BR_ENCOUNTERID",gxz:"ZV30GXV13",gxold:"OV30GXV13",gxvar:"GXV13",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV13=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV30GXV13=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_COMORBIDITY_BR_ENCOUNTERID",gx.O.GXV13,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV13=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_COMORBIDITY_BR_ENCOUNTERID",",")},nac:gx.falseFn};t[66]={id:66,lvl:0,type:"svchar",len:2e3,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_COMORBIDITY_BR_INFORMATION_PATIENTNO",gxz:"ZV31GXV14",gxold:"OV31GXV14",gxvar:"GXV14",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV14=n)},v2z:function(n){n!==undefined&&(gx.O.ZV31GXV14=n)},v2c:function(){gx.fn.setControlValue("BR_COMORBIDITY_BR_INFORMATION_PATIENTNO",gx.O.GXV14,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV14=this.val())},val:function(){return gx.fn.getControlValue("BR_COMORBIDITY_BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};this.GXV1="";this.ZV18GXV1="";this.OV18GXV1="";this.GXV2="";this.ZV19GXV2="";this.OV19GXV2="";this.GXV3="";this.ZV20GXV3="";this.OV20GXV3="";this.GXV4="";this.ZV21GXV4="";this.OV21GXV4="";this.GXV5="";this.ZV22GXV5="";this.OV22GXV5="";this.GXV6="";this.ZV23GXV6="";this.OV23GXV6="";this.GXV7="";this.ZV24GXV7="";this.OV24GXV7="";this.GXV8="";this.ZV25GXV8="";this.OV25GXV8="";this.GXV9="";this.ZV26GXV9="";this.OV26GXV9="";this.GXV10="";this.ZV27GXV10="";this.OV27GXV10="";this.GXV11="";this.ZV28GXV11="";this.OV28GXV11="";this.GXV12=0;this.ZV29GXV12=0;this.OV29GXV12=0;this.GXV13=0;this.ZV30GXV13=0;this.OV30GXV13=0;this.GXV14="";this.ZV31GXV14="";this.OV31GXV14="";this.GXV1="";this.GXV2="";this.GXV3="";this.GXV4="";this.GXV5="";this.GXV6="";this.GXV7="";this.GXV8="";this.GXV9="";this.GXV10="";this.GXV11="";this.GXV12=0;this.GXV13=0;this.GXV14="";this.A19BR_EncounterID=0;this.A37BR_ComorbidityID=0;this.Events={e133w2_client:["ENTER",!0],e143w2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"A37BR_ComorbidityID",fld:"BR_COMORBIDITYID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV33Pgmname",fld:"vPGMNAME",pic:""},{av:"AV8BR_EncounterID",fld:"vBR_ENCOUNTERID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[{av:"AV13BR_Comorbidity",fld:"vBR_COMORBIDITY",pic:""}]];this.EvtParms.LOAD=[[],[{ctrl:"BR_COMORBIDITY_BR_COMORBIDITYID",prop:"Visible"},{ctrl:"BR_COMORBIDITY_BR_ENCOUNTERID",prop:"Visible"},{ctrl:"BR_COMORBIDITY_BR_INFORMATION_PATIENTNO",prop:"Visible"}]];this.setVCMap("A19BR_EncounterID","BR_ENCOUNTERID",0,"int",18,0);this.addBCProperty("Br_comorbidity",["BR_Comorbidity_Hypertension"],this.GXValidFnc[11],"AV13BR_Comorbidity");this.addBCProperty("Br_comorbidity",["BR_Comorbidity_Diabetes"],this.GXValidFnc[15],"AV13BR_Comorbidity");this.addBCProperty("Br_comorbidity",["BR_Comorbidity_CHD"],this.GXValidFnc[20],"AV13BR_Comorbidity");this.addBCProperty("Br_comorbidity",["BR_Comorbidity_Hapetitis"],this.GXValidFnc[24],"AV13BR_Comorbidity");this.addBCProperty("Br_comorbidity",["BR_Comorbidity_TB"],this.GXValidFnc[29],"AV13BR_Comorbidity");this.addBCProperty("Br_comorbidity",["BR_Comorbidity_KidneyDisease"],this.GXValidFnc[33],"AV13BR_Comorbidity");this.addBCProperty("Br_comorbidity",["BR_Comorbidity_SurgeryHistory"],this.GXValidFnc[38],"AV13BR_Comorbidity");this.addBCProperty("Br_comorbidity",["BR_Comorbidity_InjuryHistory"],this.GXValidFnc[42],"AV13BR_Comorbidity");this.addBCProperty("Br_comorbidity",["BR_Comorbidity_BloodHistory"],this.GXValidFnc[47],"AV13BR_Comorbidity");this.addBCProperty("Br_comorbidity",["BR_Comorbidity_allergy"],this.GXValidFnc[51],"AV13BR_Comorbidity");this.addBCProperty("Br_comorbidity",["BR_Comorbidity_Others"],this.GXValidFnc[60],"AV13BR_Comorbidity");this.addBCProperty("Br_comorbidity",["BR_ComorbidityID"],this.GXValidFnc[64],"AV13BR_Comorbidity");this.addBCProperty("Br_comorbidity",["BR_EncounterID"],this.GXValidFnc[65],"AV13BR_Comorbidity");this.addBCProperty("Br_comorbidity",["BR_Information_PatientNo"],this.GXValidFnc[66],"AV13BR_Comorbidity");this.Initialize()})