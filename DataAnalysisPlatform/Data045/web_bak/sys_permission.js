/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:38:52.94
*/
gx.evt.autoSkip=!1;gx.define("sys_permission",!1,function(){this.ServerClass="sys_permission";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Permissioncode=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Permissioncode",["gx.O.A362PermissionCode","gx.O.A403PermissionName","gx.O.A404OrderIndex","gx.O.A405SYS_PermissionDescription","gx.O.A406SYS_PermissionModuleCode","gx.O.A407SYS_PermissionIsDeleted"],["A403PermissionName","A404OrderIndex","A405SYS_PermissionDescription","A406SYS_PermissionModuleCode","A407SYS_PermissionIsDeleted","Gx_mode","Z362PermissionCode","Z403PermissionName","Z404OrderIndex","Z405SYS_PermissionDescription","Z406SYS_PermissionModuleCode","Z407SYS_PermissionIsDeleted",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.e111946_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e121946_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62];this.GXLastCtrlId=62;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"TABLEMAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLE",format:0,grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"BTN_FIRST",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"BTN_PREVIOUS",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"BTN_NEXT",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"BTN_LAST",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"BTN_SELECT",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,lvl:0,type:"svchar",len:64,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Permissioncode,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PERMISSIONCODE",gxz:"Z362PermissionCode",gxold:"O362PermissionCode",gxvar:"A362PermissionCode",ucs:[],op:[53,48,43,38,33],ip:[53,48,43,38,33,28],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A362PermissionCode=n)},v2z:function(n){n!==undefined&&(gx.O.Z362PermissionCode=n)},v2c:function(){gx.fn.setControlValue("PERMISSIONCODE",gx.O.A362PermissionCode,0)},c2v:function(){this.val()!==undefined&&(gx.O.A362PermissionCode=this.val())},val:function(){return gx.fn.getControlValue("PERMISSIONCODE")},nac:gx.falseFn};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,lvl:0,type:"svchar",len:64,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PERMISSIONNAME",gxz:"Z403PermissionName",gxold:"O403PermissionName",gxvar:"A403PermissionName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A403PermissionName=n)},v2z:function(n){n!==undefined&&(gx.O.Z403PermissionName=n)},v2c:function(){gx.fn.setControlValue("PERMISSIONNAME",gx.O.A403PermissionName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A403PermissionName=this.val())},val:function(){return gx.fn.getControlValue("PERMISSIONNAME")},nac:gx.falseFn};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ORDERINDEX",gxz:"Z404OrderIndex",gxold:"O404OrderIndex",gxvar:"A404OrderIndex",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A404OrderIndex=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z404OrderIndex=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ORDERINDEX",gx.O.A404OrderIndex,0)},c2v:function(){this.val()!==undefined&&(gx.O.A404OrderIndex=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ORDERINDEX",",")},nac:gx.falseFn};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,lvl:0,type:"vchar",len:2048,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_PERMISSIONDESCRIPTION",gxz:"Z405SYS_PermissionDescription",gxold:"O405SYS_PermissionDescription",gxvar:"A405SYS_PermissionDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A405SYS_PermissionDescription=n)},v2z:function(n){n!==undefined&&(gx.O.Z405SYS_PermissionDescription=n)},v2c:function(){gx.fn.setControlValue("SYS_PERMISSIONDESCRIPTION",gx.O.A405SYS_PermissionDescription,0)},c2v:function(){this.val()!==undefined&&(gx.O.A405SYS_PermissionDescription=this.val())},val:function(){return gx.fn.getControlValue("SYS_PERMISSIONDESCRIPTION")},nac:gx.falseFn};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,lvl:0,type:"svchar",len:32,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_PERMISSIONMODULECODE",gxz:"Z406SYS_PermissionModuleCode",gxold:"O406SYS_PermissionModuleCode",gxvar:"A406SYS_PermissionModuleCode",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A406SYS_PermissionModuleCode=n)},v2z:function(n){n!==undefined&&(gx.O.Z406SYS_PermissionModuleCode=n)},v2c:function(){gx.fn.setControlValue("SYS_PERMISSIONMODULECODE",gx.O.A406SYS_PermissionModuleCode,0)},c2v:function(){this.val()!==undefined&&(gx.O.A406SYS_PermissionModuleCode=this.val())},val:function(){return gx.fn.getControlValue("SYS_PERMISSIONMODULECODE")},nac:gx.falseFn};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,lvl:0,type:"int",len:1,dec:0,sign:!1,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_PERMISSIONISDELETED",gxz:"Z407SYS_PermissionIsDeleted",gxold:"O407SYS_PermissionIsDeleted",gxvar:"A407SYS_PermissionIsDeleted",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A407SYS_PermissionIsDeleted=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z407SYS_PermissionIsDeleted=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("SYS_PERMISSIONISDELETED",gx.O.A407SYS_PermissionIsDeleted,0)},c2v:function(){this.val()!==undefined&&(gx.O.A407SYS_PermissionIsDeleted=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("SYS_PERMISSIONISDELETED",",")},nac:gx.falseFn};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"BTN_ENTER",grid:0};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"BTN_CANCEL",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"BTN_DELETE",grid:0};this.A362PermissionCode="";this.Z362PermissionCode="";this.O362PermissionCode="";this.A403PermissionName="";this.Z403PermissionName="";this.O403PermissionName="";this.A404OrderIndex=0;this.Z404OrderIndex=0;this.O404OrderIndex=0;this.A405SYS_PermissionDescription="";this.Z405SYS_PermissionDescription="";this.O405SYS_PermissionDescription="";this.A406SYS_PermissionModuleCode="";this.Z406SYS_PermissionModuleCode="";this.O406SYS_PermissionModuleCode="";this.A407SYS_PermissionIsDeleted=0;this.Z407SYS_PermissionIsDeleted=0;this.O407SYS_PermissionIsDeleted=0;this.A362PermissionCode="";this.A403PermissionName="";this.A404OrderIndex=0;this.A405SYS_PermissionDescription="";this.A406SYS_PermissionModuleCode="";this.A407SYS_PermissionIsDeleted=0;this.Events={e111946_client:["ENTER",!0],e121946_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.Initialize()});gx.createParentObj(sys_permission)