/*!   GeneXus C# 16_0_1-129648 on 10/17/2020 11:15:33.3
*/
gx.evt.autoSkip=!1;gx.define("docentegeneral",!0,function(n){this.ServerClass="docentegeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Docenteid=function(){try{var n=gx.util.balloon.getNew("DOCENTEID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e110o1_client=function(){return this.clearMessages(),this.call("docente.aspx",["UPD",this.A12DocenteId]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e120o1_client=function(){return this.clearMessages(),this.call("docente.aspx",["DLT",this.A12DocenteId]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e150o2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e160o2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39];this.GXLastCtrlId=39;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"BTNUPDATE",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"BTNDELETE",grid:0};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"ATTRIBUTESTABLE",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Docenteid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DOCENTEID",gxz:"Z12DocenteId",gxold:"O12DocenteId",gxvar:"A12DocenteId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A12DocenteId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z12DocenteId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("DOCENTEID",gx.O.A12DocenteId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A12DocenteId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("DOCENTEID",",")},nac:gx.falseFn};t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DOCENTENOMBRE",gxz:"Z13DocenteNombre",gxold:"O13DocenteNombre",gxvar:"A13DocenteNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A13DocenteNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z13DocenteNombre=n)},v2c:function(){gx.fn.setControlValue("DOCENTENOMBRE",gx.O.A13DocenteNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A13DocenteNombre=this.val())},val:function(){return gx.fn.getControlValue("DOCENTENOMBRE")},nac:gx.falseFn};t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ASIGNATURAID",gxz:"Z10AsignaturaId",gxold:"O10AsignaturaId",gxvar:"A10AsignaturaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A10AsignaturaId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z10AsignaturaId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ASIGNATURAID",gx.O.A10AsignaturaId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A10AsignaturaId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ASIGNATURAID",",")},nac:gx.falseFn};t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ASIGNATURANOMBRE",gxz:"Z11AsignaturaNombre",gxold:"O11AsignaturaNombre",gxvar:"A11AsignaturaNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A11AsignaturaNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z11AsignaturaNombre=n)},v2c:function(){gx.fn.setControlValue("ASIGNATURANOMBRE",gx.O.A11AsignaturaNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A11AsignaturaNombre=this.val())},val:function(){return gx.fn.getControlValue("ASIGNATURANOMBRE")},nac:gx.falseFn};t[34]={id:34,fld:"",grid:0};t[35]={id:35,fld:"IMAGESTABLE",grid:0};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"",grid:0};t[38]={id:38,fld:"",grid:0};t[39]={id:39,lvl:0,type:"bits",len:1024,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DOCENTEFOTO",gxz:"Z14DocenteFoto",gxold:"O14DocenteFoto",gxvar:"A14DocenteFoto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A14DocenteFoto=n)},v2z:function(n){n!==undefined&&(gx.O.Z14DocenteFoto=n)},v2c:function(){gx.fn.setMultimediaValue("DOCENTEFOTO",gx.O.A14DocenteFoto,gx.O.A40000DocenteFoto_GXI)},c2v:function(){gx.O.A40000DocenteFoto_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.A14DocenteFoto=this.val())},val:function(){return gx.fn.getBlobValue("DOCENTEFOTO")},val_GXI:function(){return gx.fn.getControlValue("DOCENTEFOTO_GXI")},gxvar_GXI:"A40000DocenteFoto_GXI",nac:gx.falseFn};this.A12DocenteId=0;this.Z12DocenteId=0;this.O12DocenteId=0;this.A13DocenteNombre="";this.Z13DocenteNombre="";this.O13DocenteNombre="";this.A10AsignaturaId=0;this.Z10AsignaturaId=0;this.O10AsignaturaId=0;this.A11AsignaturaNombre="";this.Z11AsignaturaNombre="";this.O11AsignaturaNombre="";this.A40000DocenteFoto_GXI="";this.A14DocenteFoto="";this.Z14DocenteFoto="";this.O14DocenteFoto="";this.A12DocenteId=0;this.A13DocenteNombre="";this.A10AsignaturaId=0;this.A11AsignaturaNombre="";this.A14DocenteFoto="";this.A40000DocenteFoto_GXI="";this.Events={e150o2_client:["ENTER",!0],e160o2_client:["CANCEL",!0],e110o1_client:["'DOUPDATE'",!1],e120o1_client:["'DODELETE'",!1]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"AV13Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6DocenteId",fld:"vDOCENTEID",pic:"ZZZ9"}],[]];this.EvtParms.LOAD=[[],[]];this.EvtParms["'DOUPDATE'"]=[[{av:"A12DocenteId",fld:"DOCENTEID",pic:"ZZZ9"}],[]];this.EvtParms["'DODELETE'"]=[[{av:"A12DocenteId",fld:"DOCENTEID",pic:"ZZZ9"}],[]];this.Initialize()})