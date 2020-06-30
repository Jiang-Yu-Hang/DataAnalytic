/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:54:40.43
*/
gx.evt.autoSkip=!1;gx.define("br_medicationgeneral",!0,function(n){this.ServerClass="br_medicationgeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Br_medicationid=function(){try{var n=gx.util.balloon.getNew("BR_MEDICATIONID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Br_encounterid=function(){try{var n=gx.util.balloon.getNew("BR_ENCOUNTERID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e133m2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e143m2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73];this.GXLastCtrlId=73;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLE",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"TRANSACTIONDETAIL_TABLEATTRIBUTES",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"",grid:0};t[14]={id:14,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXNAME",gxz:"Z121BR_Medication_RXName",gxold:"O121BR_Medication_RXName",gxvar:"A121BR_Medication_RXName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A121BR_Medication_RXName=n)},v2z:function(n){n!==undefined&&(gx.O.Z121BR_Medication_RXName=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_RXNAME",gx.O.A121BR_Medication_RXName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A121BR_Medication_RXName=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_RXNAME")},nac:gx.falseFn};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXCODE",gxz:"Z122BR_Medication_RXCode",gxold:"O122BR_Medication_RXCode",gxvar:"A122BR_Medication_RXCode",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A122BR_Medication_RXCode=n)},v2z:function(n){n!==undefined&&(gx.O.Z122BR_Medication_RXCode=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_RXCODE",gx.O.A122BR_Medication_RXCode,0)},c2v:function(){this.val()!==undefined&&(gx.O.A122BR_Medication_RXCode=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_RXCODE")},nac:gx.falseFn};t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXTYPE",gxz:"Z123BR_Medication_RXType",gxold:"O123BR_Medication_RXType",gxvar:"A123BR_Medication_RXType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A123BR_Medication_RXType=n)},v2z:function(n){n!==undefined&&(gx.O.Z123BR_Medication_RXType=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_RXTYPE",gx.O.A123BR_Medication_RXType,0)},c2v:function(){this.val()!==undefined&&(gx.O.A123BR_Medication_RXType=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_RXTYPE")},nac:gx.falseFn};t[23]={id:23,fld:"",grid:0};t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,lvl:0,type:"decimal",len:15,dec:5,sign:!1,pic:"ZZZZZZZZZ.ZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXDOSE",gxz:"Z124BR_Medication_RXDose",gxold:"O124BR_Medication_RXDose",gxvar:"A124BR_Medication_RXDose",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A124BR_Medication_RXDose=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z124BR_Medication_RXDose=gx.fn.toDecimalValue(n,",","."))},v2c:function(){gx.fn.setDecimalValue("BR_MEDICATION_RXDOSE",gx.O.A124BR_Medication_RXDose,5,".");typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A124BR_Medication_RXDose=this.val())},val:function(){return gx.fn.getDecimalValue("BR_MEDICATION_RXDOSE",",",".")},nac:gx.falseFn};this.declareDomainHdlr(27,function(){});t[28]={id:28,fld:"",grid:0};t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXUNIT",gxz:"Z125BR_Medication_RXUnit",gxold:"O125BR_Medication_RXUnit",gxvar:"A125BR_Medication_RXUnit",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A125BR_Medication_RXUnit=n)},v2z:function(n){n!==undefined&&(gx.O.Z125BR_Medication_RXUnit=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_RXUNIT",gx.O.A125BR_Medication_RXUnit,0)},c2v:function(){this.val()!==undefined&&(gx.O.A125BR_Medication_RXUnit=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_RXUNIT")},nac:gx.falseFn};t[32]={id:32,fld:"",grid:0};t[33]={id:33,fld:"",grid:0};t[34]={id:34,fld:"",grid:0};t[35]={id:35,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXFREQUENCY",gxz:"Z126BR_Medication_RXFrequency",gxold:"O126BR_Medication_RXFrequency",gxvar:"A126BR_Medication_RXFrequency",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A126BR_Medication_RXFrequency=n)},v2z:function(n){n!==undefined&&(gx.O.Z126BR_Medication_RXFrequency=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_RXFREQUENCY",gx.O.A126BR_Medication_RXFrequency,0)},c2v:function(){this.val()!==undefined&&(gx.O.A126BR_Medication_RXFrequency=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_RXFREQUENCY")},nac:gx.falseFn};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"",grid:0};t[38]={id:38,fld:"",grid:0};t[39]={id:39,fld:"",grid:0};t[40]={id:40,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXQUANTITY",gxz:"Z127BR_Medication_RXQuantity",gxold:"O127BR_Medication_RXQuantity",gxvar:"A127BR_Medication_RXQuantity",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A127BR_Medication_RXQuantity=n)},v2z:function(n){n!==undefined&&(gx.O.Z127BR_Medication_RXQuantity=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_RXQUANTITY",gx.O.A127BR_Medication_RXQuantity,0)},c2v:function(){this.val()!==undefined&&(gx.O.A127BR_Medication_RXQuantity=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_RXQUANTITY")},nac:gx.falseFn};t[41]={id:41,fld:"",grid:0};t[42]={id:42,fld:"",grid:0};t[43]={id:43,fld:"",grid:0};t[44]={id:44,lvl:0,type:"decimal",len:15,dec:5,sign:!1,pic:"ZZZZZZZZZ.ZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXDAYSSUPPLY",gxz:"Z128BR_Medication_RXDaysSupply",gxold:"O128BR_Medication_RXDaysSupply",gxvar:"A128BR_Medication_RXDaysSupply",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A128BR_Medication_RXDaysSupply=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z128BR_Medication_RXDaysSupply=gx.fn.toDecimalValue(n,",","."))},v2c:function(){gx.fn.setDecimalValue("BR_MEDICATION_RXDAYSSUPPLY",gx.O.A128BR_Medication_RXDaysSupply,5,".");typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A128BR_Medication_RXDaysSupply=this.val())},val:function(){return gx.fn.getDecimalValue("BR_MEDICATION_RXDAYSSUPPLY",",",".")},nac:gx.falseFn};this.declareDomainHdlr(44,function(){});t[45]={id:45,fld:"",grid:0};t[46]={id:46,fld:"",grid:0};t[47]={id:47,fld:"",grid:0};t[48]={id:48,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXROUTE",gxz:"Z129BR_Medication_RXRoute",gxold:"O129BR_Medication_RXRoute",gxvar:"A129BR_Medication_RXRoute",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A129BR_Medication_RXRoute=n)},v2z:function(n){n!==undefined&&(gx.O.Z129BR_Medication_RXRoute=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_RXROUTE",gx.O.A129BR_Medication_RXRoute,0)},c2v:function(){this.val()!==undefined&&(gx.O.A129BR_Medication_RXRoute=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_RXROUTE")},nac:gx.falseFn};t[49]={id:49,fld:"",grid:0};t[50]={id:50,fld:"",grid:0};t[51]={id:51,fld:"",grid:0};t[52]={id:52,fld:"",grid:0};t[53]={id:53,lvl:0,type:"date",len:10,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_PRESCRIPTIONDATE",gxz:"Z130BR_Medication_PrescriptionDate",gxold:"O130BR_Medication_PrescriptionDate",gxvar:"A130BR_Medication_PrescriptionDate",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A130BR_Medication_PrescriptionDate=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z130BR_Medication_PrescriptionDate=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_PRESCRIPTIONDATE",gx.O.A130BR_Medication_PrescriptionDate,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A130BR_Medication_PrescriptionDate=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("BR_MEDICATION_PRESCRIPTIONDATE")},nac:gx.falseFn};this.declareDomainHdlr(53,function(){});t[54]={id:54,fld:"",grid:0};t[55]={id:55,fld:"",grid:0};t[56]={id:56,fld:"",grid:0};t[57]={id:57,lvl:0,type:"date",len:10,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_ADMITSTARTDATE",gxz:"Z132BR_Medication_AdmitStartDate",gxold:"O132BR_Medication_AdmitStartDate",gxvar:"A132BR_Medication_AdmitStartDate",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A132BR_Medication_AdmitStartDate=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z132BR_Medication_AdmitStartDate=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_ADMITSTARTDATE",gx.O.A132BR_Medication_AdmitStartDate,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A132BR_Medication_AdmitStartDate=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("BR_MEDICATION_ADMITSTARTDATE")},nac:gx.falseFn};this.declareDomainHdlr(57,function(){});t[58]={id:58,fld:"",grid:0};t[59]={id:59,fld:"",grid:0};t[60]={id:60,fld:"",grid:0};t[61]={id:61,lvl:0,type:"date",len:10,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_ADMITENDDATE",gxz:"Z133BR_Medication_AdmitEndDate",gxold:"O133BR_Medication_AdmitEndDate",gxvar:"A133BR_Medication_AdmitEndDate",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A133BR_Medication_AdmitEndDate=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z133BR_Medication_AdmitEndDate=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_ADMITENDDATE",gx.O.A133BR_Medication_AdmitEndDate,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A133BR_Medication_AdmitEndDate=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("BR_MEDICATION_ADMITENDDATE")},nac:gx.falseFn};this.declareDomainHdlr(61,function(){});t[62]={id:62,fld:"",grid:0};t[63]={id:63,fld:"",grid:0};t[64]={id:64,fld:"",grid:0};t[65]={id:65,fld:"",grid:0};t[66]={id:66,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_INPATIENTCHEMO",gxz:"Z131BR_Medication_InpatientChemo",gxold:"O131BR_Medication_InpatientChemo",gxvar:"A131BR_Medication_InpatientChemo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.A131BR_Medication_InpatientChemo=n)},v2z:function(n){n!==undefined&&(gx.O.Z131BR_Medication_InpatientChemo=n)},v2c:function(){gx.fn.setComboBoxValue("BR_MEDICATION_INPATIENTCHEMO",gx.O.A131BR_Medication_InpatientChemo);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A131BR_Medication_InpatientChemo=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_INPATIENTCHEMO")},nac:gx.falseFn};this.declareDomainHdlr(66,function(){});t[67]={id:67,fld:"",grid:0};t[68]={id:68,fld:"",grid:0};t[69]={id:69,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};t[70]={id:70,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_medicationid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATIONID",gxz:"Z119BR_MedicationID",gxold:"O119BR_MedicationID",gxvar:"A119BR_MedicationID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A119BR_MedicationID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z119BR_MedicationID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICATIONID",gx.O.A119BR_MedicationID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A119BR_MedicationID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_MEDICATIONID",",")},nac:gx.falseFn};this.declareDomainHdlr(70,function(){});t[71]={id:71,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A19BR_EncounterID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z19BR_EncounterID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A19BR_EncounterID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",",")},nac:gx.falseFn};this.declareDomainHdlr(71,function(){});t[72]={id:72,lvl:0,type:"svchar",len:2e3,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_PATIENTNO",gxz:"Z36BR_Information_PatientNo",gxold:"O36BR_Information_PatientNo",gxvar:"A36BR_Information_PatientNo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A36BR_Information_PatientNo=n)},v2z:function(n){n!==undefined&&(gx.O.Z36BR_Information_PatientNo=n)},v2c:function(){gx.fn.setControlValue("BR_INFORMATION_PATIENTNO",gx.O.A36BR_Information_PatientNo,0)},c2v:function(){this.val()!==undefined&&(gx.O.A36BR_Information_PatientNo=this.val())},val:function(){return gx.fn.getControlValue("BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};t[73]={id:73,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXID",gxz:"Z120BR_Medication_RXID",gxold:"O120BR_Medication_RXID",gxvar:"A120BR_Medication_RXID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A120BR_Medication_RXID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z120BR_Medication_RXID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_RXID",gx.O.A120BR_Medication_RXID,0)},c2v:function(){this.val()!==undefined&&(gx.O.A120BR_Medication_RXID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_MEDICATION_RXID",",")},nac:gx.falseFn};this.A121BR_Medication_RXName="";this.Z121BR_Medication_RXName="";this.O121BR_Medication_RXName="";this.A122BR_Medication_RXCode="";this.Z122BR_Medication_RXCode="";this.O122BR_Medication_RXCode="";this.A123BR_Medication_RXType="";this.Z123BR_Medication_RXType="";this.O123BR_Medication_RXType="";this.A124BR_Medication_RXDose=0;this.Z124BR_Medication_RXDose=0;this.O124BR_Medication_RXDose=0;this.A125BR_Medication_RXUnit="";this.Z125BR_Medication_RXUnit="";this.O125BR_Medication_RXUnit="";this.A126BR_Medication_RXFrequency="";this.Z126BR_Medication_RXFrequency="";this.O126BR_Medication_RXFrequency="";this.A127BR_Medication_RXQuantity="";this.Z127BR_Medication_RXQuantity="";this.O127BR_Medication_RXQuantity="";this.A128BR_Medication_RXDaysSupply=0;this.Z128BR_Medication_RXDaysSupply=0;this.O128BR_Medication_RXDaysSupply=0;this.A129BR_Medication_RXRoute="";this.Z129BR_Medication_RXRoute="";this.O129BR_Medication_RXRoute="";this.A130BR_Medication_PrescriptionDate=gx.date.nullDate();this.Z130BR_Medication_PrescriptionDate=gx.date.nullDate();this.O130BR_Medication_PrescriptionDate=gx.date.nullDate();this.A132BR_Medication_AdmitStartDate=gx.date.nullDate();this.Z132BR_Medication_AdmitStartDate=gx.date.nullDate();this.O132BR_Medication_AdmitStartDate=gx.date.nullDate();this.A133BR_Medication_AdmitEndDate=gx.date.nullDate();this.Z133BR_Medication_AdmitEndDate=gx.date.nullDate();this.O133BR_Medication_AdmitEndDate=gx.date.nullDate();this.A131BR_Medication_InpatientChemo="";this.Z131BR_Medication_InpatientChemo="";this.O131BR_Medication_InpatientChemo="";this.A119BR_MedicationID=0;this.Z119BR_MedicationID=0;this.O119BR_MedicationID=0;this.A19BR_EncounterID=0;this.Z19BR_EncounterID=0;this.O19BR_EncounterID=0;this.A36BR_Information_PatientNo="";this.Z36BR_Information_PatientNo="";this.O36BR_Information_PatientNo="";this.A120BR_Medication_RXID=0;this.Z120BR_Medication_RXID=0;this.O120BR_Medication_RXID=0;this.A121BR_Medication_RXName="";this.A122BR_Medication_RXCode="";this.A123BR_Medication_RXType="";this.A124BR_Medication_RXDose=0;this.A125BR_Medication_RXUnit="";this.A126BR_Medication_RXFrequency="";this.A127BR_Medication_RXQuantity="";this.A128BR_Medication_RXDaysSupply=0;this.A129BR_Medication_RXRoute="";this.A130BR_Medication_PrescriptionDate=gx.date.nullDate();this.A132BR_Medication_AdmitStartDate=gx.date.nullDate();this.A133BR_Medication_AdmitEndDate=gx.date.nullDate();this.A131BR_Medication_InpatientChemo="";this.A119BR_MedicationID=0;this.A19BR_EncounterID=0;this.A36BR_Information_PatientNo="";this.A120BR_Medication_RXID=0;this.A85BR_Information_ID=0;this.Events={e133m2_client:["ENTER",!0],e143m2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"AV16Pgmname",fld:"vPGMNAME",pic:""},{av:"AV8BR_MedicationID",fld:"vBR_MEDICATIONID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[]];this.EvtParms.LOAD=[[],[{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Visible")',ctrl:"BR_MEDICATIONID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Visible")',ctrl:"BR_ENCOUNTERID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Visible")',ctrl:"BR_INFORMATION_PATIENTNO",prop:"Visible"},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXID","Visible")',ctrl:"BR_MEDICATION_RXID",prop:"Visible"}]];this.Initialize()})