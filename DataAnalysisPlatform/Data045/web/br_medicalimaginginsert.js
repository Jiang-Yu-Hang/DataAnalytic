/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:17:8.40
*/
gx.evt.autoSkip=!1;gx.define("br_medicalimaginginsert",!1,function(){var n,t;this.ServerClass="br_medicalimaginginsert";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV17tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE");this.AV10BR_MedicalImaging=gx.fn.getControlValue("vBR_MEDICALIMAGING");this.AV18BR_EncounterID=gx.fn.getIntegerValue("vBR_ENCOUNTERID",",")};this.Validv_Vmetastasesdx=function(){try{var n=gx.util.balloon.getNew("vVMETASTASESDX");if(this.AnyError=0,!(this.AV23vMetastasesDX=="否"||this.AV23vMetastasesDX=="是"||this.AV23vMetastasesDX=="不详"||""==this.AV23vMetastasesDX))try{n.setError("域v Metastases DX超界");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Validv_Vmetadate=function(){try{var n=gx.util.balloon.getNew("vVMETADATE");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.s112_client=function(){this.AV11vName=="其它"?gx.fn.setCtrlProperty("VOTHERNAME_CELL","Class","RequiredDataContentCell"):gx.fn.setCtrlProperty("VOTHERNAME_CELL","Class","DataContentCell");this.AV14wzName=="其它"?gx.fn.setCtrlProperty("WXNAME_CELL","Class","RequiredDataContentCell"):gx.fn.setCtrlProperty("WXNAME_CELL","Class","DataContentCell")};this.e15971_client=function(){return this.clearMessages(),this.AV23vMetastasesDX=="是"?(gx.fn.setCtrlProperty("vVMETADATE","Visible",!0),gx.fn.setCtrlProperty("vVMETALOC","Visible",!0)):(gx.fn.setCtrlProperty("vVMETADATE","Visible",!1),gx.fn.setCtrlProperty("vVMETALOC","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("vVMETADATE","Visible")',ctrl:"vVMETADATE",prop:"Visible"},{av:'gx.fn.getCtrlProperty("vVMETALOC","Visible")',ctrl:"vVMETALOC",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e16971_client=function(){return this.clearMessages(),this.AV11vName=="其它"?gx.fn.setCtrlProperty("vVOTHERNAME","Visible",!0):gx.fn.setCtrlProperty("vVOTHERNAME","Visible",!1),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("vVOTHERNAME","Visible")',ctrl:"vVOTHERNAME",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e17971_client=function(){return this.clearMessages(),this.AV14wzName=="其它"?gx.fn.setCtrlProperty("vWXNAME","Visible",!0):gx.fn.setCtrlProperty("vWXNAME","Visible",!1),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("vWXNAME","Visible")',ctrl:"vWXNAME",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e13972_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e18971_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,35,36,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,90,91,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125];this.GXLastCtrlId=125;this.DVPANEL_TABLEATTRIBUTESContainer=gx.uc.getNew(this,16,0,"BootstrapPanel","DVPANEL_TABLEATTRIBUTESContainer","Dvpanel_tableattributes","DVPANEL_TABLEATTRIBUTES");t=this.DVPANEL_TABLEATTRIBUTESContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Width","Width","100%","str");t.setProp("Height","Height","100","str");t.setProp("AutoWidth","Autowidth",!1,"bool");t.setProp("AutoHeight","Autoheight",!0,"bool");t.setProp("Cls","Cls","PanelCard_BaseColor","str");t.setProp("ShowHeader","Showheader",!0,"bool");t.setProp("Title","Title","影像学","str");t.setProp("Collapsible","Collapsible",!1,"bool");t.setProp("Collapsed","Collapsed",!1,"bool");t.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");t.setProp("IconPosition","Iconposition","left","str");t.setProp("AutoScroll","Autoscroll",!1,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"TABLECONTENT",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};n[18]={id:18,fld:"LAYOUT_TABLEATTRIBUTES",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"TABLEATTRIBUTES",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_NO",gxz:"ZV29GXV1",gxold:"OV29GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV1=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV29GXV1=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_NO",gx.O.GXV1,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV1=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_NO",",")},nac:gx.falseFn};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"TABLESPLITTEDVNAME",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"TEXTBLOCKVNAME",format:0,grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"TABLEMERGEDVNAME",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:"e16971_client",evt_cvcing:null,rgrid:[],fld:"vVNAME",gxz:"ZV11vName",gxold:"OV11vName",gxvar:"AV11vName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.AV11vName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11vName=n)},v2c:function(){gx.fn.setComboBoxValue("vVNAME",gx.O.AV11vName)},c2v:function(){this.val()!==undefined&&(gx.O.AV11vName=this.val())},val:function(){return gx.fn.getControlValue("vVNAME")},nac:gx.falseFn};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVOTHERNAME",gxz:"ZV12vOtherName",gxold:"OV12vOtherName",gxvar:"AV12vOtherName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12vOtherName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12vOtherName=n)},v2c:function(){gx.fn.setControlValue("vVOTHERNAME",gx.O.AV12vOtherName,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12vOtherName=this.val())},val:function(){return gx.fn.getControlValue("vVOTHERNAME")},nac:gx.falseFn};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDATE",gxz:"ZV30GXV2",gxold:"OV30GXV2",gxvar:"GXV2",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV2=gx.fn.toDatetimeValue(n,"Y4MD"))},v2z:function(n){n!==undefined&&(gx.O.ZV30GXV2=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDATE",gx.O.GXV2,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV2=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDATE")},nac:gx.falseFn};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEHOSP",gxz:"ZV31GXV3",gxold:"OV31GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.GXV3=n)},v2z:function(n){n!==undefined&&(gx.O.ZV31GXV3=n)},v2c:function(){gx.fn.setComboBoxValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEHOSP",gx.O.GXV3)},c2v:function(){this.val()!==undefined&&(gx.O.GXV3=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEHOSP")},nac:gx.falseFn};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,lvl:0,type:"int",len:3,dec:0,sign:!1,pic:"ZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEAGE",gxz:"ZV32GXV4",gxold:"OV32GXV4",gxvar:"GXV4",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV4=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV32GXV4=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEAGE",gx.O.GXV4,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV4=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEAGE",",")},nac:gx.falseFn};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_TUMORSIZE",gxz:"ZV33GXV5",gxold:"OV33GXV5",gxvar:"GXV5",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV5=n)},v2z:function(n){n!==undefined&&(gx.O.ZV33GXV5=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_TUMORSIZE",gx.O.GXV5,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV5=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_TUMORSIZE")},nac:gx.falseFn};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vmetastasesdx,isvalid:null,evt_cvc:"e15971_client",evt_cvcing:null,rgrid:[],fld:"vVMETASTASESDX",gxz:"ZV23vMetastasesDX",gxold:"OV23vMetastasesDX",gxvar:"AV23vMetastasesDX",ucs:[],op:[62],ip:[62],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.AV23vMetastasesDX=n)},v2z:function(n){n!==undefined&&(gx.O.ZV23vMetastasesDX=n)},v2c:function(){gx.fn.setComboBoxValue("vVMETASTASESDX",gx.O.AV23vMetastasesDX)},c2v:function(){this.val()!==undefined&&(gx.O.AV23vMetastasesDX=this.val())},val:function(){return gx.fn.getControlValue("vVMETASTASESDX")},nac:gx.falseFn};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,fld:"",grid:0};n[67]={id:67,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVMETALOC",gxz:"ZV24vMetaLoc",gxold:"OV24vMetaLoc",gxvar:"AV24vMetaLoc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV24vMetaLoc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV24vMetaLoc=n)},v2c:function(){gx.fn.setControlValue("vVMETALOC",gx.O.AV24vMetaLoc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV24vMetaLoc=this.val())},val:function(){return gx.fn.getControlValue("vVMETALOC")},nac:gx.falseFn};n[68]={id:68,fld:"",grid:0};n[69]={id:69,fld:"",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vmetadate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVMETADATE",gxz:"ZV25vMetaDate",gxold:"OV25vMetaDate",gxvar:"AV25vMetaDate",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV25vMetaDate=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV25vMetaDate=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vVMETADATE",gx.O.AV25vMetaDate,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV25vMetaDate=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("vVMETADATE")},nac:gx.falseFn};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"",grid:0};n[74]={id:74,fld:"UNNAMEDTABLEBR_MEDICALIMAGING_BR_MEDICALIMAGING_PREIMAGEDIAG",grid:0};n[75]={id:75,fld:"",grid:0};n[76]={id:76,fld:"",grid:0};n[77]={id:77,fld:"TEXTBLOCKBR_MEDICALIMAGING_BR_MEDICALIMAGING_PREIMAGEDIAG",format:0,grid:0};n[78]={id:78,fld:"",grid:0};n[79]={id:79,fld:"",grid:0};n[80]={id:80,lvl:0,type:"svchar",len:4e3,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_PREIMAGEDIAG",gxz:"ZV34GXV6",gxold:"OV34GXV6",gxvar:"GXV6",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV6=n)},v2z:function(n){n!==undefined&&(gx.O.ZV34GXV6=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_PREIMAGEDIAG",gx.O.GXV6,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV6=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_PREIMAGEDIAG")},nac:gx.falseFn};n[81]={id:81,fld:"",grid:0};n[82]={id:82,fld:"TABLESPLITTEDWZNAME",grid:0};n[83]={id:83,fld:"",grid:0};n[84]={id:84,fld:"",grid:0};n[85]={id:85,fld:"TEXTBLOCKWZNAME",format:0,grid:0};n[86]={id:86,fld:"",grid:0};n[87]={id:87,fld:"TABLEMERGEDWZNAME",grid:0};n[90]={id:90,fld:"",grid:0};n[91]={id:91,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:"e17971_client",evt_cvcing:null,rgrid:[],fld:"vWZNAME",gxz:"ZV14wzName",gxold:"OV14wzName",gxvar:"AV14wzName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.AV14wzName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV14wzName=n)},v2c:function(){gx.fn.setComboBoxValue("vWZNAME",gx.O.AV14wzName)},c2v:function(){this.val()!==undefined&&(gx.O.AV14wzName=this.val())},val:function(){return gx.fn.getControlValue("vWZNAME")},nac:gx.falseFn};n[93]={id:93,fld:"",grid:0};n[94]={id:94,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vWXNAME",gxz:"ZV15wxName",gxold:"OV15wxName",gxvar:"AV15wxName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV15wxName=n)},v2z:function(n){n!==undefined&&(gx.O.ZV15wxName=n)},v2c:function(){gx.fn.setControlValue("vWXNAME",gx.O.AV15wxName,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV15wxName=this.val())},val:function(){return gx.fn.getControlValue("vWXNAME")},nac:gx.falseFn};n[95]={id:95,fld:"",grid:0};n[96]={id:96,fld:"",grid:0};n[97]={id:97,fld:"UNNAMEDTABLEBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEORGAN",grid:0};n[98]={id:98,fld:"",grid:0};n[99]={id:99,fld:"",grid:0};n[100]={id:100,fld:"TEXTBLOCKBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEORGAN",format:0,grid:0};n[101]={id:101,fld:"",grid:0};n[102]={id:102,fld:"",grid:0};n[103]={id:103,lvl:0,type:"svchar",len:5e3,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEORGAN",gxz:"ZV35GXV7",gxold:"OV35GXV7",gxvar:"GXV7",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV7=n)},v2z:function(n){n!==undefined&&(gx.O.ZV35GXV7=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEORGAN",gx.O.GXV7,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV7=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEORGAN")},nac:gx.falseFn};n[104]={id:104,fld:"",grid:0};n[105]={id:105,fld:"UNNAMEDTABLEBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDES",grid:0};n[106]={id:106,fld:"",grid:0};n[107]={id:107,fld:"",grid:0};n[108]={id:108,fld:"TEXTBLOCKBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDES",format:0,grid:0};n[109]={id:109,fld:"",grid:0};n[110]={id:110,fld:"",grid:0};n[111]={id:111,lvl:0,type:"svchar",len:9999,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDES",gxz:"ZV36GXV8",gxold:"OV36GXV8",gxvar:"GXV8",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV8=n)},v2z:function(n){n!==undefined&&(gx.O.ZV36GXV8=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDES",gx.O.GXV8,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV8=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDES")},nac:gx.falseFn};n[112]={id:112,fld:"",grid:0};n[113]={id:113,fld:"",grid:0};n[114]={id:114,fld:"",grid:0};n[115]={id:115,fld:"",grid:0};n[116]={id:116,fld:"BTNENTER",grid:0};n[117]={id:117,fld:"",grid:0};n[118]={id:118,fld:"BTNCANCEL",grid:0};n[119]={id:119,fld:"",grid:0};n[120]={id:120,fld:"",grid:0};n[121]={id:121,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};n[122]={id:122,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGINGID",gxz:"ZV37GXV9",gxold:"OV37GXV9",gxvar:"GXV9",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV9=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV37GXV9=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGINGID",gx.O.GXV9,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV9=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_BR_MEDICALIMAGINGID",",")},nac:gx.falseFn};n[123]={id:123,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_ENCOUNTERID",gxz:"ZV38GXV10",gxold:"OV38GXV10",gxvar:"GXV10",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV10=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV38GXV10=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_ENCOUNTERID",gx.O.GXV10,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV10=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_BR_ENCOUNTERID",",")},nac:gx.falseFn};n[124]={id:124,lvl:0,type:"svchar",len:2e3,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_INFORMATION_PATIENTNO",gxz:"ZV39GXV11",gxold:"OV39GXV11",gxvar:"GXV11",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV11=n)},v2z:function(n){n!==undefined&&(gx.O.ZV39GXV11=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_INFORMATION_PATIENTNO",gx.O.GXV11,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV11=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};n[125]={id:125,lvl:0,type:"int",len:10,dec:0,sign:!1,pic:"ZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_ID",gxz:"ZV40GXV12",gxold:"OV40GXV12",gxvar:"GXV12",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV12=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV40GXV12=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_ID",gx.O.GXV12,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV12=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_ID",",")},nac:gx.falseFn};this.GXV1=0;this.ZV29GXV1=0;this.OV29GXV1=0;this.AV11vName="";this.ZV11vName="";this.OV11vName="";this.AV12vOtherName="";this.ZV12vOtherName="";this.OV12vOtherName="";this.GXV2=gx.date.nullDate();this.ZV30GXV2=gx.date.nullDate();this.OV30GXV2=gx.date.nullDate();this.GXV3="";this.ZV31GXV3="";this.OV31GXV3="";this.GXV4=0;this.ZV32GXV4=0;this.OV32GXV4=0;this.GXV5="";this.ZV33GXV5="";this.OV33GXV5="";this.AV23vMetastasesDX="";this.ZV23vMetastasesDX="";this.OV23vMetastasesDX="";this.AV24vMetaLoc="";this.ZV24vMetaLoc="";this.OV24vMetaLoc="";this.AV25vMetaDate=gx.date.nullDate();this.ZV25vMetaDate=gx.date.nullDate();this.OV25vMetaDate=gx.date.nullDate();this.GXV6="";this.ZV34GXV6="";this.OV34GXV6="";this.AV14wzName="";this.ZV14wzName="";this.OV14wzName="";this.AV15wxName="";this.ZV15wxName="";this.OV15wxName="";this.GXV7="";this.ZV35GXV7="";this.OV35GXV7="";this.GXV8="";this.ZV36GXV8="";this.OV36GXV8="";this.GXV9=0;this.ZV37GXV9=0;this.OV37GXV9=0;this.GXV10=0;this.ZV38GXV10=0;this.OV38GXV10=0;this.GXV11="";this.ZV39GXV11="";this.OV39GXV11="";this.GXV12=0;this.ZV40GXV12=0;this.OV40GXV12=0;this.GXV1=0;this.AV11vName="";this.AV12vOtherName="";this.GXV2=gx.date.nullDate();this.GXV3="";this.GXV4=0;this.GXV5="";this.AV23vMetastasesDX="";this.AV24vMetaLoc="";this.AV25vMetaDate=gx.date.nullDate();this.GXV6="";this.AV14wzName="";this.AV15wxName="";this.GXV7="";this.GXV8="";this.GXV9=0;this.GXV10=0;this.GXV11="";this.GXV12=0;this.AV18BR_EncounterID=0;this.AV10BR_MedicalImaging={BR_MedicalImagingID:0,BR_EncounterID:0,BR_Information_PatientNo:"",BR_MedicalImaging_ID:0,BR_MedicalImaging_No:0,BR_MedicalImaging_ImageName:"",BR_MedicalImaging_ImageName_Code:"",BR_MedicalImaging_ImageDate:gx.date.nullDate(),BR_MedicalImaging_ImageHosp:"",BR_MedicalImaging_ImageHosp_Code:"",BR_MedicalImaging_ImageAge:0,BR_MedicalImaging_ImageLoc:"",BR_MedicalImaging_ImageLoc_Code:"",BR_MedicalImaging_ImageOrgan:"",BR_MedicalImaging_PreImageDiag:"",BR_MedicalImaging_ImageDes:"",BR_MedicalImaging_TumorSize:"",BR_MedicalImaging_ImageHtml:"",BR_MedicalImaging_MetastasesDX:"",BR_MedicalImaging_MetaLoc:"",BR_MedicalImaging_MetaDate:gx.date.nullDate(),Mode:"",Initialized:0,BR_MedicalImagingID_Z:0,BR_EncounterID_Z:0,BR_Information_PatientNo_Z:"",BR_MedicalImaging_ID_Z:0,BR_MedicalImaging_No_Z:0,BR_MedicalImaging_ImageName_Z:"",BR_MedicalImaging_ImageName_Code_Z:"",BR_MedicalImaging_ImageDate_Z:gx.date.nullDate(),BR_MedicalImaging_ImageHosp_Z:"",BR_MedicalImaging_ImageHosp_Code_Z:"",BR_MedicalImaging_ImageAge_Z:0,BR_MedicalImaging_ImageLoc_Z:"",BR_MedicalImaging_ImageLoc_Code_Z:"",BR_MedicalImaging_ImageOrgan_Z:"",BR_MedicalImaging_PreImageDiag_Z:"",BR_MedicalImaging_ImageDes_Z:"",BR_MedicalImaging_TumorSize_Z:"",BR_MedicalImaging_ImageHtml_Z:"",BR_MedicalImaging_MetastasesDX_Z:"",BR_MedicalImaging_MetaLoc_Z:"",BR_MedicalImaging_MetaDate_Z:gx.date.nullDate()};this.Events={e13972_client:["ENTER",!0],e18971_client:["CANCEL",!0],e15971_client:["VVMETASTASESDX.CONTROLVALUECHANGED",!1],e16971_client:["VVNAME.CONTROLVALUECHANGED",!1],e17971_client:["VWZNAME.CONTROLVALUECHANGED",!1]};this.EvtParms.REFRESH=[[{av:"AV18BR_EncounterID",fld:"vBR_ENCOUNTERID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[]];this.EvtParms.START=[[{av:"AV10BR_MedicalImaging",fld:"vBR_MEDICALIMAGING",pic:""},{ctrl:"vVNAME"},{av:"AV11vName",fld:"vVNAME",pic:""},{ctrl:"vWZNAME"},{av:"AV14wzName",fld:"vWZNAME",pic:""}],[{ctrl:"BR_MEDICALIMAGING_BR_MEDICALIMAGINGID",prop:"Visible"},{ctrl:"BR_MEDICALIMAGING_BR_ENCOUNTERID",prop:"Visible"},{ctrl:"BR_MEDICALIMAGING_BR_INFORMATION_PATIENTNO",prop:"Visible"},{ctrl:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_ID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("vVOTHERNAME","Visible")',ctrl:"vVOTHERNAME",prop:"Visible"},{av:'gx.fn.getCtrlProperty("vWXNAME","Visible")',ctrl:"vWXNAME",prop:"Visible"},{av:"AV24vMetaLoc",fld:"vVMETALOC",pic:""},{av:"AV25vMetaDate",fld:"vVMETADATE",pic:""},{av:'gx.fn.getCtrlProperty("VOTHERNAME_CELL","Class")',ctrl:"VOTHERNAME_CELL",prop:"Class"},{av:'gx.fn.getCtrlProperty("WXNAME_CELL","Class")',ctrl:"WXNAME_CELL",prop:"Class"}]];this.EvtParms["VVMETASTASESDX.CONTROLVALUECHANGED"]=[[{ctrl:"vVMETASTASESDX"},{av:"AV23vMetastasesDX",fld:"vVMETASTASESDX",pic:""}],[{av:'gx.fn.getCtrlProperty("vVMETADATE","Visible")',ctrl:"vVMETADATE",prop:"Visible"},{av:'gx.fn.getCtrlProperty("vVMETALOC","Visible")',ctrl:"vVMETALOC",prop:"Visible"}]];this.EvtParms.ENTER=[[{av:"AV10BR_MedicalImaging",fld:"vBR_MEDICALIMAGING",pic:""},{ctrl:"vVNAME"},{av:"AV11vName",fld:"vVNAME",pic:""},{av:"AV12vOtherName",fld:"vVOTHERNAME",pic:""},{ctrl:"vWZNAME"},{av:"AV14wzName",fld:"vWZNAME",pic:""},{av:"AV15wxName",fld:"vWXNAME",pic:""},{av:"AV18BR_EncounterID",fld:"vBR_ENCOUNTERID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV24vMetaLoc",fld:"vVMETALOC",pic:""},{av:"AV25vMetaDate",fld:"vVMETADATE",pic:""},{ctrl:"vVMETASTASESDX"},{av:"AV23vMetastasesDX",fld:"vVMETASTASESDX",pic:""}],[{av:"AV10BR_MedicalImaging",fld:"vBR_MEDICALIMAGING",pic:""}]];this.EvtParms["VVNAME.CONTROLVALUECHANGED"]=[[{ctrl:"vVNAME"},{av:"AV11vName",fld:"vVNAME",pic:""}],[{av:'gx.fn.getCtrlProperty("vVOTHERNAME","Visible")',ctrl:"vVOTHERNAME",prop:"Visible"}]];this.EvtParms["VWZNAME.CONTROLVALUECHANGED"]=[[{ctrl:"vWZNAME"},{av:"AV14wzName",fld:"vWZNAME",pic:""}],[{av:'gx.fn.getCtrlProperty("vWXNAME","Visible")',ctrl:"vWXNAME",prop:"Visible"}]];this.EvtParms.LOAD=[[{av:"AV20BR_MedicalImagingID",fld:"vBR_MEDICALIMAGINGID",pic:"ZZZZZZZZZZZZZZZZZZ"},{ctrl:"vVNAME"},{av:"AV11vName",fld:"vVNAME",pic:""},{ctrl:"vWZNAME"},{av:"AV14wzName",fld:"vWZNAME",pic:""},{ctrl:"vVMETASTASESDX"},{av:"AV23vMetastasesDX",fld:"vVMETASTASESDX",pic:""}],[{av:"AV10BR_MedicalImaging",fld:"vBR_MEDICALIMAGING",pic:""},{av:'gx.fn.getCtrlProperty("vVMETADATE","Visible")',ctrl:"vVMETADATE",prop:"Visible"},{av:'gx.fn.getCtrlProperty("vVMETALOC","Visible")',ctrl:"vVMETALOC",prop:"Visible"},{ctrl:"vVNAME"},{av:"AV11vName",fld:"vVNAME",pic:""},{ctrl:"vWZNAME"},{av:"AV14wzName",fld:"vWZNAME",pic:""},{ctrl:"vVMETASTASESDX"},{av:"AV23vMetastasesDX",fld:"vVMETASTASESDX",pic:""}]];this.EnterCtrl=["BTNENTER"];this.setVCMap("AV17tCurrentCode","vTCURRENTCODE",0,"svchar",40,0);this.setVCMap("AV10BR_MedicalImaging","vBR_MEDICALIMAGING",0,"BR_MedicalImaging",0,0);this.setVCMap("AV18BR_EncounterID","vBR_ENCOUNTERID",0,"int",18,0);this.addBCProperty("Br_medicalimaging",["BR_MedicalImaging_No"],this.GXValidFnc[25],"AV10BR_MedicalImaging");this.addBCProperty("Br_medicalimaging",["BR_MedicalImaging_ImageDate"],this.GXValidFnc[44],"AV10BR_MedicalImaging");this.addBCProperty("Br_medicalimaging",["BR_MedicalImaging_ImageHosp"],this.GXValidFnc[48],"AV10BR_MedicalImaging");this.addBCProperty("Br_medicalimaging",["BR_MedicalImaging_ImageAge"],this.GXValidFnc[53],"AV10BR_MedicalImaging");this.addBCProperty("Br_medicalimaging",["BR_MedicalImaging_TumorSize"],this.GXValidFnc[57],"AV10BR_MedicalImaging");this.addBCProperty("Br_medicalimaging",["BR_MedicalImaging_PreImageDiag"],this.GXValidFnc[80],"AV10BR_MedicalImaging");this.addBCProperty("Br_medicalimaging",["BR_MedicalImaging_ImageOrgan"],this.GXValidFnc[103],"AV10BR_MedicalImaging");this.addBCProperty("Br_medicalimaging",["BR_MedicalImaging_ImageDes"],this.GXValidFnc[111],"AV10BR_MedicalImaging");this.addBCProperty("Br_medicalimaging",["BR_MedicalImagingID"],this.GXValidFnc[122],"AV10BR_MedicalImaging");this.addBCProperty("Br_medicalimaging",["BR_EncounterID"],this.GXValidFnc[123],"AV10BR_MedicalImaging");this.addBCProperty("Br_medicalimaging",["BR_Information_PatientNo"],this.GXValidFnc[124],"AV10BR_MedicalImaging");this.addBCProperty("Br_medicalimaging",["BR_MedicalImaging_ID"],this.GXValidFnc[125],"AV10BR_MedicalImaging");this.Initialize()});gx.createParentObj(br_medicalimaginginsert)