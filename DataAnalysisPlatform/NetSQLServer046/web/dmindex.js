/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:6:27.22
*/
gx.evt.autoSkip=!1;gx.define("dmindex",!1,function(){this.ServerClass="dmindex";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.e13882_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e14882_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18];this.GXLastCtrlId=18;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"INDEXBG",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"DATA",format:0,grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"DM",format:0,grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"TESTMI",format:2,grid:0};this.Events={e13882_client:["ENTER",!0],e14882_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[],[{av:'gx.fn.getCtrlProperty("TESTMI","Caption")',ctrl:"TESTMI",prop:"Caption"}]];this.Initialize()});gx.createParentObj(dmindex)