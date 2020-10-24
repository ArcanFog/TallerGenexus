/*
               File: Carrera
        Description: Carrera
             Author: GeneXus C# Generator version 16_0_1-129648
       Generated on: 10/17/2020 11:15:43.4
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
   public class carrera : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_6") == 0 )
         {
            A10AsignaturaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            A11AsignaturaNombre = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_6( A10AsignaturaId, A11AsignaturaNombre) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridcarrera_asignatura") == 0 )
         {
            nRC_GXsfl_48 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_48_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_48_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridcarrera_asignatura_newrow( ) ;
            return  ;
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
               AV7CarreraId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7CarreraId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCARRERAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7CarreraId), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Carrera", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtCarreraNombre_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public carrera( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public carrera( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_CarreraId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7CarreraId = aP1_CarreraId;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Carrera", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Carrera.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Carrera.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Carrera.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Carrera.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Carrera.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Carrera.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCarreraId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCarreraId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtCarreraId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8CarreraId), 4, 0, ".", "")), ((edtCarreraId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A8CarreraId), "ZZZ9")) : context.localUtil.Format( (decimal)(A8CarreraId), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCarreraId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCarreraId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Carrera.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCarreraNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCarreraNombre_Internalname, "Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtCarreraNombre_Internalname, StringUtil.RTrim( A9CarreraNombre), StringUtil.RTrim( context.localUtil.Format( A9CarreraNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCarreraNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCarreraNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Carrera.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAsignaturatable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitleasignatura_Internalname, "Asignatura", "", "", lblTitleasignatura_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Carrera.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridcarrera_asignatura( ) ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Carrera.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Carrera.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Carrera.htm");
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

      protected void gxdraw_Gridcarrera_asignatura( )
      {
         /*  Grid Control  */
         Gridcarrera_asignaturaContainer.AddObjectProperty("GridName", "Gridcarrera_asignatura");
         Gridcarrera_asignaturaContainer.AddObjectProperty("Header", subGridcarrera_asignatura_Header);
         Gridcarrera_asignaturaContainer.AddObjectProperty("Class", "Grid");
         Gridcarrera_asignaturaContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridcarrera_asignaturaContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridcarrera_asignaturaContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcarrera_asignatura_Backcolorstyle), 1, 0, ".", "")));
         Gridcarrera_asignaturaContainer.AddObjectProperty("CmpContext", "");
         Gridcarrera_asignaturaContainer.AddObjectProperty("InMasterPage", "false");
         Gridcarrera_asignaturaColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcarrera_asignaturaColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10AsignaturaId), 4, 0, ".", "")));
         Gridcarrera_asignaturaColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaId_Enabled), 5, 0, ".", "")));
         Gridcarrera_asignaturaContainer.AddColumnProperties(Gridcarrera_asignaturaColumn);
         Gridcarrera_asignaturaColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcarrera_asignaturaColumn.AddObjectProperty("Value", StringUtil.RTrim( A11AsignaturaNombre));
         Gridcarrera_asignaturaColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaNombre_Enabled), 5, 0, ".", "")));
         Gridcarrera_asignaturaContainer.AddColumnProperties(Gridcarrera_asignaturaColumn);
         Gridcarrera_asignaturaColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcarrera_asignaturaContainer.AddColumnProperties(Gridcarrera_asignaturaColumn);
         Gridcarrera_asignaturaColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcarrera_asignaturaColumn.AddObjectProperty("Value", context.localUtil.Format(A21AsignaturaSemestre, "99/99/99"));
         Gridcarrera_asignaturaColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaSemestre_Enabled), 5, 0, ".", "")));
         Gridcarrera_asignaturaContainer.AddColumnProperties(Gridcarrera_asignaturaColumn);
         Gridcarrera_asignaturaContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcarrera_asignatura_Selectedindex), 4, 0, ".", "")));
         Gridcarrera_asignaturaContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcarrera_asignatura_Allowselection), 1, 0, ".", "")));
         Gridcarrera_asignaturaContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcarrera_asignatura_Selectioncolor), 9, 0, ".", "")));
         Gridcarrera_asignaturaContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcarrera_asignatura_Allowhovering), 1, 0, ".", "")));
         Gridcarrera_asignaturaContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcarrera_asignatura_Hoveringcolor), 9, 0, ".", "")));
         Gridcarrera_asignaturaContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcarrera_asignatura_Allowcollapsing), 1, 0, ".", "")));
         Gridcarrera_asignaturaContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcarrera_asignatura_Collapsed), 1, 0, ".", "")));
         nGXsfl_48_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount8 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_8 = 1;
               ScanStart048( ) ;
               while ( RcdFound8 != 0 )
               {
                  init_level_properties8( ) ;
                  getByPrimaryKey048( ) ;
                  AddRow048( ) ;
                  ScanNext048( ) ;
               }
               ScanEnd048( ) ;
               nBlankRcdCount8 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal048( ) ;
            standaloneModal048( ) ;
            sMode8 = Gx_mode;
            while ( nGXsfl_48_idx < nRC_GXsfl_48 )
            {
               bGXsfl_48_Refreshing = true;
               ReadRow048( ) ;
               edtAsignaturaId_Enabled = (int)(context.localUtil.CToN( cgiGet( "ASIGNATURAID_"+sGXsfl_48_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaId_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
               edtAsignaturaNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "ASIGNATURANOMBRE_"+sGXsfl_48_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaNombre_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
               edtAsignaturaSemestre_Enabled = (int)(context.localUtil.CToN( cgiGet( "ASIGNATURASEMESTRE_"+sGXsfl_48_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaSemestre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaSemestre_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
               imgprompt_10_11_Link = cgiGet( "PROMPT_10_11_"+sGXsfl_48_idx+"Link");
               if ( ( nRcdExists_8 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal048( ) ;
               }
               SendRow048( ) ;
               bGXsfl_48_Refreshing = false;
            }
            Gx_mode = sMode8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount8 = 5;
            nRcdExists_8 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart048( ) ;
               while ( RcdFound8 != 0 )
               {
                  sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_48_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_488( ) ;
                  init_level_properties8( ) ;
                  standaloneNotModal048( ) ;
                  getByPrimaryKey048( ) ;
                  standaloneModal048( ) ;
                  AddRow048( ) ;
                  ScanNext048( ) ;
               }
               ScanEnd048( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode8 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_48_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_488( ) ;
            InitAll048( ) ;
            init_level_properties8( ) ;
            standaloneNotModal048( ) ;
            standaloneModal048( ) ;
            nRcdExists_8 = 0;
            nIsMod_8 = 0;
            nRcdDeleted_8 = 0;
            nBlankRcdCount8 = (short)(nBlankRcdUsr8+nBlankRcdCount8);
            fRowAdded = 0;
            while ( nBlankRcdCount8 > 0 )
            {
               AddRow048( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtAsignaturaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount8 = (short)(nBlankRcdCount8-1);
            }
            Gx_mode = sMode8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridcarrera_asignaturaContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridcarrera_asignatura", Gridcarrera_asignaturaContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridcarrera_asignaturaContainerData", Gridcarrera_asignaturaContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridcarrera_asignaturaContainerData"+"V", Gridcarrera_asignaturaContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridcarrera_asignaturaContainerData"+"V"+"\" value='"+Gridcarrera_asignaturaContainer.GridValuesHidden()+"'/>") ;
         }
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
         E11042 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A8CarreraId = (short)(context.localUtil.CToN( cgiGet( edtCarreraId_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
               A9CarreraNombre = cgiGet( edtCarreraNombre_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CarreraNombre", A9CarreraNombre);
               /* Read saved values. */
               Z8CarreraId = (short)(context.localUtil.CToN( cgiGet( "Z8CarreraId"), ".", ","));
               Z9CarreraNombre = cgiGet( "Z9CarreraNombre");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_48 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_48"), ".", ","));
               AV7CarreraId = (short)(context.localUtil.CToN( cgiGet( "vCARRERAID"), ".", ","));
               AV11Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Carrera";
               A8CarreraId = (short)(context.localUtil.CToN( cgiGet( edtCarreraId_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A8CarreraId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A8CarreraId != Z8CarreraId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("carrera:[SecurityCheckFailed value for]"+"CarreraId:"+context.localUtil.Format( (decimal)(A8CarreraId), "ZZZ9"));
                  GXUtil.WriteLog("carrera:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
               /* Check if conditions changed and reset current page numbers */
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
                  A8CarreraId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
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
                     sMode2 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode2;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound2 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_040( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "CARRERAID");
                        AnyError = 1;
                        GX_FocusControl = edtCarreraId_Internalname;
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
                           E11042 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12042 ();
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
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
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
            E12042 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll042( ) ;
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
            DisableAttributes042( ) ;
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

      protected void CONFIRM_040( )
      {
         BeforeValidate042( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls042( ) ;
            }
            else
            {
               CheckExtendedTable042( ) ;
               CloseExtendedTableCursors042( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode2 = Gx_mode;
            CONFIRM_048( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode2;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_048( )
      {
         nGXsfl_48_idx = 0;
         while ( nGXsfl_48_idx < nRC_GXsfl_48 )
         {
            ReadRow048( ) ;
            if ( ( nRcdExists_8 != 0 ) || ( nIsMod_8 != 0 ) )
            {
               GetKey048( ) ;
               if ( ( nRcdExists_8 == 0 ) && ( nRcdDeleted_8 == 0 ) )
               {
                  if ( RcdFound8 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate048( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable048( ) ;
                        CloseExtendedTableCursors048( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "ASIGNATURAID_" + sGXsfl_48_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtAsignaturaId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound8 != 0 )
                  {
                     if ( nRcdDeleted_8 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey048( ) ;
                        Load048( ) ;
                        BeforeValidate048( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls048( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_8 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate048( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable048( ) ;
                              CloseExtendedTableCursors048( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_8 == 0 )
                     {
                        GXCCtl = "ASIGNATURAID_" + sGXsfl_48_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtAsignaturaId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtAsignaturaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10AsignaturaId), 4, 0, ".", ""))) ;
            ChangePostValue( edtAsignaturaNombre_Internalname, StringUtil.RTrim( A11AsignaturaNombre)) ;
            ChangePostValue( edtAsignaturaSemestre_Internalname, context.localUtil.Format(A21AsignaturaSemestre, "99/99/99")) ;
            ChangePostValue( "ZT_"+"Z10AsignaturaId_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10AsignaturaId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z11AsignaturaNombre_"+sGXsfl_48_idx, StringUtil.RTrim( Z11AsignaturaNombre)) ;
            ChangePostValue( "nRcdDeleted_8_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_8), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_8_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_8), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_8_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_8), 4, 0, ".", ""))) ;
            if ( nIsMod_8 != 0 )
            {
               ChangePostValue( "ASIGNATURAID_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ASIGNATURANOMBRE_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ASIGNATURASEMESTRE_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaSemestre_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption040( )
      {
      }

      protected void E11042( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV11Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "UniApp");
      }

      protected void E12042( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwcarrera.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         pr_default.close(4);
         returnInSub = true;
         if (true) return;
      }

      protected void ZM042( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z9CarreraNombre = T00046_A9CarreraNombre[0];
            }
            else
            {
               Z9CarreraNombre = A9CarreraNombre;
            }
         }
         if ( GX_JID == -4 )
         {
            Z8CarreraId = A8CarreraId;
            Z9CarreraNombre = A9CarreraNombre;
         }
      }

      protected void standaloneNotModal( )
      {
         edtCarreraId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarreraId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarreraId_Enabled), 5, 0)), true);
         edtCarreraId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarreraId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarreraId_Enabled), 5, 0)), true);
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7CarreraId) )
         {
            A8CarreraId = AV7CarreraId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
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
      }

      protected void Load042( )
      {
         /* Using cursor T00047 */
         pr_default.execute(5, new Object[] {A8CarreraId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound2 = 1;
            A9CarreraNombre = T00047_A9CarreraNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CarreraNombre", A9CarreraNombre);
            ZM042( -4) ;
         }
         pr_default.close(5);
         OnLoadActions042( ) ;
      }

      protected void OnLoadActions042( )
      {
         AV11Pgmname = "Carrera";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CheckExtendedTable042( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV11Pgmname = "Carrera";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A9CarreraNombre)) )
         {
            GX_msglist.addItem("Debe escribir la carrera", 1, "CARRERANOMBRE");
            AnyError = 1;
            GX_FocusControl = edtCarreraNombre_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors042( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey042( )
      {
         /* Using cursor T00048 */
         pr_default.execute(6, new Object[] {A8CarreraId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound2 = 1;
         }
         else
         {
            RcdFound2 = 0;
         }
         pr_default.close(6);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00046 */
         pr_default.execute(4, new Object[] {A8CarreraId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM042( 4) ;
            RcdFound2 = 1;
            A8CarreraId = T00046_A8CarreraId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
            A9CarreraNombre = T00046_A9CarreraNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CarreraNombre", A9CarreraNombre);
            Z8CarreraId = A8CarreraId;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load042( ) ;
            if ( AnyError == 1 )
            {
               RcdFound2 = 0;
               InitializeNonKey042( ) ;
            }
            Gx_mode = sMode2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound2 = 0;
            InitializeNonKey042( ) ;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey042( ) ;
         if ( RcdFound2 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound2 = 0;
         /* Using cursor T00049 */
         pr_default.execute(7, new Object[] {A8CarreraId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00049_A8CarreraId[0] < A8CarreraId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00049_A8CarreraId[0] > A8CarreraId ) ) )
            {
               A8CarreraId = T00049_A8CarreraId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
               RcdFound2 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void move_previous( )
      {
         RcdFound2 = 0;
         /* Using cursor T000410 */
         pr_default.execute(8, new Object[] {A8CarreraId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000410_A8CarreraId[0] > A8CarreraId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000410_A8CarreraId[0] < A8CarreraId ) ) )
            {
               A8CarreraId = T000410_A8CarreraId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
               RcdFound2 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey042( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtCarreraNombre_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert042( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound2 == 1 )
            {
               if ( A8CarreraId != Z8CarreraId )
               {
                  A8CarreraId = Z8CarreraId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "CARRERAID");
                  AnyError = 1;
                  GX_FocusControl = edtCarreraId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtCarreraNombre_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update042( ) ;
                  GX_FocusControl = edtCarreraNombre_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A8CarreraId != Z8CarreraId )
               {
                  /* Insert record */
                  GX_FocusControl = edtCarreraNombre_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert042( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "CARRERAID");
                     AnyError = 1;
                     GX_FocusControl = edtCarreraId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtCarreraNombre_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert042( ) ;
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
         if ( A8CarreraId != Z8CarreraId )
         {
            A8CarreraId = Z8CarreraId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "CARRERAID");
            AnyError = 1;
            GX_FocusControl = edtCarreraId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtCarreraNombre_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency042( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00045 */
            pr_default.execute(3, new Object[] {A8CarreraId});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Carrera"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) || ( StringUtil.StrCmp(Z9CarreraNombre, T00045_A9CarreraNombre[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z9CarreraNombre, T00045_A9CarreraNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("carrera:[seudo value changed for attri]"+"CarreraNombre");
                  GXUtil.WriteLogRaw("Old: ",Z9CarreraNombre);
                  GXUtil.WriteLogRaw("Current: ",T00045_A9CarreraNombre[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Carrera"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert042( )
      {
         BeforeValidate042( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable042( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM042( 0) ;
            CheckOptimisticConcurrency042( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm042( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert042( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000411 */
                     pr_default.execute(9, new Object[] {A9CarreraNombre});
                     A8CarreraId = T000411_A8CarreraId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Carrera") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel042( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption040( ) ;
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
            else
            {
               Load042( ) ;
            }
            EndLevel042( ) ;
         }
         CloseExtendedTableCursors042( ) ;
      }

      protected void Update042( )
      {
         BeforeValidate042( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable042( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency042( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm042( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate042( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000412 */
                     pr_default.execute(10, new Object[] {A9CarreraNombre, A8CarreraId});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Carrera") ;
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Carrera"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate042( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel042( ) ;
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
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel042( ) ;
         }
         CloseExtendedTableCursors042( ) ;
      }

      protected void DeferredUpdate042( )
      {
      }

      protected void delete( )
      {
         BeforeValidate042( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency042( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls042( ) ;
            AfterConfirm042( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete042( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart048( ) ;
                  while ( RcdFound8 != 0 )
                  {
                     getByPrimaryKey048( ) ;
                     Delete048( ) ;
                     ScanNext048( ) ;
                  }
                  ScanEnd048( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000413 */
                     pr_default.execute(11, new Object[] {A8CarreraId});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("Carrera") ;
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
         }
         sMode2 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel042( ) ;
         Gx_mode = sMode2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls042( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV11Pgmname = "Carrera";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000414 */
            pr_default.execute(12, new Object[] {A8CarreraId});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Examen"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
            /* Using cursor T000415 */
            pr_default.execute(13, new Object[] {A8CarreraId});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Estudiante"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(13);
            /* Using cursor T000416 */
            pr_default.execute(14, new Object[] {A8CarreraId});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Examen"+" ("+"Examen Carr Asig"+")"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(14);
         }
      }

      protected void ProcessNestedLevel048( )
      {
         nGXsfl_48_idx = 0;
         while ( nGXsfl_48_idx < nRC_GXsfl_48 )
         {
            ReadRow048( ) ;
            if ( ( nRcdExists_8 != 0 ) || ( nIsMod_8 != 0 ) )
            {
               standaloneNotModal048( ) ;
               GetKey048( ) ;
               if ( ( nRcdExists_8 == 0 ) && ( nRcdDeleted_8 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert048( ) ;
               }
               else
               {
                  if ( RcdFound8 != 0 )
                  {
                     if ( ( nRcdDeleted_8 != 0 ) && ( nRcdExists_8 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete048( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_8 != 0 ) && ( nRcdExists_8 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update048( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_8 == 0 )
                     {
                        GXCCtl = "ASIGNATURAID_" + sGXsfl_48_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtAsignaturaId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtAsignaturaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10AsignaturaId), 4, 0, ".", ""))) ;
            ChangePostValue( edtAsignaturaNombre_Internalname, StringUtil.RTrim( A11AsignaturaNombre)) ;
            ChangePostValue( edtAsignaturaSemestre_Internalname, context.localUtil.Format(A21AsignaturaSemestre, "99/99/99")) ;
            ChangePostValue( "ZT_"+"Z10AsignaturaId_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10AsignaturaId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z11AsignaturaNombre_"+sGXsfl_48_idx, StringUtil.RTrim( Z11AsignaturaNombre)) ;
            ChangePostValue( "nRcdDeleted_8_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_8), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_8_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_8), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_8_"+sGXsfl_48_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_8), 4, 0, ".", ""))) ;
            if ( nIsMod_8 != 0 )
            {
               ChangePostValue( "ASIGNATURAID_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ASIGNATURANOMBRE_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ASIGNATURASEMESTRE_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaSemestre_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll048( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_8 = 0;
         nIsMod_8 = 0;
         nRcdDeleted_8 = 0;
      }

      protected void ProcessLevel042( )
      {
         /* Save parent mode. */
         sMode2 = Gx_mode;
         ProcessNestedLevel048( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
      }

      protected void EndLevel042( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(3);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete042( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.CommitDataStores("carrera",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues040( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.RollbackDataStores("carrera",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart042( )
      {
         /* Scan By routine */
         /* Using cursor T000417 */
         pr_default.execute(15);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound2 = 1;
            A8CarreraId = T000417_A8CarreraId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext042( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound2 = 1;
            A8CarreraId = T000417_A8CarreraId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
         }
      }

      protected void ScanEnd042( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm042( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert042( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate042( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete042( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete042( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate042( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes042( )
      {
         edtCarreraId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarreraId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarreraId_Enabled), 5, 0)), true);
         edtCarreraNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarreraNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarreraNombre_Enabled), 5, 0)), true);
      }

      protected void ZM048( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z11AsignaturaNombre = T00043_A11AsignaturaNombre[0];
            }
            else
            {
               Z11AsignaturaNombre = A11AsignaturaNombre;
            }
         }
         if ( GX_JID == -5 )
         {
            Z8CarreraId = A8CarreraId;
            Z10AsignaturaId = A10AsignaturaId;
            Z11AsignaturaNombre = A11AsignaturaNombre;
            Z21AsignaturaSemestre = A21AsignaturaSemestre;
         }
      }

      protected void standaloneNotModal048( )
      {
      }

      protected void standaloneModal048( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtAsignaturaId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaId_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         }
         else
         {
            edtAsignaturaId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaId_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         }
      }

      protected void Load048( )
      {
         /* Using cursor T000418 */
         pr_default.execute(16, new Object[] {A8CarreraId, A10AsignaturaId});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound8 = 1;
            A21AsignaturaSemestre = T000418_A21AsignaturaSemestre[0];
            A11AsignaturaNombre = T000418_A11AsignaturaNombre[0];
            ZM048( -5) ;
         }
         pr_default.close(16);
         OnLoadActions048( ) ;
      }

      protected void OnLoadActions048( )
      {
      }

      protected void CheckExtendedTable048( )
      {
         Gx_BScreen = 1;
         standaloneModal048( ) ;
         /* Using cursor T00044 */
         pr_default.execute(2, new Object[] {A10AsignaturaId, A11AsignaturaNombre});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "ASIGNATURAID_" + sGXsfl_48_idx;
            GX_msglist.addItem("No matching 'Asignatura'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtAsignaturaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A21AsignaturaSemestre = T00044_A21AsignaturaSemestre[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors048( )
      {
         pr_default.close(2);
      }

      protected void enableDisable048( )
      {
      }

      protected void gxLoad_6( short A10AsignaturaId ,
                               String A11AsignaturaNombre )
      {
         /* Using cursor T000419 */
         pr_default.execute(17, new Object[] {A10AsignaturaId, A11AsignaturaNombre});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GXCCtl = "ASIGNATURAID_" + sGXsfl_48_idx;
            GX_msglist.addItem("No matching 'Asignatura'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtAsignaturaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A21AsignaturaSemestre = T000419_A21AsignaturaSemestre[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( context.localUtil.Format(A21AsignaturaSemestre, "99/99/99"))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(17) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(17);
      }

      protected void GetKey048( )
      {
         /* Using cursor T000420 */
         pr_default.execute(18, new Object[] {A8CarreraId, A10AsignaturaId});
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound8 = 1;
         }
         else
         {
            RcdFound8 = 0;
         }
         pr_default.close(18);
      }

      protected void getByPrimaryKey048( )
      {
         /* Using cursor T00043 */
         pr_default.execute(1, new Object[] {A8CarreraId, A10AsignaturaId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM048( 5) ;
            RcdFound8 = 1;
            InitializeNonKey048( ) ;
            A10AsignaturaId = T00043_A10AsignaturaId[0];
            A11AsignaturaNombre = T00043_A11AsignaturaNombre[0];
            Z8CarreraId = A8CarreraId;
            Z10AsignaturaId = A10AsignaturaId;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load048( ) ;
            Gx_mode = sMode8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound8 = 0;
            InitializeNonKey048( ) ;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal048( ) ;
            Gx_mode = sMode8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes048( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency048( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00042 */
            pr_default.execute(0, new Object[] {A8CarreraId, A10AsignaturaId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CarreraAsignatura"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z11AsignaturaNombre, T00042_A11AsignaturaNombre[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z11AsignaturaNombre, T00042_A11AsignaturaNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("carrera:[seudo value changed for attri]"+"AsignaturaNombre");
                  GXUtil.WriteLogRaw("Old: ",Z11AsignaturaNombre);
                  GXUtil.WriteLogRaw("Current: ",T00042_A11AsignaturaNombre[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CarreraAsignatura"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert048( )
      {
         BeforeValidate048( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable048( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM048( 0) ;
            CheckOptimisticConcurrency048( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm048( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert048( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000421 */
                     pr_default.execute(19, new Object[] {A8CarreraId, A10AsignaturaId, A11AsignaturaNombre});
                     pr_default.close(19);
                     dsDefault.SmartCacheProvider.SetUpdated("CarreraAsignatura") ;
                     if ( (pr_default.getStatus(19) == 1) )
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
               Load048( ) ;
            }
            EndLevel048( ) ;
         }
         CloseExtendedTableCursors048( ) ;
      }

      protected void Update048( )
      {
         BeforeValidate048( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable048( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency048( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm048( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate048( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000422 */
                     pr_default.execute(20, new Object[] {A11AsignaturaNombre, A8CarreraId, A10AsignaturaId});
                     pr_default.close(20);
                     dsDefault.SmartCacheProvider.SetUpdated("CarreraAsignatura") ;
                     if ( (pr_default.getStatus(20) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CarreraAsignatura"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate048( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey048( ) ;
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
            EndLevel048( ) ;
         }
         CloseExtendedTableCursors048( ) ;
      }

      protected void DeferredUpdate048( )
      {
      }

      protected void Delete048( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate048( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency048( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls048( ) ;
            AfterConfirm048( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete048( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000423 */
                  pr_default.execute(21, new Object[] {A8CarreraId, A10AsignaturaId});
                  pr_default.close(21);
                  dsDefault.SmartCacheProvider.SetUpdated("CarreraAsignatura") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode8 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel048( ) ;
         Gx_mode = sMode8;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls048( )
      {
         standaloneModal048( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000424 */
            pr_default.execute(22, new Object[] {A10AsignaturaId, A11AsignaturaNombre});
            A21AsignaturaSemestre = T000424_A21AsignaturaSemestre[0];
            pr_default.close(22);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000425 */
            pr_default.execute(23, new Object[] {A8CarreraId, A10AsignaturaId});
            if ( (pr_default.getStatus(23) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Examen"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(23);
         }
      }

      protected void EndLevel048( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart048( )
      {
         /* Scan By routine */
         /* Using cursor T000426 */
         pr_default.execute(24, new Object[] {A8CarreraId});
         RcdFound8 = 0;
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound8 = 1;
            A10AsignaturaId = T000426_A10AsignaturaId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext048( )
      {
         /* Scan next routine */
         pr_default.readNext(24);
         RcdFound8 = 0;
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound8 = 1;
            A10AsignaturaId = T000426_A10AsignaturaId[0];
         }
      }

      protected void ScanEnd048( )
      {
         pr_default.close(24);
      }

      protected void AfterConfirm048( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert048( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate048( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete048( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete048( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate048( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes048( )
      {
         edtAsignaturaId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaId_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         edtAsignaturaNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaNombre_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
         edtAsignaturaSemestre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaSemestre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaSemestre_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
      }

      protected void send_integrity_lvl_hashes048( )
      {
      }

      protected void send_integrity_lvl_hashes042( )
      {
      }

      protected void SubsflControlProps_488( )
      {
         edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_48_idx;
         edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE_"+sGXsfl_48_idx;
         imgprompt_10_11_Internalname = "PROMPT_10_11_"+sGXsfl_48_idx;
         edtAsignaturaSemestre_Internalname = "ASIGNATURASEMESTRE_"+sGXsfl_48_idx;
      }

      protected void SubsflControlProps_fel_488( )
      {
         edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_48_fel_idx;
         edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE_"+sGXsfl_48_fel_idx;
         imgprompt_10_11_Internalname = "PROMPT_10_11_"+sGXsfl_48_fel_idx;
         edtAsignaturaSemestre_Internalname = "ASIGNATURASEMESTRE_"+sGXsfl_48_fel_idx;
      }

      protected void AddRow048( )
      {
         nGXsfl_48_idx = (short)(nGXsfl_48_idx+1);
         sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_48_idx), 4, 0)), 4, "0");
         SubsflControlProps_488( ) ;
         SendRow048( ) ;
      }

      protected void SendRow048( )
      {
         Gridcarrera_asignaturaRow = GXWebRow.GetNew(context);
         if ( subGridcarrera_asignatura_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridcarrera_asignatura_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridcarrera_asignatura_Class, "") != 0 )
            {
               subGridcarrera_asignatura_Linesclass = subGridcarrera_asignatura_Class+"Odd";
            }
         }
         else if ( subGridcarrera_asignatura_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridcarrera_asignatura_Backstyle = 0;
            subGridcarrera_asignatura_Backcolor = subGridcarrera_asignatura_Allbackcolor;
            if ( StringUtil.StrCmp(subGridcarrera_asignatura_Class, "") != 0 )
            {
               subGridcarrera_asignatura_Linesclass = subGridcarrera_asignatura_Class+"Uniform";
            }
         }
         else if ( subGridcarrera_asignatura_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridcarrera_asignatura_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridcarrera_asignatura_Class, "") != 0 )
            {
               subGridcarrera_asignatura_Linesclass = subGridcarrera_asignatura_Class+"Odd";
            }
            subGridcarrera_asignatura_Backcolor = (int)(0x0);
         }
         else if ( subGridcarrera_asignatura_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridcarrera_asignatura_Backstyle = 1;
            if ( ((int)(((nGXsfl_48_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridcarrera_asignatura_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridcarrera_asignatura_Class, "") != 0 )
               {
                  subGridcarrera_asignatura_Linesclass = subGridcarrera_asignatura_Class+"Odd";
               }
            }
            else
            {
               subGridcarrera_asignatura_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridcarrera_asignatura_Class, "") != 0 )
               {
                  subGridcarrera_asignatura_Linesclass = subGridcarrera_asignatura_Class+"Even";
               }
            }
         }
         imgprompt_10_11_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00a0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ASIGNATURAID_"+sGXsfl_48_idx+"'), id:'"+"ASIGNATURAID_"+sGXsfl_48_idx+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"ASIGNATURANOMBRE_"+sGXsfl_48_idx+"'), id:'"+"ASIGNATURANOMBRE_"+sGXsfl_48_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_8_"+sGXsfl_48_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_8_" + sGXsfl_48_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_48_idx + "',48)\"";
         ROClassString = "Attribute";
         Gridcarrera_asignaturaRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAsignaturaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A10AsignaturaId), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A10AsignaturaId), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAsignaturaId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtAsignaturaId_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)48,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_8_" + sGXsfl_48_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_48_idx + "',48)\"";
         ROClassString = "Attribute";
         Gridcarrera_asignaturaRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAsignaturaNombre_Internalname,StringUtil.RTrim( A11AsignaturaNombre),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAsignaturaNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtAsignaturaNombre_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)48,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
         Gridcarrera_asignaturaRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_10_11_Internalname,(String)sImgUrl,(String)imgprompt_10_11_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_10_11_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridcarrera_asignaturaRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAsignaturaSemestre_Internalname,context.localUtil.Format(A21AsignaturaSemestre, "99/99/99"),context.localUtil.Format( A21AsignaturaSemestre, "99/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtAsignaturaSemestre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtAsignaturaSemestre_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)48,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         context.httpAjaxContext.ajax_sending_grid_row(Gridcarrera_asignaturaRow);
         send_integrity_lvl_hashes048( ) ;
         GXCCtl = "Z10AsignaturaId_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10AsignaturaId), 4, 0, ".", "")));
         GXCCtl = "Z11AsignaturaNombre_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z11AsignaturaNombre));
         GXCCtl = "nRcdDeleted_8_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_8), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_8_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_8), 4, 0, ".", "")));
         GXCCtl = "nIsMod_8_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_8), 4, 0, ".", "")));
         GXCCtl = "vMODE_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_48_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV9TrnContext);
         }
         GXCCtl = "vCARRERAID_" + sGXsfl_48_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7CarreraId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ASIGNATURAID_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ASIGNATURANOMBRE_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaNombre_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ASIGNATURASEMESTRE_"+sGXsfl_48_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaSemestre_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_10_11_"+sGXsfl_48_idx+"Link", StringUtil.RTrim( imgprompt_10_11_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridcarrera_asignaturaContainer.AddRow(Gridcarrera_asignaturaRow);
      }

      protected void ReadRow048( )
      {
         nGXsfl_48_idx = (short)(nGXsfl_48_idx+1);
         sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_48_idx), 4, 0)), 4, "0");
         SubsflControlProps_488( ) ;
         edtAsignaturaId_Enabled = (int)(context.localUtil.CToN( cgiGet( "ASIGNATURAID_"+sGXsfl_48_idx+"Enabled"), ".", ","));
         edtAsignaturaNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "ASIGNATURANOMBRE_"+sGXsfl_48_idx+"Enabled"), ".", ","));
         edtAsignaturaSemestre_Enabled = (int)(context.localUtil.CToN( cgiGet( "ASIGNATURASEMESTRE_"+sGXsfl_48_idx+"Enabled"), ".", ","));
         imgprompt_10_11_Link = cgiGet( "PROMPT_10_11_"+sGXsfl_48_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtAsignaturaId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtAsignaturaId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "ASIGNATURAID_" + sGXsfl_48_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtAsignaturaId_Internalname;
            wbErr = true;
            A10AsignaturaId = 0;
         }
         else
         {
            A10AsignaturaId = (short)(context.localUtil.CToN( cgiGet( edtAsignaturaId_Internalname), ".", ","));
         }
         A11AsignaturaNombre = cgiGet( edtAsignaturaNombre_Internalname);
         A21AsignaturaSemestre = context.localUtil.CToD( cgiGet( edtAsignaturaSemestre_Internalname), 1);
         GXCCtl = "Z10AsignaturaId_" + sGXsfl_48_idx;
         Z10AsignaturaId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "Z11AsignaturaNombre_" + sGXsfl_48_idx;
         Z11AsignaturaNombre = cgiGet( GXCCtl);
         GXCCtl = "nRcdDeleted_8_" + sGXsfl_48_idx;
         nRcdDeleted_8 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdExists_8_" + sGXsfl_48_idx;
         nRcdExists_8 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nIsMod_8_" + sGXsfl_48_idx;
         nIsMod_8 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
      }

      protected void assign_properties_default( )
      {
         defedtAsignaturaId_Enabled = edtAsignaturaId_Enabled;
      }

      protected void ConfirmValues040( )
      {
         nGXsfl_48_idx = 0;
         sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_48_idx), 4, 0)), 4, "0");
         SubsflControlProps_488( ) ;
         while ( nGXsfl_48_idx < nRC_GXsfl_48 )
         {
            nGXsfl_48_idx = (short)(nGXsfl_48_idx+1);
            sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_48_idx), 4, 0)), 4, "0");
            SubsflControlProps_488( ) ;
            ChangePostValue( "Z10AsignaturaId_"+sGXsfl_48_idx, cgiGet( "ZT_"+"Z10AsignaturaId_"+sGXsfl_48_idx)) ;
            DeletePostValue( "ZT_"+"Z10AsignaturaId_"+sGXsfl_48_idx) ;
            ChangePostValue( "Z11AsignaturaNombre_"+sGXsfl_48_idx, cgiGet( "ZT_"+"Z11AsignaturaNombre_"+sGXsfl_48_idx)) ;
            DeletePostValue( "ZT_"+"Z11AsignaturaNombre_"+sGXsfl_48_idx) ;
         }
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
         context.AddJavascriptSource("gxcfg.js", "?2020101711154552", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("carrera.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7CarreraId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Carrera";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A8CarreraId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("carrera:[SendSecurityCheck value for]"+"CarreraId:"+context.localUtil.Format( (decimal)(A8CarreraId), "ZZZ9"));
         GXUtil.WriteLog("carrera:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z8CarreraId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8CarreraId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z9CarreraNombre", StringUtil.RTrim( Z9CarreraNombre));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_48", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_48_idx), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vCARRERAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7CarreraId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vCARRERAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7CarreraId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV11Pgmname));
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
         return formatLink("carrera.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7CarreraId) ;
      }

      public override String GetPgmname( )
      {
         return "Carrera" ;
      }

      public override String GetPgmdesc( )
      {
         return "Carrera" ;
      }

      protected void InitializeNonKey042( )
      {
         A9CarreraNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CarreraNombre", A9CarreraNombre);
         Z9CarreraNombre = "";
      }

      protected void InitAll042( )
      {
         A8CarreraId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
         InitializeNonKey042( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey048( )
      {
         A11AsignaturaNombre = "";
         A21AsignaturaSemestre = DateTime.MinValue;
         Z11AsignaturaNombre = "";
      }

      protected void InitAll048( )
      {
         A10AsignaturaId = 0;
         InitializeNonKey048( ) ;
      }

      protected void StandaloneModalInsert048( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020101711154562", true, true);
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
         context.AddJavascriptSource("carrera.js", "?2020101711154562", false, true);
         /* End function include_jscripts */
      }

      protected void init_level_properties8( )
      {
         edtAsignaturaId_Enabled = defedtAsignaturaId_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaId_Enabled), 5, 0)), !bGXsfl_48_Refreshing);
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
         edtCarreraId_Internalname = "CARRERAID";
         edtCarreraNombre_Internalname = "CARRERANOMBRE";
         lblTitleasignatura_Internalname = "TITLEASIGNATURA";
         edtAsignaturaId_Internalname = "ASIGNATURAID";
         edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE";
         edtAsignaturaSemestre_Internalname = "ASIGNATURASEMESTRE";
         divAsignaturatable_Internalname = "ASIGNATURATABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_10_11_Internalname = "PROMPT_10_11";
         subGridcarrera_asignatura_Internalname = "GRIDCARRERA_ASIGNATURA";
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
         Form.Caption = "Carrera";
         edtAsignaturaSemestre_Jsonclick = "";
         imgprompt_10_11_Visible = 1;
         imgprompt_10_11_Link = "";
         imgprompt_10_11_Visible = 1;
         edtAsignaturaNombre_Jsonclick = "";
         edtAsignaturaId_Jsonclick = "";
         subGridcarrera_asignatura_Class = "Grid";
         subGridcarrera_asignatura_Backcolorstyle = 0;
         subGridcarrera_asignatura_Allowcollapsing = 0;
         subGridcarrera_asignatura_Allowselection = 0;
         edtAsignaturaSemestre_Enabled = 0;
         edtAsignaturaNombre_Enabled = 1;
         edtAsignaturaId_Enabled = 1;
         subGridcarrera_asignatura_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtCarreraNombre_Jsonclick = "";
         edtCarreraNombre_Enabled = 1;
         edtCarreraId_Jsonclick = "";
         edtCarreraId_Enabled = 0;
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

      protected void gxnrGridcarrera_asignatura_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_488( ) ;
         while ( nGXsfl_48_idx <= nRC_GXsfl_48 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal048( ) ;
            standaloneModal048( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow048( ) ;
            nGXsfl_48_idx = (short)(nGXsfl_48_idx+1);
            sGXsfl_48_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_48_idx), 4, 0)), 4, "0");
            SubsflControlProps_488( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridcarrera_asignaturaContainer));
         /* End function gxnrGridcarrera_asignatura_newrow */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      public void Valid_Asignaturanombre( short GX_Parm1 ,
                                          String GX_Parm2 ,
                                          DateTime GX_Parm3 )
      {
         A10AsignaturaId = GX_Parm1;
         A11AsignaturaNombre = GX_Parm2;
         A21AsignaturaSemestre = GX_Parm3;
         /* Using cursor T000424 */
         pr_default.execute(22, new Object[] {A10AsignaturaId, A11AsignaturaNombre});
         if ( (pr_default.getStatus(22) == 101) )
         {
            GX_msglist.addItem("No matching 'Asignatura'.", "ForeignKeyNotFound", 1, "ASIGNATURAID");
            AnyError = 1;
            GX_FocusControl = edtAsignaturaId_Internalname;
         }
         A21AsignaturaSemestre = T000424_A21AsignaturaSemestre[0];
         pr_default.close(22);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A21AsignaturaSemestre = DateTime.MinValue;
         }
         isValidOutput.Add(context.localUtil.Format(A21AsignaturaSemestre, "99/99/99"));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7CarreraId',fld:'vCARRERAID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7CarreraId',fld:'vCARRERAID',pic:'ZZZ9',hsh:true},{av:'A8CarreraId',fld:'CARRERAID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12042',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(22);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z9CarreraNombre = "";
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
         A9CarreraNombre = "";
         lblTitleasignatura_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridcarrera_asignaturaContainer = new GXWebGrid( context);
         Gridcarrera_asignaturaColumn = new GXWebColumn();
         A21AsignaturaSemestre = DateTime.MinValue;
         sMode8 = "";
         sStyleString = "";
         AV11Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode2 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         T00047_A8CarreraId = new short[1] ;
         T00047_A9CarreraNombre = new String[] {""} ;
         T00048_A8CarreraId = new short[1] ;
         T00046_A8CarreraId = new short[1] ;
         T00046_A9CarreraNombre = new String[] {""} ;
         T00049_A8CarreraId = new short[1] ;
         T000410_A8CarreraId = new short[1] ;
         T00045_A8CarreraId = new short[1] ;
         T00045_A9CarreraNombre = new String[] {""} ;
         T000411_A8CarreraId = new short[1] ;
         T000414_A17ExamenId = new short[1] ;
         T000415_A15EstudianteId = new short[1] ;
         T000416_A17ExamenId = new short[1] ;
         T000417_A8CarreraId = new short[1] ;
         Z21AsignaturaSemestre = DateTime.MinValue;
         T000418_A8CarreraId = new short[1] ;
         T000418_A21AsignaturaSemestre = new DateTime[] {DateTime.MinValue} ;
         T000418_A10AsignaturaId = new short[1] ;
         T000418_A11AsignaturaNombre = new String[] {""} ;
         T00044_A21AsignaturaSemestre = new DateTime[] {DateTime.MinValue} ;
         T000419_A21AsignaturaSemestre = new DateTime[] {DateTime.MinValue} ;
         T000420_A8CarreraId = new short[1] ;
         T000420_A10AsignaturaId = new short[1] ;
         T00043_A8CarreraId = new short[1] ;
         T00043_A10AsignaturaId = new short[1] ;
         T00043_A11AsignaturaNombre = new String[] {""} ;
         T00042_A8CarreraId = new short[1] ;
         T00042_A10AsignaturaId = new short[1] ;
         T00042_A11AsignaturaNombre = new String[] {""} ;
         T000424_A21AsignaturaSemestre = new DateTime[] {DateTime.MinValue} ;
         T000425_A17ExamenId = new short[1] ;
         T000426_A8CarreraId = new short[1] ;
         T000426_A10AsignaturaId = new short[1] ;
         Gridcarrera_asignaturaRow = new GXWebRow();
         subGridcarrera_asignatura_Linesclass = "";
         ROClassString = "";
         sImgUrl = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.carrera__default(),
            new Object[][] {
                new Object[] {
               T00042_A8CarreraId, T00042_A10AsignaturaId, T00042_A11AsignaturaNombre
               }
               , new Object[] {
               T00043_A8CarreraId, T00043_A10AsignaturaId, T00043_A11AsignaturaNombre
               }
               , new Object[] {
               T00044_A21AsignaturaSemestre
               }
               , new Object[] {
               T00045_A8CarreraId, T00045_A9CarreraNombre
               }
               , new Object[] {
               T00046_A8CarreraId, T00046_A9CarreraNombre
               }
               , new Object[] {
               T00047_A8CarreraId, T00047_A9CarreraNombre
               }
               , new Object[] {
               T00048_A8CarreraId
               }
               , new Object[] {
               T00049_A8CarreraId
               }
               , new Object[] {
               T000410_A8CarreraId
               }
               , new Object[] {
               T000411_A8CarreraId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000414_A17ExamenId
               }
               , new Object[] {
               T000415_A15EstudianteId
               }
               , new Object[] {
               T000416_A17ExamenId
               }
               , new Object[] {
               T000417_A8CarreraId
               }
               , new Object[] {
               T000418_A8CarreraId, T000418_A21AsignaturaSemestre, T000418_A10AsignaturaId, T000418_A11AsignaturaNombre
               }
               , new Object[] {
               T000419_A21AsignaturaSemestre
               }
               , new Object[] {
               T000420_A8CarreraId, T000420_A10AsignaturaId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000424_A21AsignaturaSemestre
               }
               , new Object[] {
               T000425_A17ExamenId
               }
               , new Object[] {
               T000426_A8CarreraId, T000426_A10AsignaturaId
               }
            }
         );
         AV11Pgmname = "Carrera";
      }

      private short nIsMod_8 ;
      private short wcpOAV7CarreraId ;
      private short Z8CarreraId ;
      private short nRC_GXsfl_48 ;
      private short nGXsfl_48_idx=1 ;
      private short Z10AsignaturaId ;
      private short nRcdDeleted_8 ;
      private short nRcdExists_8 ;
      private short GxWebError ;
      private short A10AsignaturaId ;
      private short AV7CarreraId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A8CarreraId ;
      private short subGridcarrera_asignatura_Backcolorstyle ;
      private short subGridcarrera_asignatura_Allowselection ;
      private short subGridcarrera_asignatura_Allowhovering ;
      private short subGridcarrera_asignatura_Allowcollapsing ;
      private short subGridcarrera_asignatura_Collapsed ;
      private short nBlankRcdCount8 ;
      private short RcdFound8 ;
      private short nBlankRcdUsr8 ;
      private short RcdFound2 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short subGridcarrera_asignatura_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtCarreraId_Enabled ;
      private int edtCarreraNombre_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtAsignaturaId_Enabled ;
      private int edtAsignaturaNombre_Enabled ;
      private int edtAsignaturaSemestre_Enabled ;
      private int subGridcarrera_asignatura_Selectedindex ;
      private int subGridcarrera_asignatura_Selectioncolor ;
      private int subGridcarrera_asignatura_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridcarrera_asignatura_Backcolor ;
      private int subGridcarrera_asignatura_Allbackcolor ;
      private int imgprompt_10_11_Visible ;
      private int defedtAsignaturaId_Enabled ;
      private int idxLst ;
      private long GRIDCARRERA_ASIGNATURA_nFirstRecordOnPage ;
      private String sPrefix ;
      private String sGXsfl_48_idx="0001" ;
      private String wcpOGx_mode ;
      private String Z9CarreraNombre ;
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
      private String edtCarreraNombre_Internalname ;
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
      private String edtCarreraId_Internalname ;
      private String edtCarreraId_Jsonclick ;
      private String A9CarreraNombre ;
      private String edtCarreraNombre_Jsonclick ;
      private String divAsignaturatable_Internalname ;
      private String lblTitleasignatura_Internalname ;
      private String lblTitleasignatura_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridcarrera_asignatura_Header ;
      private String sMode8 ;
      private String edtAsignaturaId_Internalname ;
      private String edtAsignaturaNombre_Internalname ;
      private String edtAsignaturaSemestre_Internalname ;
      private String imgprompt_10_11_Link ;
      private String sStyleString ;
      private String AV11Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode2 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String imgprompt_10_11_Internalname ;
      private String sGXsfl_48_fel_idx="0001" ;
      private String subGridcarrera_asignatura_Class ;
      private String subGridcarrera_asignatura_Linesclass ;
      private String ROClassString ;
      private String edtAsignaturaId_Jsonclick ;
      private String edtAsignaturaNombre_Jsonclick ;
      private String sImgUrl ;
      private String edtAsignaturaSemestre_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridcarrera_asignatura_Internalname ;
      private DateTime A21AsignaturaSemestre ;
      private DateTime Z21AsignaturaSemestre ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_48_Refreshing=false ;
      private bool returnInSub ;
      private IGxSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridcarrera_asignaturaContainer ;
      private GXWebRow Gridcarrera_asignaturaRow ;
      private GXWebColumn Gridcarrera_asignaturaColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00047_A8CarreraId ;
      private String[] T00047_A9CarreraNombre ;
      private short[] T00048_A8CarreraId ;
      private short[] T00046_A8CarreraId ;
      private String[] T00046_A9CarreraNombre ;
      private short[] T00049_A8CarreraId ;
      private short[] T000410_A8CarreraId ;
      private short[] T00045_A8CarreraId ;
      private String[] T00045_A9CarreraNombre ;
      private short[] T000411_A8CarreraId ;
      private short[] T000414_A17ExamenId ;
      private short[] T000415_A15EstudianteId ;
      private short[] T000416_A17ExamenId ;
      private short[] T000417_A8CarreraId ;
      private short[] T000418_A8CarreraId ;
      private DateTime[] T000418_A21AsignaturaSemestre ;
      private short[] T000418_A10AsignaturaId ;
      private String[] T000418_A11AsignaturaNombre ;
      private DateTime[] T00044_A21AsignaturaSemestre ;
      private DateTime[] T000419_A21AsignaturaSemestre ;
      private short[] T000420_A8CarreraId ;
      private short[] T000420_A10AsignaturaId ;
      private short[] T00043_A8CarreraId ;
      private short[] T00043_A10AsignaturaId ;
      private String[] T00043_A11AsignaturaNombre ;
      private short[] T00042_A8CarreraId ;
      private short[] T00042_A10AsignaturaId ;
      private String[] T00042_A11AsignaturaNombre ;
      private DateTime[] T000424_A21AsignaturaSemestre ;
      private short[] T000425_A17ExamenId ;
      private short[] T000426_A8CarreraId ;
      private short[] T000426_A10AsignaturaId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class carrera__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new UpdateCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new ForEachCursor(def[24])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00047 ;
          prmT00047 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00048 ;
          prmT00048 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00046 ;
          prmT00046 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00049 ;
          prmT00049 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000410 ;
          prmT000410 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00045 ;
          prmT00045 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000411 ;
          prmT000411 = new Object[] {
          new Object[] {"@CarreraNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT000412 ;
          prmT000412 = new Object[] {
          new Object[] {"@CarreraNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000413 ;
          prmT000413 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000414 ;
          prmT000414 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000415 ;
          prmT000415 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000416 ;
          prmT000416 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000417 ;
          prmT000417 = new Object[] {
          } ;
          Object[] prmT000418 ;
          prmT000418 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00044 ;
          prmT00044 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT000419 ;
          prmT000419 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT000420 ;
          prmT000420 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00043 ;
          prmT00043 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00042 ;
          prmT00042 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000421 ;
          prmT000421 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          Object[] prmT000422 ;
          prmT000422 = new Object[] {
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000423 ;
          prmT000423 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000425 ;
          prmT000425 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000426 ;
          prmT000426 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000424 ;
          prmT000424 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaNombre",SqlDbType.Char,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00042", "SELECT [CarreraId], [AsignaturaId], [AsignaturaNombre] FROM [CarreraAsignatura] WITH (UPDLOCK) WHERE [CarreraId] = @CarreraId AND [AsignaturaId] = @AsignaturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00042,1,0,true,false )
             ,new CursorDef("T00043", "SELECT [CarreraId], [AsignaturaId], [AsignaturaNombre] FROM [CarreraAsignatura] WITH (NOLOCK) WHERE [CarreraId] = @CarreraId AND [AsignaturaId] = @AsignaturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00043,1,0,true,false )
             ,new CursorDef("T00044", "SELECT [AsignaturaSemestre] FROM [Asignatura] WITH (NOLOCK) WHERE [AsignaturaId] = @AsignaturaId AND [AsignaturaNombre] = @AsignaturaNombre ",true, GxErrorMask.GX_NOMASK, false, this,prmT00044,1,0,true,false )
             ,new CursorDef("T00045", "SELECT [CarreraId], [CarreraNombre] FROM [Carrera] WITH (UPDLOCK) WHERE [CarreraId] = @CarreraId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00045,1,0,true,false )
             ,new CursorDef("T00046", "SELECT [CarreraId], [CarreraNombre] FROM [Carrera] WITH (NOLOCK) WHERE [CarreraId] = @CarreraId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00046,1,0,true,false )
             ,new CursorDef("T00047", "SELECT TM1.[CarreraId], TM1.[CarreraNombre] FROM [Carrera] TM1 WITH (NOLOCK) WHERE TM1.[CarreraId] = @CarreraId ORDER BY TM1.[CarreraId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00047,100,0,true,false )
             ,new CursorDef("T00048", "SELECT [CarreraId] FROM [Carrera] WITH (NOLOCK) WHERE [CarreraId] = @CarreraId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00048,1,0,true,false )
             ,new CursorDef("T00049", "SELECT TOP 1 [CarreraId] FROM [Carrera] WITH (NOLOCK) WHERE ( [CarreraId] > @CarreraId) ORDER BY [CarreraId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00049,1,0,true,true )
             ,new CursorDef("T000410", "SELECT TOP 1 [CarreraId] FROM [Carrera] WITH (NOLOCK) WHERE ( [CarreraId] < @CarreraId) ORDER BY [CarreraId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000410,1,0,true,true )
             ,new CursorDef("T000411", "INSERT INTO [Carrera]([CarreraNombre]) VALUES(@CarreraNombre); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000411)
             ,new CursorDef("T000412", "UPDATE [Carrera] SET [CarreraNombre]=@CarreraNombre  WHERE [CarreraId] = @CarreraId", GxErrorMask.GX_NOMASK,prmT000412)
             ,new CursorDef("T000413", "DELETE FROM [Carrera]  WHERE [CarreraId] = @CarreraId", GxErrorMask.GX_NOMASK,prmT000413)
             ,new CursorDef("T000414", "SELECT TOP 1 [ExamenId] FROM [Examen] WITH (NOLOCK) WHERE [ExamenCarrAsigCarreraId] = @CarreraId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000414,1,0,true,true )
             ,new CursorDef("T000415", "SELECT TOP 1 [EstudianteId] FROM [Estudiante] WITH (NOLOCK) WHERE [CarreraId] = @CarreraId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000415,1,0,true,true )
             ,new CursorDef("T000416", "SELECT TOP 1 [ExamenId] FROM [Examen] WITH (NOLOCK) WHERE [ExamenCarrAsigCarreraId] = @CarreraId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000416,1,0,true,true )
             ,new CursorDef("T000417", "SELECT [CarreraId] FROM [Carrera] WITH (NOLOCK) ORDER BY [CarreraId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000417,100,0,true,false )
             ,new CursorDef("T000418", "SELECT T1.[CarreraId], T2.[AsignaturaSemestre], T1.[AsignaturaId], T1.[AsignaturaNombre] FROM ([CarreraAsignatura] T1 WITH (NOLOCK) INNER JOIN [Asignatura] T2 WITH (NOLOCK) ON T2.[AsignaturaId] = T1.[AsignaturaId] AND T2.[AsignaturaNombre] = T1.[AsignaturaNombre]) WHERE T1.[CarreraId] = @CarreraId and T1.[AsignaturaId] = @AsignaturaId ORDER BY T1.[CarreraId], T1.[AsignaturaId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000418,11,0,true,false )
             ,new CursorDef("T000419", "SELECT [AsignaturaSemestre] FROM [Asignatura] WITH (NOLOCK) WHERE [AsignaturaId] = @AsignaturaId AND [AsignaturaNombre] = @AsignaturaNombre ",true, GxErrorMask.GX_NOMASK, false, this,prmT000419,1,0,true,false )
             ,new CursorDef("T000420", "SELECT [CarreraId], [AsignaturaId] FROM [CarreraAsignatura] WITH (NOLOCK) WHERE [CarreraId] = @CarreraId AND [AsignaturaId] = @AsignaturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000420,1,0,true,false )
             ,new CursorDef("T000421", "INSERT INTO [CarreraAsignatura]([CarreraId], [AsignaturaId], [AsignaturaNombre]) VALUES(@CarreraId, @AsignaturaId, @AsignaturaNombre)", GxErrorMask.GX_NOMASK,prmT000421)
             ,new CursorDef("T000422", "UPDATE [CarreraAsignatura] SET [AsignaturaNombre]=@AsignaturaNombre  WHERE [CarreraId] = @CarreraId AND [AsignaturaId] = @AsignaturaId", GxErrorMask.GX_NOMASK,prmT000422)
             ,new CursorDef("T000423", "DELETE FROM [CarreraAsignatura]  WHERE [CarreraId] = @CarreraId AND [AsignaturaId] = @AsignaturaId", GxErrorMask.GX_NOMASK,prmT000423)
             ,new CursorDef("T000424", "SELECT [AsignaturaSemestre] FROM [Asignatura] WITH (NOLOCK) WHERE [AsignaturaId] = @AsignaturaId AND [AsignaturaNombre] = @AsignaturaNombre ",true, GxErrorMask.GX_NOMASK, false, this,prmT000424,1,0,true,false )
             ,new CursorDef("T000425", "SELECT TOP 1 [ExamenId] FROM [Examen] WITH (NOLOCK) WHERE [ExamenCarrAsigCarreraId] = @CarreraId AND [ExamenCarrAsigAsignaturaId] = @AsignaturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000425,1,0,true,true )
             ,new CursorDef("T000426", "SELECT [CarreraId], [AsignaturaId] FROM [CarreraAsignatura] WITH (NOLOCK) WHERE [CarreraId] = @CarreraId ORDER BY [CarreraId], [AsignaturaId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000426,11,0,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                return;
             case 2 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
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
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                return;
             case 17 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                return;
             case 18 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 22 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                return;
             case 23 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 24 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
