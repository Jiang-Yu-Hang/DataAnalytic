/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:42:12.73
*/
gx.evt.autoSkip=!1;gx.define("br_encounterdetail",!1,function(){var n,t,i,r,u;this.ServerClass="br_encounterdetail";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV11iBR_EncounterID=gx.fn.getIntegerValue("vIBR_ENCOUNTERID",",")};this.e144e2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e154e1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,159,160,161,162,163,166,167,168,169,170,171,172,173,174,175,176,177,178,179,180,181,182,183,184,185,186,187,188,189,190,191,192,193,194,195,196,197,198,199,200,201,202,203,204,205,206,207,208,209,210,211,212,213,214,217,218,219,220,221,222,223,224,225,226,227,228,229,230,231,232,233,234,235,236,237,238,239,240,241,242,243,244,245];this.GXLastCtrlId=245;this.DVPANEL_TABLEATTRIBUTESContainer=gx.uc.getNew(this,16,0,"BootstrapPanel","DVPANEL_TABLEATTRIBUTESContainer","Dvpanel_tableattributes","DVPANEL_TABLEATTRIBUTES");t=this.DVPANEL_TABLEATTRIBUTESContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Width","Width","100%","str");t.setProp("Height","Height","100","str");t.setProp("AutoWidth","Autowidth",!1,"bool");t.setProp("AutoHeight","Autoheight",!0,"bool");t.setProp("Cls","Cls","PanelCard_BaseColor","str");t.setProp("ShowHeader","Showheader",!0,"bool");t.setProp("Title","Title","瀹℃壒鎯呭喌","str");t.setProp("Collapsible","Collapsible",!0,"bool");t.setProp("Collapsed","Collapsed",!1,"bool");t.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");t.setProp("IconPosition","Iconposition","left","str");t.setProp("AutoScroll","Autoscroll",!1,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});this.setUserControl(t);this.DVPANEL_UNNAMEDTABLE1Container=gx.uc.getNew(this,107,35,"BootstrapPanel","DVPANEL_UNNAMEDTABLE1Container","Dvpanel_unnamedtable1","DVPANEL_UNNAMEDTABLE1");i=this.DVPANEL_UNNAMEDTABLE1Container;i.setProp("Class","Class","","char");i.setProp("Enabled","Enabled",!0,"boolean");i.setProp("Width","Width","100%","str");i.setProp("Height","Height","100","str");i.setProp("AutoWidth","Autowidth",!1,"bool");i.setProp("AutoHeight","Autoheight",!0,"bool");i.setProp("Cls","Cls","PanelCard_BaseColor","str");i.setProp("ShowHeader","Showheader",!0,"bool");i.setProp("Title","Title","鍒濆鎶芥煡","str");i.setProp("Collapsible","Collapsible",!0,"bool");i.setProp("Collapsed","Collapsed",!1,"bool");i.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");i.setProp("IconPosition","Iconposition","left","str");i.setProp("AutoScroll","Autoscroll",!1,"bool");i.setProp("Visible","Visible",!0,"bool");i.setC2ShowFunction(function(n){n.show()});this.setUserControl(i);this.DVPANEL_UNNAMEDTABLE2Container=gx.uc.getNew(this,164,35,"BootstrapPanel","DVPANEL_UNNAMEDTABLE2Container","Dvpanel_unnamedtable2","DVPANEL_UNNAMEDTABLE2");r=this.DVPANEL_UNNAMEDTABLE2Container;r.setProp("Class","Class","","char");r.setProp("Enabled","Enabled",!0,"boolean");r.setProp("Width","Width","100%","str");r.setProp("Height","Height","100","str");r.setProp("AutoWidth","Autowidth",!1,"bool");r.setProp("AutoHeight","Autoheight",!0,"bool");r.setProp("Cls","Cls","PanelCard_BaseColor","str");r.setProp("ShowHeader","Showheader",!0,"bool");r.setProp("Title","Title","澶嶅鎶芥煡","str");r.setProp("Collapsible","Collapsible",!0,"bool");r.setProp("Collapsed","Collapsed",!1,"bool");r.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");r.setProp("IconPosition","Iconposition","left","str");r.setProp("AutoScroll","Autoscroll",!1,"bool");r.setProp("Visible","Visible",!0,"bool");r.setC2ShowFunction(function(n){n.show()});this.setUserControl(r);this.DVPANEL_UNNAMEDTABLE3Container=gx.uc.getNew(this,215,35,"BootstrapPanel","DVPANEL_UNNAMEDTABLE3Container","Dvpanel_unnamedtable3","DVPANEL_UNNAMEDTABLE3");u=this.DVPANEL_UNNAMEDTABLE3Container;u.setProp("Class","Class","","char");u.setProp("Enabled","Enabled",!0,"boolean");u.setProp("Width","Width","100%","str");u.setProp("Height","Height","100","str");u.setProp("AutoWidth","Autowidth",!1,"bool");u.setProp("AutoHeight","Autoheight",!0,"bool");u.setProp("Cls","Cls","PanelCard_BaseColor","str");u.setProp("ShowHeader","Showheader",!0,"bool");u.setProp("Title","Title","淇敼鎯呭喌","str");u.setProp("Collapsible","Collapsible",!0,"bool");u.setProp("Collapsed","Collapsed",!1,"bool");u.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");u.setProp("IconPosition","Iconposition","left","str");u.setProp("AutoScroll","Autoscroll",!1,"bool");u.setProp("Visible","Visible",!0,"bool");u.setC2ShowFunction(function(n){n.show()});this.setUserControl(u);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TABLECONTENT",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"BTN_CANCEL",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};n[18]={id:18,fld:"LAYOUT_TABLEATTRIBUTES",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"TABLEATTRIBUTES",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"UNNAMEDTABLE6",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,fld:"UNNAMEDTABLE7",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_CRTDISPLAYNAME",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_CRTDISPLAYNAME",format:0,grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_CRTDISPLAYNAME",gxz:"ZV14GXV1",gxold:"OV14GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV1=n)},v2z:function(n){n!==undefined&&(gx.O.ZV14GXV1=n)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_CRTDISPLAYNAME",gx.O.GXV1,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV1=this.val())},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_BR_ENCOUNTER_CRTDISPLAYNAME")},nac:gx.falseFn};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_CRTDATE",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_CRTDATE",format:0,grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_CRTDATE",gxz:"ZV15GXV2",gxold:"OV15GXV2",gxvar:"GXV2",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV2=gx.fn.toDatetimeValue(n,"Y4MD"))},v2z:function(n){n!==undefined&&(gx.O.ZV15GXV2=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_CRTDATE",gx.O.GXV2,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV2=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("BR_ENCOUNTER_BR_ENCOUNTER_CRTDATE")},nac:gx.falseFn};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"UNNAMEDTABLE8",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_SUBMITUSER",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_SUBMITUSER",format:0,grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_SUBMITUSER",gxz:"ZV16GXV3",gxold:"OV16GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV3=n)},v2z:function(n){n!==undefined&&(gx.O.ZV16GXV3=n)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_SUBMITUSER",gx.O.GXV3,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV3=this.val())},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_BR_ENCOUNTER_SUBMITUSER")},nac:gx.falseFn};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_SUBMITDATE",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"",grid:0};n[60]={id:60,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_SUBMITDATE",format:0,grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_SUBMITDATE",gxz:"ZV17GXV4",gxold:"OV17GXV4",gxvar:"GXV4",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV4=gx.fn.toDatetimeValue(n,"Y4MD"))},v2z:function(n){n!==undefined&&(gx.O.ZV17GXV4=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_SUBMITDATE",gx.O.GXV4,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV4=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("BR_ENCOUNTER_BR_ENCOUNTER_SUBMITDATE")},nac:gx.falseFn};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,fld:"UNNAMEDTABLE9",grid:0};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"",grid:0};n[69]={id:69,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_APPROVER",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"",grid:0};n[72]={id:72,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_APPROVER",format:0,grid:0};n[73]={id:73,fld:"",grid:0};n[74]={id:74,fld:"",grid:0};n[75]={id:75,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_APPROVER",gxz:"ZV18GXV5",gxold:"OV18GXV5",gxvar:"GXV5",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV5=n)},v2z:function(n){n!==undefined&&(gx.O.ZV18GXV5=n)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_APPROVER",gx.O.GXV5,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV5=this.val())},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_BR_ENCOUNTER_APPROVER")},nac:gx.falseFn};n[76]={id:76,fld:"",grid:0};n[77]={id:77,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_APPROVEDATE",grid:0};n[78]={id:78,fld:"",grid:0};n[79]={id:79,fld:"",grid:0};n[80]={id:80,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_APPROVEDATE",format:0,grid:0};n[81]={id:81,fld:"",grid:0};n[82]={id:82,fld:"",grid:0};n[83]={id:83,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_APPROVEDATE",gxz:"ZV19GXV6",gxold:"OV19GXV6",gxvar:"GXV6",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV6=gx.fn.toDatetimeValue(n,"Y4MD"))},v2z:function(n){n!==undefined&&(gx.O.ZV19GXV6=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_APPROVEDATE",gx.O.GXV6,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV6=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("BR_ENCOUNTER_BR_ENCOUNTER_APPROVEDATE")},nac:gx.falseFn};n[84]={id:84,fld:"",grid:0};n[85]={id:85,fld:"",grid:0};n[86]={id:86,fld:"UNNAMEDTABLE10",grid:0};n[87]={id:87,fld:"",grid:0};n[88]={id:88,fld:"",grid:0};n[89]={id:89,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_RECHECKUSER",grid:0};n[90]={id:90,fld:"",grid:0};n[91]={id:91,fld:"",grid:0};n[92]={id:92,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_RECHECKUSER",format:0,grid:0};n[93]={id:93,fld:"",grid:0};n[94]={id:94,fld:"",grid:0};n[95]={id:95,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_RECHECKUSER",gxz:"ZV20GXV7",gxold:"OV20GXV7",gxvar:"GXV7",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV7=n)},v2z:function(n){n!==undefined&&(gx.O.ZV20GXV7=n)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_RECHECKUSER",gx.O.GXV7,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV7=this.val())},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_BR_ENCOUNTER_RECHECKUSER")},nac:gx.falseFn};n[96]={id:96,fld:"",grid:0};n[97]={id:97,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_RECHECKDATE",grid:0};n[98]={id:98,fld:"",grid:0};n[99]={id:99,fld:"",grid:0};n[100]={id:100,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_RECHECKDATE",format:0,grid:0};n[101]={id:101,fld:"",grid:0};n[102]={id:102,fld:"",grid:0};n[103]={id:103,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_RECHECKDATE",gxz:"ZV21GXV8",gxold:"OV21GXV8",gxvar:"GXV8",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV8=gx.fn.toDatetimeValue(n,"Y4MD"))},v2z:function(n){n!==undefined&&(gx.O.ZV21GXV8=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_RECHECKDATE",gx.O.GXV8,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV8=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("BR_ENCOUNTER_BR_ENCOUNTER_RECHECKDATE")},nac:gx.falseFn};n[104]={id:104,fld:"",grid:0};n[105]={id:105,fld:"",grid:0};n[106]={id:106,fld:"HTML_DVPANEL_UNNAMEDTABLE1",grid:0};n[109]={id:109,fld:"LAYOUT_UNNAMEDTABLE1",grid:0};n[110]={id:110,fld:"",grid:0};n[111]={id:111,fld:"UNNAMEDTABLE1",grid:0};n[112]={id:112,fld:"",grid:0};n[113]={id:113,fld:"",grid:0};n[114]={id:114,fld:"UNNAMEDTABLE4",grid:0};n[115]={id:115,fld:"",grid:0};n[116]={id:116,fld:"",grid:0};n[117]={id:117,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVE",grid:0};n[118]={id:118,fld:"",grid:0};n[119]={id:119,fld:"",grid:0};n[120]={id:120,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVE",format:0,grid:0};n[121]={id:121,fld:"",grid:0};n[122]={id:122,fld:"",grid:0};n[123]={id:123,lvl:0,type:"boolean",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVE",gxz:"ZV22GXV9",gxold:"OV22GXV9",gxvar:"GXV9",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(n){n!==undefined&&(gx.O.GXV9=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV22GXV9=gx.lang.booleanValue(n))},v2c:function(){gx.fn.setCheckBoxValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVE",gx.O.GXV9,!0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV9=gx.lang.booleanValue(this.val()))},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVE")},nac:gx.falseFn,values:["true","false"]};n[124]={id:124,fld:"",grid:0};n[125]={id:125,fld:"",grid:0};n[126]={id:126,fld:"UNNAMEDTABLE5",grid:0};n[127]={id:127,fld:"",grid:0};n[128]={id:128,fld:"",grid:0};n[129]={id:129,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVER",grid:0};n[130]={id:130,fld:"",grid:0};n[131]={id:131,fld:"",grid:0};n[132]={id:132,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVER",format:0,grid:0};n[133]={id:133,fld:"",grid:0};n[134]={id:134,fld:"",grid:0};n[135]={id:135,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVER",gxz:"ZV23GXV10",gxold:"OV23GXV10",gxvar:"GXV10",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV10=n)},v2z:function(n){n!==undefined&&(gx.O.ZV23GXV10=n)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVER",gx.O.GXV10,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV10=this.val())},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVER")},nac:gx.falseFn};n[136]={id:136,fld:"",grid:0};n[137]={id:137,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVEDATE",grid:0};n[138]={id:138,fld:"",grid:0};n[139]={id:139,fld:"",grid:0};n[140]={id:140,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVEDATE",format:0,grid:0};n[141]={id:141,fld:"",grid:0};n[142]={id:142,fld:"",grid:0};n[143]={id:143,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVEDATE",gxz:"ZV24GXV11",gxold:"OV24GXV11",gxvar:"GXV11",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV11=gx.fn.toDatetimeValue(n,"Y4MD"))},v2z:function(n){n!==undefined&&(gx.O.ZV24GXV11=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVEDATE",gx.O.GXV11,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV11=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVEDATE")},nac:gx.falseFn};n[144]={id:144,fld:"",grid:0};n[145]={id:145,fld:"",grid:0};n[146]={id:146,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDNOAPPROVER",grid:0};n[147]={id:147,fld:"",grid:0};n[148]={id:148,fld:"",grid:0};n[149]={id:149,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDNOAPPROVER",format:0,grid:0};n[150]={id:150,fld:"",grid:0};n[151]={id:151,fld:"",grid:0};n[152]={id:152,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_ISRANDNOAPPROVER",gxz:"ZV25GXV12",gxold:"OV25GXV12",gxvar:"GXV12",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV12=n)},v2z:function(n){n!==undefined&&(gx.O.ZV25GXV12=n)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDNOAPPROVER",gx.O.GXV12,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV12=this.val())},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDNOAPPROVER")},nac:gx.falseFn};n[153]={id:153,fld:"",grid:0};n[154]={id:154,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDNOAPPROVEDATE",grid:0};n[155]={id:155,fld:"",grid:0};n[156]={id:156,fld:"",grid:0};n[157]={id:157,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDNOAPPROVEDATE",format:0,grid:0};n[158]={id:158,fld:"",grid:0};n[159]={id:159,fld:"",grid:0};n[160]={id:160,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_ISRANDNOAPPROVEDATE",gxz:"ZV26GXV13",gxold:"OV26GXV13",gxvar:"GXV13",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV13=gx.fn.toDatetimeValue(n,"Y4MD"))},v2z:function(n){n!==undefined&&(gx.O.ZV26GXV13=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDNOAPPROVEDATE",gx.O.GXV13,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV13=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDNOAPPROVEDATE")},nac:gx.falseFn};n[161]={id:161,fld:"",grid:0};n[162]={id:162,fld:"",grid:0};n[163]={id:163,fld:"HTML_DVPANEL_UNNAMEDTABLE2",grid:0};n[166]={id:166,fld:"LAYOUT_UNNAMEDTABLE2",grid:0};n[167]={id:167,fld:"",grid:0};n[168]={id:168,fld:"UNNAMEDTABLE2",grid:0};n[169]={id:169,fld:"",grid:0};n[170]={id:170,fld:"",grid:0};n[171]={id:171,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECK",grid:0};n[172]={id:172,fld:"",grid:0};n[173]={id:173,fld:"",grid:0};n[174]={id:174,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECK",format:0,grid:0};n[175]={id:175,fld:"",grid:0};n[176]={id:176,fld:"",grid:0};n[177]={id:177,lvl:0,type:"boolean",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECK",gxz:"ZV27GXV14",gxold:"OV27GXV14",gxvar:"GXV14",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(n){n!==undefined&&(gx.O.GXV14=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV27GXV14=gx.lang.booleanValue(n))},v2c:function(){gx.fn.setCheckBoxValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECK",gx.O.GXV14,!0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV14=gx.lang.booleanValue(this.val()))},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECK")},nac:gx.falseFn,values:["true","false"]};n[178]={id:178,fld:"",grid:0};n[179]={id:179,fld:"",grid:0};n[180]={id:180,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECKR",grid:0};n[181]={id:181,fld:"",grid:0};n[182]={id:182,fld:"",grid:0};n[183]={id:183,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECKR",format:0,grid:0};n[184]={id:184,fld:"",grid:0};n[185]={id:185,fld:"",grid:0};n[186]={id:186,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECKR",gxz:"ZV28GXV15",gxold:"OV28GXV15",gxvar:"GXV15",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV15=n)},v2z:function(n){n!==undefined&&(gx.O.ZV28GXV15=n)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECKR",gx.O.GXV15,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV15=this.val())},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECKR")},nac:gx.falseFn};n[187]={id:187,fld:"",grid:0};n[188]={id:188,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECKDATE",grid:0};n[189]={id:189,fld:"",grid:0};n[190]={id:190,fld:"",grid:0};n[191]={id:191,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECKDATE",format:0,grid:0};n[192]={id:192,fld:"",grid:0};n[193]={id:193,fld:"",grid:0};n[194]={id:194,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECKDATE",gxz:"ZV29GXV16",gxold:"OV29GXV16",gxvar:"GXV16",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV16=gx.fn.toDatetimeValue(n,"Y4MD"))},v2z:function(n){n!==undefined&&(gx.O.ZV29GXV16=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECKDATE",gx.O.GXV16,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV16=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECKDATE")},nac:gx.falseFn};n[195]={id:195,fld:"",grid:0};n[196]={id:196,fld:"",grid:0};n[197]={id:197,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDNORECHECKR",grid:0};n[198]={id:198,fld:"",grid:0};n[199]={id:199,fld:"",grid:0};n[200]={id:200,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDNORECHECKR",format:0,grid:0};n[201]={id:201,fld:"",grid:0};n[202]={id:202,fld:"",grid:0};n[203]={id:203,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_ISRANDNORECHECKR",gxz:"ZV30GXV17",gxold:"OV30GXV17",gxvar:"GXV17",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV17=n)},v2z:function(n){n!==undefined&&(gx.O.ZV30GXV17=n)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDNORECHECKR",gx.O.GXV17,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV17=this.val())},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDNORECHECKR")},nac:gx.falseFn};n[204]={id:204,fld:"",grid:0};n[205]={id:205,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDNORECHECKDATE",grid:0};n[206]={id:206,fld:"",grid:0};n[207]={id:207,fld:"",grid:0};n[208]={id:208,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDNORECHECKDATE",format:0,grid:0};n[209]={id:209,fld:"",grid:0};n[210]={id:210,fld:"",grid:0};n[211]={id:211,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_ISRANDNORECHECKDATE",gxz:"ZV31GXV18",gxold:"OV31GXV18",gxvar:"GXV18",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV18=gx.fn.toDatetimeValue(n,"Y4MD"))},v2z:function(n){n!==undefined&&(gx.O.ZV31GXV18=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDNORECHECKDATE",gx.O.GXV18,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV18=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("BR_ENCOUNTER_BR_ENCOUNTER_ISRANDNORECHECKDATE")},nac:gx.falseFn};n[212]={id:212,fld:"",grid:0};n[213]={id:213,fld:"",grid:0};n[214]={id:214,fld:"HTML_DVPANEL_UNNAMEDTABLE3",grid:0};n[217]={id:217,fld:"LAYOUT_UNNAMEDTABLE3",grid:0};n[218]={id:218,fld:"",grid:0};n[219]={id:219,fld:"UNNAMEDTABLE3",grid:0};n[220]={id:220,fld:"",grid:0};n[221]={id:221,fld:"",grid:0};n[222]={id:222,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISUPDATE",grid:0};n[223]={id:223,fld:"",grid:0};n[224]={id:224,fld:"",grid:0};n[225]={id:225,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISUPDATE",format:0,grid:0};n[226]={id:226,fld:"",grid:0};n[227]={id:227,fld:"",grid:0};n[228]={id:228,lvl:0,type:"boolean",len:4,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_ISUPDATE",gxz:"ZV32GXV19",gxold:"OV32GXV19",gxvar:"GXV19",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(n){n!==undefined&&(gx.O.GXV19=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV32GXV19=gx.lang.booleanValue(n))},v2c:function(){gx.fn.setCheckBoxValue("BR_ENCOUNTER_BR_ENCOUNTER_ISUPDATE",gx.O.GXV19,!0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV19=gx.lang.booleanValue(this.val()))},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_BR_ENCOUNTER_ISUPDATE")},nac:gx.falseFn,values:["true","false"]};n[229]={id:229,fld:"",grid:0};n[230]={id:230,fld:"",grid:0};n[231]={id:231,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_UPDDATE",grid:0};n[232]={id:232,fld:"",grid:0};n[233]={id:233,fld:"",grid:0};n[234]={id:234,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_UPDDATE",format:0,grid:0};n[235]={id:235,fld:"",grid:0};n[236]={id:236,fld:"",grid:0};n[237]={id:237,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_UPDDATE",gxz:"ZV33GXV20",gxold:"OV33GXV20",gxvar:"GXV20",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV20=gx.fn.toDatetimeValue(n,"Y4MD"))},v2z:function(n){n!==undefined&&(gx.O.ZV33GXV20=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_UPDDATE",gx.O.GXV20,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV20=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("BR_ENCOUNTER_BR_ENCOUNTER_UPDDATE")},nac:gx.falseFn};n[238]={id:238,fld:"",grid:0};n[239]={id:239,fld:"UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_UPDUSER",grid:0};n[240]={id:240,fld:"",grid:0};n[241]={id:241,fld:"",grid:0};n[242]={id:242,fld:"TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_UPDUSER",format:0,grid:0};n[243]={id:243,fld:"",grid:0};n[244]={id:244,fld:"",grid:0};n[245]={id:245,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_BR_ENCOUNTER_UPDUSER",gxz:"ZV34GXV21",gxold:"OV34GXV21",gxvar:"GXV21",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV21=n)},v2z:function(n){n!==undefined&&(gx.O.ZV34GXV21=n)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_BR_ENCOUNTER_UPDUSER",gx.O.GXV21,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV21=this.val())},val:function(){return gx.fn.getControlValue("BR_ENCOUNTER_BR_ENCOUNTER_UPDUSER")},nac:gx.falseFn};this.GXV1="";this.ZV14GXV1="";this.OV14GXV1="";this.GXV2=gx.date.nullDate();this.ZV15GXV2=gx.date.nullDate();this.OV15GXV2=gx.date.nullDate();this.GXV3="";this.ZV16GXV3="";this.OV16GXV3="";this.GXV4=gx.date.nullDate();this.ZV17GXV4=gx.date.nullDate();this.OV17GXV4=gx.date.nullDate();this.GXV5="";this.ZV18GXV5="";this.OV18GXV5="";this.GXV6=gx.date.nullDate();this.ZV19GXV6=gx.date.nullDate();this.OV19GXV6=gx.date.nullDate();this.GXV7="";this.ZV20GXV7="";this.OV20GXV7="";this.GXV8=gx.date.nullDate();this.ZV21GXV8=gx.date.nullDate();this.OV21GXV8=gx.date.nullDate();this.GXV9=!1;this.ZV22GXV9=!1;this.OV22GXV9=!1;this.GXV10="";this.ZV23GXV10="";this.OV23GXV10="";this.GXV11=gx.date.nullDate();this.ZV24GXV11=gx.date.nullDate();this.OV24GXV11=gx.date.nullDate();this.GXV12="";this.ZV25GXV12="";this.OV25GXV12="";this.GXV13=gx.date.nullDate();this.ZV26GXV13=gx.date.nullDate();this.OV26GXV13=gx.date.nullDate();this.GXV14=!1;this.ZV27GXV14=!1;this.OV27GXV14=!1;this.GXV15="";this.ZV28GXV15="";this.OV28GXV15="";this.GXV16=gx.date.nullDate();this.ZV29GXV16=gx.date.nullDate();this.OV29GXV16=gx.date.nullDate();this.GXV17="";this.ZV30GXV17="";this.OV30GXV17="";this.GXV18=gx.date.nullDate();this.ZV31GXV18=gx.date.nullDate();this.OV31GXV18=gx.date.nullDate();this.GXV19=!1;this.ZV32GXV19=!1;this.OV32GXV19=!1;this.GXV20=gx.date.nullDate();this.ZV33GXV20=gx.date.nullDate();this.OV33GXV20=gx.date.nullDate();this.GXV21="";this.ZV34GXV21="";this.OV34GXV21="";this.GXV1="";this.GXV2=gx.date.nullDate();this.GXV3="";this.GXV4=gx.date.nullDate();this.GXV5="";this.GXV6=gx.date.nullDate();this.GXV7="";this.GXV8=gx.date.nullDate();this.GXV9=!1;this.GXV10="";this.GXV11=gx.date.nullDate();this.GXV12="";this.GXV13=gx.date.nullDate();this.GXV14=!1;this.GXV15="";this.GXV16=gx.date.nullDate();this.GXV17="";this.GXV18=gx.date.nullDate();this.GXV19=!1;this.GXV20=gx.date.nullDate();this.GXV21="";this.AV11iBR_EncounterID=0;this.Events={e144e2_client:["ENTER",!0],e154e1_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"AV11iBR_EncounterID",fld:"vIBR_ENCOUNTERID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[]];this.EvtParms.START=[[{av:"AV11iBR_EncounterID",fld:"vIBR_ENCOUNTERID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[{av:"AV10BR_Encounter",fld:"vBR_ENCOUNTER",pic:""}]];this.setVCMap("AV11iBR_EncounterID","vIBR_ENCOUNTERID",0,"int",18,0);this.addBCProperty("Br_encounter",["BR_Encounter_CrtDisplayName"],this.GXValidFnc[35],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_CrtDate"],this.GXValidFnc[43],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_SubmitUser"],this.GXValidFnc[55],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_SubmitDate"],this.GXValidFnc[63],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_Approver"],this.GXValidFnc[75],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_ApproveDate"],this.GXValidFnc[83],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_RecheckUser"],this.GXValidFnc[95],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_RecheckDate"],this.GXValidFnc[103],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_IsRandApprove"],this.GXValidFnc[123],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_IsRandApprover"],this.GXValidFnc[135],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_IsRandApproveDate"],this.GXValidFnc[143],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_IsRandNoApprover"],this.GXValidFnc[152],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_IsRandNoApproveDate"],this.GXValidFnc[160],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_IsRandRecheck"],this.GXValidFnc[177],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_IsRandRecheckr"],this.GXValidFnc[186],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_IsRandRecheckDate"],this.GXValidFnc[194],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_IsRandNoRecheckr"],this.GXValidFnc[203],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_IsRandNoRecheckDate"],this.GXValidFnc[211],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_IsUpdate"],this.GXValidFnc[228],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_UpdDate"],this.GXValidFnc[237],"AV10BR_Encounter");this.addBCProperty("Br_encounter",["BR_Encounter_UpdUser"],this.GXValidFnc[245],"AV10BR_Encounter");this.Initialize()});gx.createParentObj(br_encounterdetail)