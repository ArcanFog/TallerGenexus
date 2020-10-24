/*
               File: Docente
        Description: Docente
             Author: GeneXus C# Generator version 16_0_1-129648
       Generated on: 10/17/2020 11:15:39.6
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class docente : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false;
         gxfirstwebparm = GetNextPar( );
         gxfirstwebparm_bkp = gxfirstwebparm;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_10") == 0 )
         {
            A10AsignaturaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10AsignaturaId), 4, 0)));
            A11AsignaturaNombre = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11AsignaturaNombre", A11AsignaturaNombre);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_10( A10AsignaturaId, A11AsignaturaNombre) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
         {
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp;
         }
         if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7DocenteId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7DocenteId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vDOCENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7DocenteId), "ZZZ9"), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
         }
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_web_controls( ) ;
         if ( toggleJsOutput )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_1-129648", 0) ;
            Form.Meta.addItem("description", "Docente", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtDocenteId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public docente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public docente( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_DocenteId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7DocenteId = aP1_DocenteId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdmasterpage", "GeneXus.Programs.rwdmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void fix_multi_value_controls( )
      {
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "WWAdvancedContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Docente", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Docente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFormcontainer_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divToolbarcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 ToolbarCellClass", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            ClassString = "BtnFirst";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Docente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Docente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Docente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Docente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Docente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellAdvanced", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDocenteId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDocenteId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtDocenteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A12DocenteId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A12DocenteId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDocenteId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDocenteId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Docente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDocenteNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDocenteNombre_Internalname, "Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtDocenteNombre_Internalname, StringUtil.RTrim( A13DocenteNombre), StringUtil.RTrim( context.localUtil.Format( A13DocenteNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDocenteNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDocenteNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Docente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAsignaturaId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtAsignaturaId_Internalname, "Asignatura Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtAsignaturaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10AsignaturaId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A10AsignaturaId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAsignaturaId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAsignaturaId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Docente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAsignaturaNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtAsignaturaNombre_Internalname, "Asignatura Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtAsignaturaNombre_Internalname, StringUtil.RTrim( A11AsignaturaNombre), StringUtil.RTrim( context.localUtil.Format( A11AsignaturaNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAsignaturaNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAsignaturaNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Docente.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_10_11_Internalname, sImgUrl, imgprompt_10_11_Link, "", "", context.GetTheme( ), imgprompt_10_11_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Docente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgDocenteFoto_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, "", "Foto", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Static Bitmap Variable */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            A14DocenteFoto_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A14DocenteFoto))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000DocenteFoto_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A14DocenteFoto)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A14DocenteFoto)) ? A40000DocenteFoto_GXI : context.PathToRelativeUrl( A14DocenteFoto));
            GxWebStd.gx_bitmap( context, imgDocenteFoto_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgDocenteFoto_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "", "", "", 0, A14DocenteFoto_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_Docente.htm");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgDocenteFoto_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A14DocenteFoto)) ? A40000DocenteFoto_GXI : context.PathToRelativeUrl( A14DocenteFoto)), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgDocenteFoto_Internalname, "IsBlob", StringUtil.BoolToStr( A14DocenteFoto_IsBlob), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Docente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Docente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Docente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11062 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtDocenteId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDocenteId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "DOCENTEID");
                  AnyError = 1;
                  GX_FocusControl = edtDocenteId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A12DocenteId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A12DocenteId), 4, 0)));
               }
               else
               {
                  A12DocenteId = (short)(context.localUtil.CToN( cgiGet( edtDocenteId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A12DocenteId), 4, 0)));
               }
               A13DocenteNombre = cgiGet( edtDocenteNombre_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13DocenteNombre", A13DocenteNombre);
               if ( ( ( context.localUtil.CToN( cgiGet( edtAsignaturaId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtAsignaturaId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ASIGNATURAID");
                  AnyError = 1;
                  GX_FocusControl = edtAsignaturaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A10AsignaturaId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10AsignaturaId), 4, 0)));
               }
               else
               {
                  A10AsignaturaId = (short)(context.localUtil.CToN( cgiGet( edtAsignaturaId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10AsignaturaId), 4, 0)));
               }
               A11AsignaturaNombre = cgiGet( edtAsignaturaNombre_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11AsignaturaNombre", A11AsignaturaNombre);
               A14DocenteFoto = cgiGet( imgDocenteFoto_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14DocenteFoto", A14DocenteFoto);
               /* Read saved values. */
               Z12DocenteId = (short)(context.localUtil.CToN( cgiGet( "Z12DocenteId"), ".", ","));
               Z13DocenteNombre = cgiGet( "Z13DocenteNombre");
               Z10AsignaturaId = (short)(context.localUtil.CToN( cgiGet( "Z10AsignaturaId"), ".", ","));
               Z11AsignaturaNombre = cgiGet( "Z11AsignaturaNombre");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N10AsignaturaId = (short)(context.localUtil.CToN( cgiGet( "N10AsignaturaId"), ".", ","));
               AV7DocenteId = (short)(context.localUtil.CToN( cgiGet( "vDOCENTEID"), ".", ","));
               AV11Insert_AsignaturaId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_ASIGNATURAID"), ".", ","));
               A40000DocenteFoto_GXI = cgiGet( "DOCENTEFOTO_GXI");
               AV13Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               getMultimediaValue(imgDocenteFoto_Internalname, ref  A14DocenteFoto, ref  A40000DocenteFoto_GXI);
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Docente";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_AsignaturaId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A12DocenteId != Z12DocenteId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("docente:[SecurityCheckFailed value for]"+"Insert_AsignaturaId:"+context.localUtil.Format( (decimal)(AV11Insert_AsignaturaId), "ZZZ9"));
                  GXUtil.WriteLog("docente:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A12DocenteId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A12DocenteId), 4, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode4 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode4;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound4 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_060( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "DOCENTEID");
                        AnyError = 1;
                        GX_FocusControl = edtDocenteId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName");
            EvtGridId = cgiGet( "_EventGridId");
            EvtRowId = cgiGet( "_EventRowId");
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1);
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1);
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E11062 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12062 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E12062 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll064( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         bttBtn_first_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_first_Visible), 5, 0)), true);
         bttBtn_previous_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_previous_Visible), 5, 0)), true);
         bttBtn_next_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_next_Visible), 5, 0)), true);
         bttBtn_last_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_last_Visible), 5, 0)), true);
         bttBtn_select_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_select_Visible), 5, 0)), true);
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)), true);
            }
            DisableAttributes064( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_060( )
      {
         BeforeValidate064( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls064( ) ;
            }
            else
            {
               CheckExtendedTable064( ) ;
               CloseExtendedTableCursors064( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption060( )
      {
      }

      protected void E11062( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV13Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "UniApp");
         AV11Insert_AsignaturaId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_AsignaturaId), 4, 0)));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV13Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV14GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14GXV1), 8, 0)));
            while ( AV14GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV12TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV14GXV1));
               if ( StringUtil.StrCmp(AV12TrnContextAtt.gxTpr_Attributename, "AsignaturaId") == 0 )
               {
                  AV11Insert_AsignaturaId = (short)(NumberUtil.Val( AV12TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_AsignaturaId), 4, 0)));
               }
               AV14GXV1 = (int)(AV14GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14GXV1), 8, 0)));
            }
         }
      }

      protected void E12062( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwdocente.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM064( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z13DocenteNombre = T00063_A13DocenteNombre[0];
               Z10AsignaturaId = T00063_A10AsignaturaId[0];
               Z11AsignaturaNombre = T00063_A11AsignaturaNombre[0];
            }
            else
            {
               Z13DocenteNombre = A13DocenteNombre;
               Z10AsignaturaId = A10AsignaturaId;
               Z11AsignaturaNombre = A11AsignaturaNombre;
            }
         }
         if ( GX_JID == -9 )
         {
            Z12DocenteId = A12DocenteId;
            Z13DocenteNombre = A13DocenteNombre;
            Z14DocenteFoto = A14DocenteFoto;
            Z40000DocenteFoto_GXI = A40000DocenteFoto_GXI;
            Z10AsignaturaId = A10AsignaturaId;
            Z11AsignaturaNombre = A11AsignaturaNombre;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_10_11_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00a0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ASIGNATURAID"+"'), id:'"+"ASIGNATURAID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"ASIGNATURANOMBRE"+"'), id:'"+"ASIGNATURANOMBRE"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7DocenteId) )
         {
            A12DocenteId = AV7DocenteId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A12DocenteId), 4, 0)));
         }
         if ( ! (0==AV7DocenteId) )
         {
            edtDocenteId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocenteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocenteId_Enabled), 5, 0)), true);
         }
         else
         {
            edtDocenteId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocenteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocenteId_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7DocenteId) )
         {
            edtDocenteId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocenteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocenteId_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_AsignaturaId) )
         {
            edtAsignaturaId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaId_Enabled), 5, 0)), true);
         }
         else
         {
            edtAsignaturaId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaId_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_AsignaturaId) )
         {
            A10AsignaturaId = AV11Insert_AsignaturaId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10AsignaturaId), 4, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV13Pgmname = "Docente";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         }
      }

      protected void Load064( )
      {
         /* Using cursor T00065 */
         pr_default.execute(3, new Object[] {A12DocenteId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound4 = 1;
            A13DocenteNombre = T00065_A13DocenteNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13DocenteNombre", A13DocenteNombre);
            A40000DocenteFoto_GXI = T00065_A40000DocenteFoto_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgDocenteFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A14DocenteFoto)) ? A40000DocenteFoto_GXI : context.convertURL( context.PathToRelativeUrl( A14DocenteFoto))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgDocenteFoto_Internalname, "SrcSet", context.GetImageSrcSet( A14DocenteFoto), true);
            A10AsignaturaId = T00065_A10AsignaturaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10AsignaturaId), 4, 0)));
            A11AsignaturaNombre = T00065_A11AsignaturaNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11AsignaturaNombre", A11AsignaturaNombre);
            A14DocenteFoto = T00065_A14DocenteFoto[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14DocenteFoto", A14DocenteFoto);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgDocenteFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A14DocenteFoto)) ? A40000DocenteFoto_GXI : context.convertURL( context.PathToRelativeUrl( A14DocenteFoto))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgDocenteFoto_Internalname, "SrcSet", context.GetImageSrcSet( A14DocenteFoto), true);
            ZM064( -9) ;
         }
         pr_default.close(3);
         OnLoadActions064( ) ;
      }

      protected void OnLoadActions064( )
      {
         AV13Pgmname = "Docente";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
      }

      protected void CheckExtendedTable064( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV13Pgmname = "Docente";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         /* Using cursor T00064 */
         pr_default.execute(2, new Object[] {A10AsignaturaId, A11AsignaturaNombre});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Asignatura'.", "ForeignKeyNotFound", 1, "ASIGNATURAID");
            AnyError = 1;
            GX_FocusControl = edtAsignaturaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors064( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_10( short A10AsignaturaId ,
                                String A11AsignaturaNombre )
      {
         /* Using cursor T00066 */
         pr_default.execute(4, new Object[] {A10AsignaturaId, A11AsignaturaNombre});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No matching 'Asignatura'.", "ForeignKeyNotFound", 1, "ASIGNATURAID");
            AnyError = 1;
            GX_FocusControl = edtAsignaturaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(4);
      }

      protected void GetKey064( )
      {
         /* Using cursor T00067 */
         pr_default.execute(5, new Object[] {A12DocenteId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound4 = 1;
         }
         else
         {
            RcdFound4 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00063 */
         pr_default.execute(1, new Object[] {A12DocenteId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM064( 9) ;
            RcdFound4 = 1;
            A12DocenteId = T00063_A12DocenteId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A12DocenteId), 4, 0)));
            A13DocenteNombre = T00063_A13DocenteNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13DocenteNombre", A13DocenteNombre);
            A40000DocenteFoto_GXI = T00063_A40000DocenteFoto_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgDocenteFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A14DocenteFoto)) ? A40000DocenteFoto_GXI : context.convertURL( context.PathToRelativeUrl( A14DocenteFoto))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgDocenteFoto_Internalname, "SrcSet", context.GetImageSrcSet( A14DocenteFoto), true);
            A10AsignaturaId = T00063_A10AsignaturaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10AsignaturaId), 4, 0)));
            A11AsignaturaNombre = T00063_A11AsignaturaNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11AsignaturaNombre", A11AsignaturaNombre);
            A14DocenteFoto = T00063_A14DocenteFoto[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14DocenteFoto", A14DocenteFoto);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgDocenteFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A14DocenteFoto)) ? A40000DocenteFoto_GXI : context.convertURL( context.PathToRelativeUrl( A14DocenteFoto))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgDocenteFoto_Internalname, "SrcSet", context.GetImageSrcSet( A14DocenteFoto), true);
            Z12DocenteId = A12DocenteId;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load064( ) ;
            if ( AnyError == 1 )
            {
               RcdFound4 = 0;
               InitializeNonKey064( ) ;
            }
            Gx_mode = sMode4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound4 = 0;
            InitializeNonKey064( ) ;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey064( ) ;
         if ( RcdFound4 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound4 = 0;
         /* Using cursor T00068 */
         pr_default.execute(6, new Object[] {A12DocenteId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00068_A12DocenteId[0] < A12DocenteId ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00068_A12DocenteId[0] > A12DocenteId ) ) )
            {
               A12DocenteId = T00068_A12DocenteId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A12DocenteId), 4, 0)));
               RcdFound4 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound4 = 0;
         /* Using cursor T00069 */
         pr_default.execute(7, new Object[] {A12DocenteId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00069_A12DocenteId[0] > A12DocenteId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00069_A12DocenteId[0] < A12DocenteId ) ) )
            {
               A12DocenteId = T00069_A12DocenteId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A12DocenteId), 4, 0)));
               RcdFound4 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey064( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtDocenteId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert064( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound4 == 1 )
            {
               if ( A12DocenteId != Z12DocenteId )
               {
                  A12DocenteId = Z12DocenteId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A12DocenteId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "DOCENTEID");
                  AnyError = 1;
                  GX_FocusControl = edtDocenteId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtDocenteId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update064( ) ;
                  GX_FocusControl = edtDocenteId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A12DocenteId != Z12DocenteId )
               {
                  /* Insert record */
                  GX_FocusControl = edtDocenteId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert064( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "DOCENTEID");
                     AnyError = 1;
                     GX_FocusControl = edtDocenteId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtDocenteId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert064( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A12DocenteId != Z12DocenteId )
         {
            A12DocenteId = Z12DocenteId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A12DocenteId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "DOCENTEID");
            AnyError = 1;
            GX_FocusControl = edtDocenteId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtDocenteId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency064( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00062 */
            pr_default.execute(0, new Object[] {A12DocenteId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Docente"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z13DocenteNombre, T00062_A13DocenteNombre[0]) != 0 ) || ( Z10AsignaturaId != T00062_A10AsignaturaId[0] ) || ( StringUtil.StrCmp(Z11AsignaturaNombre, T00062_A11AsignaturaNombre[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z13DocenteNombre, T00062_A13DocenteNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("docente:[seudo value changed for attri]"+"DocenteNombre");
                  GXUtil.WriteLogRaw("Old: ",Z13DocenteNombre);
                  GXUtil.WriteLogRaw("Current: ",T00062_A13DocenteNombre[0]);
               }
               if ( Z10AsignaturaId != T00062_A10AsignaturaId[0] )
               {
                  GXUtil.WriteLog("docente:[seudo value changed for attri]"+"AsignaturaId");
                  GXUtil.WriteLogRaw("Old: ",Z10AsignaturaId);
                  GXUtil.WriteLogRaw("Current: ",T00062_A10AsignaturaId[0]);
               }
               if ( StringUtil.StrCmp(Z11AsignaturaNombre, T00062_A11AsignaturaNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("docente:[seudo value changed for attri]"+"AsignaturaNombre");
                  GXUtil.WriteLogRaw("Old: ",Z11AsignaturaNombre);
                  GXUtil.WriteLogRaw("Current: ",T00062_A11AsignaturaNombre[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Docente"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert064( )
      {
         BeforeValidate064( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable064( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM064( 0) ;
            CheckOptimisticConcurrency064( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm064( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert064( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000610 */
                     pr_default.execute(8, new Object[] {A12DocenteId, A13DocenteNombre, A14DocenteFoto, A40000DocenteFoto_GXI, A10AsignaturaId, A11AsignaturaNombre});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Docente") ;
                     if ( (pr_default.getStatus(8) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption060( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load064( ) ;
            }
            EndLevel064( ) ;
         }
         CloseExtendedTableCursors064( ) ;
      }

      protected void Update064( )
      {
         BeforeValidate064( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable064( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency064( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm064( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate064( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000611 */
                     pr_default.execute(9, new Object[] {A13DocenteNombre, A10AsignaturaId, A11AsignaturaNombre, A12DocenteId});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Docente") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Docente"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate064( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel064( ) ;
         }
         CloseExtendedTableCursors064( ) ;
      }

      protected void DeferredUpdate064( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T000612 */
            pr_default.execute(10, new Object[] {A14DocenteFoto, A40000DocenteFoto_GXI, A12DocenteId});
            pr_default.close(10);
            dsDefault.SmartCacheProvider.SetUpdated("Docente") ;
         }
      }

      protected void delete( )
      {
         BeforeValidate064( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency064( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls064( ) ;
            AfterConfirm064( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete064( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000613 */
                  pr_default.execute(11, new Object[] {A12DocenteId});
                  pr_default.close(11);
                  dsDefault.SmartCacheProvider.SetUpdated("Docente") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode4 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel064( ) ;
         Gx_mode = sMode4;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls064( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV13Pgmname = "Docente";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         }
      }

      protected void EndLevel064( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete064( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("docente",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues060( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("docente",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart064( )
      {
         /* Scan By routine */
         /* Using cursor T000614 */
         pr_default.execute(12);
         RcdFound4 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound4 = 1;
            A12DocenteId = T000614_A12DocenteId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A12DocenteId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext064( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound4 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound4 = 1;
            A12DocenteId = T000614_A12DocenteId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A12DocenteId), 4, 0)));
         }
      }

      protected void ScanEnd064( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm064( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert064( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate064( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete064( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete064( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate064( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes064( )
      {
         edtDocenteId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocenteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocenteId_Enabled), 5, 0)), true);
         edtDocenteNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocenteNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocenteNombre_Enabled), 5, 0)), true);
         edtAsignaturaId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaId_Enabled), 5, 0)), true);
         edtAsignaturaNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaNombre_Enabled), 5, 0)), true);
         imgDocenteFoto_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgDocenteFoto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgDocenteFoto_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes064( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues060( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 129648), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("gxcfg.js", "?202010171115412", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("docente.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7DocenteId)+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "Docente";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_AsignaturaId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("docente:[SendSecurityCheck value for]"+"Insert_AsignaturaId:"+context.localUtil.Format( (decimal)(AV11Insert_AsignaturaId), "ZZZ9"));
         GXUtil.WriteLog("docente:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z12DocenteId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z12DocenteId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z13DocenteNombre", StringUtil.RTrim( Z13DocenteNombre));
         GxWebStd.gx_hidden_field( context, "Z10AsignaturaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10AsignaturaId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z11AsignaturaNombre", StringUtil.RTrim( Z11AsignaturaNombre));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N10AsignaturaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10AsignaturaId), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vDOCENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7DocenteId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vDOCENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7DocenteId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_ASIGNATURAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_AsignaturaId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DOCENTEFOTO_GXI", A40000DocenteFoto_GXI);
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV13Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GXCCtlgxBlob = "DOCENTEFOTO" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A14DocenteFoto);
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("docente.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7DocenteId) ;
      }

      public override String GetPgmname( )
      {
         return "Docente" ;
      }

      public override String GetPgmdesc( )
      {
         return "Docente" ;
      }

      protected void InitializeNonKey064( )
      {
         A10AsignaturaId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10AsignaturaId), 4, 0)));
         A13DocenteNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13DocenteNombre", A13DocenteNombre);
         A11AsignaturaNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11AsignaturaNombre", A11AsignaturaNombre);
         A14DocenteFoto = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14DocenteFoto", A14DocenteFoto);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgDocenteFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A14DocenteFoto)) ? A40000DocenteFoto_GXI : context.convertURL( context.PathToRelativeUrl( A14DocenteFoto))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgDocenteFoto_Internalname, "SrcSet", context.GetImageSrcSet( A14DocenteFoto), true);
         A40000DocenteFoto_GXI = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgDocenteFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A14DocenteFoto)) ? A40000DocenteFoto_GXI : context.convertURL( context.PathToRelativeUrl( A14DocenteFoto))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgDocenteFoto_Internalname, "SrcSet", context.GetImageSrcSet( A14DocenteFoto), true);
         Z13DocenteNombre = "";
         Z10AsignaturaId = 0;
         Z11AsignaturaNombre = "";
      }

      protected void InitAll064( )
      {
         A12DocenteId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A12DocenteId), 4, 0)));
         InitializeNonKey064( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020101711154114", true, true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.eng.js", "?"+GetCacheInvalidationToken( ), false, true);
         context.AddJavascriptSource("docente.js", "?2020101711154114", false, true);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         divTitlecontainer_Internalname = "TITLECONTAINER";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         divToolbarcell_Internalname = "TOOLBARCELL";
         edtDocenteId_Internalname = "DOCENTEID";
         edtDocenteNombre_Internalname = "DOCENTENOMBRE";
         edtAsignaturaId_Internalname = "ASIGNATURAID";
         edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE";
         imgDocenteFoto_Internalname = "DOCENTEFOTO";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_10_11_Internalname = "PROMPT_10_11";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Docente";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         imgDocenteFoto_Enabled = 1;
         imgprompt_10_11_Visible = 1;
         imgprompt_10_11_Link = "";
         edtAsignaturaNombre_Jsonclick = "";
         edtAsignaturaNombre_Enabled = 1;
         edtAsignaturaId_Jsonclick = "";
         edtAsignaturaId_Enabled = 1;
         edtDocenteNombre_Jsonclick = "";
         edtDocenteNombre_Enabled = 1;
         edtDocenteId_Jsonclick = "";
         edtDocenteId_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      public void Valid_Asignaturanombre( short GX_Parm1 ,
                                          String GX_Parm2 )
      {
         A10AsignaturaId = GX_Parm1;
         A11AsignaturaNombre = GX_Parm2;
         /* Using cursor T000615 */
         pr_default.execute(13, new Object[] {A10AsignaturaId, A11AsignaturaNombre});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No matching 'Asignatura'.", "ForeignKeyNotFound", 1, "ASIGNATURAID");
            AnyError = 1;
            GX_FocusControl = edtAsignaturaId_Internalname;
         }
         pr_default.close(13);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7DocenteId',fld:'vDOCENTEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7DocenteId',fld:'vDOCENTEID',pic:'ZZZ9',hsh:true},{av:'AV11Insert_AsignaturaId',fld:'vINSERT_ASIGNATURAID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12062',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
         pr_default.close(13);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z13DocenteNombre = "";
         Z11AsignaturaNombre = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A11AsignaturaNombre = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A13DocenteNombre = "";
         sImgUrl = "";
         A14DocenteFoto = "";
         A40000DocenteFoto_GXI = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV13Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode4 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z14DocenteFoto = "";
         Z40000DocenteFoto_GXI = "";
         T00065_A12DocenteId = new short[1] ;
         T00065_A13DocenteNombre = new String[] {""} ;
         T00065_A40000DocenteFoto_GXI = new String[] {""} ;
         T00065_A10AsignaturaId = new short[1] ;
         T00065_A11AsignaturaNombre = new String[] {""} ;
         T00065_A14DocenteFoto = new String[] {""} ;
         T00064_A10AsignaturaId = new short[1] ;
         T00066_A10AsignaturaId = new short[1] ;
         T00067_A12DocenteId = new short[1] ;
         T00063_A12DocenteId = new short[1] ;
         T00063_A13DocenteNombre = new String[] {""} ;
         T00063_A40000DocenteFoto_GXI = new String[] {""} ;
         T00063_A10AsignaturaId = new short[1] ;
         T00063_A11AsignaturaNombre = new String[] {""} ;
         T00063_A14DocenteFoto = new String[] {""} ;
         T00068_A12DocenteId = new short[1] ;
         T00069_A12DocenteId = new short[1] ;
         T00062_A12DocenteId = new short[1] ;
         T00062_A13DocenteNombre = new String[] {""} ;
         T00062_A40000DocenteFoto_GXI = new String[] {""} ;
         T00062_A10AsignaturaId = new short[1] ;
         T00062_A11AsignaturaNombre = new String[] {""} ;
         T00062_A14DocenteFoto = new String[] {""} ;
         T000614_A12DocenteId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXCCtlgxBlob = "";
         T000615_A10AsignaturaId = new short[1] ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.docente__default(),
            new Object[][] {
                new Object[] {
               T00062_A12DocenteId, T00062_A13DocenteNombre, T00062_A40000DocenteFoto_GXI, T00062_A10AsignaturaId, T00062_A11AsignaturaNombre, T00062_A14DocenteFoto
               }
               , new Object[] {
               T00063_A12DocenteId, T00063_A13DocenteNombre, T00063_A40000DocenteFoto_GXI, T00063_A10AsignaturaId, T00063_A11AsignaturaNombre, T00063_A14DocenteFoto
               }
               , new Object[] {
               T00064_A10AsignaturaId
               }
               , new Object[] {
               T00065_A12DocenteId, T00065_A13DocenteNombre, T00065_A40000DocenteFoto_GXI, T00065_A10AsignaturaId, T00065_A11AsignaturaNombre, T00065_A14DocenteFoto
               }
               , new Object[] {
               T00066_A10AsignaturaId
               }
               , new Object[] {
               T00067_A12DocenteId
               }
               , new Object[] {
               T00068_A12DocenteId
               }
               , new Object[] {
               T00069_A12DocenteId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000614_A12DocenteId
               }
               , new Object[] {
               T000615_A10AsignaturaId
               }
            }
         );
         AV13Pgmname = "Docente";
      }

      private short wcpOAV7DocenteId ;
      private short Z12DocenteId ;
      private short Z10AsignaturaId ;
      private short N10AsignaturaId ;
      private short GxWebError ;
      private short A10AsignaturaId ;
      private short AV7DocenteId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A12DocenteId ;
      private short AV11Insert_AsignaturaId ;
      private short RcdFound4 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtDocenteId_Enabled ;
      private int edtDocenteNombre_Enabled ;
      private int edtAsignaturaId_Enabled ;
      private int edtAsignaturaNombre_Enabled ;
      private int imgprompt_10_11_Visible ;
      private int imgDocenteFoto_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV14GXV1 ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z13DocenteNombre ;
      private String Z11AsignaturaNombre ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A11AsignaturaNombre ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtDocenteId_Internalname ;
      private String divMaintable_Internalname ;
      private String divTitlecontainer_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divFormcontainer_Internalname ;
      private String divToolbarcell_Internalname ;
      private String TempTags ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String edtDocenteId_Jsonclick ;
      private String edtDocenteNombre_Internalname ;
      private String A13DocenteNombre ;
      private String edtDocenteNombre_Jsonclick ;
      private String edtAsignaturaId_Internalname ;
      private String edtAsignaturaId_Jsonclick ;
      private String edtAsignaturaNombre_Internalname ;
      private String edtAsignaturaNombre_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_10_11_Internalname ;
      private String imgprompt_10_11_Link ;
      private String imgDocenteFoto_Internalname ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV13Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode4 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXCCtlgxBlob ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A14DocenteFoto_IsBlob ;
      private bool returnInSub ;
      private String A40000DocenteFoto_GXI ;
      private String Z40000DocenteFoto_GXI ;
      private String A14DocenteFoto ;
      private String Z14DocenteFoto ;
      private IGxSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00065_A12DocenteId ;
      private String[] T00065_A13DocenteNombre ;
      private String[] T00065_A40000DocenteFoto_GXI ;
      private short[] T00065_A10AsignaturaId ;
      private String[] T00065_A11AsignaturaNombre ;
      private String[] T00065_A14DocenteFoto ;
      private short[] T00064_A10AsignaturaId ;
      private short[] T00066_A10AsignaturaId ;
      private short[] T00067_A12DocenteId ;
      private short[] T00063_A12DocenteId ;
      private String[] T00063_A13DocenteNombre ;
      private String[] T00063_A40000DocenteFoto_GXI ;
      private short[] T00063_A10AsignaturaId ;
      private String[] T00063_A11AsignaturaNombre ;
      private String[] T00063_A14DocenteFoto ;
      private short[] T00068_A12DocenteId ;
      private short[] T00069_A12DocenteId ;
      private short[] T00062_A12DocenteId ;
      private String[] T00062_A13DocenteNombre ;
      private String[] T00062_A40000DocenteFoto_GXI ;
      private short[] T00062_A10AsignaturaId ;
      private String[] T00062_A11AsignaturaNombre ;
      private String[] T00062_A14DocenteFoto ;
      private short[] T000614_A12DocenteId ;
      private short[] T000615_A10AsignaturaId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV12TrnContextAtt ;
   }

   public class docente__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00065 ;
          prmT00065 = new Object[] {
          new Object[] {"@DocenteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00064 ;
          prmT00064 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT00066 ;
          prmT00066 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT00067 ;
          prmT00067 = new Object[] {
          new Object[] {"@DocenteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00063 ;
          prmT00063 = new Object[] {
          new Object[] {"@DocenteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00068 ;
          prmT00068 = new Object[] {
          new Object[] {"@DocenteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00069 ;
          prmT00069 = new Object[] {
          new Object[] {"@DocenteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00062 ;
          prmT00062 = new Object[] {
          new Object[] {"@DocenteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000610 ;
          prmT000610 = new Object[] {
          new Object[] {"@DocenteId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DocenteNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@DocenteFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@DocenteFoto_GXI",SqlDbType.VarChar,2048,0} ,
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT000611 ;
          prmT000611 = new Object[] {
          new Object[] {"@DocenteNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@DocenteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000612 ;
          prmT000612 = new Object[] {
          new Object[] {"@DocenteFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@DocenteFoto_GXI",SqlDbType.VarChar,2048,0} ,
          new Object[] {"@DocenteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000613 ;
          prmT000613 = new Object[] {
          new Object[] {"@DocenteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000614 ;
          prmT000614 = new Object[] {
          } ;
          Object[] prmT000615 ;
          prmT000615 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00062", "SELECT [DocenteId], [DocenteNombre], [DocenteFoto_GXI], [AsignaturaId], [AsignaturaNombre], [DocenteFoto] FROM [Docente] WITH (UPDLOCK) WHERE [DocenteId] = @DocenteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00062,1,0,true,false )
             ,new CursorDef("T00063", "SELECT [DocenteId], [DocenteNombre], [DocenteFoto_GXI], [AsignaturaId], [AsignaturaNombre], [DocenteFoto] FROM [Docente] WITH (NOLOCK) WHERE [DocenteId] = @DocenteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00063,1,0,true,false )
             ,new CursorDef("T00064", "SELECT [AsignaturaId] FROM [Asignatura] WITH (NOLOCK) WHERE [AsignaturaId] = @AsignaturaId AND [AsignaturaNombre] = @AsignaturaNombre ",true, GxErrorMask.GX_NOMASK, false, this,prmT00064,1,0,true,false )
             ,new CursorDef("T00065", "SELECT TM1.[DocenteId], TM1.[DocenteNombre], TM1.[DocenteFoto_GXI], TM1.[AsignaturaId], TM1.[AsignaturaNombre], TM1.[DocenteFoto] FROM [Docente] TM1 WITH (NOLOCK) WHERE TM1.[DocenteId] = @DocenteId ORDER BY TM1.[DocenteId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00065,100,0,true,false )
             ,new CursorDef("T00066", "SELECT [AsignaturaId] FROM [Asignatura] WITH (NOLOCK) WHERE [AsignaturaId] = @AsignaturaId AND [AsignaturaNombre] = @AsignaturaNombre ",true, GxErrorMask.GX_NOMASK, false, this,prmT00066,1,0,true,false )
             ,new CursorDef("T00067", "SELECT [DocenteId] FROM [Docente] WITH (NOLOCK) WHERE [DocenteId] = @DocenteId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00067,1,0,true,false )
             ,new CursorDef("T00068", "SELECT TOP 1 [DocenteId] FROM [Docente] WITH (NOLOCK) WHERE ( [DocenteId] > @DocenteId) ORDER BY [DocenteId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00068,1,0,true,true )
             ,new CursorDef("T00069", "SELECT TOP 1 [DocenteId] FROM [Docente] WITH (NOLOCK) WHERE ( [DocenteId] < @DocenteId) ORDER BY [DocenteId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00069,1,0,true,true )
             ,new CursorDef("T000610", "INSERT INTO [Docente]([DocenteId], [DocenteNombre], [DocenteFoto], [DocenteFoto_GXI], [AsignaturaId], [AsignaturaNombre]) VALUES(@DocenteId, @DocenteNombre, @DocenteFoto, @DocenteFoto_GXI, @AsignaturaId, @AsignaturaNombre)", GxErrorMask.GX_NOMASK,prmT000610)
             ,new CursorDef("T000611", "UPDATE [Docente] SET [DocenteNombre]=@DocenteNombre, [AsignaturaId]=@AsignaturaId, [AsignaturaNombre]=@AsignaturaNombre  WHERE [DocenteId] = @DocenteId", GxErrorMask.GX_NOMASK,prmT000611)
             ,new CursorDef("T000612", "UPDATE [Docente] SET [DocenteFoto]=@DocenteFoto, [DocenteFoto_GXI]=@DocenteFoto_GXI  WHERE [DocenteId] = @DocenteId", GxErrorMask.GX_NOMASK,prmT000612)
             ,new CursorDef("T000613", "DELETE FROM [Docente]  WHERE [DocenteId] = @DocenteId", GxErrorMask.GX_NOMASK,prmT000613)
             ,new CursorDef("T000614", "SELECT [DocenteId] FROM [Docente] WITH (NOLOCK) ORDER BY [DocenteId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000614,100,0,true,false )
             ,new CursorDef("T000615", "SELECT [AsignaturaId] FROM [Asignatura] WITH (NOLOCK) WHERE [AsignaturaId] = @AsignaturaId AND [AsignaturaNombre] = @AsignaturaNombre ",true, GxErrorMask.GX_NOMASK, false, this,prmT000615,1,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(3)) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(3)) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(3)) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameterBlob(3, (String)parms[2], false);
                stmt.SetParameterMultimedia(4, (String)parms[3], (String)parms[2], "Docente", "DocenteFoto");
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 10 :
                stmt.SetParameterBlob(1, (String)parms[0], false);
                stmt.SetParameterMultimedia(2, (String)parms[1], (String)parms[0], "Docente", "DocenteFoto");
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
       }
    }

 }

}
