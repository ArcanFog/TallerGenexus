/*!   GeneXus C# 16_0_1-129648 on 10/17/2020 11:15:42.88
*/
gx.evt.autoSkip=!1;gx.define("asignaturadocentewc",!0,function(n){var t,i;this.ServerClass="asignaturadocentewc";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6AsignaturaId=gx.fn.getIntegerValue("vASIGNATURAID",",");this.AV14AsignaturaNombre=gx.fn.getControlValue("vASIGNATURANOMBRE");this.AV6AsignaturaId=gx.fn.getIntegerValue("vASIGNATURAID",",");this.AV14AsignaturaNombre=gx.fn.getControlValue("vASIGNATURANOMBRE")};this.e110d2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e140d2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e150d2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,18,19,21,22,23,24,25,26,27,28,29,30,31,32,33];this.GXLastCtrlId=33;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",20,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"asignaturadocentewc",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);i=this.GridContainer;i.addSingleLineEdit(12,21,"DOCENTEID","Id","","DocenteId","int",0,"px",4,4,"right",null,[],12,"DocenteId",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(13,22,"DOCENTENOMBRE","Nombre","","DocenteNombre","char",0,"px",20,20,"left",null,[],13,"DocenteNombre",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");i.addBitmap(14,"DOCENTEFOTO",23,0,"px",17,"px",null,"","Foto","ImageAttribute","WWColumn WWOptionalColumn");i.addSingleLineEdit("Update",24,"vUPDATE","","","Update","char",0,"px",20,20,"left",null,[],"Update","Update",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");i.addSingleLineEdit("Delete",25,"vDELETE","","","Delete","char",0,"px",20,20,"left",null,[],"Delete","Delete",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");this.GridContainer.emptyText="";this.setGrid(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLETOP",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"BTNINSERT",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"GRIDCELL",grid:0};t[14]={id:14,fld:"GRIDTABLE",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[18]={id:18,fld:"",grid:0};t[19]={id:19,fld:"",grid:0};t[21]={id:21,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DOCENTEID",gxz:"Z12DocenteId",gxold:"O12DocenteId",gxvar:"A12DocenteId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A12DocenteId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z12DocenteId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("DOCENTEID",n||gx.fn.currentGridRowImpl(20),gx.O.A12DocenteId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A12DocenteId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("DOCENTEID",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[22]={id:22,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DOCENTENOMBRE",gxz:"Z13DocenteNombre",gxold:"O13DocenteNombre",gxvar:"A13DocenteNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A13DocenteNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z13DocenteNombre=n)},v2c:function(n){gx.fn.setGridControlValue("DOCENTENOMBRE",n||gx.fn.currentGridRowImpl(20),gx.O.A13DocenteNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A13DocenteNombre=this.val())},val:function(n){return gx.fn.getGridControlValue("DOCENTENOMBRE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[23]={id:23,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DOCENTEFOTO",gxz:"Z14DocenteFoto",gxold:"O14DocenteFoto",gxvar:"A14DocenteFoto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A14DocenteFoto=n)},v2z:function(n){n!==undefined&&(gx.O.Z14DocenteFoto=n)},v2c:function(n){gx.fn.setGridMultimediaValue("DOCENTEFOTO",n||gx.fn.currentGridRowImpl(20),gx.O.A14DocenteFoto,gx.O.A40000DocenteFoto_GXI)},c2v:function(){gx.O.A40000DocenteFoto_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.A14DocenteFoto=this.val())},val:function(n){return gx.fn.getGridControlValue("DOCENTEFOTO",n||gx.fn.currentGridRowImpl(20))},val_GXI:function(n){return gx.fn.getGridControlValue("DOCENTEFOTO_GXI",n||gx.fn.currentGridRowImpl(20))},gxvar_GXI:"A40000DocenteFoto_GXI",nac:gx.falseFn};t[24]={id:24,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV12Update",gxold:"OV12Update",gxvar:"AV12Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV12Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12Update=n)},v2c:function(n){gx.fn.setGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20),gx.O.AV12Update,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12Update=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[25]={id:25,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV13Delete",gxold:"OV13Delete",gxvar:"AV13Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV13Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV13Delete=n)},v2c:function(n){gx.fn.setGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20),gx.O.AV13Delete,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV13Delete=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,fld:"",grid:0};t[29]={id:29,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ASIGNATURAID",gxz:"Z10AsignaturaId",gxold:"O10AsignaturaId",gxvar:"A10AsignaturaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A10AsignaturaId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z10AsignaturaId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ASIGNATURAID",gx.O.A10AsignaturaId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A10AsignaturaId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ASIGNATURAID",",")},nac:gx.falseFn};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ASIGNATURANOMBRE",gxz:"Z11AsignaturaNombre",gxold:"O11AsignaturaNombre",gxvar:"A11AsignaturaNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A11AsignaturaNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z11AsignaturaNombre=n)},v2c:function(){gx.fn.setControlValue("ASIGNATURANOMBRE",gx.O.A11AsignaturaNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A11AsignaturaNombre=this.val())},val:function(){return gx.fn.getControlValue("ASIGNATURANOMBRE")},nac:gx.falseFn};this.Z12DocenteId=0;this.O12DocenteId=0;this.Z13DocenteNombre="";this.O13DocenteNombre="";this.Z14DocenteFoto="";this.O14DocenteFoto="";this.ZV12Update="";this.OV12Update="";this.ZV13Delete="";this.OV13Delete="";this.A10AsignaturaId=0;this.Z10AsignaturaId=0;this.O10AsignaturaId=0;this.A11AsignaturaNombre="";this.Z11AsignaturaNombre="";this.O11AsignaturaNombre="";this.A10AsignaturaId=0;this.A11AsignaturaNombre="";this.A40000DocenteFoto_GXI="";this.AV6AsignaturaId=0;this.AV14AsignaturaNombre="";this.A12DocenteId=0;this.A13DocenteNombre="";this.A14DocenteFoto="";this.AV12Update="";this.AV13Delete="";this.Events={e110d2_client:["'DOINSERT'",!0],e140d2_client:["ENTER",!0],e150d2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6AsignaturaId",fld:"vASIGNATURAID",pic:"ZZZ9"},{av:"AV14AsignaturaNombre",fld:"vASIGNATURANOMBRE",pic:""},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.START=[[{av:"AV17Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6AsignaturaId",fld:"vASIGNATURAID",pic:"ZZZ9"},{av:"AV14AsignaturaNombre",fld:"vASIGNATURANOMBRE",pic:""}],[{ctrl:"GRID",prop:"Rows"},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("ASIGNATURAID","Visible")',ctrl:"ASIGNATURAID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("ASIGNATURANOMBRE","Visible")',ctrl:"ASIGNATURANOMBRE",prop:"Visible"}]];this.EvtParms["GRID.LOAD"]=[[{av:"A12DocenteId",fld:"DOCENTEID",pic:"ZZZ9",hsh:!0}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"},{av:'gx.fn.getCtrlProperty("DOCENTENOMBRE","Link")',ctrl:"DOCENTENOMBRE",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A12DocenteId",fld:"DOCENTEID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6AsignaturaId",fld:"vASIGNATURAID",pic:"ZZZ9"},{av:"AV14AsignaturaNombre",fld:"vASIGNATURANOMBRE",pic:""},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6AsignaturaId",fld:"vASIGNATURAID",pic:"ZZZ9"},{av:"AV14AsignaturaNombre",fld:"vASIGNATURANOMBRE",pic:""},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6AsignaturaId",fld:"vASIGNATURAID",pic:"ZZZ9"},{av:"AV14AsignaturaNombre",fld:"vASIGNATURANOMBRE",pic:""},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6AsignaturaId",fld:"vASIGNATURAID",pic:"ZZZ9"},{av:"AV14AsignaturaNombre",fld:"vASIGNATURANOMBRE",pic:""},{av:"AV12Update",fld:"vUPDATE",pic:""},{av:"AV13Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.setVCMap("AV6AsignaturaId","vASIGNATURAID",0,"int",4,0);this.setVCMap("AV14AsignaturaNombre","vASIGNATURANOMBRE",0,"char",20,0);this.setVCMap("AV6AsignaturaId","vASIGNATURAID",0,"int",4,0);this.setVCMap("AV14AsignaturaNombre","vASIGNATURANOMBRE",0,"char",20,0);this.setVCMap("AV6AsignaturaId","vASIGNATURAID",0,"int",4,0);this.setVCMap("AV14AsignaturaNombre","vASIGNATURANOMBRE",0,"char",20,0);i.addRefreshingVar({rfrVar:"AV6AsignaturaId"});i.addRefreshingVar({rfrVar:"AV14AsignaturaNombre"});i.addRefreshingVar({rfrVar:"AV12Update",rfrProp:"Value",gxAttId:"Update"});i.addRefreshingVar({rfrVar:"AV13Delete",rfrProp:"Value",gxAttId:"Delete"});this.Initialize()})