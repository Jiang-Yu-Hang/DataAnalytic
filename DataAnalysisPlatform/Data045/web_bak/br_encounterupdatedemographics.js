/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:36:16.67
*/
gx.evt.autoSkip=!1;gx.define("br_encounterupdatedemographics",!0,function(n){this.ServerClass="br_encounterupdatedemographics";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV21tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE");this.AV13BR_Demographics=gx.fn.getControlValue("vBR_DEMOGRAPHICS");this.A20BR_BehaviorID=gx.fn.getIntegerValue("BR_BEHAVIORID",",");this.A19BR_EncounterID=gx.fn.getIntegerValue("BR_ENCOUNTERID",",")};this.e152k1_client=function(){return this.clearMessages(),this.AV16vInsurance=="鍏跺畠"?gx.fn.setCtrlProperty("vVOTHERINSURANCE","Visible",!0):gx.fn.setCtrlProperty("vVOTHERINSURANCE","Visible",!1),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("vVOTHERINSURANCE","Visible")',ctrl:"vVOTHERINSURANCE",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e132k2_client=function(){return this.executeServerEvent("'DOSAVE'",!1,null,!1,!1)};this.e162k2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e172k2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,56,57,59,60,61,62,63,64,65,67,68,69,70,71,72];this.GXLastCtrlId=72;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"UNNAMEDTABLE1",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"UNNAMEDTABLE2",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"",grid:0};t[14]={id:14,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_SEX",gxz:"ZV31GXV1",gxold:"OV31GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.GXV1=n)},v2z:function(n){n!==undefined&&(gx.O.ZV31GXV1=n)},v2c:function(){gx.fn.setComboBoxValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_SEX",gx.O.GXV1)},c2v:function(){this.val()!==undefined&&(gx.O.GXV1=this.val())},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_SEX")},nac:gx.falseFn};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_BIRTHDATE",gxz:"ZV32GXV2",gxold:"OV32GXV2",gxvar:"GXV2",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV2=gx.fn.toDatetimeValue(n,"Y4MD"))},v2z:function(n){n!==undefined&&(gx.O.ZV32GXV2=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_BIRTHDATE",gx.O.GXV2,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV2=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_BIRTHDATE")},nac:gx.falseFn};t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ETHNIC",gxz:"ZV33GXV3",gxold:"OV33GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.GXV3=n)},v2z:function(n){n!==undefined&&(gx.O.ZV33GXV3=n)},v2c:function(){gx.fn.setComboBoxValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ETHNIC",gx.O.GXV3)},c2v:function(){this.val()!==undefined&&(gx.O.GXV3=this.val())},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ETHNIC")},nac:gx.falseFn};t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_MARRITALSTATUS",gxz:"ZV34GXV4",gxold:"OV34GXV4",gxvar:"GXV4",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.GXV4=n)},v2z:function(n){n!==undefined&&(gx.O.ZV34GXV4=n)},v2c:function(){gx.fn.setComboBoxValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_MARRITALSTATUS",gx.O.GXV4)},c2v:function(){this.val()!==undefined&&(gx.O.GXV4=this.val())},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_MARRITALSTATUS")},nac:gx.falseFn};t[28]={id:28,fld:"",grid:0};t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_EDUCATION",gxz:"ZV35GXV5",gxold:"OV35GXV5",gxvar:"GXV5",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.GXV5=n)},v2z:function(n){n!==undefined&&(gx.O.ZV35GXV5=n)},v2c:function(){gx.fn.setComboBoxValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_EDUCATION",gx.O.GXV5)},c2v:function(){this.val()!==undefined&&(gx.O.GXV5=this.val())},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_EDUCATION")},nac:gx.falseFn};t[33]={id:33,fld:"",grid:0};t[34]={id:34,fld:"",grid:0};t[35]={id:35,fld:"",grid:0};t[36]={id:36,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_OCCUPATION",gxz:"ZV36GXV6",gxold:"OV36GXV6",gxvar:"GXV6",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV6=n)},v2z:function(n){n!==undefined&&(gx.O.ZV36GXV6=n)},v2c:function(){gx.fn.setControlValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_OCCUPATION",gx.O.GXV6,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV6=this.val())},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_OCCUPATION")},nac:gx.falseFn};t[37]={id:37,fld:"",grid:0};t[38]={id:38,fld:"",grid:0};t[39]={id:39,fld:"",grid:0};t[40]={id:40,fld:"",grid:0};t[41]={id:41,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_PROVINCE",gxz:"ZV37GXV7",gxold:"OV37GXV7",gxvar:"GXV7",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV7=n)},v2z:function(n){n!==undefined&&(gx.O.ZV37GXV7=n)},v2c:function(){gx.fn.setControlValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_PROVINCE",gx.O.GXV7,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV7=this.val())},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_PROVINCE")},nac:gx.falseFn};t[42]={id:42,fld:"",grid:0};t[43]={id:43,fld:"",grid:0};t[44]={id:44,fld:"",grid:0};t[45]={id:45,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_CITY",gxz:"ZV38GXV8",gxold:"OV38GXV8",gxvar:"GXV8",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV8=n)},v2z:function(n){n!==undefined&&(gx.O.ZV38GXV8=n)},v2c:function(){gx.fn.setControlValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_CITY",gx.O.GXV8,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV8=this.val())},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_CITY")},nac:gx.falseFn};t[46]={id:46,fld:"",grid:0};t[47]={id:47,fld:"",grid:0};t[48]={id:48,fld:"TABLESPLITTEDVINSURANCE",grid:0};t[49]={id:49,fld:"",grid:0};t[50]={id:50,fld:"",grid:0};t[51]={id:51,fld:"TEXTBLOCKVINSURANCE",format:0,grid:0};t[52]={id:52,fld:"",grid:0};t[53]={id:53,fld:"TABLEMERGEDVINSURANCE",grid:0};t[56]={id:56,fld:"",grid:0};t[57]={id:57,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:"e152k1_client",evt_cvcing:null,rgrid:[],fld:"vVINSURANCE",gxz:"ZV16vInsurance",gxold:"OV16vInsurance",gxvar:"AV16vInsurance",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.AV16vInsurance=n)},v2z:function(n){n!==undefined&&(gx.O.ZV16vInsurance=n)},v2c:function(){gx.fn.setComboBoxValue("vVINSURANCE",gx.O.AV16vInsurance)},c2v:function(){this.val()!==undefined&&(gx.O.AV16vInsurance=this.val())},val:function(){return gx.fn.getControlValue("vVINSURANCE")},nac:gx.falseFn};t[59]={id:59,fld:"",grid:0};t[60]={id:60,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVOTHERINSURANCE",gxz:"ZV17vOtherInsurance",gxold:"OV17vOtherInsurance",gxvar:"AV17vOtherInsurance",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV17vOtherInsurance=n)},v2z:function(n){n!==undefined&&(gx.O.ZV17vOtherInsurance=n)},v2c:function(){gx.fn.setControlValue("vVOTHERINSURANCE",gx.O.AV17vOtherInsurance,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV17vOtherInsurance=this.val())},val:function(){return gx.fn.getControlValue("vVOTHERINSURANCE")},nac:gx.falseFn};t[61]={id:61,fld:"",grid:0};t[62]={id:62,fld:"",grid:0};t[63]={id:63,fld:"BTNSAVE",grid:0};t[64]={id:64,fld:"",grid:0};t[65]={id:65,fld:"",grid:0};t[67]={id:67,fld:"",grid:0};t[68]={id:68,fld:"",grid:0};t[69]={id:69,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};t[70]={id:70,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ID",gxz:"ZV39GXV9",gxold:"OV39GXV9",gxvar:"GXV9",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV9=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV39GXV9=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ID",gx.O.GXV9,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV9=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ID",",")},nac:gx.falseFn};t[71]={id:71,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_BR_ENCOUNTERID",gxz:"ZV40GXV10",gxold:"OV40GXV10",gxvar:"GXV10",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV10=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV40GXV10=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_DEMOGRAPHICS_BR_ENCOUNTERID",gx.O.GXV10,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV10=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_DEMOGRAPHICS_BR_ENCOUNTERID",",")},nac:gx.falseFn};t[72]={id:72,lvl:0,type:"svchar",len:2e3,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEMOGRAPHICS_BR_INFORMATION_PATIENTNO",gxz:"ZV41GXV11",gxold:"OV41GXV11",gxvar:"GXV11",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV11=n)},v2z:function(n){n!==undefined&&(gx.O.ZV41GXV11=n)},v2c:function(){gx.fn.setControlValue("BR_DEMOGRAPHICS_BR_INFORMATION_PATIENTNO",gx.O.GXV11,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV11=this.val())},val:function(){return gx.fn.getControlValue("BR_DEMOGRAPHICS_BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};this.GXV1="";this.ZV31GXV1="";this.OV31GXV1="";this.GXV2=gx.date.nullDate();this.ZV32GXV2=gx.date.nullDate();this.OV32GXV2=gx.date.nullDate();this.GXV3="";this.ZV33GXV3="";this.OV33GXV3="";this.GXV4="";this.ZV34GXV4="";this.OV34GXV4="";this.GXV5="";this.ZV35GXV5="";this.OV35GXV5="";this.GXV6="";this.ZV36GXV6="";this.OV36GXV6="";this.GXV7="";this.ZV37GXV7="";this.OV37GXV7="";this.GXV8="";this.ZV38GXV8="";this.OV38GXV8="";this.AV16vInsurance="";this.ZV16vInsurance="";this.OV16vInsurance="";this.AV17vOtherInsurance="";this.ZV17vOtherInsurance="";this.OV17vOtherInsurance="";this.GXV9=0;this.ZV39GXV9=0;this.OV39GXV9=0;this.GXV10=0;this.ZV40GXV10=0;this.OV40GXV10=0;this.GXV11="";this.ZV41GXV11="";this.OV41GXV11="";this.GXV1="";this.GXV2=gx.date.nullDate();this.GXV3="";this.GXV4="";this.GXV5="";this.GXV6="";this.GXV7="";this.GXV8="";this.AV16vInsurance="";this.AV17vOtherInsurance="";this.GXV9=0;this.GXV10=0;this.GXV11="";this.A19BR_EncounterID=0;this.A20BR_BehaviorID=0;this.A61BR_Demographics_ID=0;this.AV13BR_Demographics={BR_Demographics_ID:0,BR_EncounterID:0,BR_Information_PatientNo:"",BR_Demographics_BirthDate:gx.date.nullDate(),BR_Demographics_Sex:"",BR_Demographics_Sex_Code:"",BR_Demographics_MarritalStatus:"",BR_Demographics_MarritalStatus_Code:"",BR_Demographics_Ethnic:"",BR_Demographics_Ethnic_Code:"",BR_Demographics_Education:"",BR_Demographics_Education_Code:"",BR_Demographics_Occupation:"",BR_Demographics_Insurance:"",BR_Demographics_Insurance_Code:"",BR_Demographics_Province:"",BR_Demographics_City:"",Mode:"",Initialized:0,BR_Demographics_ID_Z:0,BR_EncounterID_Z:0,BR_Information_PatientNo_Z:"",BR_Demographics_BirthDate_Z:gx.date.nullDate(),BR_Demographics_Sex_Z:"",BR_Demographics_Sex_Code_Z:"",BR_Demographics_MarritalStatus_Z:"",BR_Demographics_MarritalStatus_Code_Z:"",BR_Demographics_Ethnic_Z:"",BR_Demographics_Ethnic_Code_Z:"",BR_Demographics_Education_Z:"",BR_Demographics_Education_Code_Z:"",BR_Demographics_Occupation_Z:"",BR_Demographics_Insurance_Z:"",BR_Demographics_Insurance_Code_Z:"",BR_Demographics_Province_Z:"",BR_Demographics_City_Z:""};this.Events={e132k2_client:["'DOSAVE'",!0],e162k2_client:["ENTER",!0],e172k2_client:["CANCEL",!0],e152k1_client:["VVINSURANCE.CONTROLVALUECHANGED",!1]};this.EvtParms.REFRESH=[[{av:"AV13BR_Demographics",fld:"vBR_DEMOGRAPHICS",pic:""},{ctrl:"vVINSURANCE"},{av:"AV16vInsurance",fld:"vVINSURANCE",pic:""},{av:"A20BR_BehaviorID",fld:"BR_BEHAVIORID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[{ctrl:"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ID",prop:"Visible"},{ctrl:"BR_DEMOGRAPHICS_BR_ENCOUNTERID",prop:"Visible"},{ctrl:"BR_DEMOGRAPHICS_BR_INFORMATION_PATIENTNO",prop:"Visible"},{ctrl:"vVINSURANCE"},{av:"AV16vInsurance",fld:"vVINSURANCE",pic:""}]];this.EvtParms.START=[[{av:"A61BR_Demographics_ID",fld:"BR_DEMOGRAPHICS_ID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"A19BR_EncounterID",fld:"BR_ENCOUNTERID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV45Pgmname",fld:"vPGMNAME",pic:""},{av:"AV8BR_EncounterID",fld:"vBR_ENCOUNTERID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[{av:"AV13BR_Demographics",fld:"vBR_DEMOGRAPHICS",pic:""},{ctrl:"vVINSURANCE"},{av:"AV16vInsurance",fld:"vVINSURANCE",pic:""},{av:'gx.fn.getCtrlProperty("vVOTHERINSURANCE","Visible")',ctrl:"vVOTHERINSURANCE",prop:"Visible"}]];this.EvtParms.LOAD=[[{av:"AV13BR_Demographics",fld:"vBR_DEMOGRAPHICS",pic:""},{ctrl:"vVINSURANCE"},{av:"AV16vInsurance",fld:"vVINSURANCE",pic:""}],[{ctrl:"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ID",prop:"Visible"},{ctrl:"BR_DEMOGRAPHICS_BR_ENCOUNTERID",prop:"Visible"},{ctrl:"BR_DEMOGRAPHICS_BR_INFORMATION_PATIENTNO",prop:"Visible"},{ctrl:"vVINSURANCE"},{av:"AV16vInsurance",fld:"vVINSURANCE",pic:""}]];this.EvtParms["'DOSAVE'"]=[[{av:"AV13BR_Demographics",fld:"vBR_DEMOGRAPHICS",pic:""},{ctrl:"vVINSURANCE"},{av:"AV16vInsurance",fld:"vVINSURANCE",pic:""},{av:"AV17vOtherInsurance",fld:"vVOTHERINSURANCE",pic:""},{av:"A20BR_BehaviorID",fld:"BR_BEHAVIORID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[{av:"AV13BR_Demographics",fld:"vBR_DEMOGRAPHICS",pic:""}]];this.EvtParms["VVINSURANCE.CONTROLVALUECHANGED"]=[[{ctrl:"vVINSURANCE"},{av:"AV16vInsurance",fld:"vVINSURANCE",pic:""}],[{av:'gx.fn.getCtrlProperty("vVOTHERINSURANCE","Visible")',ctrl:"vVOTHERINSURANCE",prop:"Visible"}]];this.setVCMap("AV21tCurrentCode","vTCURRENTCODE",0,"svchar",40,0);this.setVCMap("AV13BR_Demographics","vBR_DEMOGRAPHICS",0,"BR_Demographics",0,0);this.setVCMap("A20BR_BehaviorID","BR_BEHAVIORID",0,"int",18,0);this.setVCMap("A19BR_EncounterID","BR_ENCOUNTERID",0,"int",18,0);this.addBCProperty("Br_demographics",["BR_Demographics_Sex"],this.GXValidFnc[14],"AV13BR_Demographics");this.addBCProperty("Br_demographics",["BR_Demographics_BirthDate"],this.GXValidFnc[18],"AV13BR_Demographics");this.addBCProperty("Br_demographics",["BR_Demographics_Ethnic"],this.GXValidFnc[23],"AV13BR_Demographics");this.addBCProperty("Br_demographics",["BR_Demographics_MarritalStatus"],this.GXValidFnc[27],"AV13BR_Demographics");this.addBCProperty("Br_demographics",["BR_Demographics_Education"],this.GXValidFnc[32],"AV13BR_Demographics");this.addBCProperty("Br_demographics",["BR_Demographics_Occupation"],this.GXValidFnc[36],"AV13BR_Demographics");this.addBCProperty("Br_demographics",["BR_Demographics_Province"],this.GXValidFnc[41],"AV13BR_Demographics");this.addBCProperty("Br_demographics",["BR_Demographics_City"],this.GXValidFnc[45],"AV13BR_Demographics");this.addBCProperty("Br_demographics",["BR_Demographics_ID"],this.GXValidFnc[70],"AV13BR_Demographics");this.addBCProperty("Br_demographics",["BR_EncounterID"],this.GXValidFnc[71],"AV13BR_Demographics");this.addBCProperty("Br_demographics",["BR_Information_PatientNo"],this.GXValidFnc[72],"AV13BR_Demographics");this.Initialize()})