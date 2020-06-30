/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:9:2.96
*/
gx.evt.autoSkip=!1;gx.define("bas_institute",!1,function(){this.ServerClass="bas_institute";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Institutecode=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Institutecode",["gx.O.A358InstituteCode","gx.O.A386InstituteName","gx.O.A387BAS_InstituteLogo","gx.O.A388BAS_InstituteCreator",'gx.date.urlDateTime(gx.O.A389BAS_InstituteCreateTime,"ANSI")',"gx.O.A390BAS_InstituteModifier",'gx.date.urlDateTime(gx.O.A391BAS_InstituteModifyTime,"ANSI")',"gx.O.A392BAS_InstituteIsDeleted","gx.O.A393BAS_InstituteDescription"],["A386InstituteName","A387BAS_InstituteLogo","BAS_INSTITUTELOGO_gxBlob","A388BAS_InstituteCreator","A389BAS_InstituteCreateTime","A390BAS_InstituteModifier","A391BAS_InstituteModifyTime","A392BAS_InstituteIsDeleted","A393BAS_InstituteDescription",["A387BAS_InstituteLogo","Filetype"],["A387BAS_InstituteLogo","Filename"],"Gx_mode","Z358InstituteCode","Z386InstituteName","Z387BAS_InstituteLogo","Z388BAS_InstituteCreator","Z389BAS_InstituteCreateTime","Z390BAS_InstituteModifier","Z391BAS_InstituteModifyTime","Z392BAS_InstituteIsDeleted","Z393BAS_InstituteDescription",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.Valid_Bas_institutecreatetime=function(){try{var n=gx.util.balloon.getNew("BAS_INSTITUTECREATETIME");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.A389BAS_InstituteCreateTime)==0||new gx.date.gxdate(this.A389BAS_InstituteCreateTime).compare(gx.date.ymdhmstot(1753,01,01,00,00,00))>=0))try{n.setError("域BAS_Institute Create Time超界");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Bas_institutemodifytime=function(){try{var n=gx.util.balloon.getNew("BAS_INSTITUTEMODIFYTIME");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.A391BAS_InstituteModifyTime)==0||new gx.date.gxdate(this.A391BAS_InstituteModifyTime).compare(gx.date.ymdhmstot(1753,01,01,00,00,00))>=0))try{n.setError("域BAS_Institute Modify Time超界");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e111k57_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e121k57_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77];this.GXLastCtrlId=77;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"TABLEMAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLE",format:0,grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"BTN_FIRST",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"BTN_PREVIOUS",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"BTN_NEXT",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"BTN_LAST",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"BTN_SELECT",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,lvl:0,type:"svchar",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Institutecode,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"INSTITUTECODE",gxz:"Z358InstituteCode",gxold:"O358InstituteCode",gxvar:"A358InstituteCode",ucs:[],op:[68,63,58,53,48,43,38,33],ip:[68,63,58,53,48,43,38,33,28],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A358InstituteCode=n)},v2z:function(n){n!==undefined&&(gx.O.Z358InstituteCode=n)},v2c:function(){gx.fn.setControlValue("INSTITUTECODE",gx.O.A358InstituteCode,0)},c2v:function(){this.val()!==undefined&&(gx.O.A358InstituteCode=this.val())},val:function(){return gx.fn.getControlValue("INSTITUTECODE")},nac:gx.falseFn};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"INSTITUTENAME",gxz:"Z386InstituteName",gxold:"O386InstituteName",gxvar:"A386InstituteName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A386InstituteName=n)},v2z:function(n){n!==undefined&&(gx.O.Z386InstituteName=n)},v2c:function(){gx.fn.setControlValue("INSTITUTENAME",gx.O.A386InstituteName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A386InstituteName=this.val())},val:function(){return gx.fn.getControlValue("INSTITUTENAME")},nac:gx.falseFn};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,lvl:0,type:"bitstr",len:1024,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BAS_INSTITUTELOGO",gxz:"Z387BAS_InstituteLogo",gxold:"O387BAS_InstituteLogo",gxvar:"A387BAS_InstituteLogo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A387BAS_InstituteLogo=n)},v2z:function(n){n!==undefined&&(gx.O.Z387BAS_InstituteLogo=n)},v2c:function(){gx.fn.setBlobValue("BAS_INSTITUTELOGO",gx.O.A387BAS_InstituteLogo)},c2v:function(){this.val()!==undefined&&(gx.O.A387BAS_InstituteLogo=this.val())},val:function(){return gx.fn.getBlobValue("BAS_INSTITUTELOGO")},nac:gx.falseFn};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BAS_INSTITUTECREATOR",gxz:"Z388BAS_InstituteCreator",gxold:"O388BAS_InstituteCreator",gxvar:"A388BAS_InstituteCreator",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A388BAS_InstituteCreator=n)},v2z:function(n){n!==undefined&&(gx.O.Z388BAS_InstituteCreator=n)},v2c:function(){gx.fn.setControlValue("BAS_INSTITUTECREATOR",gx.O.A388BAS_InstituteCreator,0)},c2v:function(){this.val()!==undefined&&(gx.O.A388BAS_InstituteCreator=this.val())},val:function(){return gx.fn.getControlValue("BAS_INSTITUTECREATOR")},nac:gx.falseFn};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bas_institutecreatetime,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BAS_INSTITUTECREATETIME",gxz:"Z389BAS_InstituteCreateTime",gxold:"O389BAS_InstituteCreateTime",gxvar:"A389BAS_InstituteCreateTime",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[48],ip:[48],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A389BAS_InstituteCreateTime=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z389BAS_InstituteCreateTime=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BAS_INSTITUTECREATETIME",gx.O.A389BAS_InstituteCreateTime,0)},c2v:function(){this.val()!==undefined&&(gx.O.A389BAS_InstituteCreateTime=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("BAS_INSTITUTECREATETIME")},nac:gx.falseFn};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BAS_INSTITUTEMODIFIER",gxz:"Z390BAS_InstituteModifier",gxold:"O390BAS_InstituteModifier",gxvar:"A390BAS_InstituteModifier",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A390BAS_InstituteModifier=n)},v2z:function(n){n!==undefined&&(gx.O.Z390BAS_InstituteModifier=n)},v2c:function(){gx.fn.setControlValue("BAS_INSTITUTEMODIFIER",gx.O.A390BAS_InstituteModifier,0)},c2v:function(){this.val()!==undefined&&(gx.O.A390BAS_InstituteModifier=this.val())},val:function(){return gx.fn.getControlValue("BAS_INSTITUTEMODIFIER")},nac:gx.falseFn};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bas_institutemodifytime,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BAS_INSTITUTEMODIFYTIME",gxz:"Z391BAS_InstituteModifyTime",gxold:"O391BAS_InstituteModifyTime",gxvar:"A391BAS_InstituteModifyTime",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[58],ip:[58],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A391BAS_InstituteModifyTime=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z391BAS_InstituteModifyTime=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BAS_INSTITUTEMODIFYTIME",gx.O.A391BAS_InstituteModifyTime,0)},c2v:function(){this.val()!==undefined&&(gx.O.A391BAS_InstituteModifyTime=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("BAS_INSTITUTEMODIFYTIME")},nac:gx.falseFn};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,lvl:0,type:"int",len:1,dec:0,sign:!1,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BAS_INSTITUTEISDELETED",gxz:"Z392BAS_InstituteIsDeleted",gxold:"O392BAS_InstituteIsDeleted",gxvar:"A392BAS_InstituteIsDeleted",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A392BAS_InstituteIsDeleted=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z392BAS_InstituteIsDeleted=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BAS_INSTITUTEISDELETED",gx.O.A392BAS_InstituteIsDeleted,0)},c2v:function(){this.val()!==undefined&&(gx.O.A392BAS_InstituteIsDeleted=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BAS_INSTITUTEISDELETED",",")},nac:gx.falseFn};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,fld:"",grid:0};n[67]={id:67,fld:"",grid:0};n[68]={id:68,lvl:0,type:"vchar",len:2048,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BAS_INSTITUTEDESCRIPTION",gxz:"Z393BAS_InstituteDescription",gxold:"O393BAS_InstituteDescription",gxvar:"A393BAS_InstituteDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A393BAS_InstituteDescription=n)},v2z:function(n){n!==undefined&&(gx.O.Z393BAS_InstituteDescription=n)},v2c:function(){gx.fn.setControlValue("BAS_INSTITUTEDESCRIPTION",gx.O.A393BAS_InstituteDescription,0)},c2v:function(){this.val()!==undefined&&(gx.O.A393BAS_InstituteDescription=this.val())},val:function(){return gx.fn.getControlValue("BAS_INSTITUTEDESCRIPTION")},nac:gx.falseFn};n[69]={id:69,fld:"",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"BTN_ENTER",grid:0};n[74]={id:74,fld:"",grid:0};n[75]={id:75,fld:"BTN_CANCEL",grid:0};n[76]={id:76,fld:"",grid:0};n[77]={id:77,fld:"BTN_DELETE",grid:0};this.A358InstituteCode="";this.Z358InstituteCode="";this.O358InstituteCode="";this.A386InstituteName="";this.Z386InstituteName="";this.O386InstituteName="";this.A387BAS_InstituteLogo="";this.Z387BAS_InstituteLogo="";this.O387BAS_InstituteLogo="";this.A388BAS_InstituteCreator="";this.Z388BAS_InstituteCreator="";this.O388BAS_InstituteCreator="";this.A389BAS_InstituteCreateTime=gx.date.nullDate();this.Z389BAS_InstituteCreateTime=gx.date.nullDate();this.O389BAS_InstituteCreateTime=gx.date.nullDate();this.A390BAS_InstituteModifier="";this.Z390BAS_InstituteModifier="";this.O390BAS_InstituteModifier="";this.A391BAS_InstituteModifyTime=gx.date.nullDate();this.Z391BAS_InstituteModifyTime=gx.date.nullDate();this.O391BAS_InstituteModifyTime=gx.date.nullDate();this.A392BAS_InstituteIsDeleted=0;this.Z392BAS_InstituteIsDeleted=0;this.O392BAS_InstituteIsDeleted=0;this.A393BAS_InstituteDescription="";this.Z393BAS_InstituteDescription="";this.O393BAS_InstituteDescription="";this.A358InstituteCode="";this.A386InstituteName="";this.A387BAS_InstituteLogo="";this.A388BAS_InstituteCreator="";this.A389BAS_InstituteCreateTime=gx.date.nullDate();this.A390BAS_InstituteModifier="";this.A391BAS_InstituteModifyTime=gx.date.nullDate();this.A392BAS_InstituteIsDeleted=0;this.A393BAS_InstituteDescription="";this.Events={e111k57_client:["ENTER",!0],e121k57_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.Initialize()});gx.createParentObj(bas_institute)