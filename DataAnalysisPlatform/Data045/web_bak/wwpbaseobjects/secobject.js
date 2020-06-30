/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:35:45.76
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secobject', false, function () {
   this.ServerClass =  "wwpbaseobjects.secobject" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
   };
   this.Valid_Secobjectname=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Secobjectname",["gx.O.Gx_mode", "gx.O.A5SecObjectName"],["Gx_mode", "Z5SecObjectName", "Gridsecobject_functionalities", ["BTN_DELETE","Enabled"], ["BTN_ENTER","Enabled"]]);
      return true;
   }
   this.Valid_Secfunctionalityid=function()
   {
      try {
         this.sMode4 =  this.Gx_mode  ;
         this.Gx_mode =  gx.fn.getGridRowMode(4,34)  ;
         this.standaloneModal034( );
         this.standaloneNotModal034( );
         if(  gx.fn.currentGridRowImpl(34) ===0) {
            this.Gx_mode =  this.sMode4  ;
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("SECFUNCTIONALITYID", gx.fn.currentGridRowImpl(34));
         if ( gx.fn.gridDuplicateKey(35) )
         {
            gxballoon.setError(gx.text.format( gx.getMessage( "GXM_1004"), "Functionalities", "", "", "", "", "", "", "", ""));
            this.AnyError = gx.num.trunc( 1 ,0) ;
            this.Gx_mode =  this.sMode4  ;
            return gxballoon.show();
         }
         gx.ajax.validSrvEvt("dyncall","Valid_Secfunctionalityid",["gx.O.A1SecFunctionalityId", "gx.O.A8SecFunctionalityDescription"],["A8SecFunctionalityDescription"]);
      } finally {
         this.Gx_mode =  this.sMode4  ;
      }
      return true;
   }
   this.standaloneModal034=function()
   {
      try {
         if ( this.Gx_mode != "INS" )
         {
            gx.fn.setCtrlProperty("SECFUNCTIONALITYID","Enabled", 0 );
         }
         else
         {
            gx.fn.setCtrlProperty("SECFUNCTIONALITYID","Enabled", 1 );
         }
      }
      catch(e){}
      return true;
   }
   this.standaloneNotModal034=function()
   {
      return true;
   }
   this.e11033_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e12033_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,29,30,31,32,33,35,36,37,38,39,40,41,42,43,44,45];
   this.GXLastCtrlId =45;
   this.Gridsecobject_functionalitiesContainer = new gx.grid.grid(this, 4,"Functionalities",34,"Gridsecobject_functionalities","Gridsecobject_functionalities","Gridsecobject_functionalitiesContainer",this.CmpContext,this.IsMasterPage,"wwpbaseobjects.secobject",[1],false,1,false,true,5,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var Gridsecobject_functionalitiesContainer = this.Gridsecobject_functionalitiesContainer;
   Gridsecobject_functionalitiesContainer.addSingleLineEdit(1,35,"SECFUNCTIONALITYID","鍔熻兘缂栧彿","","SecFunctionalityId","int",0,"px",10,10,"right",null,[],1,"SecFunctionalityId",true,0,false,false,"Attribute",1,"");
   Gridsecobject_functionalitiesContainer.addSingleLineEdit(8,36,"SECFUNCTIONALITYDESCRIPTION","鏉冮檺鎻忚堪","","SecFunctionalityDescription","svchar",0,"px",100,80,"left",null,[],8,"SecFunctionalityDescription",true,0,false,false,"Attribute",1,"");
   this.Gridsecobject_functionalitiesContainer.emptyText = "";
   this.setGrid(Gridsecobject_functionalitiesContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"TABLEMAIN",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TITLE", format:0,grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"BTN_FIRST",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"BTN_PREVIOUS",grid:0};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"BTN_NEXT",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id: 18, fld:"BTN_LAST",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"BTN_SELECT",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id:28 ,lvl:0,type:"svchar",len:120,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Secobjectname,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Gridsecobject_functionalitiesContainer],fld:"SECOBJECTNAME",gxz:"Z5SecObjectName",gxold:"O5SecObjectName",gxvar:"A5SecObjectName",ucs:[],op:[],ip:[28],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A5SecObjectName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z5SecObjectName=Value},v2c:function(){gx.fn.setControlValue("SECOBJECTNAME",gx.O.A5SecObjectName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A5SecObjectName=this.val()},val:function(){return gx.fn.getControlValue("SECOBJECTNAME")},nac:gx.falseFn};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"TITLEFUNCTIONALITIES", format:0,grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[35]={ id:35 ,lvl:4,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:0,isacc:1,grid:34,gxgrid:this.Gridsecobject_functionalitiesContainer,fnc:this.Valid_Secfunctionalityid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYID",gxz:"Z1SecFunctionalityId",gxold:"O1SecFunctionalityId",gxvar:"A1SecFunctionalityId",ucs:[],op:[36],ip:[36,35],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A1SecFunctionalityId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z1SecFunctionalityId=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("SECFUNCTIONALITYID",row || gx.fn.currentGridRowImpl(34),gx.O.A1SecFunctionalityId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A1SecFunctionalityId=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECFUNCTIONALITYID",row || gx.fn.currentGridRowImpl(34),',')},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:4,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:1,grid:34,gxgrid:this.Gridsecobject_functionalitiesContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYDESCRIPTION",gxz:"Z8SecFunctionalityDescription",gxold:"O8SecFunctionalityDescription",gxvar:"A8SecFunctionalityDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A8SecFunctionalityDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z8SecFunctionalityDescription=Value},v2c:function(row){gx.fn.setGridControlValue("SECFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(34),gx.O.A8SecFunctionalityDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A8SecFunctionalityDescription=this.val()},val:function(row){return gx.fn.getGridControlValue("SECFUNCTIONALITYDESCRIPTION",row || gx.fn.currentGridRowImpl(34))},nac:gx.falseFn};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"BTN_ENTER",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"BTN_CANCEL",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"BTN_DELETE",grid:0};
   this.A5SecObjectName = "" ;
   this.Z5SecObjectName = "" ;
   this.O5SecObjectName = "" ;
   this.Z1SecFunctionalityId = 0 ;
   this.O1SecFunctionalityId = 0 ;
   this.Z8SecFunctionalityDescription = "" ;
   this.O8SecFunctionalityDescription = "" ;
   this.A1SecFunctionalityId = 0 ;
   this.A8SecFunctionalityDescription = "" ;
   this.A5SecObjectName = "" ;
   this.Events = {"e11033_client": ["ENTER", true] ,"e12033_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true}],[]];
   this.EvtParms["REFRESH"] = [[],[]];
   this.EnterCtrl = ["BTN_ENTER"];
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   Gridsecobject_functionalitiesContainer.addPostingVar({rfrVar:"Gx_mode"});
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.secobject);
