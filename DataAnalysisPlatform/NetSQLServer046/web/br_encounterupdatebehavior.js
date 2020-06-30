/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:55:53.63
*/
gx.evt.autoSkip = false;
gx.define('br_encounterupdatebehavior', true, function (CmpContext) {
   this.ServerClass =  "br_encounterupdatebehavior" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.setCmpContext(CmpContext);
   this.ReadonlyForm = true;
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV20tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.AV13BR_Behavior=gx.fn.getControlValue("vBR_BEHAVIOR") ;
      this.A19BR_EncounterID=gx.fn.getIntegerValue("BR_ENCOUNTERID",',') ;
      this.AV13BR_Behavior=gx.fn.getControlValue("vBR_BEHAVIOR") ;
   };
   this.e142t1_client=function()
   {
      this.clearMessages();
      if ( this.AV13BR_Behavior.BR_Behavior_FamilyCaHistory == "鏄? )
      {
         gx.fn.setCtrlProperty("CANCER","Visible", true );
      }
      else
      {
         gx.fn.setCtrlProperty("CANCER","Visible", false );
      }
      this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CANCER","Visible")',ctrl:'CANCER',prop:'Visible'}]);
      return gx.$.Deferred().resolve();
   };
   this.e152t1_client=function()
   {
      this.clearMessages();
      if ( this.AV13BR_Behavior.BR_Behavior_Menopause == "鏄? )
      {
         gx.fn.setCtrlProperty("AGE","Visible", true );
      }
      else
      {
         gx.fn.setCtrlProperty("AGE","Visible", false );
      }
      this.refreshOutputs([{av:'gx.fn.getCtrlProperty("AGE","Visible")',ctrl:'AGE',prop:'Visible'}]);
      return gx.$.Deferred().resolve();
   };
   this.e132t2_client=function()
   {
      return this.executeServerEvent("'DOSAVE'", false, null, false, false);
   };
   this.e162t2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e172t2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,92,93,94,95,96,97];
   this.GXLastCtrlId =97;
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"UNNAMEDTABLE1",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"UNNAMEDTABLE2",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id:14 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_SMOKING",gxz:"ZV25GXV1",gxold:"OV25GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.GXV1=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25GXV1=Value},v2c:function(){gx.fn.setComboBoxValue("BR_BEHAVIOR_BR_BEHAVIOR_SMOKING",gx.O.GXV1)},c2v:function(){if(this.val()!==undefined)gx.O.GXV1=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_SMOKING")},nac:gx.falseFn};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id:18 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_SMOKINGTIME",gxz:"ZV26GXV2",gxold:"OV26GXV2",gxvar:"GXV2",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV2=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26GXV2=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_SMOKINGTIME",gx.O.GXV2,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV2=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_SMOKINGTIME")},nac:gx.falseFn};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id:23 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_SMOKINGAMOUNT",gxz:"ZV27GXV3",gxold:"OV27GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV3=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27GXV3=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_SMOKINGAMOUNT",gx.O.GXV3,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV3=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_SMOKINGAMOUNT")},nac:gx.falseFn};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id:27 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_RAWSMOKINGAMOUNT",gxz:"ZV28GXV4",gxold:"OV28GXV4",gxvar:"GXV4",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV4=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV28GXV4=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_RAWSMOKINGAMOUNT",gx.O.GXV4,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV4=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_RAWSMOKINGAMOUNT")},nac:gx.falseFn};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id:32 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOL",gxz:"ZV29GXV5",gxold:"OV29GXV5",gxvar:"GXV5",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.GXV5=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29GXV5=Value},v2c:function(){gx.fn.setComboBoxValue("BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOL",gx.O.GXV5)},c2v:function(){if(this.val()!==undefined)gx.O.GXV5=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOL")},nac:gx.falseFn};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id:36 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOLTIME",gxz:"ZV30GXV6",gxold:"OV30GXV6",gxvar:"GXV6",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV6=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV30GXV6=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOLTIME",gx.O.GXV6,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV6=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOLTIME")},nac:gx.falseFn};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id:41 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOLAMOUNT",gxz:"ZV31GXV7",gxold:"OV31GXV7",gxvar:"GXV7",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV7=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31GXV7=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOLAMOUNT",gx.O.GXV7,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV7=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOLAMOUNT")},nac:gx.falseFn};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id:45 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_RAWACHOHOLAMOUNT",gxz:"ZV32GXV8",gxold:"OV32GXV8",gxvar:"GXV8",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV8=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV32GXV8=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_RAWACHOHOLAMOUNT",gx.O.GXV8,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV8=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_RAWACHOHOLAMOUNT")},nac:gx.falseFn};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_CHILDNUM",gxz:"ZV33GXV9",gxold:"OV33GXV9",gxvar:"GXV9",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV9=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33GXV9=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_CHILDNUM",gx.O.GXV9,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV9=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_CHILDNUM")},nac:gx.falseFn};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:'e142t1_client',evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_FAMILYCAHISTORY",gxz:"ZV34GXV10",gxold:"OV34GXV10",gxvar:"GXV10",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.GXV10=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV34GXV10=Value},v2c:function(){gx.fn.setComboBoxValue("BR_BEHAVIOR_BR_BEHAVIOR_FAMILYCAHISTORY",gx.O.GXV10)},c2v:function(){if(this.val()!==undefined)gx.O.GXV10=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_FAMILYCAHISTORY")},nac:gx.falseFn};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"CANCER",grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"UNNAMEDTABLEBR_BEHAVIOR_BR_BEHAVIOR_FAMILYCANCER",grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id: 63, fld:"TEXTBLOCKBR_BEHAVIOR_BR_BEHAVIOR_FAMILYCANCER", format:0,grid:0};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"svchar",len:200,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_FAMILYCANCER",gxz:"ZV35GXV11",gxold:"OV35GXV11",gxvar:"GXV11",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV11=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV35GXV11=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_FAMILYCANCER",gx.O.GXV11,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV11=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_FAMILYCANCER")},nac:gx.falseFn};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"MANOPSUSE",grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id: 71, fld:"",grid:0};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id:73 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_RAWMENOPAUSEAGE",gxz:"ZV36GXV12",gxold:"OV36GXV12",gxvar:"GXV12",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV12=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV36GXV12=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_RAWMENOPAUSEAGE",gx.O.GXV12,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV12=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_RAWMENOPAUSEAGE")},nac:gx.falseFn};
   GXValidFnc[74]={ id: 74, fld:"",grid:0};
   GXValidFnc[75]={ id: 75, fld:"",grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id:77 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:'e152t1_client',evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSE",gxz:"ZV37GXV13",gxold:"OV37GXV13",gxvar:"GXV13",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.GXV13=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV37GXV13=Value},v2c:function(){gx.fn.setComboBoxValue("BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSE",gx.O.GXV13)},c2v:function(){if(this.val()!==undefined)gx.O.GXV13=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSE")},nac:gx.falseFn};
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id: 80, fld:"AGE",grid:0};
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[82]={ id: 82, fld:"",grid:0};
   GXValidFnc[83]={ id: 83, fld:"",grid:0};
   GXValidFnc[84]={ id: 84, fld:"",grid:0};
   GXValidFnc[85]={ id:85 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSEAGE",gxz:"ZV38GXV14",gxold:"OV38GXV14",gxvar:"GXV14",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV14=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV38GXV14=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSEAGE",gx.O.GXV14,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV14=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSEAGE",',')},nac:gx.falseFn};
   GXValidFnc[86]={ id: 86, fld:"",grid:0};
   GXValidFnc[87]={ id: 87, fld:"",grid:0};
   GXValidFnc[88]={ id: 88, fld:"BTNSAVE",grid:0};
   GXValidFnc[89]={ id: 89, fld:"",grid:0};
   GXValidFnc[90]={ id: 90, fld:"",grid:0};
   GXValidFnc[92]={ id: 92, fld:"",grid:0};
   GXValidFnc[93]={ id: 93, fld:"",grid:0};
   GXValidFnc[94]={ id: 94, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[95]={ id:95 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIORID",gxz:"ZV39GXV15",gxold:"OV39GXV15",gxvar:"GXV15",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV15=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV39GXV15=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIORID",gx.O.GXV15,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV15=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_BEHAVIOR_BR_BEHAVIORID",',')},nac:gx.falseFn};
   GXValidFnc[96]={ id:96 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_ENCOUNTERID",gxz:"ZV40GXV16",gxold:"OV40GXV16",gxvar:"GXV16",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV16=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV40GXV16=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_ENCOUNTERID",gx.O.GXV16,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV16=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_BEHAVIOR_BR_ENCOUNTERID",',')},nac:gx.falseFn};
   GXValidFnc[97]={ id:97 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_INFORMATION_PATIENTNO",gxz:"ZV41GXV17",gxold:"OV41GXV17",gxvar:"GXV17",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV17=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV41GXV17=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_INFORMATION_PATIENTNO",gx.O.GXV17,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV17=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   this.GXV1 = "" ;
   this.ZV25GXV1 = "" ;
   this.OV25GXV1 = "" ;
   this.GXV2 = "" ;
   this.ZV26GXV2 = "" ;
   this.OV26GXV2 = "" ;
   this.GXV3 = "" ;
   this.ZV27GXV3 = "" ;
   this.OV27GXV3 = "" ;
   this.GXV4 = "" ;
   this.ZV28GXV4 = "" ;
   this.OV28GXV4 = "" ;
   this.GXV5 = "" ;
   this.ZV29GXV5 = "" ;
   this.OV29GXV5 = "" ;
   this.GXV6 = "" ;
   this.ZV30GXV6 = "" ;
   this.OV30GXV6 = "" ;
   this.GXV7 = "" ;
   this.ZV31GXV7 = "" ;
   this.OV31GXV7 = "" ;
   this.GXV8 = "" ;
   this.ZV32GXV8 = "" ;
   this.OV32GXV8 = "" ;
   this.GXV9 = "" ;
   this.ZV33GXV9 = "" ;
   this.OV33GXV9 = "" ;
   this.GXV10 = "" ;
   this.ZV34GXV10 = "" ;
   this.OV34GXV10 = "" ;
   this.GXV11 = "" ;
   this.ZV35GXV11 = "" ;
   this.OV35GXV11 = "" ;
   this.GXV12 = "" ;
   this.ZV36GXV12 = "" ;
   this.OV36GXV12 = "" ;
   this.GXV13 = "" ;
   this.ZV37GXV13 = "" ;
   this.OV37GXV13 = "" ;
   this.GXV14 = 0 ;
   this.ZV38GXV14 = 0 ;
   this.OV38GXV14 = 0 ;
   this.GXV15 = 0 ;
   this.ZV39GXV15 = 0 ;
   this.OV39GXV15 = 0 ;
   this.GXV16 = 0 ;
   this.ZV40GXV16 = 0 ;
   this.OV40GXV16 = 0 ;
   this.GXV17 = "" ;
   this.ZV41GXV17 = "" ;
   this.OV41GXV17 = "" ;
   this.GXV1 = "" ;
   this.GXV2 = "" ;
   this.GXV3 = "" ;
   this.GXV4 = "" ;
   this.GXV5 = "" ;
   this.GXV6 = "" ;
   this.GXV7 = "" ;
   this.GXV8 = "" ;
   this.GXV9 = "" ;
   this.GXV10 = "" ;
   this.GXV11 = "" ;
   this.GXV12 = "" ;
   this.GXV13 = "" ;
   this.GXV14 = 0 ;
   this.GXV15 = 0 ;
   this.GXV16 = 0 ;
   this.GXV17 = "" ;
   this.A19BR_EncounterID = 0 ;
   this.A61BR_Demographics_ID = 0 ;
   this.A20BR_BehaviorID = 0 ;
   this.AV13BR_Behavior = {BR_BehaviorID:0,BR_EncounterID:0,BR_Information_PatientNo:"",BR_Behavior_Smoking:"",BR_Behavior_Smoking_Code:"",BR_Behavior_SmokingTime:"",BR_Behavior_SmokingAmount:"",BR_Behavior_RawSmokingAmount:"",BR_Behavior_RawSmokingAmount_Code:"",BR_Behavior_Achohol:"",BR_Behavior_Achohol_Code:"",BR_Behavior_AchoholTime:"",BR_Behavior_AchoholAmount:"",BR_Behavior_RawAchoholAmount:"",BR_Behavior_RawAchoholAmount_Code:"",BR_Behavior_FamilyCaHistory:"",BR_Behavior_FamilyCaHistory_Code:"",BR_Behavior_FamilyCancer:"",BR_Behavior_Menopause:"",BR_Behavior_Menopause_Code:"",BR_Behavior_MenopauseAge:0,BR_Behavior_RawMenopauseAge:"",BR_Behavior_ChildNum:"",Mode:"",Initialized:0,BR_BehaviorID_Z:0,BR_EncounterID_Z:0,BR_Information_PatientNo_Z:"",BR_Behavior_Smoking_Z:"",BR_Behavior_Smoking_Code_Z:"",BR_Behavior_SmokingTime_Z:"",BR_Behavior_SmokingAmount_Z:"",BR_Behavior_RawSmokingAmount_Z:"",BR_Behavior_RawSmokingAmount_Code_Z:"",BR_Behavior_Achohol_Z:"",BR_Behavior_Achohol_Code_Z:"",BR_Behavior_AchoholTime_Z:"",BR_Behavior_AchoholAmount_Z:"",BR_Behavior_RawAchoholAmount_Z:"",BR_Behavior_RawAchoholAmount_Code_Z:"",BR_Behavior_FamilyCaHistory_Z:"",BR_Behavior_FamilyCaHistory_Code_Z:"",BR_Behavior_FamilyCancer_Z:"",BR_Behavior_Menopause_Z:"",BR_Behavior_Menopause_Code_Z:"",BR_Behavior_MenopauseAge_Z:0,BR_Behavior_RawMenopauseAge_Z:"",BR_Behavior_ChildNum_Z:""} ;
   this.Events = {"e132t2_client": ["'DOSAVE'", true] ,"e162t2_client": ["ENTER", true] ,"e172t2_client": ["CANCEL", true] ,"e142t1_client": ["BR_BEHAVIOR_BR_BEHAVIOR_FAMILYCAHISTORY.CONTROLVALUECHANGED", false] ,"e152t1_client": ["BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSE.CONTROLVALUECHANGED", false]};
   this.EvtParms["REFRESH"] = [[],[]];
   this.EvtParms["START"] = [[{av:'A20BR_BehaviorID',fld:'BR_BEHAVIORID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A61BR_Demographics_ID',fld:'BR_DEMOGRAPHICS_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV46Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{av:'AV13BR_Behavior',fld:'vBR_BEHAVIOR',pic:''},{av:'gx.fn.getCtrlProperty("CANCER","Visible")',ctrl:'CANCER',prop:'Visible'},{av:'gx.fn.getCtrlProperty("AGE","Visible")',ctrl:'AGE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("MANOPSUSE","Visible")',ctrl:'MANOPSUSE',prop:'Visible'}]];
   this.EvtParms["LOAD"] = [[{av:'AV13BR_Behavior',fld:'vBR_BEHAVIOR',pic:''}],[{ctrl:'BR_BEHAVIOR_BR_BEHAVIORID',prop:'Visible'},{ctrl:'BR_BEHAVIOR_BR_ENCOUNTERID',prop:'Visible'},{ctrl:'BR_BEHAVIOR_BR_INFORMATION_PATIENTNO',prop:'Visible'},{av:'AV13BR_Behavior',fld:'vBR_BEHAVIOR',pic:''}]];
   this.EvtParms["'DOSAVE'"] = [[{av:'AV13BR_Behavior',fld:'vBR_BEHAVIOR',pic:''}],[{av:'AV13BR_Behavior',fld:'vBR_BEHAVIOR',pic:''}]];
   this.EvtParms["BR_BEHAVIOR_BR_BEHAVIOR_FAMILYCAHISTORY.CONTROLVALUECHANGED"] = [[{av:'AV13BR_Behavior',fld:'vBR_BEHAVIOR',pic:''}],[{av:'gx.fn.getCtrlProperty("CANCER","Visible")',ctrl:'CANCER',prop:'Visible'}]];
   this.EvtParms["BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSE.CONTROLVALUECHANGED"] = [[{av:'AV13BR_Behavior',fld:'vBR_BEHAVIOR',pic:''}],[{av:'gx.fn.getCtrlProperty("AGE","Visible")',ctrl:'AGE',prop:'Visible'}]];
   this.setVCMap("AV20tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("AV13BR_Behavior", "vBR_BEHAVIOR", 0, "BR_Behavior", 0, 0);
   this.setVCMap("A19BR_EncounterID", "BR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV13BR_Behavior", "vBR_BEHAVIOR", 0, "BR_Behavior", 0, 0);
   this.addBCProperty("Br_behavior", ["BR_Behavior_Smoking"], this.GXValidFnc[14], "AV13BR_Behavior");
   this.addBCProperty("Br_behavior", ["BR_Behavior_SmokingTime"], this.GXValidFnc[18], "AV13BR_Behavior");
   this.addBCProperty("Br_behavior", ["BR_Behavior_SmokingAmount"], this.GXValidFnc[23], "AV13BR_Behavior");
   this.addBCProperty("Br_behavior", ["BR_Behavior_RawSmokingAmount"], this.GXValidFnc[27], "AV13BR_Behavior");
   this.addBCProperty("Br_behavior", ["BR_Behavior_Achohol"], this.GXValidFnc[32], "AV13BR_Behavior");
   this.addBCProperty("Br_behavior", ["BR_Behavior_AchoholTime"], this.GXValidFnc[36], "AV13BR_Behavior");
   this.addBCProperty("Br_behavior", ["BR_Behavior_AchoholAmount"], this.GXValidFnc[41], "AV13BR_Behavior");
   this.addBCProperty("Br_behavior", ["BR_Behavior_RawAchoholAmount"], this.GXValidFnc[45], "AV13BR_Behavior");
   this.addBCProperty("Br_behavior", ["BR_Behavior_ChildNum"], this.GXValidFnc[50], "AV13BR_Behavior");
   this.addBCProperty("Br_behavior", ["BR_Behavior_FamilyCaHistory"], this.GXValidFnc[54], "AV13BR_Behavior");
   this.addBCProperty("Br_behavior", ["BR_Behavior_FamilyCancer"], this.GXValidFnc[66], "AV13BR_Behavior");
   this.addBCProperty("Br_behavior", ["BR_Behavior_RawMenopauseAge"], this.GXValidFnc[73], "AV13BR_Behavior");
   this.addBCProperty("Br_behavior", ["BR_Behavior_Menopause"], this.GXValidFnc[77], "AV13BR_Behavior");
   this.addBCProperty("Br_behavior", ["BR_Behavior_MenopauseAge"], this.GXValidFnc[85], "AV13BR_Behavior");
   this.addBCProperty("Br_behavior", ["BR_BehaviorID"], this.GXValidFnc[95], "AV13BR_Behavior");
   this.addBCProperty("Br_behavior", ["BR_EncounterID"], this.GXValidFnc[96], "AV13BR_Behavior");
   this.addBCProperty("Br_behavior", ["BR_Information_PatientNo"], this.GXValidFnc[97], "AV13BR_Behavior");
   this.Initialize( );
});
