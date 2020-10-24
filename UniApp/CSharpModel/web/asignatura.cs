/*
               File: Asignatura
        Description: Asignatura
             Author: GeneXus C# Generator version 16_0_1-129648
       Generated on: 10/17/2020 11:15:29.58
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
   public class asignatura : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
               AV7AsignaturaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7AsignaturaId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vASIGNATURAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7AsignaturaId), "ZZZ9"), context));
               AV11AsignaturaNombre = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11AsignaturaNombre", AV11AsignaturaNombre);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vASIGNATURANOMBRE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV11AsignaturaNombre, "")), context));
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
            Form.Meta.addItem("description", "Asignatura", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtAsignaturaId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public asignatura( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public asignatura( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_AsignaturaId ,
                           String aP2_AsignaturaNombre )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7AsignaturaId = aP1_AsignaturaId;
         this.AV11AsignaturaNombre = aP2_AsignaturaNombre;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Asignatura", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Asignatura.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Asignatura.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Asignatura.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Asignatura.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Asignatura.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Asignatura.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAsignaturaId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtAsignaturaId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtAsignaturaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10AsignaturaId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A10AsignaturaId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAsignaturaId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAsignaturaId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Asignatura.htm");
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
            GxWebStd.gx_label_element( context, edtAsignaturaNombre_Internalname, "Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtAsignaturaNombre_Internalname, StringUtil.RTrim( A11AsignaturaNombre), StringUtil.RTrim( context.localUtil.Format( A11AsignaturaNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAsignaturaNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAsignaturaNombre_Enabled, 1, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Asignatura.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAsignaturaSemestre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtAsignaturaSemestre_Internalname, "Semestre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtAsignaturaSemestre_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtAsignaturaSemestre_Internalname, context.localUtil.Format(A21AsignaturaSemestre, "99/99/99"), context.localUtil.Format( A21AsignaturaSemestre, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAsignaturaSemestre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAsignaturaSemestre_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Asignatura.htm");
            GxWebStd.gx_bitmap( context, edtAsignaturaSemestre_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtAsignaturaSemestre_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Asignatura.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Asignatura.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Asignatura.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Asignatura.htm");
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
         E11052 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
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
               if ( context.localUtil.VCDate( cgiGet( edtAsignaturaSemestre_Internalname), 1) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Asignatura Semestre"}), 1, "ASIGNATURASEMESTRE");
                  AnyError = 1;
                  GX_FocusControl = edtAsignaturaSemestre_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A21AsignaturaSemestre = DateTime.MinValue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21AsignaturaSemestre", context.localUtil.Format(A21AsignaturaSemestre, "99/99/99"));
               }
               else
               {
                  A21AsignaturaSemestre = context.localUtil.CToD( cgiGet( edtAsignaturaSemestre_Internalname), 1);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21AsignaturaSemestre", context.localUtil.Format(A21AsignaturaSemestre, "99/99/99"));
               }
               /* Read saved values. */
               Z10AsignaturaId = (short)(context.localUtil.CToN( cgiGet( "Z10AsignaturaId"), ".", ","));
               Z11AsignaturaNombre = cgiGet( "Z11AsignaturaNombre");
               Z21AsignaturaSemestre = context.localUtil.CToD( cgiGet( "Z21AsignaturaSemestre"), 0);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               AV7AsignaturaId = (short)(context.localUtil.CToN( cgiGet( "vASIGNATURAID"), ".", ","));
               AV11AsignaturaNombre = cgiGet( "vASIGNATURANOMBRE");
               AV12Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Asignatura";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A10AsignaturaId != Z10AsignaturaId ) || ( StringUtil.StrCmp(A11AsignaturaNombre, Z11AsignaturaNombre) != 0 ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("asignatura:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A10AsignaturaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10AsignaturaId), 4, 0)));
                  A11AsignaturaNombre = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11AsignaturaNombre", A11AsignaturaNombre);
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
                     sMode10 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode10;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound10 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_050( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "ASIGNATURAID");
                        AnyError = 1;
                        GX_FocusControl = edtAsignaturaId_Internalname;
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
                           E11052 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12052 ();
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
            E12052 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0510( ) ;
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
            DisableAttributes0510( ) ;
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

      protected void CONFIRM_050( )
      {
         BeforeValidate0510( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0510( ) ;
            }
            else
            {
               CheckExtendedTable0510( ) ;
               CloseExtendedTableCursors0510( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption050( )
      {
      }

      protected void E11052( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV12Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "UniApp");
      }

      protected void E12052( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwasignatura.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0510( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z21AsignaturaSemestre = T00053_A21AsignaturaSemestre[0];
            }
            else
            {
               Z21AsignaturaSemestre = A21AsignaturaSemestre;
            }
         }
         if ( GX_JID == -9 )
         {
            Z10AsignaturaId = A10AsignaturaId;
            Z11AsignaturaNombre = A11AsignaturaNombre;
            Z21AsignaturaSemestre = A21AsignaturaSemestre;
         }
      }

      protected void standaloneNotModal( )
      {
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7AsignaturaId) )
         {
            A10AsignaturaId = AV7AsignaturaId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10AsignaturaId), 4, 0)));
         }
         if ( ! (0==AV7AsignaturaId) )
         {
            edtAsignaturaId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaId_Enabled), 5, 0)), true);
         }
         else
         {
            edtAsignaturaId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaId_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7AsignaturaId) )
         {
            edtAsignaturaId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaId_Enabled), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11AsignaturaNombre)) )
         {
            A11AsignaturaNombre = AV11AsignaturaNombre;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11AsignaturaNombre", A11AsignaturaNombre);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11AsignaturaNombre)) )
         {
            edtAsignaturaNombre_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaNombre_Enabled), 5, 0)), true);
         }
         else
         {
            edtAsignaturaNombre_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaNombre_Enabled), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11AsignaturaNombre)) )
         {
            edtAsignaturaNombre_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaNombre_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
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
            AV12Pgmname = "Asignatura";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
         }
      }

      protected void Load0510( )
      {
         /* Using cursor T00054 */
         pr_default.execute(2, new Object[] {A10AsignaturaId, A11AsignaturaNombre});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound10 = 1;
            A21AsignaturaSemestre = T00054_A21AsignaturaSemestre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21AsignaturaSemestre", context.localUtil.Format(A21AsignaturaSemestre, "99/99/99"));
            ZM0510( -9) ;
         }
         pr_default.close(2);
         OnLoadActions0510( ) ;
      }

      protected void OnLoadActions0510( )
      {
         AV12Pgmname = "Asignatura";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
      }

      protected void CheckExtendedTable0510( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV12Pgmname = "Asignatura";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A11AsignaturaNombre)) )
         {
            GX_msglist.addItem("Debe escribir la asignatura", 1, "ASIGNATURANOMBRE");
            AnyError = 1;
            GX_FocusControl = edtAsignaturaNombre_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A21AsignaturaSemestre) || ( A21AsignaturaSemestre >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Field Asignatura Semestre is out of range", "OutOfRange", 1, "ASIGNATURASEMESTRE");
            AnyError = 1;
            GX_FocusControl = edtAsignaturaSemestre_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0510( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0510( )
      {
         /* Using cursor T00055 */
         pr_default.execute(3, new Object[] {A10AsignaturaId, A11AsignaturaNombre});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound10 = 1;
         }
         else
         {
            RcdFound10 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00053 */
         pr_default.execute(1, new Object[] {A10AsignaturaId, A11AsignaturaNombre});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0510( 9) ;
            RcdFound10 = 1;
            A10AsignaturaId = T00053_A10AsignaturaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10AsignaturaId), 4, 0)));
            A11AsignaturaNombre = T00053_A11AsignaturaNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11AsignaturaNombre", A11AsignaturaNombre);
            A21AsignaturaSemestre = T00053_A21AsignaturaSemestre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21AsignaturaSemestre", context.localUtil.Format(A21AsignaturaSemestre, "99/99/99"));
            Z10AsignaturaId = A10AsignaturaId;
            Z11AsignaturaNombre = A11AsignaturaNombre;
            sMode10 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0510( ) ;
            if ( AnyError == 1 )
            {
               RcdFound10 = 0;
               InitializeNonKey0510( ) ;
            }
            Gx_mode = sMode10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound10 = 0;
            InitializeNonKey0510( ) ;
            sMode10 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0510( ) ;
         if ( RcdFound10 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound10 = 0;
         /* Using cursor T00056 */
         pr_default.execute(4, new Object[] {A10AsignaturaId, A11AsignaturaNombre});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00056_A10AsignaturaId[0] < A10AsignaturaId ) || ( T00056_A10AsignaturaId[0] == A10AsignaturaId ) && ( StringUtil.StrCmp(T00056_A11AsignaturaNombre[0], A11AsignaturaNombre) < 0 ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00056_A10AsignaturaId[0] > A10AsignaturaId ) || ( T00056_A10AsignaturaId[0] == A10AsignaturaId ) && ( StringUtil.StrCmp(T00056_A11AsignaturaNombre[0], A11AsignaturaNombre) > 0 ) ) )
            {
               A10AsignaturaId = T00056_A10AsignaturaId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10AsignaturaId), 4, 0)));
               A11AsignaturaNombre = T00056_A11AsignaturaNombre[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11AsignaturaNombre", A11AsignaturaNombre);
               RcdFound10 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound10 = 0;
         /* Using cursor T00057 */
         pr_default.execute(5, new Object[] {A10AsignaturaId, A11AsignaturaNombre});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00057_A10AsignaturaId[0] > A10AsignaturaId ) || ( T00057_A10AsignaturaId[0] == A10AsignaturaId ) && ( StringUtil.StrCmp(T00057_A11AsignaturaNombre[0], A11AsignaturaNombre) > 0 ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00057_A10AsignaturaId[0] < A10AsignaturaId ) || ( T00057_A10AsignaturaId[0] == A10AsignaturaId ) && ( StringUtil.StrCmp(T00057_A11AsignaturaNombre[0], A11AsignaturaNombre) < 0 ) ) )
            {
               A10AsignaturaId = T00057_A10AsignaturaId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10AsignaturaId), 4, 0)));
               A11AsignaturaNombre = T00057_A11AsignaturaNombre[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11AsignaturaNombre", A11AsignaturaNombre);
               RcdFound10 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0510( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtAsignaturaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0510( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound10 == 1 )
            {
               if ( ( A10AsignaturaId != Z10AsignaturaId ) || ( StringUtil.StrCmp(A11AsignaturaNombre, Z11AsignaturaNombre) != 0 ) )
               {
                  A10AsignaturaId = Z10AsignaturaId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10AsignaturaId), 4, 0)));
                  A11AsignaturaNombre = Z11AsignaturaNombre;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11AsignaturaNombre", A11AsignaturaNombre);
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "ASIGNATURAID");
                  AnyError = 1;
                  GX_FocusControl = edtAsignaturaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtAsignaturaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0510( ) ;
                  GX_FocusControl = edtAsignaturaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A10AsignaturaId != Z10AsignaturaId ) || ( StringUtil.StrCmp(A11AsignaturaNombre, Z11AsignaturaNombre) != 0 ) )
               {
                  /* Insert record */
                  GX_FocusControl = edtAsignaturaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0510( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ASIGNATURAID");
                     AnyError = 1;
                     GX_FocusControl = edtAsignaturaId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtAsignaturaId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0510( ) ;
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
         if ( ( A10AsignaturaId != Z10AsignaturaId ) || ( StringUtil.StrCmp(A11AsignaturaNombre, Z11AsignaturaNombre) != 0 ) )
         {
            A10AsignaturaId = Z10AsignaturaId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10AsignaturaId), 4, 0)));
            A11AsignaturaNombre = Z11AsignaturaNombre;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11AsignaturaNombre", A11AsignaturaNombre);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "ASIGNATURAID");
            AnyError = 1;
            GX_FocusControl = edtAsignaturaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtAsignaturaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0510( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00052 */
            pr_default.execute(0, new Object[] {A10AsignaturaId, A11AsignaturaNombre});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Asignatura"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z21AsignaturaSemestre != T00052_A21AsignaturaSemestre[0] ) )
            {
               if ( Z21AsignaturaSemestre != T00052_A21AsignaturaSemestre[0] )
               {
                  GXUtil.WriteLog("asignatura:[seudo value changed for attri]"+"AsignaturaSemestre");
                  GXUtil.WriteLogRaw("Old: ",Z21AsignaturaSemestre);
                  GXUtil.WriteLogRaw("Current: ",T00052_A21AsignaturaSemestre[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Asignatura"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0510( )
      {
         BeforeValidate0510( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0510( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0510( 0) ;
            CheckOptimisticConcurrency0510( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0510( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0510( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00058 */
                     pr_default.execute(6, new Object[] {A10AsignaturaId, A11AsignaturaNombre, A21AsignaturaSemestre});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Asignatura") ;
                     if ( (pr_default.getStatus(6) == 1) )
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
                           ResetCaption050( ) ;
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
               Load0510( ) ;
            }
            EndLevel0510( ) ;
         }
         CloseExtendedTableCursors0510( ) ;
      }

      protected void Update0510( )
      {
         BeforeValidate0510( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0510( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0510( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0510( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0510( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00059 */
                     pr_default.execute(7, new Object[] {A21AsignaturaSemestre, A10AsignaturaId, A11AsignaturaNombre});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Asignatura") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Asignatura"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0510( ) ;
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
            EndLevel0510( ) ;
         }
         CloseExtendedTableCursors0510( ) ;
      }

      protected void DeferredUpdate0510( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0510( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0510( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0510( ) ;
            AfterConfirm0510( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0510( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000510 */
                  pr_default.execute(8, new Object[] {A10AsignaturaId, A11AsignaturaNombre});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("Asignatura") ;
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
         sMode10 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0510( ) ;
         Gx_mode = sMode10;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0510( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV12Pgmname = "Asignatura";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Pgmname", AV12Pgmname);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000511 */
            pr_default.execute(9, new Object[] {A10AsignaturaId, A11AsignaturaNombre});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Docente"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
            /* Using cursor T000512 */
            pr_default.execute(10, new Object[] {A10AsignaturaId, A11AsignaturaNombre});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Asignatura"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(10);
         }
      }

      protected void EndLevel0510( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0510( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("asignatura",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues050( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("asignatura",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0510( )
      {
         /* Scan By routine */
         /* Using cursor T000513 */
         pr_default.execute(11);
         RcdFound10 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound10 = 1;
            A10AsignaturaId = T000513_A10AsignaturaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10AsignaturaId), 4, 0)));
            A11AsignaturaNombre = T000513_A11AsignaturaNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11AsignaturaNombre", A11AsignaturaNombre);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0510( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound10 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound10 = 1;
            A10AsignaturaId = T000513_A10AsignaturaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10AsignaturaId), 4, 0)));
            A11AsignaturaNombre = T000513_A11AsignaturaNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11AsignaturaNombre", A11AsignaturaNombre);
         }
      }

      protected void ScanEnd0510( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm0510( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0510( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0510( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0510( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0510( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0510( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0510( )
      {
         edtAsignaturaId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaId_Enabled), 5, 0)), true);
         edtAsignaturaNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaNombre_Enabled), 5, 0)), true);
         edtAsignaturaSemestre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaSemestre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaSemestre_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0510( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues050( )
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
         context.AddJavascriptSource("gxcfg.js", "?2020101711153110", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("calendar-en.js", "?"+context.GetBuildNumber( 129648), false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("asignatura.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7AsignaturaId) + "," + UrlEncode(StringUtil.RTrim(AV11AsignaturaNombre))+"\">") ;
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
         forbiddenHiddens = "hsh" + "Asignatura";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("asignatura:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z10AsignaturaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10AsignaturaId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z11AsignaturaNombre", StringUtil.RTrim( Z11AsignaturaNombre));
         GxWebStd.gx_hidden_field( context, "Z21AsignaturaSemestre", context.localUtil.DToC( Z21AsignaturaSemestre, 0, "/"));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vASIGNATURAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7AsignaturaId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vASIGNATURAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7AsignaturaId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vASIGNATURANOMBRE", StringUtil.RTrim( AV11AsignaturaNombre));
         GxWebStd.gx_hidden_field( context, "gxhash_vASIGNATURANOMBRE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV11AsignaturaNombre, "")), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV12Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
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
         return formatLink("asignatura.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7AsignaturaId) + "," + UrlEncode(StringUtil.RTrim(AV11AsignaturaNombre)) ;
      }

      public override String GetPgmname( )
      {
         return "Asignatura" ;
      }

      public override String GetPgmdesc( )
      {
         return "Asignatura" ;
      }

      protected void InitializeNonKey0510( )
      {
         A21AsignaturaSemestre = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21AsignaturaSemestre", context.localUtil.Format(A21AsignaturaSemestre, "99/99/99"));
         Z21AsignaturaSemestre = DateTime.MinValue;
      }

      protected void InitAll0510( )
      {
         A10AsignaturaId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10AsignaturaId), 4, 0)));
         A11AsignaturaNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11AsignaturaNombre", A11AsignaturaNombre);
         InitializeNonKey0510( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020101711153118", true, true);
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
         context.AddJavascriptSource("asignatura.js", "?2020101711153118", false, true);
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
         edtAsignaturaId_Internalname = "ASIGNATURAID";
         edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE";
         edtAsignaturaSemestre_Internalname = "ASIGNATURASEMESTRE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
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
         Form.Caption = "Asignatura";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtAsignaturaSemestre_Jsonclick = "";
         edtAsignaturaSemestre_Enabled = 1;
         edtAsignaturaNombre_Jsonclick = "";
         edtAsignaturaNombre_Enabled = 1;
         edtAsignaturaId_Jsonclick = "";
         edtAsignaturaId_Enabled = 1;
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

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7AsignaturaId',fld:'vASIGNATURAID',pic:'ZZZ9',hsh:true},{av:'AV11AsignaturaNombre',fld:'vASIGNATURANOMBRE',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7AsignaturaId',fld:'vASIGNATURAID',pic:'ZZZ9',hsh:true},{av:'AV11AsignaturaNombre',fld:'vASIGNATURANOMBRE',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12052',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         wcpOAV11AsignaturaNombre = "";
         Z11AsignaturaNombre = "";
         Z21AsignaturaSemestre = DateTime.MinValue;
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
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
         A11AsignaturaNombre = "";
         A21AsignaturaSemestre = DateTime.MinValue;
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV12Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode10 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         T00054_A10AsignaturaId = new short[1] ;
         T00054_A11AsignaturaNombre = new String[] {""} ;
         T00054_A21AsignaturaSemestre = new DateTime[] {DateTime.MinValue} ;
         T00055_A10AsignaturaId = new short[1] ;
         T00055_A11AsignaturaNombre = new String[] {""} ;
         T00053_A10AsignaturaId = new short[1] ;
         T00053_A11AsignaturaNombre = new String[] {""} ;
         T00053_A21AsignaturaSemestre = new DateTime[] {DateTime.MinValue} ;
         T00056_A10AsignaturaId = new short[1] ;
         T00056_A11AsignaturaNombre = new String[] {""} ;
         T00057_A10AsignaturaId = new short[1] ;
         T00057_A11AsignaturaNombre = new String[] {""} ;
         T00052_A10AsignaturaId = new short[1] ;
         T00052_A11AsignaturaNombre = new String[] {""} ;
         T00052_A21AsignaturaSemestre = new DateTime[] {DateTime.MinValue} ;
         T000511_A12DocenteId = new short[1] ;
         T000512_A8CarreraId = new short[1] ;
         T000512_A10AsignaturaId = new short[1] ;
         T000513_A10AsignaturaId = new short[1] ;
         T000513_A11AsignaturaNombre = new String[] {""} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.asignatura__default(),
            new Object[][] {
                new Object[] {
               T00052_A10AsignaturaId, T00052_A11AsignaturaNombre, T00052_A21AsignaturaSemestre
               }
               , new Object[] {
               T00053_A10AsignaturaId, T00053_A11AsignaturaNombre, T00053_A21AsignaturaSemestre
               }
               , new Object[] {
               T00054_A10AsignaturaId, T00054_A11AsignaturaNombre, T00054_A21AsignaturaSemestre
               }
               , new Object[] {
               T00055_A10AsignaturaId, T00055_A11AsignaturaNombre
               }
               , new Object[] {
               T00056_A10AsignaturaId, T00056_A11AsignaturaNombre
               }
               , new Object[] {
               T00057_A10AsignaturaId, T00057_A11AsignaturaNombre
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000511_A12DocenteId
               }
               , new Object[] {
               T000512_A8CarreraId, T000512_A10AsignaturaId
               }
               , new Object[] {
               T000513_A10AsignaturaId, T000513_A11AsignaturaNombre
               }
            }
         );
         AV12Pgmname = "Asignatura";
      }

      private short wcpOAV7AsignaturaId ;
      private short Z10AsignaturaId ;
      private short GxWebError ;
      private short AV7AsignaturaId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A10AsignaturaId ;
      private short RcdFound10 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtAsignaturaId_Enabled ;
      private int edtAsignaturaNombre_Enabled ;
      private int edtAsignaturaSemestre_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV11AsignaturaNombre ;
      private String Z11AsignaturaNombre ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String AV11AsignaturaNombre ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtAsignaturaId_Internalname ;
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
      private String edtAsignaturaId_Jsonclick ;
      private String edtAsignaturaNombre_Internalname ;
      private String A11AsignaturaNombre ;
      private String edtAsignaturaNombre_Jsonclick ;
      private String edtAsignaturaSemestre_Internalname ;
      private String edtAsignaturaSemestre_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV12Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode10 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z21AsignaturaSemestre ;
      private DateTime A21AsignaturaSemestre ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool returnInSub ;
      private IGxSession AV10WebSession ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00054_A10AsignaturaId ;
      private String[] T00054_A11AsignaturaNombre ;
      private DateTime[] T00054_A21AsignaturaSemestre ;
      private short[] T00055_A10AsignaturaId ;
      private String[] T00055_A11AsignaturaNombre ;
      private short[] T00053_A10AsignaturaId ;
      private String[] T00053_A11AsignaturaNombre ;
      private DateTime[] T00053_A21AsignaturaSemestre ;
      private short[] T00056_A10AsignaturaId ;
      private String[] T00056_A11AsignaturaNombre ;
      private short[] T00057_A10AsignaturaId ;
      private String[] T00057_A11AsignaturaNombre ;
      private short[] T00052_A10AsignaturaId ;
      private String[] T00052_A11AsignaturaNombre ;
      private DateTime[] T00052_A21AsignaturaSemestre ;
      private short[] T000511_A12DocenteId ;
      private short[] T000512_A8CarreraId ;
      private short[] T000512_A10AsignaturaId ;
      private short[] T000513_A10AsignaturaId ;
      private String[] T000513_A11AsignaturaNombre ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class asignatura__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00054 ;
          prmT00054 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT00055 ;
          prmT00055 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT00053 ;
          prmT00053 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT00056 ;
          prmT00056 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT00057 ;
          prmT00057 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT00052 ;
          prmT00052 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT00058 ;
          prmT00058 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@AsignaturaSemestre",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmT00059 ;
          prmT00059 = new Object[] {
          new Object[] {"@AsignaturaSemestre",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT000510 ;
          prmT000510 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT000511 ;
          prmT000511 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT000512 ;
          prmT000512 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT000513 ;
          prmT000513 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00052", "SELECT [AsignaturaId], [AsignaturaNombre], [AsignaturaSemestre] FROM [Asignatura] WITH (UPDLOCK) WHERE [AsignaturaId] = @AsignaturaId AND [AsignaturaNombre] = @AsignaturaNombre ",true, GxErrorMask.GX_NOMASK, false, this,prmT00052,1,0,true,false )
             ,new CursorDef("T00053", "SELECT [AsignaturaId], [AsignaturaNombre], [AsignaturaSemestre] FROM [Asignatura] WITH (NOLOCK) WHERE [AsignaturaId] = @AsignaturaId AND [AsignaturaNombre] = @AsignaturaNombre ",true, GxErrorMask.GX_NOMASK, false, this,prmT00053,1,0,true,false )
             ,new CursorDef("T00054", "SELECT TM1.[AsignaturaId], TM1.[AsignaturaNombre], TM1.[AsignaturaSemestre] FROM [Asignatura] TM1 WITH (NOLOCK) WHERE TM1.[AsignaturaId] = @AsignaturaId and TM1.[AsignaturaNombre] = @AsignaturaNombre ORDER BY TM1.[AsignaturaId], TM1.[AsignaturaNombre]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00054,100,0,true,false )
             ,new CursorDef("T00055", "SELECT [AsignaturaId], [AsignaturaNombre] FROM [Asignatura] WITH (NOLOCK) WHERE [AsignaturaId] = @AsignaturaId AND [AsignaturaNombre] = @AsignaturaNombre  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00055,1,0,true,false )
             ,new CursorDef("T00056", "SELECT TOP 1 [AsignaturaId], [AsignaturaNombre] FROM [Asignatura] WITH (NOLOCK) WHERE ( [AsignaturaId] > @AsignaturaId or [AsignaturaId] = @AsignaturaId and [AsignaturaNombre] > @AsignaturaNombre) ORDER BY [AsignaturaId], [AsignaturaNombre]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00056,1,0,true,true )
             ,new CursorDef("T00057", "SELECT TOP 1 [AsignaturaId], [AsignaturaNombre] FROM [Asignatura] WITH (NOLOCK) WHERE ( [AsignaturaId] < @AsignaturaId or [AsignaturaId] = @AsignaturaId and [AsignaturaNombre] < @AsignaturaNombre) ORDER BY [AsignaturaId] DESC, [AsignaturaNombre] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00057,1,0,true,true )
             ,new CursorDef("T00058", "INSERT INTO [Asignatura]([AsignaturaId], [AsignaturaNombre], [AsignaturaSemestre]) VALUES(@AsignaturaId, @AsignaturaNombre, @AsignaturaSemestre)", GxErrorMask.GX_NOMASK,prmT00058)
             ,new CursorDef("T00059", "UPDATE [Asignatura] SET [AsignaturaSemestre]=@AsignaturaSemestre  WHERE [AsignaturaId] = @AsignaturaId AND [AsignaturaNombre] = @AsignaturaNombre", GxErrorMask.GX_NOMASK,prmT00059)
             ,new CursorDef("T000510", "DELETE FROM [Asignatura]  WHERE [AsignaturaId] = @AsignaturaId AND [AsignaturaNombre] = @AsignaturaNombre", GxErrorMask.GX_NOMASK,prmT000510)
             ,new CursorDef("T000511", "SELECT TOP 1 [DocenteId] FROM [Docente] WITH (NOLOCK) WHERE [AsignaturaId] = @AsignaturaId AND [AsignaturaNombre] = @AsignaturaNombre ",true, GxErrorMask.GX_NOMASK, false, this,prmT000511,1,0,true,true )
             ,new CursorDef("T000512", "SELECT TOP 1 [CarreraId], [AsignaturaId] FROM [CarreraAsignatura] WITH (NOLOCK) WHERE [AsignaturaId] = @AsignaturaId AND [AsignaturaNombre] = @AsignaturaNombre ",true, GxErrorMask.GX_NOMASK, false, this,prmT000512,1,0,true,true )
             ,new CursorDef("T000513", "SELECT [AsignaturaId], [AsignaturaNombre] FROM [Asignatura] WITH (NOLOCK) ORDER BY [AsignaturaId], [AsignaturaNombre]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000513,100,0,true,false )
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
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                return;
             case 7 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
       }
    }

 }

}
