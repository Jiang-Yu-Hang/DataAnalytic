/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:35:7.8
*/
gx.evt.autoSkip=!1;gx.define("tabbedview",!0,function(n){var i,t;this.ServerClass="tabbedview";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV5FirstTab=gx.fn.getIntegerValue("vFIRSTTAB",",");this.AV11LastTab=gx.fn.getIntegerValue("vLASTTAB",",");this.AV18Tabs=gx.fn.getControlValue("vTABS");this.AV15TabCode=gx.fn.getControlValue("vTABCODE");this.AV8Index=gx.fn.getIntegerValue("vINDEX",",");this.AV13SelectedTab=gx.fn.getIntegerValue("vSELECTEDTAB",",");this.AV14Tab=gx.fn.getControlValue("vTAB");this.AV19TabsMarkup=gx.fn.getControlValue("vTABSMARKUP");this.AV20TabTemplate=gx.fn.getControlValue("vTABTEMPLATE");this.AV23URLChangedEvent=gx.fn.getControlValue("vURLCHANGEDEVENT")};this.s112_client=function(){this.AV20TabTemplate='<li class="%1">';this.AV20TabTemplate=this.AV20TabTemplate+'<a id="%2Tab" %3%7 class="%4">';this.AV20TabTemplate=this.AV20TabTemplate+'<span class="%5">';this.AV20TabTemplate=this.AV20TabTemplate+'<span class="TabBackground">';this.AV20TabTemplate=this.AV20TabTemplate+'<span class="TabText">%6<\/span>';this.AV20TabTemplate=this.AV20TabTemplate+"<\/span>";this.AV20TabTemplate=this.AV20TabTemplate+"<\/span>";this.AV20TabTemplate=this.AV20TabTemplate+"<\/a>";this.AV20TabTemplate=this.AV20TabTemplate+"<\/li>"};this.s132_client=function(){for(this.AV6Found=!1,this.AV8Index=gx.num.trunc(1,0);this.AV8Index<=this.AV18Tabs.length;){if(this.HISTORYMANAGERContainer.Hash==""&&this.AV18Tabs[this.AV8Index-1].Code==this.AV15TabCode||this.AV18Tabs[this.AV8Index-1].Code==this.HISTORYMANAGERContainer.Hash){this.AV13SelectedTab=gx.num.trunc(this.AV8Index,0);this.AV6Found=!0;break}this.AV8Index=gx.num.trunc(this.AV8Index+1,0)}!this.AV6Found&&this.AV18Tabs.length>0&&(this.AV13SelectedTab=gx.num.trunc(1,0))};this.s142_client=function(){this.AV5FirstTab=gx.num.trunc(1,0);this.AV11LastTab=gx.num.trunc(this.AV18Tabs.length,0);gx.fn.setCtrlProperty("TABPREVIOUS","Visible",0);gx.fn.setCtrlProperty("TABNEXT","Visible",0)};this.e112q2_client=function(){return this.executeServerEvent("HISTORYMANAGER.URLCHANGED",!1,null,!0,!0)};this.e152q2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e162q2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];i=this.GXValidFnc;this.GXCtrlIds=[2,5,6,7,8,11];this.GXLastCtrlId=11;this.HISTORYMANAGERContainer=gx.uc.getNew(this,15,0,"HistoryManager",this.CmpContext+"HISTORYMANAGERContainer","Historymanager","HISTORYMANAGER");t=this.HISTORYMANAGERContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Hash","Hash","","char");t.setProp("URL","Url","","char");t.setProp("QueryString","Querystring","","char");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.start()});t.addEventHandler("URLChanged",this.e112q2_client);this.setUserControl(t);i[2]={id:2,fld:"TABLE1",grid:0};i[5]={id:5,fld:"TABCONTAINER",grid:0};i[6]={id:6,fld:"TABS",format:1,grid:0};i[7]={id:7,fld:"TABPREVIOUS",grid:0};i[8]={id:8,fld:"TABNEXT",grid:0};i[11]={id:11,fld:"TABLE2",grid:0};this.AV18Tabs=[];this.AV15TabCode="";this.AV5FirstTab=0;this.AV11LastTab=0;this.AV8Index=0;this.AV13SelectedTab=0;this.AV14Tab={Code:"",Description:"",Link:"",WebComponent:""};this.AV19TabsMarkup="";this.AV20TabTemplate="";this.AV23URLChangedEvent=!1;this.AV6Found=!1;this.Events={e112q2_client:["HISTORYMANAGER.URLCHANGED",!0],e152q2_client:["ENTER",!0],e162q2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"AV23URLChangedEvent",fld:"vURLCHANGEDEVENT",pic:""},{av:"AV5FirstTab",fld:"vFIRSTTAB",pic:"ZZZ9"},{av:"AV11LastTab",fld:"vLASTTAB",pic:"ZZZ9"},{av:"AV18Tabs",fld:"vTABS",pic:""},{av:"AV15TabCode",fld:"vTABCODE",pic:""},{av:"this.HISTORYMANAGERContainer.Hash",ctrl:"HISTORYMANAGER",prop:"Hash"},{av:"AV8Index",fld:"vINDEX",pic:"ZZZ9"},{av:"AV13SelectedTab",fld:"vSELECTEDTAB",pic:"ZZZ9"},{av:"AV14Tab",fld:"vTAB",pic:""},{av:"AV19TabsMarkup",fld:"vTABSMARKUP",pic:""},{av:"AV20TabTemplate",fld:"vTABTEMPLATE",pic:"",hsh:!0}],[{av:"AV19TabsMarkup",fld:"vTABSMARKUP",pic:""},{av:"AV8Index",fld:"vINDEX",pic:"ZZZ9"},{av:"AV14Tab",fld:"vTAB",pic:""},{av:'gx.fn.getCtrlProperty("TABS","Caption")',ctrl:"TABS",prop:"Caption"},{av:"AV13SelectedTab",fld:"vSELECTEDTAB",pic:"ZZZ9"},{av:"AV5FirstTab",fld:"vFIRSTTAB",pic:"ZZZ9"},{av:"AV11LastTab",fld:"vLASTTAB",pic:"ZZZ9"},{av:'gx.fn.getCtrlProperty("TABPREVIOUS","Visible")',ctrl:"TABPREVIOUS",prop:"Visible"},{av:'gx.fn.getCtrlProperty("TABNEXT","Visible")',ctrl:"TABNEXT",prop:"Visible"},{ctrl:"COMPONENT"}]];this.EvtParms.START=[[],[{av:"AV20TabTemplate",fld:"vTABTEMPLATE",pic:"",hsh:!0}]];this.EvtParms["HISTORYMANAGER.URLCHANGED"]=[[{av:"AV5FirstTab",fld:"vFIRSTTAB",pic:"ZZZ9"},{av:"AV11LastTab",fld:"vLASTTAB",pic:"ZZZ9"},{av:"AV18Tabs",fld:"vTABS",pic:""},{av:"AV15TabCode",fld:"vTABCODE",pic:""},{av:"this.HISTORYMANAGERContainer.Hash",ctrl:"HISTORYMANAGER",prop:"Hash"},{av:"AV8Index",fld:"vINDEX",pic:"ZZZ9"},{av:"AV13SelectedTab",fld:"vSELECTEDTAB",pic:"ZZZ9"},{av:"AV14Tab",fld:"vTAB",pic:""},{av:"AV19TabsMarkup",fld:"vTABSMARKUP",pic:""},{av:"AV20TabTemplate",fld:"vTABTEMPLATE",pic:"",hsh:!0}],[{av:"AV23URLChangedEvent",fld:"vURLCHANGEDEVENT",pic:""},{av:"AV19TabsMarkup",fld:"vTABSMARKUP",pic:""},{av:"AV8Index",fld:"vINDEX",pic:"ZZZ9"},{av:"AV14Tab",fld:"vTAB",pic:""},{av:'gx.fn.getCtrlProperty("TABS","Caption")',ctrl:"TABS",prop:"Caption"},{av:"AV13SelectedTab",fld:"vSELECTEDTAB",pic:"ZZZ9"},{av:"AV5FirstTab",fld:"vFIRSTTAB",pic:"ZZZ9"},{av:"AV11LastTab",fld:"vLASTTAB",pic:"ZZZ9"},{av:'gx.fn.getCtrlProperty("TABPREVIOUS","Visible")',ctrl:"TABPREVIOUS",prop:"Visible"},{av:'gx.fn.getCtrlProperty("TABNEXT","Visible")',ctrl:"TABNEXT",prop:"Visible"},{ctrl:"COMPONENT"}]];this.setVCMap("AV5FirstTab","vFIRSTTAB",0,"int",4,0);this.setVCMap("AV11LastTab","vLASTTAB",0,"int",4,0);this.setVCMap("AV18Tabs","TABS",0,"CollTabOptions.TabOptionsItem",0,0);this.setVCMap("AV15TabCode","vTABCODE",0,"char",50,0);this.setVCMap("AV8Index","vINDEX",0,"int",4,0);this.setVCMap("AV13SelectedTab","vSELECTEDTAB",0,"int",4,0);this.setVCMap("AV14Tab","vTAB",0,"TabOptions.TabOptionsItem",0,0);this.setVCMap("AV19TabsMarkup","vTABSMARKUP",0,"char",20,0);this.setVCMap("AV20TabTemplate","vTABTEMPLATE",0,"char",20,0);this.setVCMap("AV23URLChangedEvent","vURLCHANGEDEVENT",0,"boolean",4,0);this.Initialize();this.setComponent({id:"COMPONENT",GXClass:null,Prefix:"W0014",lvl:1})})