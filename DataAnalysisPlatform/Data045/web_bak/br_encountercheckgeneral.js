/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:35:4.39
*/
gx.evt.autoSkip=!1;gx.define("br_encountercheckgeneral",!0,function(n){var t,i,r;this.ServerClass="br_encountercheckgeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Br_information_id=function(){try{var n=gx.util.balloon.getNew("BR_INFORMATION_ID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Br_encounterid=function(){try{var n=gx.util.balloon.getNew("BR_ENCOUNTERID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e133t2_client=function(){return this.executeServerEvent("'DOCHECKENTERING'",!1,null,!1,!1)};this.e143t2_client=function(){return this.executeServerEvent("'DOCHECKHISTORY'",!1,null,!1,!1)};this.e153t2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e163t2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,17,18,19,20,23,24,25,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73];this.GXLastCtrlId=73;this.DVPANEL_UNNAMEDTABLE1Container=gx.uc.getNew(this,10,0,"BootstrapPanel",this.CmpContext+"DVPANEL_UNNAMEDTABLE1Container","Dvpanel_unnamedtable1","DVPANEL_UNNAMEDTABLE1");i=this.DVPANEL_UNNAMEDTABLE1Container;i.setProp("Class","Class","","char");i.setProp("Enabled","Enabled",!0,"boolean");i.setProp("Width","Width","100%","str");i.setProp("Height","Height","100","str");i.setProp("AutoWidth","Autowidth",!1,"bool");i.setProp("AutoHeight","Autoheight",!0,"bool");i.setProp("Cls","Cls","PanelNoHeader","str");i.setProp("ShowHeader","Showheader",!0,"bool");i.setProp("Title","Title","","str");i.setProp("Collapsible","Collapsible",!0,"bool");i.setProp("Collapsed","Collapsed",!1,"bool");i.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");i.setProp("IconPosition","Iconposition","left","str");i.setProp("AutoScroll","Autoscroll",!1,"bool");i.setProp("Visible","Visible",!0,"bool");i.setC2ShowFunction(function(n){n.show()});this.setUserControl(i);this.DVPANEL_UNNAMEDTABLE2Container=gx.uc.getNew(this,21,0,"BootstrapPanel",this.CmpContext+"DVPANEL_UNNAMEDTABLE2Container","Dvpanel_unnamedtable2","DVPANEL_UNNAMEDTABLE2");r=this.DVPANEL_UNNAMEDTABLE2Container;r.setProp("Class","Class","","char");r.setProp("Enabled","Enabled",!0,"boolean");r.setProp("Width","Width","100%","str");r.setProp("Height","Height","100","str");r.setProp("AutoWidth","Autowidth",!1,"bool");r.setProp("AutoHeight","Autoheight",!0,"bool");r.setProp("Cls","Cls","PanelNoHeader","str");r.setProp("ShowHeader","Showheader",!0,"bool");r.setProp("Title","Title","","str");r.setProp("Collapsible","Collapsible",!0,"bool");r.setProp("Collapsed","Collapsed",!1,"bool");r.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");r.setProp("IconPosition","Iconposition","left","str");r.setProp("AutoScroll","Autoscroll",!1,"bool");r.setProp("Visible","Visible",!0,"bool");r.setC2ShowFunction(function(n){n.show()});this.setUserControl(r);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLE",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"DVPANEL_UNNAMEDTABLE1_CELL",grid:0};t[9]={id:9,fld:"HTML_DVPANEL_UNNAMEDTABLE1",grid:0};t[12]={id:12,fld:"LAYOUT_UNNAMEDTABLE1",grid:0};t[13]={id:13,fld:"",grid:0};t[14]={id:14,fld:"UNNAMEDTABLE1",grid:0};t[17]={id:17,fld:"BTNCHECKHISTORY",grid:0};t[18]={id:18,fld:"",grid:0};t[19]={id:19,fld:"DVPANEL_UNNAMEDTABLE2_CELL",grid:0};t[20]={id:20,fld:"HTML_DVPANEL_UNNAMEDTABLE2",grid:0};t[23]={id:23,fld:"LAYOUT_UNNAMEDTABLE2",grid:0};t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"UNNAMEDTABLE2",grid:0};t[28]={id:28,fld:"BTNCHECKENTERING",grid:0};t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"TRANSACTIONDETAIL_TABLEATTRIBUTES",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,fld:"",grid:0};t[34]={id:34,fld:"",grid:0};t[35]={id:35,fld:"",grid:0};t[36]={id:36,lvl:0,type:"svchar",len:2e3,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_PATIENTNO",gxz:"Z36BR_Information_PatientNo",gxold:"O36BR_Information_PatientNo",gxvar:"A36BR_Information_PatientNo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A36BR_Information_PatientNo=n)},v2z:function(n){n!==undefined&&(gx.O.Z36BR_Information_PatientNo=n)},v2c:function(){gx.fn.setControlValue("BR_INFORMATION_PATIENTNO",gx.O.A36BR_Information_PatientNo,0)},c2v:function(){this.val()!==undefined&&(gx.O.A36BR_Information_PatientNo=this.val())},val:function(){return gx.fn.getControlValue("BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};t[37]={id:37,fld:"",grid:0};t[38]={id:38,fld:"",grid:0};t[39]={id:39,fld:"",grid:0};t[40]={id:40,lvl:0,type:"int",len:10,dec:0,sign:!1,pic:"ZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ENCID",gxz:"Z35BR_Encounter_EncID",gxold:"O35BR_Encounter_EncID",gxvar:"A35BR_Encounter_EncID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A35BR_Encounter_EncID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z35BR_Encounter_EncID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_ENCID",gx.O.A35BR_Encounter_EncID,0)},c2v:function(){this.val()!==undefined&&(gx.O.A35BR_Encounter_EncID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTER_ENCID",",")},nac:gx.falseFn};t[41]={id:41,fld:"",grid:0};t[42]={id:42,fld:"",grid:0};t[43]={id:43,fld:"",grid:0};t[44]={id:44,fld:"",grid:0};t[45]={id:45,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_DEPARTMENT",gxz:"Z84BR_Encounter_Department",gxold:"O84BR_Encounter_Department",gxvar:"A84BR_Encounter_Department",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A84BR_Encounter_Department=n)},v2z:function(n){n!==undefined&&(gx.O.Z84BR_Encounter_Department=n)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_DEPARTMENT",gx.O.A84BR_Encounter_Department,0)},c2v:function(){this.val()!==undefined&&(gx.O.A84BR_Encounter_Department=this.val())},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_DEPARTMENT")},nac:gx.falseFn};t[46]={id:46,fld:"",grid:0};t[47]={id:47,fld:"",grid:0};t[48]={id:48,fld:"",grid:0};t[49]={id:49,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ENCTYPE",gxz:"Z90BR_Encounter_ENCType",gxold:"O90BR_Encounter_ENCType",gxvar:"A90BR_Encounter_ENCType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A90BR_Encounter_ENCType=n)},v2z:function(n){n!==undefined&&(gx.O.Z90BR_Encounter_ENCType=n)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_ENCTYPE",gx.O.A90BR_Encounter_ENCType,0)},c2v:function(){this.val()!==undefined&&(gx.O.A90BR_Encounter_ENCType=this.val())},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_ENCTYPE")},nac:gx.falseFn};t[50]={id:50,fld:"",grid:0};t[51]={id:51,fld:"",grid:0};t[52]={id:52,fld:"",grid:0};t[53]={id:53,fld:"",grid:0};t[54]={id:54,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ADMITSOURCE",gxz:"Z92BR_Encounter_AdmitSource",gxold:"O92BR_Encounter_AdmitSource",gxvar:"A92BR_Encounter_AdmitSource",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A92BR_Encounter_AdmitSource=n)},v2z:function(n){n!==undefined&&(gx.O.Z92BR_Encounter_AdmitSource=n)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_ADMITSOURCE",gx.O.A92BR_Encounter_AdmitSource,0)},c2v:function(){this.val()!==undefined&&(gx.O.A92BR_Encounter_AdmitSource=this.val())},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_ADMITSOURCE")},nac:gx.falseFn};t[55]={id:55,fld:"",grid:0};t[56]={id:56,fld:"",grid:0};t[57]={id:57,fld:"",grid:0};t[58]={id:58,lvl:0,type:"date",len:10,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ADMITDATE",gxz:"Z91BR_Encounter_AdmitDate",gxold:"O91BR_Encounter_AdmitDate",gxvar:"A91BR_Encounter_AdmitDate",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A91BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z91BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_ADMITDATE",gx.O.A91BR_Encounter_AdmitDate,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A91BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_ADMITDATE")},nac:gx.falseFn};this.declareDomainHdlr(58,function(){});t[59]={id:59,fld:"",grid:0};t[60]={id:60,fld:"",grid:0};t[61]={id:61,fld:"",grid:0};t[62]={id:62,fld:"",grid:0};t[63]={id:63,lvl:0,type:"date",len:10,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_DISCHARGEDATE",gxz:"Z93BR_Encounter_DischargeDate",gxold:"O93BR_Encounter_DischargeDate",gxvar:"A93BR_Encounter_DischargeDate",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A93BR_Encounter_DischargeDate=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z93BR_Encounter_DischargeDate=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_DISCHARGEDATE",gx.O.A93BR_Encounter_DischargeDate,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A93BR_Encounter_DischargeDate=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_DISCHARGEDATE")},nac:gx.falseFn};this.declareDomainHdlr(63,function(){});t[64]={id:64,fld:"",grid:0};t[65]={id:65,fld:"",grid:0};t[66]={id:66,fld:"",grid:0};t[67]={id:67,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_DISCHARGESTATUS",gxz:"Z94BR_Encounter_DischargeStatus",gxold:"O94BR_Encounter_DischargeStatus",gxvar:"A94BR_Encounter_DischargeStatus",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A94BR_Encounter_DischargeStatus=n)},v2z:function(n){n!==undefined&&(gx.O.Z94BR_Encounter_DischargeStatus=n)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_DISCHARGESTATUS",gx.O.A94BR_Encounter_DischargeStatus,0)},c2v:function(){this.val()!==undefined&&(gx.O.A94BR_Encounter_DischargeStatus=this.val())},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_DISCHARGESTATUS")},nac:gx.falseFn};t[68]={id:68,fld:"",grid:0};t[69]={id:69,fld:"",grid:0};t[70]={id:70,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};t[71]={id:71,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_information_id,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_ID",gxz:"Z85BR_Information_ID",gxold:"O85BR_Information_ID",gxvar:"A85BR_Information_ID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A85BR_Information_ID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z85BR_Information_ID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_INFORMATION_ID",gx.O.A85BR_Information_ID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A85BR_Information_ID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_INFORMATION_ID",",")},nac:gx.falseFn};this.declareDomainHdlr(71,function(){});t[72]={id:72,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A19BR_EncounterID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z19BR_EncounterID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A19BR_EncounterID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",",")},nac:gx.falseFn};this.declareDomainHdlr(72,function(){});t[73]={id:73,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_STATUS",gxz:"Z172BR_Encounter_Status",gxold:"O172BR_Encounter_Status",gxvar:"A172BR_Encounter_Status",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.A172BR_Encounter_Status=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z172BR_Encounter_Status=gx.num.intval(n))},v2c:function(){gx.fn.setComboBoxValue("BR_ENCOUNTER_STATUS",gx.O.A172BR_Encounter_Status);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A172BR_Encounter_Status=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTER_STATUS",",")},nac:gx.falseFn};this.declareDomainHdlr(73,function(){});this.A36BR_Information_PatientNo="";this.Z36BR_Information_PatientNo="";this.O36BR_Information_PatientNo="";this.A35BR_Encounter_EncID=0;this.Z35BR_Encounter_EncID=0;this.O35BR_Encounter_EncID=0;this.A84BR_Encounter_Department="";this.Z84BR_Encounter_Department="";this.O84BR_Encounter_Department="";this.A90BR_Encounter_ENCType="";this.Z90BR_Encounter_ENCType="";this.O90BR_Encounter_ENCType="";this.A92BR_Encounter_AdmitSource="";this.Z92BR_Encounter_AdmitSource="";this.O92BR_Encounter_AdmitSource="";this.A91BR_Encounter_AdmitDate=gx.date.nullDate();this.Z91BR_Encounter_AdmitDate=gx.date.nullDate();this.O91BR_Encounter_AdmitDate=gx.date.nullDate();this.A93BR_Encounter_DischargeDate=gx.date.nullDate();this.Z93BR_Encounter_DischargeDate=gx.date.nullDate();this.O93BR_Encounter_DischargeDate=gx.date.nullDate();this.A94BR_Encounter_DischargeStatus="";this.Z94BR_Encounter_DischargeStatus="";this.O94BR_Encounter_DischargeStatus="";this.A85BR_Information_ID=0;this.Z85BR_Information_ID=0;this.O85BR_Information_ID=0;this.A19BR_EncounterID=0;this.Z19BR_EncounterID=0;this.O19BR_EncounterID=0;this.A172BR_Encounter_Status=0;this.Z172BR_Encounter_Status=0;this.O172BR_Encounter_Status=0;this.A36BR_Information_PatientNo="";this.A35BR_Encounter_EncID=0;this.A84BR_Encounter_Department="";this.A90BR_Encounter_ENCType="";this.A92BR_Encounter_AdmitSource="";this.A91BR_Encounter_AdmitDate=gx.date.nullDate();this.A93BR_Encounter_DischargeDate=gx.date.nullDate();this.A94BR_Encounter_DischargeStatus="";this.A85BR_Information_ID=0;this.A19BR_EncounterID=0;this.A172BR_Encounter_Status=0;this.Events={e133t2_client:["'DOCHECKENTERING'",!0],e143t2_client:["'DOCHECKHISTORY'",!0],e153t2_client:["ENTER",!0],e163t2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV8BR_EncounterID",fld:"vBR_ENCOUNTERID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[]];this.EvtParms.LOAD=[[],[{av:'gx.fn.getCtrlProperty("BR_INFORMATION_ID","Visible")',ctrl:"BR_INFORMATION_ID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Visible")',ctrl:"BR_ENCOUNTERID",prop:"Visible"},{ctrl:"BR_ENCOUNTER_STATUS"},{ctrl:"BTNCHECKENTERING",prop:"Visible"},{ctrl:"BTNCHECKHISTORY",prop:"Visible"},{av:'gx.fn.getCtrlProperty("DVPANEL_UNNAMEDTABLE1_CELL","Class")',ctrl:"DVPANEL_UNNAMEDTABLE1_CELL",prop:"Class"},{av:'gx.fn.getCtrlProperty("DVPANEL_UNNAMEDTABLE2_CELL","Class")',ctrl:"DVPANEL_UNNAMEDTABLE2_CELL",prop:"Class"}]];this.EvtParms["'DOCHECKENTERING'"]=[[{av:"A19BR_EncounterID",fld:"BR_ENCOUNTERID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[]];this.EvtParms["'DOCHECKHISTORY'"]=[[{av:"A19BR_EncounterID",fld:"BR_ENCOUNTERID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[]];this.Initialize()})