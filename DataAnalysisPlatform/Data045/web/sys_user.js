/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:8:55.1
*/
gx.evt.autoSkip=!1;gx.define("sys_user",!1,function(){this.ServerClass="sys_user";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_BScreen=gx.fn.getIntegerValue("vGXBSCREEN",",");this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Userid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Userid",["gx.O.A359UserID","gx.O.A416DisplayName","gx.O.A417UserType","gx.O.A364Account","gx.O.A418PasswordHash","gx.O.A419LoginIP",'gx.date.urlDateTime(gx.O.A420LoginTime,"ANSI")',"gx.O.A421SYS_UserCreator",'gx.date.urlDateTime(gx.O.A422SYS_UserCreateTime,"ANSI")',"gx.O.A423SYS_UserModifier",'gx.date.urlDateTime(gx.O.A424SYS_UserModifyTime,"ANSI")',"gx.O.A425SYS_UserIsDeleted","gx.O.A426Email","gx.O.A427SYS_UserDescription","gx.O.A428RocheAccount"],["A416DisplayName","A417UserType","A364Account","A418PasswordHash","A419LoginIP","A420LoginTime","A421SYS_UserCreator","A422SYS_UserCreateTime","A423SYS_UserModifier","A424SYS_UserModifyTime","A425SYS_UserIsDeleted","A426Email","A427SYS_UserDescription","A428RocheAccount","Gx_mode","Z359UserID","Z416DisplayName","Z417UserType","Z364Account","Z418PasswordHash","Z419LoginIP","Z420LoginTime","Z421SYS_UserCreator","Z422SYS_UserCreateTime","Z423SYS_UserModifier","Z424SYS_UserModifyTime","Z425SYS_UserIsDeleted","Z426Email","Z427SYS_UserDescription","Z428RocheAccount",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.Valid_Account=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Account",["gx.O.A364Account","gx.O.A359UserID"],[]),!0};this.Valid_Logintime=function(){try{var n=gx.util.balloon.getNew("LOGINTIME");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.A420LoginTime)==0||new gx.date.gxdate(this.A420LoginTime).compare(gx.date.ymdhmstot(1753,01,01,00,00,00))>=0))try{n.setError("域Login Time超界");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Sys_usercreatetime=function(){try{var n=gx.util.balloon.getNew("SYS_USERCREATETIME");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.A422SYS_UserCreateTime)==0||new gx.date.gxdate(this.A422SYS_UserCreateTime).compare(gx.date.ymdhmstot(1753,01,01,00,00,00))>=0))try{n.setError("域SYS_User Create Time超界");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Sys_usermodifytime=function(){try{var n=gx.util.balloon.getNew("SYS_USERMODIFYTIME");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.A424SYS_UserModifyTime)==0||new gx.date.gxdate(this.A424SYS_UserModifyTime).compare(gx.date.ymdhmstot(1753,01,01,00,00,00))>=0))try{n.setError("域SYS_User Modify Time超界");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e111d50_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e121d50_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107];this.GXLastCtrlId=107;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"TABLEMAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLE",format:0,grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"BTN_FIRST",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"BTN_PREVIOUS",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"BTN_NEXT",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"BTN_LAST",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"BTN_SELECT",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,lvl:0,type:"guid",len:16,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Userid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERID",gxz:"Z359UserID",gxold:"O359UserID",gxvar:"A359UserID",ucs:[],op:[98,93,88,83,78,73,68,63,58,53,48,43,38,33],ip:[98,93,88,83,78,73,68,63,58,53,48,43,38,33,28],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A359UserID=n)},v2z:function(n){n!==undefined&&(gx.O.Z359UserID=n)},v2c:function(){gx.fn.setControlValue("USERID",gx.O.A359UserID,0)},c2v:function(){this.val()!==undefined&&(gx.O.A359UserID=this.val())},val:function(){return gx.fn.getControlValue("USERID")},nac:gx.falseFn};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DISPLAYNAME",gxz:"Z416DisplayName",gxold:"O416DisplayName",gxvar:"A416DisplayName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A416DisplayName=n)},v2z:function(n){n!==undefined&&(gx.O.Z416DisplayName=n)},v2c:function(){gx.fn.setControlValue("DISPLAYNAME",gx.O.A416DisplayName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A416DisplayName=this.val())},val:function(){return gx.fn.getControlValue("DISPLAYNAME")},nac:gx.falseFn};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERTYPE",gxz:"Z417UserType",gxold:"O417UserType",gxvar:"A417UserType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A417UserType=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z417UserType=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("USERTYPE",gx.O.A417UserType,0)},c2v:function(){this.val()!==undefined&&(gx.O.A417UserType=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("USERTYPE",",")},nac:gx.falseFn};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Account,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ACCOUNT",gxz:"Z364Account",gxold:"O364Account",gxvar:"A364Account",ucs:[],op:[],ip:[28,43],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A364Account=n)},v2z:function(n){n!==undefined&&(gx.O.Z364Account=n)},v2c:function(){gx.fn.setControlValue("ACCOUNT",gx.O.A364Account,0)},c2v:function(){this.val()!==undefined&&(gx.O.A364Account=this.val())},val:function(){return gx.fn.getControlValue("ACCOUNT")},nac:gx.falseFn};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PASSWORDHASH",gxz:"Z418PasswordHash",gxold:"O418PasswordHash",gxvar:"A418PasswordHash",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A418PasswordHash=n)},v2z:function(n){n!==undefined&&(gx.O.Z418PasswordHash=n)},v2c:function(){gx.fn.setControlValue("PASSWORDHASH",gx.O.A418PasswordHash,0)},c2v:function(){this.val()!==undefined&&(gx.O.A418PasswordHash=this.val())},val:function(){return gx.fn.getControlValue("PASSWORDHASH")},nac:gx.falseFn};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,lvl:0,type:"svchar",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LOGINIP",gxz:"Z419LoginIP",gxold:"O419LoginIP",gxvar:"A419LoginIP",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A419LoginIP=n)},v2z:function(n){n!==undefined&&(gx.O.Z419LoginIP=n)},v2c:function(){gx.fn.setControlValue("LOGINIP",gx.O.A419LoginIP,0)},c2v:function(){this.val()!==undefined&&(gx.O.A419LoginIP=this.val())},val:function(){return gx.fn.getControlValue("LOGINIP")},nac:gx.falseFn};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Logintime,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LOGINTIME",gxz:"Z420LoginTime",gxold:"O420LoginTime",gxvar:"A420LoginTime",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[58],ip:[58],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A420LoginTime=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z420LoginTime=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("LOGINTIME",gx.O.A420LoginTime,0)},c2v:function(){this.val()!==undefined&&(gx.O.A420LoginTime=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("LOGINTIME")},nac:gx.falseFn};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_USERCREATOR",gxz:"Z421SYS_UserCreator",gxold:"O421SYS_UserCreator",gxvar:"A421SYS_UserCreator",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A421SYS_UserCreator=n)},v2z:function(n){n!==undefined&&(gx.O.Z421SYS_UserCreator=n)},v2c:function(){gx.fn.setControlValue("SYS_USERCREATOR",gx.O.A421SYS_UserCreator,0)},c2v:function(){this.val()!==undefined&&(gx.O.A421SYS_UserCreator=this.val())},val:function(){return gx.fn.getControlValue("SYS_USERCREATOR")},nac:gx.falseFn};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,fld:"",grid:0};n[67]={id:67,fld:"",grid:0};n[68]={id:68,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Sys_usercreatetime,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_USERCREATETIME",gxz:"Z422SYS_UserCreateTime",gxold:"O422SYS_UserCreateTime",gxvar:"A422SYS_UserCreateTime",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[68],ip:[68],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A422SYS_UserCreateTime=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z422SYS_UserCreateTime=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("SYS_USERCREATETIME",gx.O.A422SYS_UserCreateTime,0)},c2v:function(){this.val()!==undefined&&(gx.O.A422SYS_UserCreateTime=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("SYS_USERCREATETIME")},nac:gx.falseFn};n[69]={id:69,fld:"",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"",grid:0};n[73]={id:73,lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_USERMODIFIER",gxz:"Z423SYS_UserModifier",gxold:"O423SYS_UserModifier",gxvar:"A423SYS_UserModifier",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A423SYS_UserModifier=n)},v2z:function(n){n!==undefined&&(gx.O.Z423SYS_UserModifier=n)},v2c:function(){gx.fn.setControlValue("SYS_USERMODIFIER",gx.O.A423SYS_UserModifier,0)},c2v:function(){this.val()!==undefined&&(gx.O.A423SYS_UserModifier=this.val())},val:function(){return gx.fn.getControlValue("SYS_USERMODIFIER")},nac:gx.falseFn};n[74]={id:74,fld:"",grid:0};n[75]={id:75,fld:"",grid:0};n[76]={id:76,fld:"",grid:0};n[77]={id:77,fld:"",grid:0};n[78]={id:78,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Sys_usermodifytime,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_USERMODIFYTIME",gxz:"Z424SYS_UserModifyTime",gxold:"O424SYS_UserModifyTime",gxvar:"A424SYS_UserModifyTime",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[78],ip:[78],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A424SYS_UserModifyTime=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z424SYS_UserModifyTime=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("SYS_USERMODIFYTIME",gx.O.A424SYS_UserModifyTime,0)},c2v:function(){this.val()!==undefined&&(gx.O.A424SYS_UserModifyTime=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("SYS_USERMODIFYTIME")},nac:gx.falseFn};n[79]={id:79,fld:"",grid:0};n[80]={id:80,fld:"",grid:0};n[81]={id:81,fld:"",grid:0};n[82]={id:82,fld:"",grid:0};n[83]={id:83,lvl:0,type:"int",len:1,dec:0,sign:!1,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_USERISDELETED",gxz:"Z425SYS_UserIsDeleted",gxold:"O425SYS_UserIsDeleted",gxvar:"A425SYS_UserIsDeleted",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A425SYS_UserIsDeleted=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z425SYS_UserIsDeleted=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("SYS_USERISDELETED",gx.O.A425SYS_UserIsDeleted,0)},c2v:function(){this.val()!==undefined&&(gx.O.A425SYS_UserIsDeleted=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("SYS_USERISDELETED",",")},nac:gx.falseFn};n[84]={id:84,fld:"",grid:0};n[85]={id:85,fld:"",grid:0};n[86]={id:86,fld:"",grid:0};n[87]={id:87,fld:"",grid:0};n[88]={id:88,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"EMAIL",gxz:"Z426Email",gxold:"O426Email",gxvar:"A426Email",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A426Email=n)},v2z:function(n){n!==undefined&&(gx.O.Z426Email=n)},v2c:function(){gx.fn.setControlValue("EMAIL",gx.O.A426Email,0)},c2v:function(){this.val()!==undefined&&(gx.O.A426Email=this.val())},val:function(){return gx.fn.getControlValue("EMAIL")},nac:gx.falseFn};n[89]={id:89,fld:"",grid:0};n[90]={id:90,fld:"",grid:0};n[91]={id:91,fld:"",grid:0};n[92]={id:92,fld:"",grid:0};n[93]={id:93,lvl:0,type:"vchar",len:2048,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_USERDESCRIPTION",gxz:"Z427SYS_UserDescription",gxold:"O427SYS_UserDescription",gxvar:"A427SYS_UserDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A427SYS_UserDescription=n)},v2z:function(n){n!==undefined&&(gx.O.Z427SYS_UserDescription=n)},v2c:function(){gx.fn.setControlValue("SYS_USERDESCRIPTION",gx.O.A427SYS_UserDescription,0)},c2v:function(){this.val()!==undefined&&(gx.O.A427SYS_UserDescription=this.val())},val:function(){return gx.fn.getControlValue("SYS_USERDESCRIPTION")},nac:gx.falseFn};n[94]={id:94,fld:"",grid:0};n[95]={id:95,fld:"",grid:0};n[96]={id:96,fld:"",grid:0};n[97]={id:97,fld:"",grid:0};n[98]={id:98,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ROCHEACCOUNT",gxz:"Z428RocheAccount",gxold:"O428RocheAccount",gxvar:"A428RocheAccount",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A428RocheAccount=n)},v2z:function(n){n!==undefined&&(gx.O.Z428RocheAccount=n)},v2c:function(){gx.fn.setControlValue("ROCHEACCOUNT",gx.O.A428RocheAccount,0)},c2v:function(){this.val()!==undefined&&(gx.O.A428RocheAccount=this.val())},val:function(){return gx.fn.getControlValue("ROCHEACCOUNT")},nac:gx.falseFn};n[99]={id:99,fld:"",grid:0};n[100]={id:100,fld:"",grid:0};n[101]={id:101,fld:"",grid:0};n[102]={id:102,fld:"",grid:0};n[103]={id:103,fld:"BTN_ENTER",grid:0};n[104]={id:104,fld:"",grid:0};n[105]={id:105,fld:"BTN_CANCEL",grid:0};n[106]={id:106,fld:"",grid:0};n[107]={id:107,fld:"BTN_DELETE",grid:0};this.A359UserID="00000000-0000-0000-0000-000000000000";this.Z359UserID="00000000-0000-0000-0000-000000000000";this.O359UserID="00000000-0000-0000-0000-000000000000";this.A416DisplayName="";this.Z416DisplayName="";this.O416DisplayName="";this.A417UserType=0;this.Z417UserType=0;this.O417UserType=0;this.A364Account="";this.Z364Account="";this.O364Account="";this.A418PasswordHash="";this.Z418PasswordHash="";this.O418PasswordHash="";this.A419LoginIP="";this.Z419LoginIP="";this.O419LoginIP="";this.A420LoginTime=gx.date.nullDate();this.Z420LoginTime=gx.date.nullDate();this.O420LoginTime=gx.date.nullDate();this.A421SYS_UserCreator="";this.Z421SYS_UserCreator="";this.O421SYS_UserCreator="";this.A422SYS_UserCreateTime=gx.date.nullDate();this.Z422SYS_UserCreateTime=gx.date.nullDate();this.O422SYS_UserCreateTime=gx.date.nullDate();this.A423SYS_UserModifier="";this.Z423SYS_UserModifier="";this.O423SYS_UserModifier="";this.A424SYS_UserModifyTime=gx.date.nullDate();this.Z424SYS_UserModifyTime=gx.date.nullDate();this.O424SYS_UserModifyTime=gx.date.nullDate();this.A425SYS_UserIsDeleted=0;this.Z425SYS_UserIsDeleted=0;this.O425SYS_UserIsDeleted=0;this.A426Email="";this.Z426Email="";this.O426Email="";this.A427SYS_UserDescription="";this.Z427SYS_UserDescription="";this.O427SYS_UserDescription="";this.A428RocheAccount="";this.Z428RocheAccount="";this.O428RocheAccount="";this.A359UserID="00000000-0000-0000-0000-000000000000";this.Gx_BScreen=0;this.A416DisplayName="";this.A417UserType=0;this.A364Account="";this.A418PasswordHash="";this.A419LoginIP="";this.A420LoginTime=gx.date.nullDate();this.A421SYS_UserCreator="";this.A422SYS_UserCreateTime=gx.date.nullDate();this.A423SYS_UserModifier="";this.A424SYS_UserModifyTime=gx.date.nullDate();this.A425SYS_UserIsDeleted=0;this.A426Email="";this.A427SYS_UserDescription="";this.A428RocheAccount="";this.Events={e111d50_client:["ENTER",!0],e121d50_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_BScreen","vGXBSCREEN",0,"int",1,0);this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.Initialize()});gx.createParentObj(sys_user)