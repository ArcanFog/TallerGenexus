/*!   GeneXus C# 16_0_1-129648 on 10/17/2020 11:15:54.73
*/
gx.evt.autoSkip=!1;gx.define("wwdocente",!1,function(){var n,t;this.ServerClass="wwdocente";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV19Pgmname=gx.fn.getControlValue("vPGMNAME");this.AV19Pgmname=gx.fn.getControlValue("vPGMNAME")};this.e110n2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e150n2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e160n2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,23,24,26,27,28,29,30,31,32];this.GXLastCtrlId=32;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",25,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwdocente",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.GridContainer;t.addSingleLineEdit(12,26,"DOCENTEID","Id","","DocenteId","int",0,"px",4,4,"right",null,[],12,"DocenteId",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(13,27,"DOCENTENOMBRE","Nombre","","DocenteNombre","char",0,"px",20,20,"left",null,[],13,"DocenteNombre",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(10,28,"ASIGNATURAID","Asignatura Id","","AsignaturaId","int",0,"px",4,4,"right",null,[],10,"AsignaturaId",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(11,29,"ASIGNATURANOMBRE","Asignatura Nombre","","AsignaturaNombre","char",0,"px",20,20,"left",null,[],11,"AsignaturaNombre",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addBitmap(14,"DOCENTEFOTO",30,0,"px",17,"px",null,"","Foto","ImageAttribute","WWColumn WWOptionalColumn");t.addSingleLineEdit("Update",31,"vUPDATE","","","Update","char",0,"px",20,20,"left",null,[],"Update","Update",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");t.addSingleLineEdit("Delete",32,"vDELETE","","","Delete","char",0,"px",20,20,"left",null,[],"Delete","Delete",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");this.GridContainer.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLETOP",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLETEXT",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"BTNINSERT",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vDOCENTENOMBRE",gxz:"ZV13DocenteNombre",gxold:"OV13DocenteNombre",gxvar:"AV13DocenteNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV13DocenteNombre=n)},v2z:function(n){n!==undefined&&(gx.O.ZV13DocenteNombre=n)},v2c:function(){gx.fn.setControlValue("vDOCENTENOMBRE",gx.O.AV13DocenteNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV13DocenteNombre=this.val())},val:function(){return gx.fn.getControlValue("vDOCENTENOMBRE")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"GRIDCELL",grid:0};n[19]={id:19,fld:"GRIDTABLE",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[26]={id:26,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DOCENTEID",gxz:"Z12DocenteId",gxold:"O12DocenteId",gxvar:"A12DocenteId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A12DocenteId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z12DocenteId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("DOCENTEID",n||gx.fn.currentGridRowImpl(25),gx.O.A12DocenteId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A12DocenteId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("DOCENTEID",n||gx.fn.currentGridRowImpl(25),",")},nac:gx.falseFn};n[27]={id:27,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DOCENTENOMBRE",gxz:"Z13DocenteNombre",gxold:"O13DocenteNombre",gxvar:"A13DocenteNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A13DocenteNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z13DocenteNombre=n)},v2c:function(n){gx.fn.setGridControlValue("DOCENTENOMBRE",n||gx.fn.currentGridRowImpl(25),gx.O.A13DocenteNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A13DocenteNombre=this.val())},val:function(n){return gx.fn.getGridControlValue("DOCENTENOMBRE",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[28]={id:28,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ASIGNATURAID",gxz:"Z10AsignaturaId",gxold:"O10AsignaturaId",gxvar:"A10AsignaturaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A10AsignaturaId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z10AsignaturaId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ASIGNATURAID",n||gx.fn.currentGridRowImpl(25),gx.O.A10AsignaturaId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A10AsignaturaId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ASIGNATURAID",n||gx.fn.currentGridRowImpl(25),",")},nac:gx.falseFn};n[29]={id:29,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ASIGNATURANOMBRE",gxz:"Z11AsignaturaNombre",gxold:"O11AsignaturaNombre",gxvar:"A11AsignaturaNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A11AsignaturaNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z11AsignaturaNombre=n)},v2c:function(n){gx.fn.setGridControlValue("ASIGNATURANOMBRE",n||gx.fn.currentGridRowImpl(25),gx.O.A11AsignaturaNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A11AsignaturaNombre=this.val())},val:function(n){return gx.fn.getGridControlValue("ASIGNATURANOMBRE",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[30]={id:30,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DOCENTEFOTO",gxz:"Z14DocenteFoto",gxold:"O14DocenteFoto",gxvar:"A14DocenteFoto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A14DocenteFoto=n)},v2z:function(n){n!==undefined&&(gx.O.Z14DocenteFoto=n)},v2c:function(n){gx.fn.setGridMultimediaValue("DOCENTEFOTO",n||gx.fn.currentGridRowImpl(25),gx.O.A14DocenteFoto,gx.O.A40000DocenteFoto_GXI)},c2v:function(){gx.O.A40000DocenteFoto_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.A14DocenteFoto=this.val())},val:function(n){return gx.fn.getGridControlValue("DOCENTEFOTO",n||gx.fn.currentGridRowImpl(25))},val_GXI:function(n){return gx.fn.getGridControlValue("DOCENTEFOTO_GXI",n||gx.fn.currentGridRowImpl(25))},gxvar_GXI:"A40000DocenteFoto_GXI",nac:gx.falseFn};n[31]={id:31,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV14Update",gxold:"OV14Update",gxvar:"AV14Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV14Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV14Update=n)},v2c:function(n){gx.fn.setGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(25),gx.O.AV14Update,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV14Update=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[32]={id:32,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV15Delete",gxold:"OV15Delete",gxvar:"AV15Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV15Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV15Delete=n)},v2c:function(n){gx.fn.setGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(25),gx.O.AV15Delete,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV15Delete=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};this.AV13DocenteNombre="";this.ZV13DocenteNombre="";this.OV13DocenteNombre="";this.Z12DocenteId=0;this.O12DocenteId=0;this.Z13DocenteNombre="";this.O13DocenteNombre="";this.Z10AsignaturaId=0;this.O10AsignaturaId=0;this.Z11AsignaturaNombre="";this.O11AsignaturaNombre="";this.Z14DocenteFoto="";this.O14DocenteFoto="";this.ZV14Update="";this.OV14Update="";this.ZV15Delete="";this.OV15Delete="";this.AV13DocenteNombre="";this.A40000DocenteFoto_GXI="";this.A12DocenteId=0;this.A13DocenteNombre="";this.A10AsignaturaId=0;this.A11AsignaturaNombre="";this.A14DocenteFoto="";this.AV14Update="";this.AV15Delete="";this.AV19Pgmname="";this.Events={e110n2_client:["'DOINSERT'",!0],e150n2_client:["ENTER",!0],e160n2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13DocenteNombre",fld:"vDOCENTENOMBRE",pic:""}],[]];this.EvtParms.START=[[{av:"AV19Pgmname",fld:"vPGMNAME",pic:""}],[{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{ctrl:"FORM",prop:"Caption"},{av:"AV13DocenteNombre",fld:"vDOCENTENOMBRE",pic:""}]];this.EvtParms["GRID.LOAD"]=[[{av:"A12DocenteId",fld:"DOCENTEID",pic:"ZZZ9",hsh:!0}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"},{av:'gx.fn.getCtrlProperty("DOCENTENOMBRE","Link")',ctrl:"DOCENTENOMBRE",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A12DocenteId",fld:"DOCENTEID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13DocenteNombre",fld:"vDOCENTENOMBRE",pic:""}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13DocenteNombre",fld:"vDOCENTENOMBRE",pic:""}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13DocenteNombre",fld:"vDOCENTENOMBRE",pic:""}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13DocenteNombre",fld:"vDOCENTENOMBRE",pic:""}],[]];this.setVCMap("AV19Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV19Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV19Pgmname","vPGMNAME",0,"char",129,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar({rfrVar:"AV19Pgmname"});t.addRefreshingVar({rfrVar:"AV14Update",rfrProp:"Value",gxAttId:"Update"});t.addRefreshingVar({rfrVar:"AV15Delete",rfrProp:"Value",gxAttId:"Delete"});this.Initialize()});gx.wi(function(){gx.createParentObj(wwdocente)})