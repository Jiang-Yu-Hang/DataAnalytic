/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:39:2.1
*/
gx.evt.autoSkip=!1;gx.define("sys_tenantuserrole",!1,function(){this.ServerClass="sys_tenantuserrole";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_BScreen=gx.fn.getIntegerValue("vGXBSCREEN",",");this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Sys_tenantuserroleuserroleid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Sys_tenantuserroleuserroleid",["gx.O.A370SYS_TenantUserRoleUserRoleID","gx.O.A433SYS_TenantUserRoleUserID","gx.O.A441SYS_TenantUserRoleTenantCode","gx.O.A434SYS_TenantUserRoleRoleID"],["A433SYS_TenantUserRoleUserID","A441SYS_TenantUserRoleTenantCode","A434SYS_TenantUserRoleRoleID","Gx_mode","Z370SYS_TenantUserRoleUserRoleID","Z433SYS_TenantUserRoleUserID","Z441SYS_TenantUserRoleTenantCode","Z434SYS_TenantUserRoleRoleID",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.Valid_Sys_tenantuserroleuserid=function(){try{var n=gx.util.balloon.getNew("SYS_TENANTUSERROLEUSERID");if(this.AnyError=0,!gx.util.regExp.isMatch(this.A433SYS_TenantUserRoleUserID,"([0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}|^\\s*$)"))try{n.setError("GXM_InvalidGUID");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Sys_tenantuserroleroleid=function(){try{var n=gx.util.balloon.getNew("SYS_TENANTUSERROLEROLEID");if(this.AnyError=0,!gx.util.regExp.isMatch(this.A434SYS_TenantUserRoleRoleID,"([0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}|^\\s*$)"))try{n.setError("GXM_InvalidGUID");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e111j56_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e121j56_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52];this.GXLastCtrlId=52;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"TABLEMAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLE",format:0,grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"BTN_FIRST",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"BTN_PREVIOUS",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"BTN_NEXT",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"BTN_LAST",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"BTN_SELECT",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,lvl:0,type:"guid",len:16,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Sys_tenantuserroleuserroleid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_TENANTUSERROLEUSERROLEID",gxz:"Z370SYS_TenantUserRoleUserRoleID",gxold:"O370SYS_TenantUserRoleUserRoleID",gxvar:"A370SYS_TenantUserRoleUserRoleID",ucs:[],op:[43,38,33],ip:[43,38,33,28],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A370SYS_TenantUserRoleUserRoleID=n)},v2z:function(n){n!==undefined&&(gx.O.Z370SYS_TenantUserRoleUserRoleID=n)},v2c:function(){gx.fn.setControlValue("SYS_TENANTUSERROLEUSERROLEID",gx.O.A370SYS_TenantUserRoleUserRoleID,0)},c2v:function(){this.val()!==undefined&&(gx.O.A370SYS_TenantUserRoleUserRoleID=this.val())},val:function(){return gx.fn.getControlValue("SYS_TENANTUSERROLEUSERROLEID")},nac:gx.falseFn};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,lvl:0,type:"guid",len:16,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Sys_tenantuserroleuserid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_TENANTUSERROLEUSERID",gxz:"Z433SYS_TenantUserRoleUserID",gxold:"O433SYS_TenantUserRoleUserID",gxvar:"A433SYS_TenantUserRoleUserID",ucs:[],op:[],ip:[33],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A433SYS_TenantUserRoleUserID=n)},v2z:function(n){n!==undefined&&(gx.O.Z433SYS_TenantUserRoleUserID=n)},v2c:function(){gx.fn.setControlValue("SYS_TENANTUSERROLEUSERID",gx.O.A433SYS_TenantUserRoleUserID,0)},c2v:function(){this.val()!==undefined&&(gx.O.A433SYS_TenantUserRoleUserID=this.val())},val:function(){return gx.fn.getControlValue("SYS_TENANTUSERROLEUSERID")},nac:gx.falseFn};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,lvl:0,type:"svchar",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_TENANTUSERROLETENANTCODE",gxz:"Z441SYS_TenantUserRoleTenantCode",gxold:"O441SYS_TenantUserRoleTenantCode",gxvar:"A441SYS_TenantUserRoleTenantCode",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A441SYS_TenantUserRoleTenantCode=n)},v2z:function(n){n!==undefined&&(gx.O.Z441SYS_TenantUserRoleTenantCode=n)},v2c:function(){gx.fn.setControlValue("SYS_TENANTUSERROLETENANTCODE",gx.O.A441SYS_TenantUserRoleTenantCode,0)},c2v:function(){this.val()!==undefined&&(gx.O.A441SYS_TenantUserRoleTenantCode=this.val())},val:function(){return gx.fn.getControlValue("SYS_TENANTUSERROLETENANTCODE")},nac:gx.falseFn};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,lvl:0,type:"guid",len:16,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Sys_tenantuserroleroleid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SYS_TENANTUSERROLEROLEID",gxz:"Z434SYS_TenantUserRoleRoleID",gxold:"O434SYS_TenantUserRoleRoleID",gxvar:"A434SYS_TenantUserRoleRoleID",ucs:[],op:[],ip:[43],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A434SYS_TenantUserRoleRoleID=n)},v2z:function(n){n!==undefined&&(gx.O.Z434SYS_TenantUserRoleRoleID=n)},v2c:function(){gx.fn.setControlValue("SYS_TENANTUSERROLEROLEID",gx.O.A434SYS_TenantUserRoleRoleID,0)},c2v:function(){this.val()!==undefined&&(gx.O.A434SYS_TenantUserRoleRoleID=this.val())},val:function(){return gx.fn.getControlValue("SYS_TENANTUSERROLEROLEID")},nac:gx.falseFn};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"BTN_ENTER",grid:0};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"BTN_CANCEL",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"BTN_DELETE",grid:0};this.A370SYS_TenantUserRoleUserRoleID="00000000-0000-0000-0000-000000000000";this.Z370SYS_TenantUserRoleUserRoleID="00000000-0000-0000-0000-000000000000";this.O370SYS_TenantUserRoleUserRoleID="00000000-0000-0000-0000-000000000000";this.A433SYS_TenantUserRoleUserID="00000000-0000-0000-0000-000000000000";this.Z433SYS_TenantUserRoleUserID="00000000-0000-0000-0000-000000000000";this.O433SYS_TenantUserRoleUserID="00000000-0000-0000-0000-000000000000";this.A441SYS_TenantUserRoleTenantCode="";this.Z441SYS_TenantUserRoleTenantCode="";this.O441SYS_TenantUserRoleTenantCode="";this.A434SYS_TenantUserRoleRoleID="00000000-0000-0000-0000-000000000000";this.Z434SYS_TenantUserRoleRoleID="00000000-0000-0000-0000-000000000000";this.O434SYS_TenantUserRoleRoleID="00000000-0000-0000-0000-000000000000";this.A370SYS_TenantUserRoleUserRoleID="00000000-0000-0000-0000-000000000000";this.Gx_BScreen=0;this.A433SYS_TenantUserRoleUserID="00000000-0000-0000-0000-000000000000";this.A441SYS_TenantUserRoleTenantCode="";this.A434SYS_TenantUserRoleRoleID="00000000-0000-0000-0000-000000000000";this.Events={e111j56_client:["ENTER",!0],e121j56_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_BScreen","vGXBSCREEN",0,"int",1,0);this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.Initialize()});gx.createParentObj(sys_tenantuserrole)