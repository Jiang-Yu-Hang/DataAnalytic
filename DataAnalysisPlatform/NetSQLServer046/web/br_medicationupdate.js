/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:59:12.8
*/
gx.evt.autoSkip=!1;gx.define("br_medicationupdate",!1,function(){var n,t;this.ServerClass="br_medicationupdate";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV22tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE");this.AV10BR_Medication=gx.fn.getControlValue("vBR_MEDICATION");this.AV25BR_MedicationID=gx.fn.getIntegerValue("vBR_MEDICATIONID",",")};this.s112_client=function(){this.AV20vMedicationName=="鍏跺畠"?gx.fn.setCtrlProperty("VOTHERMEDICATIONNAME_CELL","Class","RequiredDataContentCell"):gx.fn.setCtrlProperty("VOTHERMEDICATIONNAME_CELL","Class","DataContentCell");this.AV17vRXFrequency=="鍏跺畠"?gx.fn.setCtrlProperty("VOTHERRXFREQUENCY_CELL","Class","RequiredDataContentCell"):gx.fn.setCtrlProperty("VOTHERRXFREQUENCY_CELL","Class","DataContentCell");this.AV14vUpdateRXRoute=="鍏跺畠"?gx.fn.setCtrlProperty("VRXROUTE_CELL","Class","RequiredDataContentCell"):gx.fn.setCtrlProperty("VRXROUTE_CELL","Class","DataContentCell")};this.e152z1_client=function(){return this.clearMessages(),this.AV20vMedicationName=="鍏跺畠"?gx.fn.setCtrlProperty("vVOTHERMEDICATIONNAME","Visible",!0):gx.fn.setCtrlProperty("vVOTHERMEDICATIONNAME","Visible",!1),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("vVOTHERMEDICATIONNAME","Visible")',ctrl:"vVOTHERMEDICATIONNAME",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e162z1_client=function(){return this.clearMessages(),this.AV14vUpdateRXRoute=="鍏跺畠"?gx.fn.setCtrlProperty("vVRXROUTE","Visible",!0):gx.fn.setCtrlProperty("vVRXROUTE","Visible",!1),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("vVRXROUTE","Visible")',ctrl:"vVRXROUTE",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e172z1_client=function(){return this.clearMessages(),this.AV17vRXFrequency=="鍏跺畠"?gx.fn.setCtrlProperty("vVOTHERRXFREQUENCY","Visible",!0):gx.fn.setCtrlProperty("vVOTHERRXFREQUENCY","Visible",!1),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("vVOTHERRXFREQUENCY","Visible")',ctrl:"vVOTHERRXFREQUENCY",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e142z2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e182z1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,31,32,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,63,64,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,87,88,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122];this.GXLastCtrlId=122;this.DVPANEL_TABLEATTRIBUTESContainer=gx.uc.getNew(this,16,0,"BootstrapPanel","DVPANEL_TABLEATTRIBUTESContainer","Dvpanel_tableattributes","DVPANEL_TABLEATTRIBUTES");t=this.DVPANEL_TABLEATTRIBUTESContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Width","Width","100%","str");t.setProp("Height","Height","100","str");t.setProp("AutoWidth","Autowidth",!1,"bool");t.setProp("AutoHeight","Autoheight",!0,"bool");t.setProp("Cls","Cls","PanelCard_BaseColor","str");t.setProp("ShowHeader","Showheader",!0,"bool");t.setProp("Title","Title","鑽墿娌荤枟","str");t.setProp("Collapsible","Collapsible",!1,"bool");t.setProp("Collapsed","Collapsed",!1,"bool");t.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");t.setProp("IconPosition","Iconposition","left","str");t.setProp("AutoScroll","Autoscroll",!1,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"TABLECONTENT",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};n[18]={id:18,fld:"LAYOUT_TABLEATTRIBUTES",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"TABLEATTRIBUTES",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"TABLESPLITTEDVMEDICATIONNAME",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,fld:"TEXTBLOCKVMEDICATIONNAME",format:0,grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"TABLEMERGEDVMEDICATIONNAME",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:"e152z1_client",evt_cvcing:null,rgrid:[],fld:"vVMEDICATIONNAME",gxz:"ZV20vMedicationName",gxold:"OV20vMedicationName",gxvar:"AV20vMedicationName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.AV20vMedicationName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV20vMedicationName=n)},v2c:function(){gx.fn.setComboBoxValue("vVMEDICATIONNAME",gx.O.AV20vMedicationName)},c2v:function(){this.val()!==undefined&&(gx.O.AV20vMedicationName=this.val())},val:function(){return gx.fn.getControlValue("vVMEDICATIONNAME")},nac:gx.falseFn};n[34]={id:34,fld:"",grid:0};n[35]={id:35,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVOTHERMEDICATIONNAME",gxz:"ZV21vOtherMedicationName",gxold:"OV21vOtherMedicationName",gxvar:"AV21vOtherMedicationName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV21vOtherMedicationName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV21vOtherMedicationName=n)},v2c:function(){gx.fn.setControlValue("vVOTHERMEDICATIONNAME",gx.O.AV21vOtherMedicationName,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV21vOtherMedicationName=this.val())},val:function(){return gx.fn.getControlValue("vVOTHERMEDICATIONNAME")},nac:gx.falseFn};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_BR_MEDICATION_RXCODE",gxz:"ZV28GXV1",gxold:"OV28GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV1=n)},v2z:function(n){n!==undefined&&(gx.O.ZV28GXV1=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_BR_MEDICATION_RXCODE",gx.O.GXV1,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV1=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_BR_MEDICATION_RXCODE")},nac:gx.falseFn};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_BR_MEDICATION_RXTYPE",gxz:"ZV29GXV2",gxold:"OV29GXV2",gxvar:"GXV2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV2=n)},v2z:function(n){n!==undefined&&(gx.O.ZV29GXV2=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_BR_MEDICATION_RXTYPE",gx.O.GXV2,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV2=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_BR_MEDICATION_RXTYPE")},nac:gx.falseFn};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,lvl:0,type:"decimal",len:15,dec:5,sign:!1,pic:"ZZZZZZZZZ.ZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_BR_MEDICATION_RXDOSE",gxz:"ZV30GXV3",gxold:"OV30GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV3=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.ZV30GXV3=gx.fn.toDecimalValue(n,",","."))},v2c:function(){gx.fn.setDecimalValue("BR_MEDICATION_BR_MEDICATION_RXDOSE",gx.O.GXV3,5,".")},c2v:function(){this.val()!==undefined&&(gx.O.GXV3=this.val())},val:function(){return gx.fn.getDecimalValue("BR_MEDICATION_BR_MEDICATION_RXDOSE",",",".")},nac:gx.falseFn};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_BR_MEDICATION_RXUNIT",gxz:"ZV31GXV4",gxold:"OV31GXV4",gxvar:"GXV4",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV4=n)},v2z:function(n){n!==undefined&&(gx.O.ZV31GXV4=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_BR_MEDICATION_RXUNIT",gx.O.GXV4,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV4=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_BR_MEDICATION_RXUNIT")},nac:gx.falseFn};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"TABLESPLITTEDVRXFREQUENCY",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"TEXTBLOCKVRXFREQUENCY",format:0,grid:0};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"TABLEMERGEDVRXFREQUENCY",grid:0};n[63]={id:63,fld:"",grid:0};n[64]={id:64,lvl:0,type:"svchar",len:99,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:"e172z1_client",evt_cvcing:null,rgrid:[],fld:"vVRXFREQUENCY",gxz:"ZV17vRXFrequency",gxold:"OV17vRXFrequency",gxvar:"AV17vRXFrequency",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.AV17vRXFrequency=n)},v2z:function(n){n!==undefined&&(gx.O.ZV17vRXFrequency=n)},v2c:function(){gx.fn.setComboBoxValue("vVRXFREQUENCY",gx.O.AV17vRXFrequency)},c2v:function(){this.val()!==undefined&&(gx.O.AV17vRXFrequency=this.val())},val:function(){return gx.fn.getControlValue("vVRXFREQUENCY")},nac:gx.falseFn};n[66]={id:66,fld:"",grid:0};n[67]={id:67,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVOTHERRXFREQUENCY",gxz:"ZV18vOtherRXFrequency",gxold:"OV18vOtherRXFrequency",gxvar:"AV18vOtherRXFrequency",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV18vOtherRXFrequency=n)},v2z:function(n){n!==undefined&&(gx.O.ZV18vOtherRXFrequency=n)},v2c:function(){gx.fn.setControlValue("vVOTHERRXFREQUENCY",gx.O.AV18vOtherRXFrequency,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV18vOtherRXFrequency=this.val())},val:function(){return gx.fn.getControlValue("vVOTHERRXFREQUENCY")},nac:gx.falseFn};n[68]={id:68,fld:"",grid:0};n[69]={id:69,fld:"",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_BR_MEDICATION_RXQUANTITY",gxz:"ZV32GXV5",gxold:"OV32GXV5",gxvar:"GXV5",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV5=n)},v2z:function(n){n!==undefined&&(gx.O.ZV32GXV5=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_BR_MEDICATION_RXQUANTITY",gx.O.GXV5,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV5=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_BR_MEDICATION_RXQUANTITY")},nac:gx.falseFn};n[73]={id:73,fld:"",grid:0};n[74]={id:74,fld:"",grid:0};n[75]={id:75,fld:"",grid:0};n[76]={id:76,lvl:0,type:"decimal",len:15,dec:5,sign:!1,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_BR_MEDICATION_RXDAYSSUPPLY",gxz:"ZV33GXV6",gxold:"OV33GXV6",gxvar:"GXV6",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV6=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.ZV33GXV6=gx.fn.toDecimalValue(n,",","."))},v2c:function(){gx.fn.setDecimalValue("BR_MEDICATION_BR_MEDICATION_RXDAYSSUPPLY",gx.O.GXV6,5,".")},c2v:function(){this.val()!==undefined&&(gx.O.GXV6=this.val())},val:function(){return gx.fn.getDecimalValue("BR_MEDICATION_BR_MEDICATION_RXDAYSSUPPLY",",",".")},nac:gx.falseFn};n[77]={id:77,fld:"",grid:0};n[78]={id:78,fld:"",grid:0};n[79]={id:79,fld:"TABLESPLITTEDVUPDATERXROUTE",grid:0};n[80]={id:80,fld:"",grid:0};n[81]={id:81,fld:"",grid:0};n[82]={id:82,fld:"TEXTBLOCKVUPDATERXROUTE",format:0,grid:0};n[83]={id:83,fld:"",grid:0};n[84]={id:84,fld:"TABLEMERGEDVUPDATERXROUTE",grid:0};n[87]={id:87,fld:"",grid:0};n[88]={id:88,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:"e162z1_client",evt_cvcing:null,rgrid:[],fld:"vVUPDATERXROUTE",gxz:"ZV14vUpdateRXRoute",gxold:"OV14vUpdateRXRoute",gxvar:"AV14vUpdateRXRoute",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.AV14vUpdateRXRoute=n)},v2z:function(n){n!==undefined&&(gx.O.ZV14vUpdateRXRoute=n)},v2c:function(){gx.fn.setComboBoxValue("vVUPDATERXROUTE",gx.O.AV14vUpdateRXRoute)},c2v:function(){this.val()!==undefined&&(gx.O.AV14vUpdateRXRoute=this.val())},val:function(){return gx.fn.getControlValue("vVUPDATERXROUTE")},nac:gx.falseFn};n[90]={id:90,fld:"",grid:0};n[91]={id:91,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVRXROUTE",gxz:"ZV15vRXRoute",gxold:"OV15vRXRoute",gxvar:"AV15vRXRoute",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV15vRXRoute=n)},v2z:function(n){n!==undefined&&(gx.O.ZV15vRXRoute=n)},v2c:function(){gx.fn.setControlValue("vVRXROUTE",gx.O.AV15vRXRoute,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV15vRXRoute=this.val())},val:function(){return gx.fn.getControlValue("vVRXROUTE")},nac:gx.falseFn};n[92]={id:92,fld:"",grid:0};n[93]={id:93,fld:"",grid:0};n[94]={id:94,fld:"",grid:0};n[95]={id:95,lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_BR_MEDICATION_PRESCRIPTIONDATE",gxz:"ZV34GXV7",gxold:"OV34GXV7",gxvar:"GXV7",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV7=gx.fn.toDatetimeValue(n,"Y4MD"))},v2z:function(n){n!==undefined&&(gx.O.ZV34GXV7=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_BR_MEDICATION_PRESCRIPTIONDATE",gx.O.GXV7,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV7=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("BR_MEDICATION_BR_MEDICATION_PRESCRIPTIONDATE")},nac:gx.falseFn};n[96]={id:96,fld:"",grid:0};n[97]={id:97,fld:"",grid:0};n[98]={id:98,fld:"",grid:0};n[99]={id:99,fld:"",grid:0};n[100]={id:100,lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_BR_MEDICATION_ADMITSTARTDATE",gxz:"ZV35GXV8",gxold:"OV35GXV8",gxvar:"GXV8",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV8=gx.fn.toDatetimeValue(n,"Y4MD"))},v2z:function(n){n!==undefined&&(gx.O.ZV35GXV8=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_BR_MEDICATION_ADMITSTARTDATE",gx.O.GXV8,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV8=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("BR_MEDICATION_BR_MEDICATION_ADMITSTARTDATE")},nac:gx.falseFn};n[101]={id:101,fld:"",grid:0};n[102]={id:102,fld:"",grid:0};n[103]={id:103,fld:"",grid:0};n[104]={id:104,lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_BR_MEDICATION_ADMITENDDATE",gxz:"ZV36GXV9",gxold:"OV36GXV9",gxvar:"GXV9",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV9=gx.fn.toDatetimeValue(n,"Y4MD"))},v2z:function(n){n!==undefined&&(gx.O.ZV36GXV9=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_BR_MEDICATION_ADMITENDDATE",gx.O.GXV9,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV9=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("BR_MEDICATION_BR_MEDICATION_ADMITENDDATE")},nac:gx.falseFn};n[105]={id:105,fld:"",grid:0};n[106]={id:106,fld:"",grid:0};n[107]={id:107,fld:"",grid:0};n[108]={id:108,fld:"",grid:0};n[109]={id:109,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_BR_MEDICATION_INPATIENTCHEMO",gxz:"ZV37GXV10",gxold:"OV37GXV10",gxvar:"GXV10",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.GXV10=n)},v2z:function(n){n!==undefined&&(gx.O.ZV37GXV10=n)},v2c:function(){gx.fn.setComboBoxValue("BR_MEDICATION_BR_MEDICATION_INPATIENTCHEMO",gx.O.GXV10)},c2v:function(){this.val()!==undefined&&(gx.O.GXV10=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_BR_MEDICATION_INPATIENTCHEMO")},nac:gx.falseFn};n[110]={id:110,fld:"",grid:0};n[111]={id:111,fld:"",grid:0};n[112]={id:112,fld:"",grid:0};n[113]={id:113,fld:"",grid:0};n[114]={id:114,fld:"BTNENTER",grid:0};n[115]={id:115,fld:"",grid:0};n[116]={id:116,fld:"BTNCANCEL",grid:0};n[117]={id:117,fld:"",grid:0};n[118]={id:118,fld:"",grid:0};n[119]={id:119,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};n[120]={id:120,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_BR_MEDICATIONID",gxz:"ZV38GXV11",gxold:"OV38GXV11",gxvar:"GXV11",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV11=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV38GXV11=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_BR_MEDICATIONID",gx.O.GXV11,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV11=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_MEDICATION_BR_MEDICATIONID",",")},nac:gx.falseFn};n[121]={id:121,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_BR_ENCOUNTERID",gxz:"ZV39GXV12",gxold:"OV39GXV12",gxvar:"GXV12",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV12=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV39GXV12=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_BR_ENCOUNTERID",gx.O.GXV12,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV12=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_MEDICATION_BR_ENCOUNTERID",",")},nac:gx.falseFn};n[122]={id:122,lvl:0,type:"svchar",len:2e3,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_BR_INFORMATION_PATIENTNO",gxz:"ZV40GXV13",gxold:"OV40GXV13",gxvar:"GXV13",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV13=n)},v2z:function(n){n!==undefined&&(gx.O.ZV40GXV13=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_BR_INFORMATION_PATIENTNO",gx.O.GXV13,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV13=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};this.AV20vMedicationName="";this.ZV20vMedicationName="";this.OV20vMedicationName="";this.AV21vOtherMedicationName="";this.ZV21vOtherMedicationName="";this.OV21vOtherMedicationName="";this.GXV1="";this.ZV28GXV1="";this.OV28GXV1="";this.GXV2="";this.ZV29GXV2="";this.OV29GXV2="";this.GXV3=0;this.ZV30GXV3=0;this.OV30GXV3=0;this.GXV4="";this.ZV31GXV4="";this.OV31GXV4="";this.AV17vRXFrequency="";this.ZV17vRXFrequency="";this.OV17vRXFrequency="";this.AV18vOtherRXFrequency="";this.ZV18vOtherRXFrequency="";this.OV18vOtherRXFrequency="";this.GXV5="";this.ZV32GXV5="";this.OV32GXV5="";this.GXV6=0;this.ZV33GXV6=0;this.OV33GXV6=0;this.AV14vUpdateRXRoute="";this.ZV14vUpdateRXRoute="";this.OV14vUpdateRXRoute="";this.AV15vRXRoute="";this.ZV15vRXRoute="";this.OV15vRXRoute="";this.GXV7=gx.date.nullDate();this.ZV34GXV7=gx.date.nullDate();this.OV34GXV7=gx.date.nullDate();this.GXV8=gx.date.nullDate();this.ZV35GXV8=gx.date.nullDate();this.OV35GXV8=gx.date.nullDate();this.GXV9=gx.date.nullDate();this.ZV36GXV9=gx.date.nullDate();this.OV36GXV9=gx.date.nullDate();this.GXV10="";this.ZV37GXV10="";this.OV37GXV10="";this.GXV11=0;this.ZV38GXV11=0;this.OV38GXV11=0;this.GXV12=0;this.ZV39GXV12=0;this.OV39GXV12=0;this.GXV13="";this.ZV40GXV13="";this.OV40GXV13="";this.AV20vMedicationName="";this.AV21vOtherMedicationName="";this.GXV1="";this.GXV2="";this.GXV3=0;this.GXV4="";this.AV17vRXFrequency="";this.AV18vOtherRXFrequency="";this.GXV5="";this.GXV6=0;this.AV14vUpdateRXRoute="";this.AV15vRXRoute="";this.GXV7=gx.date.nullDate();this.GXV8=gx.date.nullDate();this.GXV9=gx.date.nullDate();this.GXV10="";this.GXV11=0;this.GXV12=0;this.GXV13="";this.AV25BR_MedicationID=0;this.AV10BR_Medication={BR_MedicationID:0,BR_EncounterID:0,BR_Information_PatientNo:"",BR_Medication_RXID:0,BR_Medication_RXName:"",BR_Medication_RXName_Code:"",BR_Medication_RXCode:"",BR_Medication_RXType:"",BR_Medication_RXDose:0,BR_Medication_RXUnit:"",BR_Medication_RXFrequency:"",BR_Medication_RXFrequency_Code:"",BR_Medication_RXQuantity:"",BR_Medication_RXDaysSupply:0,BR_Medication_RXRoute:"",BR_Medication_RXRoute_Code:"",BR_Medication_PrescriptionDate:gx.date.nullDate(),BR_Medication_AdmitStartDate:gx.date.nullDate(),BR_Medication_AdmitEndDate:gx.date.nullDate(),BR_Medication_InpatientChemo:"",BR_Medication_InpatientChemo_Code:"",Mode:"",Initialized:0,BR_MedicationID_Z:0,BR_EncounterID_Z:0,BR_Information_PatientNo_Z:"",BR_Medication_RXID_Z:0,BR_Medication_RXName_Z:"",BR_Medication_RXName_Code_Z:"",BR_Medication_RXCode_Z:"",BR_Medication_RXType_Z:"",BR_Medication_RXDose_Z:0,BR_Medication_RXUnit_Z:"",BR_Medication_RXFrequency_Z:"",BR_Medication_RXFrequency_Code_Z:"",BR_Medication_RXQuantity_Z:"",BR_Medication_RXDaysSupply_Z:0,BR_Medication_RXRoute_Z:"",BR_Medication_RXRoute_Code_Z:"",BR_Medication_PrescriptionDate_Z:gx.date.nullDate(),BR_Medication_AdmitStartDate_Z:gx.date.nullDate(),BR_Medication_AdmitEndDate_Z:gx.date.nullDate(),BR_Medication_InpatientChemo_Z:"",BR_Medication_InpatientChemo_Code_Z:""};this.Events={e142z2_client:["ENTER",!0],e182z1_client:["CANCEL",!0],e152z1_client:["VVMEDICATIONNAME.CONTROLVALUECHANGED",!1],e162z1_client:["VVUPDATERXROUTE.CONTROLVALUECHANGED",!1],e172z1_client:["VVRXFREQUENCY.CONTROLVALUECHANGED",!1]};this.EvtParms.REFRESH=[[{av:"AV25BR_MedicationID",fld:"vBR_MEDICATIONID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[]];this.EvtParms.START=[[{av:"AV25BR_MedicationID",fld:"vBR_MEDICATIONID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{ctrl:"vVMEDICATIONNAME"},{av:"AV20vMedicationName",fld:"vVMEDICATIONNAME",pic:""},{ctrl:"vVRXFREQUENCY"},{av:"AV17vRXFrequency",fld:"vVRXFREQUENCY",pic:""},{ctrl:"vVUPDATERXROUTE"},{av:"AV14vUpdateRXRoute",fld:"vVUPDATERXROUTE",pic:""}],[{ctrl:"BR_MEDICATION_BR_MEDICATIONID",prop:"Visible"},{ctrl:"BR_MEDICATION_BR_ENCOUNTERID",prop:"Visible"},{ctrl:"BR_MEDICATION_BR_INFORMATION_PATIENTNO",prop:"Visible"},{av:"AV10BR_Medication",fld:"vBR_MEDICATION",pic:""},{av:'gx.fn.getCtrlProperty("vVRXROUTE","Visible")',ctrl:"vVRXROUTE",prop:"Visible"},{av:'gx.fn.getCtrlProperty("vVOTHERRXFREQUENCY","Visible")',ctrl:"vVOTHERRXFREQUENCY",prop:"Visible"},{av:'gx.fn.getCtrlProperty("vVOTHERMEDICATIONNAME","Visible")',ctrl:"vVOTHERMEDICATIONNAME",prop:"Visible"},{av:'gx.fn.getCtrlProperty("VOTHERMEDICATIONNAME_CELL","Class")',ctrl:"VOTHERMEDICATIONNAME_CELL",prop:"Class"},{av:'gx.fn.getCtrlProperty("VOTHERRXFREQUENCY_CELL","Class")',ctrl:"VOTHERRXFREQUENCY_CELL",prop:"Class"},{av:'gx.fn.getCtrlProperty("VRXROUTE_CELL","Class")',ctrl:"VRXROUTE_CELL",prop:"Class"}]];this.EvtParms.LOAD=[[{av:"AV10BR_Medication",fld:"vBR_MEDICATION",pic:""},{ctrl:"vVUPDATERXROUTE"},{av:"AV14vUpdateRXRoute",fld:"vVUPDATERXROUTE",pic:""},{ctrl:"vVRXFREQUENCY"},{av:"AV17vRXFrequency",fld:"vVRXFREQUENCY",pic:""},{ctrl:"vVMEDICATIONNAME"},{av:"AV20vMedicationName",fld:"vVMEDICATIONNAME",pic:""}],[{ctrl:"vVUPDATERXROUTE"},{av:"AV14vUpdateRXRoute",fld:"vVUPDATERXROUTE",pic:""},{ctrl:"vVRXFREQUENCY"},{av:"AV17vRXFrequency",fld:"vVRXFREQUENCY",pic:""},{ctrl:"vVMEDICATIONNAME"},{av:"AV20vMedicationName",fld:"vVMEDICATIONNAME",pic:""}]];this.EvtParms["VVMEDICATIONNAME.CONTROLVALUECHANGED"]=[[{ctrl:"vVMEDICATIONNAME"},{av:"AV20vMedicationName",fld:"vVMEDICATIONNAME",pic:""}],[{av:'gx.fn.getCtrlProperty("vVOTHERMEDICATIONNAME","Visible")',ctrl:"vVOTHERMEDICATIONNAME",prop:"Visible"}]];this.EvtParms["VVUPDATERXROUTE.CONTROLVALUECHANGED"]=[[{ctrl:"vVUPDATERXROUTE"},{av:"AV14vUpdateRXRoute",fld:"vVUPDATERXROUTE",pic:""}],[{av:'gx.fn.getCtrlProperty("vVRXROUTE","Visible")',ctrl:"vVRXROUTE",prop:"Visible"}]];this.EvtParms["VVRXFREQUENCY.CONTROLVALUECHANGED"]=[[{ctrl:"vVRXFREQUENCY"},{av:"AV17vRXFrequency",fld:"vVRXFREQUENCY",pic:""}],[{av:'gx.fn.getCtrlProperty("vVOTHERRXFREQUENCY","Visible")',ctrl:"vVOTHERRXFREQUENCY",prop:"Visible"}]];this.EvtParms.ENTER=[[{ctrl:"vVMEDICATIONNAME"},{av:"AV20vMedicationName",fld:"vVMEDICATIONNAME",pic:""},{av:"AV21vOtherMedicationName",fld:"vVOTHERMEDICATIONNAME",pic:""},{av:"AV10BR_Medication",fld:"vBR_MEDICATION",pic:""},{ctrl:"vVRXFREQUENCY"},{av:"AV17vRXFrequency",fld:"vVRXFREQUENCY",pic:""},{av:"AV18vOtherRXFrequency",fld:"vVOTHERRXFREQUENCY",pic:""},{ctrl:"vVUPDATERXROUTE"},{av:"AV14vUpdateRXRoute",fld:"vVUPDATERXROUTE",pic:""},{av:"AV15vRXRoute",fld:"vVRXROUTE",pic:""}],[{av:"AV10BR_Medication",fld:"vBR_MEDICATION",pic:""}]];this.EnterCtrl=["BTNENTER"];this.setVCMap("AV22tCurrentCode","vTCURRENTCODE",0,"svchar",40,0);this.setVCMap("AV10BR_Medication","vBR_MEDICATION",0,"BR_Medication",0,0);this.setVCMap("AV25BR_MedicationID","vBR_MEDICATIONID",0,"int",18,0);this.addBCProperty("Br_medication",["BR_Medication_RXCode"],this.GXValidFnc[39],"AV10BR_Medication");this.addBCProperty("Br_medication",["BR_Medication_RXType"],this.GXValidFnc[44],"AV10BR_Medication");this.addBCProperty("Br_medication",["BR_Medication_RXDose"],this.GXValidFnc[48],"AV10BR_Medication");this.addBCProperty("Br_medication",["BR_Medication_RXUnit"],this.GXValidFnc[53],"AV10BR_Medication");this.addBCProperty("Br_medication",["BR_Medication_RXQuantity"],this.GXValidFnc[72],"AV10BR_Medication");this.addBCProperty("Br_medication",["BR_Medication_RXDaysSupply"],this.GXValidFnc[76],"AV10BR_Medication");this.addBCProperty("Br_medication",["BR_Medication_PrescriptionDate"],this.GXValidFnc[95],"AV10BR_Medication");this.addBCProperty("Br_medication",["BR_Medication_AdmitStartDate"],this.GXValidFnc[100],"AV10BR_Medication");this.addBCProperty("Br_medication",["BR_Medication_AdmitEndDate"],this.GXValidFnc[104],"AV10BR_Medication");this.addBCProperty("Br_medication",["BR_Medication_InpatientChemo"],this.GXValidFnc[109],"AV10BR_Medication");this.addBCProperty("Br_medication",["BR_MedicationID"],this.GXValidFnc[120],"AV10BR_Medication");this.addBCProperty("Br_medication",["BR_EncounterID"],this.GXValidFnc[121],"AV10BR_Medication");this.addBCProperty("Br_medication",["BR_Information_PatientNo"],this.GXValidFnc[122],"AV10BR_Medication");this.Initialize()});gx.createParentObj(br_medicationupdate)