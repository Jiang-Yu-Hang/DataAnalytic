/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:9:1.77
*/
gx.evt.autoSkip=!1;gx.define("sys_log",!1,function(){this.ServerClass="sys_log";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Sys_loglogid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Sys_loglogid",["gx.num.urlDecimal(gx.O.A442SYS_LogLogID,',','.')","gx.O.A372SYS_LogTenantCode","gx.O.A451SYS_LogTitle","gx.O.A450SYS_LogContent","gx.O.A449SYS_LogClientIP","gx.O.A376SYS_LogModuleCode","gx.O.A448SYS_LogLogType","gx.O.A378SYS_LogCreator",'gx.date.urlDateTime(gx.O.A379SYS_LogCreateTime,"ANSI")'],["A372SYS_LogTenantCode","A451SYS_LogTitle","A450SYS_LogContent","A449SYS_LogClientIP","A376SYS_LogModuleCode","A448SYS_LogLogType","A378SYS_LogCreator","A379SYS_LogCreateTime","Gx_mode","Z442SYS_LogLogID","Z372SYS_LogTenantCode","Z451SYS_LogTitle","Z450SYS_LogContent","Z449SYS_LogClientIP","Z376SYS_LogModuleCode","Z448SYS_LogLogType","Z378SYS_LogCreator","Z379SYS_LogCreateTime",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.Valid_Sys_logcreatetime=function(){try{var n=gx.util.balloon.getNew("SYS_LOGCREATETIME");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.A379SYS_LogCreateTime)==0||new gx.date.gxdate(this.A379SYS_LogCreateTime).compare(gx.date.ymdhmstot(1753,01,01,00,00,00))>=0))try{n.setError("域SYS_Log Create Time超界");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e111l60_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e121l60_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77];this.GXLastCtrlId=77;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"TABLEMAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLE",format:0,grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"BTN_FIRST",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"BTN_PREVIOUS",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"BTN_NEXT",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"BTN_LAST",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"BTN_SELECT",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Sys_loglogid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_LOGLOGID",gxz:"Z442SYS_LogLogID",gxold:"O442SYS_LogLogID",gxvar:"A442SYS_LogLogID",ucs:[],op:[68,63,58,53,48,43,38,33],ip:[68,63,58,53,48,43,38,33,28],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A442SYS_LogLogID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z442SYS_LogLogID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("SYS_LOGLOGID",gx.O.A442SYS_LogLogID,0)},c2v:function(){this.val()!==undefined&&(gx.O.A442SYS_LogLogID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("SYS_LOGLOGID",",")},nac:gx.falseFn};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,lvl:0,type:"svchar",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_LOGTENANTCODE",gxz:"Z372SYS_LogTenantCode",gxold:"O372SYS_LogTenantCode",gxvar:"A372SYS_LogTenantCode",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A372SYS_LogTenantCode=n)},v2z:function(n){n!==undefined&&(gx.O.Z372SYS_LogTenantCode=n)},v2c:function(){gx.fn.setControlValue("SYS_LOGTENANTCODE",gx.O.A372SYS_LogTenantCode,0)},c2v:function(){this.val()!==undefined&&(gx.O.A372SYS_LogTenantCode=this.val())},val:function(){return gx.fn.getControlValue("SYS_LOGTENANTCODE")},nac:gx.falseFn};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_LOGTITLE",gxz:"Z451SYS_LogTitle",gxold:"O451SYS_LogTitle",gxvar:"A451SYS_LogTitle",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A451SYS_LogTitle=n)},v2z:function(n){n!==undefined&&(gx.O.Z451SYS_LogTitle=n)},v2c:function(){gx.fn.setControlValue("SYS_LOGTITLE",gx.O.A451SYS_LogTitle,0)},c2v:function(){this.val()!==undefined&&(gx.O.A451SYS_LogTitle=this.val())},val:function(){return gx.fn.getControlValue("SYS_LOGTITLE")},nac:gx.falseFn};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,lvl:0,type:"vchar",len:2048,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_LOGCONTENT",gxz:"Z450SYS_LogContent",gxold:"O450SYS_LogContent",gxvar:"A450SYS_LogContent",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A450SYS_LogContent=n)},v2z:function(n){n!==undefined&&(gx.O.Z450SYS_LogContent=n)},v2c:function(){gx.fn.setControlValue("SYS_LOGCONTENT",gx.O.A450SYS_LogContent,0)},c2v:function(){this.val()!==undefined&&(gx.O.A450SYS_LogContent=this.val())},val:function(){return gx.fn.getControlValue("SYS_LOGCONTENT")},nac:gx.falseFn};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_LOGCLIENTIP",gxz:"Z449SYS_LogClientIP",gxold:"O449SYS_LogClientIP",gxvar:"A449SYS_LogClientIP",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A449SYS_LogClientIP=n)},v2z:function(n){n!==undefined&&(gx.O.Z449SYS_LogClientIP=n)},v2c:function(){gx.fn.setControlValue("SYS_LOGCLIENTIP",gx.O.A449SYS_LogClientIP,0)},c2v:function(){this.val()!==undefined&&(gx.O.A449SYS_LogClientIP=this.val())},val:function(){return gx.fn.getControlValue("SYS_LOGCLIENTIP")},nac:gx.falseFn};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,lvl:0,type:"svchar",len:30,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_LOGMODULECODE",gxz:"Z376SYS_LogModuleCode",gxold:"O376SYS_LogModuleCode",gxvar:"A376SYS_LogModuleCode",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A376SYS_LogModuleCode=n)},v2z:function(n){n!==undefined&&(gx.O.Z376SYS_LogModuleCode=n)},v2c:function(){gx.fn.setControlValue("SYS_LOGMODULECODE",gx.O.A376SYS_LogModuleCode,0)},c2v:function(){this.val()!==undefined&&(gx.O.A376SYS_LogModuleCode=this.val())},val:function(){return gx.fn.getControlValue("SYS_LOGMODULECODE")},nac:gx.falseFn};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,lvl:0,type:"svchar",len:30,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_LOGLOGTYPE",gxz:"Z448SYS_LogLogType",gxold:"O448SYS_LogLogType",gxvar:"A448SYS_LogLogType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A448SYS_LogLogType=n)},v2z:function(n){n!==undefined&&(gx.O.Z448SYS_LogLogType=n)},v2c:function(){gx.fn.setControlValue("SYS_LOGLOGTYPE",gx.O.A448SYS_LogLogType,0)},c2v:function(){this.val()!==undefined&&(gx.O.A448SYS_LogLogType=this.val())},val:function(){return gx.fn.getControlValue("SYS_LOGLOGTYPE")},nac:gx.falseFn};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_LOGCREATOR",gxz:"Z378SYS_LogCreator",gxold:"O378SYS_LogCreator",gxvar:"A378SYS_LogCreator",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A378SYS_LogCreator=n)},v2z:function(n){n!==undefined&&(gx.O.Z378SYS_LogCreator=n)},v2c:function(){gx.fn.setControlValue("SYS_LOGCREATOR",gx.O.A378SYS_LogCreator,0)},c2v:function(){this.val()!==undefined&&(gx.O.A378SYS_LogCreator=this.val())},val:function(){return gx.fn.getControlValue("SYS_LOGCREATOR")},nac:gx.falseFn};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,fld:"",grid:0};n[67]={id:67,fld:"",grid:0};n[68]={id:68,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Sys_logcreatetime,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_LOGCREATETIME",gxz:"Z379SYS_LogCreateTime",gxold:"O379SYS_LogCreateTime",gxvar:"A379SYS_LogCreateTime",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[68],ip:[68],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A379SYS_LogCreateTime=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z379SYS_LogCreateTime=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("SYS_LOGCREATETIME",gx.O.A379SYS_LogCreateTime,0)},c2v:function(){this.val()!==undefined&&(gx.O.A379SYS_LogCreateTime=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("SYS_LOGCREATETIME")},nac:gx.falseFn};n[69]={id:69,fld:"",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"BTN_ENTER",grid:0};n[74]={id:74,fld:"",grid:0};n[75]={id:75,fld:"BTN_CANCEL",grid:0};n[76]={id:76,fld:"",grid:0};n[77]={id:77,fld:"BTN_DELETE",grid:0};this.A442SYS_LogLogID=0;this.Z442SYS_LogLogID=0;this.O442SYS_LogLogID=0;this.A372SYS_LogTenantCode="";this.Z372SYS_LogTenantCode="";this.O372SYS_LogTenantCode="";this.A451SYS_LogTitle="";this.Z451SYS_LogTitle="";this.O451SYS_LogTitle="";this.A450SYS_LogContent="";this.Z450SYS_LogContent="";this.O450SYS_LogContent="";this.A449SYS_LogClientIP="";this.Z449SYS_LogClientIP="";this.O449SYS_LogClientIP="";this.A376SYS_LogModuleCode="";this.Z376SYS_LogModuleCode="";this.O376SYS_LogModuleCode="";this.A448SYS_LogLogType="";this.Z448SYS_LogLogType="";this.O448SYS_LogLogType="";this.A378SYS_LogCreator="";this.Z378SYS_LogCreator="";this.O378SYS_LogCreator="";this.A379SYS_LogCreateTime=gx.date.nullDate();this.Z379SYS_LogCreateTime=gx.date.nullDate();this.O379SYS_LogCreateTime=gx.date.nullDate();this.A442SYS_LogLogID=0;this.A372SYS_LogTenantCode="";this.A451SYS_LogTitle="";this.A450SYS_LogContent="";this.A449SYS_LogClientIP="";this.A376SYS_LogModuleCode="";this.A448SYS_LogLogType="";this.A378SYS_LogCreator="";this.A379SYS_LogCreateTime=gx.date.nullDate();this.Events={e111l60_client:["ENTER",!0],e121l60_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.Initialize()});gx.createParentObj(sys_log)