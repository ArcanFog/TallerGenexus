/*
               File: Examen
        Description: Examen
             Author: GeneXus C# Generator version 16_0_1-129648
       Generated on: 10/22/2020 21:6:11.16
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
   public class examen : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_16") == 0 )
         {
            A22ExamenCarrAsigCarreraId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_16( A22ExamenCarrAsigCarreraId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_17") == 0 )
         {
            A22ExamenCarrAsigCarreraId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
            A24ExamenCarrAsigAsignaturaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_17( A22ExamenCarrAsigCarreraId, A24ExamenCarrAsigAsignaturaId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_19") == 0 )
         {
            A15EstudianteId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_19( A15EstudianteId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_20") == 0 )
         {
            A8CarreraId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_20( A8CarreraId) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridexamen_estudiiante") == 0 )
         {
            nRC_GXsfl_68 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_68_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_68_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridexamen_estudiiante_newrow( ) ;
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
               AV7ExamenId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ExamenId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEXAMENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ExamenId), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Examen", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtExamenId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public examen( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public examen( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_ExamenId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7ExamenId = aP1_ExamenId;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Examen", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Examen.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Examen.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Examen.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Examen.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Examen.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Examen.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtExamenId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17ExamenId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A17ExamenId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtExamenId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Examen.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenFecha_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenFecha_Internalname, "Fecha", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtExamenFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtExamenFecha_Internalname, context.localUtil.Format(A26ExamenFecha, "99/99/99"), context.localUtil.Format( A26ExamenFecha, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenFecha_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtExamenFecha_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Examen.htm");
            GxWebStd.gx_bitmap( context, edtExamenFecha_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtExamenFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Examen.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenCarrAsigCarreraId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenCarrAsigCarreraId_Internalname, "Carrera Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtExamenCarrAsigCarreraId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A22ExamenCarrAsigCarreraId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenCarrAsigCarreraId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtExamenCarrAsigCarreraId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Examen.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_22_Internalname, sImgUrl, imgprompt_22_Link, "", "", context.GetTheme( ), imgprompt_22_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Examen.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenCarrAsigCarreraNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenCarrAsigCarreraNombre_Internalname, "Carrera Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtExamenCarrAsigCarreraNombre_Internalname, StringUtil.RTrim( A23ExamenCarrAsigCarreraNombre), StringUtil.RTrim( context.localUtil.Format( A23ExamenCarrAsigCarreraNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenCarrAsigCarreraNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtExamenCarrAsigCarreraNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Examen.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenCarrAsigAsignaturaId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenCarrAsigAsignaturaId_Internalname, "Asignatura Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtExamenCarrAsigAsignaturaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A24ExamenCarrAsigAsignaturaId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenCarrAsigAsignaturaId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtExamenCarrAsigAsignaturaId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Examen.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_24_Internalname, sImgUrl, imgprompt_24_Link, "", "", context.GetTheme( ), imgprompt_24_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Examen.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtExamenCarrAsigAsignaturaNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtExamenCarrAsigAsignaturaNombre_Internalname, "Asignatura Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtExamenCarrAsigAsignaturaNombre_Internalname, StringUtil.RTrim( A25ExamenCarrAsigAsignaturaNombre), StringUtil.RTrim( context.localUtil.Format( A25ExamenCarrAsigAsignaturaNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtExamenCarrAsigAsignaturaNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtExamenCarrAsigAsignaturaNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Examen.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divEstudiiantetable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitleestudiiante_Internalname, "Estudiiante", "", "", lblTitleestudiiante_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Examen.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridexamen_estudiiante( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Examen.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Examen.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Examen.htm");
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

      protected void gxdraw_Gridexamen_estudiiante( )
      {
         /*  Grid Control  */
         Gridexamen_estudiianteContainer.AddObjectProperty("GridName", "Gridexamen_estudiiante");
         Gridexamen_estudiianteContainer.AddObjectProperty("Header", subGridexamen_estudiiante_Header);
         Gridexamen_estudiianteContainer.AddObjectProperty("Class", "Grid");
         Gridexamen_estudiianteContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridexamen_estudiianteContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridexamen_estudiianteContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridexamen_estudiiante_Backcolorstyle), 1, 0, ".", "")));
         Gridexamen_estudiianteContainer.AddObjectProperty("CmpContext", "");
         Gridexamen_estudiianteContainer.AddObjectProperty("InMasterPage", "false");
         Gridexamen_estudiianteColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridexamen_estudiianteColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A15EstudianteId), 4, 0, ".", "")));
         Gridexamen_estudiianteColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEstudianteId_Enabled), 5, 0, ".", "")));
         Gridexamen_estudiianteContainer.AddColumnProperties(Gridexamen_estudiianteColumn);
         Gridexamen_estudiianteColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridexamen_estudiianteContainer.AddColumnProperties(Gridexamen_estudiianteColumn);
         Gridexamen_estudiianteColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridexamen_estudiianteColumn.AddObjectProperty("Value", StringUtil.RTrim( A18EstudianteNombre));
         Gridexamen_estudiianteColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEstudianteNombre_Enabled), 5, 0, ".", "")));
         Gridexamen_estudiianteContainer.AddColumnProperties(Gridexamen_estudiianteColumn);
         Gridexamen_estudiianteColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridexamen_estudiianteColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8CarreraId), 4, 0, ".", "")));
         Gridexamen_estudiianteColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCarreraId_Enabled), 5, 0, ".", "")));
         Gridexamen_estudiianteContainer.AddColumnProperties(Gridexamen_estudiianteColumn);
         Gridexamen_estudiianteColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridexamen_estudiianteColumn.AddObjectProperty("Value", StringUtil.RTrim( A9CarreraNombre));
         Gridexamen_estudiianteColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCarreraNombre_Enabled), 5, 0, ".", "")));
         Gridexamen_estudiianteContainer.AddColumnProperties(Gridexamen_estudiianteColumn);
         Gridexamen_estudiianteColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridexamen_estudiianteColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ExamenEstudianteNota), 4, 0, ".", "")));
         Gridexamen_estudiianteColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExamenEstudianteNota_Enabled), 5, 0, ".", "")));
         Gridexamen_estudiianteContainer.AddColumnProperties(Gridexamen_estudiianteColumn);
         Gridexamen_estudiianteContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridexamen_estudiiante_Selectedindex), 4, 0, ".", "")));
         Gridexamen_estudiianteContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridexamen_estudiiante_Allowselection), 1, 0, ".", "")));
         Gridexamen_estudiianteContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridexamen_estudiiante_Selectioncolor), 9, 0, ".", "")));
         Gridexamen_estudiianteContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridexamen_estudiiante_Allowhovering), 1, 0, ".", "")));
         Gridexamen_estudiianteContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridexamen_estudiiante_Hoveringcolor), 9, 0, ".", "")));
         Gridexamen_estudiianteContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridexamen_estudiiante_Allowcollapsing), 1, 0, ".", "")));
         Gridexamen_estudiianteContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridexamen_estudiiante_Collapsed), 1, 0, ".", "")));
         nGXsfl_68_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount9 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_9 = 1;
               ScanStart099( ) ;
               while ( RcdFound9 != 0 )
               {
                  init_level_properties9( ) ;
                  getByPrimaryKey099( ) ;
                  AddRow099( ) ;
                  ScanNext099( ) ;
               }
               ScanEnd099( ) ;
               nBlankRcdCount9 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal099( ) ;
            standaloneModal099( ) ;
            sMode9 = Gx_mode;
            while ( nGXsfl_68_idx < nRC_GXsfl_68 )
            {
               bGXsfl_68_Refreshing = true;
               ReadRow099( ) ;
               edtEstudianteId_Enabled = (int)(context.localUtil.CToN( cgiGet( "ESTUDIANTEID_"+sGXsfl_68_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteId_Enabled), 5, 0)), !bGXsfl_68_Refreshing);
               edtEstudianteNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "ESTUDIANTENOMBRE_"+sGXsfl_68_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteNombre_Enabled), 5, 0)), !bGXsfl_68_Refreshing);
               edtCarreraId_Enabled = (int)(context.localUtil.CToN( cgiGet( "CARRERAID_"+sGXsfl_68_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarreraId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarreraId_Enabled), 5, 0)), !bGXsfl_68_Refreshing);
               edtCarreraNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "CARRERANOMBRE_"+sGXsfl_68_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarreraNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarreraNombre_Enabled), 5, 0)), !bGXsfl_68_Refreshing);
               edtExamenEstudianteNota_Enabled = (int)(context.localUtil.CToN( cgiGet( "EXAMENESTUDIANTENOTA_"+sGXsfl_68_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenEstudianteNota_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenEstudianteNota_Enabled), 5, 0)), !bGXsfl_68_Refreshing);
               imgprompt_22_Link = cgiGet( "PROMPT_15_"+sGXsfl_68_idx+"Link");
               if ( ( nRcdExists_9 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal099( ) ;
               }
               SendRow099( ) ;
               bGXsfl_68_Refreshing = false;
            }
            Gx_mode = sMode9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount9 = 5;
            nRcdExists_9 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart099( ) ;
               while ( RcdFound9 != 0 )
               {
                  sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_68_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_689( ) ;
                  init_level_properties9( ) ;
                  standaloneNotModal099( ) ;
                  getByPrimaryKey099( ) ;
                  standaloneModal099( ) ;
                  AddRow099( ) ;
                  ScanNext099( ) ;
               }
               ScanEnd099( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode9 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_68_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_689( ) ;
            InitAll099( ) ;
            init_level_properties9( ) ;
            standaloneNotModal099( ) ;
            standaloneModal099( ) ;
            nRcdExists_9 = 0;
            nIsMod_9 = 0;
            nRcdDeleted_9 = 0;
            nBlankRcdCount9 = (short)(nBlankRcdUsr9+nBlankRcdCount9);
            fRowAdded = 0;
            while ( nBlankRcdCount9 > 0 )
            {
               AddRow099( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtEstudianteId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount9 = (short)(nBlankRcdCount9-1);
            }
            Gx_mode = sMode9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridexamen_estudiianteContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridexamen_estudiiante", Gridexamen_estudiianteContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridexamen_estudiianteContainerData", Gridexamen_estudiianteContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridexamen_estudiianteContainerData"+"V", Gridexamen_estudiianteContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridexamen_estudiianteContainerData"+"V"+"\" value='"+Gridexamen_estudiianteContainer.GridValuesHidden()+"'/>") ;
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
         E11092 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtExamenId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtExamenId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "EXAMENID");
                  AnyError = 1;
                  GX_FocusControl = edtExamenId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A17ExamenId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
               }
               else
               {
                  A17ExamenId = (short)(context.localUtil.CToN( cgiGet( edtExamenId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
               }
               if ( context.localUtil.VCDate( cgiGet( edtExamenFecha_Internalname), 1) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Examen Fecha"}), 1, "EXAMENFECHA");
                  AnyError = 1;
                  GX_FocusControl = edtExamenFecha_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A26ExamenFecha = DateTime.MinValue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
               }
               else
               {
                  A26ExamenFecha = context.localUtil.CToD( cgiGet( edtExamenFecha_Internalname), 1);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtExamenCarrAsigCarreraId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtExamenCarrAsigCarreraId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "EXAMENCARRASIGCARRERAID");
                  AnyError = 1;
                  GX_FocusControl = edtExamenCarrAsigCarreraId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A22ExamenCarrAsigCarreraId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
               }
               else
               {
                  A22ExamenCarrAsigCarreraId = (short)(context.localUtil.CToN( cgiGet( edtExamenCarrAsigCarreraId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
               }
               A23ExamenCarrAsigCarreraNombre = cgiGet( edtExamenCarrAsigCarreraNombre_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23ExamenCarrAsigCarreraNombre", A23ExamenCarrAsigCarreraNombre);
               if ( ( ( context.localUtil.CToN( cgiGet( edtExamenCarrAsigAsignaturaId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtExamenCarrAsigAsignaturaId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "EXAMENCARRASIGASIGNATURAID");
                  AnyError = 1;
                  GX_FocusControl = edtExamenCarrAsigAsignaturaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A24ExamenCarrAsigAsignaturaId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
               }
               else
               {
                  A24ExamenCarrAsigAsignaturaId = (short)(context.localUtil.CToN( cgiGet( edtExamenCarrAsigAsignaturaId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
               }
               A25ExamenCarrAsigAsignaturaNombre = cgiGet( edtExamenCarrAsigAsignaturaNombre_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25ExamenCarrAsigAsignaturaNombre", A25ExamenCarrAsigAsignaturaNombre);
               /* Read saved values. */
               Z17ExamenId = (short)(context.localUtil.CToN( cgiGet( "Z17ExamenId"), ".", ","));
               Z26ExamenFecha = context.localUtil.CToD( cgiGet( "Z26ExamenFecha"), 0);
               Z22ExamenCarrAsigCarreraId = (short)(context.localUtil.CToN( cgiGet( "Z22ExamenCarrAsigCarreraId"), ".", ","));
               Z24ExamenCarrAsigAsignaturaId = (short)(context.localUtil.CToN( cgiGet( "Z24ExamenCarrAsigAsignaturaId"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_68 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_68"), ".", ","));
               N22ExamenCarrAsigCarreraId = (short)(context.localUtil.CToN( cgiGet( "N22ExamenCarrAsigCarreraId"), ".", ","));
               N24ExamenCarrAsigAsignaturaId = (short)(context.localUtil.CToN( cgiGet( "N24ExamenCarrAsigAsignaturaId"), ".", ","));
               AV7ExamenId = (short)(context.localUtil.CToN( cgiGet( "vEXAMENID"), ".", ","));
               AV11Insert_ExamenCarrAsigCarreraId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_EXAMENCARRASIGCARRERAID"), ".", ","));
               AV12Insert_ExamenCarrAsigAsignaturaId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_EXAMENCARRASIGASIGNATURAID"), ".", ","));
               AV14Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Examen";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_ExamenCarrAsigCarreraId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12Insert_ExamenCarrAsigAsignaturaId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A17ExamenId != Z17ExamenId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("examen:[SecurityCheckFailed value for]"+"Insert_ExamenCarrAsigCarreraId:"+context.localUtil.Format( (decimal)(AV11Insert_ExamenCarrAsigCarreraId), "ZZZ9"));
                  GXUtil.WriteLog("examen:[SecurityCheckFailed value for]"+"Insert_ExamenCarrAsigAsignaturaId:"+context.localUtil.Format( (decimal)(AV12Insert_ExamenCarrAsigAsignaturaId), "ZZZ9"));
                  GXUtil.WriteLog("examen:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A17ExamenId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
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
                     sMode7 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode7;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound7 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_090( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "EXAMENID");
                        AnyError = 1;
                        GX_FocusControl = edtExamenId_Internalname;
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
                           E11092 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12092 ();
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
            E12092 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll097( ) ;
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
            DisableAttributes097( ) ;
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

      protected void CONFIRM_090( )
      {
         BeforeValidate097( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls097( ) ;
            }
            else
            {
               CheckExtendedTable097( ) ;
               CloseExtendedTableCursors097( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode7 = Gx_mode;
            CONFIRM_099( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode7;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_099( )
      {
         nGXsfl_68_idx = 0;
         while ( nGXsfl_68_idx < nRC_GXsfl_68 )
         {
            ReadRow099( ) ;
            if ( ( nRcdExists_9 != 0 ) || ( nIsMod_9 != 0 ) )
            {
               GetKey099( ) ;
               if ( ( nRcdExists_9 == 0 ) && ( nRcdDeleted_9 == 0 ) )
               {
                  if ( RcdFound9 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate099( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable099( ) ;
                        CloseExtendedTableCursors099( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "ESTUDIANTEID_" + sGXsfl_68_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtEstudianteId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound9 != 0 )
                  {
                     if ( nRcdDeleted_9 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey099( ) ;
                        Load099( ) ;
                        BeforeValidate099( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls099( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_9 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate099( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable099( ) ;
                              CloseExtendedTableCursors099( ) ;
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
                     if ( nRcdDeleted_9 == 0 )
                     {
                        GXCCtl = "ESTUDIANTEID_" + sGXsfl_68_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtEstudianteId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtEstudianteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A15EstudianteId), 4, 0, ".", ""))) ;
            ChangePostValue( edtEstudianteNombre_Internalname, StringUtil.RTrim( A18EstudianteNombre)) ;
            ChangePostValue( edtCarreraId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8CarreraId), 4, 0, ".", ""))) ;
            ChangePostValue( edtCarreraNombre_Internalname, StringUtil.RTrim( A9CarreraNombre)) ;
            ChangePostValue( edtExamenEstudianteNota_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ExamenEstudianteNota), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z15EstudianteId_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15EstudianteId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z27ExamenEstudianteNota_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z27ExamenEstudianteNota), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_9_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_9), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_9_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_9), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_9_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_9), 4, 0, ".", ""))) ;
            if ( nIsMod_9 != 0 )
            {
               ChangePostValue( "ESTUDIANTEID_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEstudianteId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ESTUDIANTENOMBRE_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEstudianteNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CARRERAID_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCarreraId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CARRERANOMBRE_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCarreraNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EXAMENESTUDIANTENOTA_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExamenEstudianteNota_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption090( )
      {
      }

      protected void E11092( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV14Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV14Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "UniApp");
         AV11Insert_ExamenCarrAsigCarreraId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_ExamenCarrAsigCarreraId), 4, 0)));
         AV12Insert_ExamenCarrAsigAsignaturaId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Insert_ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Insert_ExamenCarrAsigAsignaturaId), 4, 0)));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV14Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV15GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GXV1), 8, 0)));
            while ( AV15GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV13TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV15GXV1));
               if ( StringUtil.StrCmp(AV13TrnContextAtt.gxTpr_Attributename, "ExamenCarrAsigCarreraId") == 0 )
               {
                  AV11Insert_ExamenCarrAsigCarreraId = (short)(NumberUtil.Val( AV13TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_ExamenCarrAsigCarreraId), 4, 0)));
               }
               else if ( StringUtil.StrCmp(AV13TrnContextAtt.gxTpr_Attributename, "ExamenCarrAsigAsignaturaId") == 0 )
               {
                  AV12Insert_ExamenCarrAsigAsignaturaId = (short)(NumberUtil.Val( AV13TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Insert_ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Insert_ExamenCarrAsigAsignaturaId), 4, 0)));
               }
               AV15GXV1 = (int)(AV15GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15GXV1), 8, 0)));
            }
         }
      }

      protected void E12092( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwexamen.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM097( short GX_JID )
      {
         if ( ( GX_JID == 15 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z26ExamenFecha = T00097_A26ExamenFecha[0];
               Z22ExamenCarrAsigCarreraId = T00097_A22ExamenCarrAsigCarreraId[0];
               Z24ExamenCarrAsigAsignaturaId = T00097_A24ExamenCarrAsigAsignaturaId[0];
            }
            else
            {
               Z26ExamenFecha = A26ExamenFecha;
               Z22ExamenCarrAsigCarreraId = A22ExamenCarrAsigCarreraId;
               Z24ExamenCarrAsigAsignaturaId = A24ExamenCarrAsigAsignaturaId;
            }
         }
         if ( GX_JID == -15 )
         {
            Z17ExamenId = A17ExamenId;
            Z26ExamenFecha = A26ExamenFecha;
            Z22ExamenCarrAsigCarreraId = A22ExamenCarrAsigCarreraId;
            Z24ExamenCarrAsigAsignaturaId = A24ExamenCarrAsigAsignaturaId;
            Z23ExamenCarrAsigCarreraNombre = A23ExamenCarrAsigCarreraNombre;
            Z25ExamenCarrAsigAsignaturaNombre = A25ExamenCarrAsigAsignaturaNombre;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_22_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EXAMENCARRASIGCARRERAID"+"'), id:'"+"EXAMENCARRASIGCARRERAID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_24_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0081.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EXAMENCARRASIGCARRERAID"+"'), id:'"+"EXAMENCARRASIGCARRERAID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"EXAMENCARRASIGASIGNATURAID"+"'), id:'"+"EXAMENCARRASIGASIGNATURAID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7ExamenId) )
         {
            A17ExamenId = AV7ExamenId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
         }
         if ( ! (0==AV7ExamenId) )
         {
            edtExamenId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenId_Enabled), 5, 0)), true);
         }
         else
         {
            edtExamenId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenId_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7ExamenId) )
         {
            edtExamenId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenId_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_ExamenCarrAsigCarreraId) )
         {
            edtExamenCarrAsigCarreraId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenCarrAsigCarreraId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenCarrAsigCarreraId_Enabled), 5, 0)), true);
         }
         else
         {
            edtExamenCarrAsigCarreraId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenCarrAsigCarreraId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenCarrAsigCarreraId_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_ExamenCarrAsigAsignaturaId) )
         {
            edtExamenCarrAsigAsignaturaId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenCarrAsigAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenCarrAsigAsignaturaId_Enabled), 5, 0)), true);
         }
         else
         {
            edtExamenCarrAsigAsignaturaId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenCarrAsigAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenCarrAsigAsignaturaId_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_ExamenCarrAsigAsignaturaId) )
         {
            A24ExamenCarrAsigAsignaturaId = AV12Insert_ExamenCarrAsigAsignaturaId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_ExamenCarrAsigCarreraId) )
         {
            A22ExamenCarrAsigCarreraId = AV11Insert_ExamenCarrAsigCarreraId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
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
            AV14Pgmname = "Examen";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
            /* Using cursor T00098 */
            pr_default.execute(6, new Object[] {A22ExamenCarrAsigCarreraId});
            A23ExamenCarrAsigCarreraNombre = T00098_A23ExamenCarrAsigCarreraNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23ExamenCarrAsigCarreraNombre", A23ExamenCarrAsigCarreraNombre);
            pr_default.close(6);
            /* Using cursor T00099 */
            pr_default.execute(7, new Object[] {A22ExamenCarrAsigCarreraId, A24ExamenCarrAsigAsignaturaId});
            A25ExamenCarrAsigAsignaturaNombre = T00099_A25ExamenCarrAsigAsignaturaNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25ExamenCarrAsigAsignaturaNombre", A25ExamenCarrAsigAsignaturaNombre);
            pr_default.close(7);
         }
      }

      protected void Load097( )
      {
         /* Using cursor T000910 */
         pr_default.execute(8, new Object[] {A17ExamenId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound7 = 1;
            A26ExamenFecha = T000910_A26ExamenFecha[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
            A23ExamenCarrAsigCarreraNombre = T000910_A23ExamenCarrAsigCarreraNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23ExamenCarrAsigCarreraNombre", A23ExamenCarrAsigCarreraNombre);
            A22ExamenCarrAsigCarreraId = T000910_A22ExamenCarrAsigCarreraId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
            A24ExamenCarrAsigAsignaturaId = T000910_A24ExamenCarrAsigAsignaturaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
            A25ExamenCarrAsigAsignaturaNombre = T000910_A25ExamenCarrAsigAsignaturaNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25ExamenCarrAsigAsignaturaNombre", A25ExamenCarrAsigAsignaturaNombre);
            ZM097( -15) ;
         }
         pr_default.close(8);
         OnLoadActions097( ) ;
      }

      protected void OnLoadActions097( )
      {
         AV14Pgmname = "Examen";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
      }

      protected void CheckExtendedTable097( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV14Pgmname = "Examen";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
         if ( ! ( (DateTime.MinValue==A26ExamenFecha) || ( A26ExamenFecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Field Examen Fecha is out of range", "OutOfRange", 1, "EXAMENFECHA");
            AnyError = 1;
            GX_FocusControl = edtExamenFecha_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T00098 */
         pr_default.execute(6, new Object[] {A22ExamenCarrAsigCarreraId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No matching 'Examen Carr Asig'.", "ForeignKeyNotFound", 1, "EXAMENCARRASIGCARRERAID");
            AnyError = 1;
            GX_FocusControl = edtExamenCarrAsigCarreraId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A23ExamenCarrAsigCarreraNombre = T00098_A23ExamenCarrAsigCarreraNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23ExamenCarrAsigCarreraNombre", A23ExamenCarrAsigCarreraNombre);
         pr_default.close(6);
         /* Using cursor T00099 */
         pr_default.execute(7, new Object[] {A22ExamenCarrAsigCarreraId, A24ExamenCarrAsigAsignaturaId});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No matching 'Examen Carr Asig'.", "ForeignKeyNotFound", 1, "EXAMENCARRASIGCARRERAID");
            AnyError = 1;
            GX_FocusControl = edtExamenCarrAsigCarreraId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A25ExamenCarrAsigAsignaturaNombre = T00099_A25ExamenCarrAsigAsignaturaNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25ExamenCarrAsigAsignaturaNombre", A25ExamenCarrAsigAsignaturaNombre);
         pr_default.close(7);
      }

      protected void CloseExtendedTableCursors097( )
      {
         pr_default.close(6);
         pr_default.close(7);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_16( short A22ExamenCarrAsigCarreraId )
      {
         /* Using cursor T000911 */
         pr_default.execute(9, new Object[] {A22ExamenCarrAsigCarreraId});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No matching 'Examen Carr Asig'.", "ForeignKeyNotFound", 1, "EXAMENCARRASIGCARRERAID");
            AnyError = 1;
            GX_FocusControl = edtExamenCarrAsigCarreraId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A23ExamenCarrAsigCarreraNombre = T000911_A23ExamenCarrAsigCarreraNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23ExamenCarrAsigCarreraNombre", A23ExamenCarrAsigCarreraNombre);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A23ExamenCarrAsigCarreraNombre))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(9) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(9);
      }

      protected void gxLoad_17( short A22ExamenCarrAsigCarreraId ,
                                short A24ExamenCarrAsigAsignaturaId )
      {
         /* Using cursor T000912 */
         pr_default.execute(10, new Object[] {A22ExamenCarrAsigCarreraId, A24ExamenCarrAsigAsignaturaId});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No matching 'Examen Carr Asig'.", "ForeignKeyNotFound", 1, "EXAMENCARRASIGCARRERAID");
            AnyError = 1;
            GX_FocusControl = edtExamenCarrAsigCarreraId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A25ExamenCarrAsigAsignaturaNombre = T000912_A25ExamenCarrAsigAsignaturaNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25ExamenCarrAsigAsignaturaNombre", A25ExamenCarrAsigAsignaturaNombre);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A25ExamenCarrAsigAsignaturaNombre))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(10) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(10);
      }

      protected void GetKey097( )
      {
         /* Using cursor T000913 */
         pr_default.execute(11, new Object[] {A17ExamenId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound7 = 1;
         }
         else
         {
            RcdFound7 = 0;
         }
         pr_default.close(11);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00097 */
         pr_default.execute(5, new Object[] {A17ExamenId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            ZM097( 15) ;
            RcdFound7 = 1;
            A17ExamenId = T00097_A17ExamenId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
            A26ExamenFecha = T00097_A26ExamenFecha[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
            A22ExamenCarrAsigCarreraId = T00097_A22ExamenCarrAsigCarreraId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
            A24ExamenCarrAsigAsignaturaId = T00097_A24ExamenCarrAsigAsignaturaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
            Z17ExamenId = A17ExamenId;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load097( ) ;
            if ( AnyError == 1 )
            {
               RcdFound7 = 0;
               InitializeNonKey097( ) ;
            }
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound7 = 0;
            InitializeNonKey097( ) ;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(5);
      }

      protected void getEqualNoModal( )
      {
         GetKey097( ) ;
         if ( RcdFound7 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound7 = 0;
         /* Using cursor T000914 */
         pr_default.execute(12, new Object[] {A17ExamenId});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( ( T000914_A17ExamenId[0] < A17ExamenId ) ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( ( T000914_A17ExamenId[0] > A17ExamenId ) ) )
            {
               A17ExamenId = T000914_A17ExamenId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
               RcdFound7 = 1;
            }
         }
         pr_default.close(12);
      }

      protected void move_previous( )
      {
         RcdFound7 = 0;
         /* Using cursor T000915 */
         pr_default.execute(13, new Object[] {A17ExamenId});
         if ( (pr_default.getStatus(13) != 101) )
         {
            while ( (pr_default.getStatus(13) != 101) && ( ( T000915_A17ExamenId[0] > A17ExamenId ) ) )
            {
               pr_default.readNext(13);
            }
            if ( (pr_default.getStatus(13) != 101) && ( ( T000915_A17ExamenId[0] < A17ExamenId ) ) )
            {
               A17ExamenId = T000915_A17ExamenId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
               RcdFound7 = 1;
            }
         }
         pr_default.close(13);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey097( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtExamenId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert097( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound7 == 1 )
            {
               if ( A17ExamenId != Z17ExamenId )
               {
                  A17ExamenId = Z17ExamenId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "EXAMENID");
                  AnyError = 1;
                  GX_FocusControl = edtExamenId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtExamenId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update097( ) ;
                  GX_FocusControl = edtExamenId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A17ExamenId != Z17ExamenId )
               {
                  /* Insert record */
                  GX_FocusControl = edtExamenId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert097( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "EXAMENID");
                     AnyError = 1;
                     GX_FocusControl = edtExamenId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtExamenId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert097( ) ;
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
         if ( A17ExamenId != Z17ExamenId )
         {
            A17ExamenId = Z17ExamenId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "EXAMENID");
            AnyError = 1;
            GX_FocusControl = edtExamenId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtExamenId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency097( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00096 */
            pr_default.execute(4, new Object[] {A17ExamenId});
            if ( (pr_default.getStatus(4) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Examen"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(4) == 101) || ( Z26ExamenFecha != T00096_A26ExamenFecha[0] ) || ( Z22ExamenCarrAsigCarreraId != T00096_A22ExamenCarrAsigCarreraId[0] ) || ( Z24ExamenCarrAsigAsignaturaId != T00096_A24ExamenCarrAsigAsignaturaId[0] ) )
            {
               if ( Z26ExamenFecha != T00096_A26ExamenFecha[0] )
               {
                  GXUtil.WriteLog("examen:[seudo value changed for attri]"+"ExamenFecha");
                  GXUtil.WriteLogRaw("Old: ",Z26ExamenFecha);
                  GXUtil.WriteLogRaw("Current: ",T00096_A26ExamenFecha[0]);
               }
               if ( Z22ExamenCarrAsigCarreraId != T00096_A22ExamenCarrAsigCarreraId[0] )
               {
                  GXUtil.WriteLog("examen:[seudo value changed for attri]"+"ExamenCarrAsigCarreraId");
                  GXUtil.WriteLogRaw("Old: ",Z22ExamenCarrAsigCarreraId);
                  GXUtil.WriteLogRaw("Current: ",T00096_A22ExamenCarrAsigCarreraId[0]);
               }
               if ( Z24ExamenCarrAsigAsignaturaId != T00096_A24ExamenCarrAsigAsignaturaId[0] )
               {
                  GXUtil.WriteLog("examen:[seudo value changed for attri]"+"ExamenCarrAsigAsignaturaId");
                  GXUtil.WriteLogRaw("Old: ",Z24ExamenCarrAsigAsignaturaId);
                  GXUtil.WriteLogRaw("Current: ",T00096_A24ExamenCarrAsigAsignaturaId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Examen"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert097( )
      {
         BeforeValidate097( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable097( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM097( 0) ;
            CheckOptimisticConcurrency097( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm097( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert097( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000916 */
                     pr_default.execute(14, new Object[] {A17ExamenId, A26ExamenFecha, A22ExamenCarrAsigCarreraId, A24ExamenCarrAsigAsignaturaId});
                     pr_default.close(14);
                     dsDefault.SmartCacheProvider.SetUpdated("Examen") ;
                     if ( (pr_default.getStatus(14) == 1) )
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
                           ProcessLevel097( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption090( ) ;
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
               Load097( ) ;
            }
            EndLevel097( ) ;
         }
         CloseExtendedTableCursors097( ) ;
      }

      protected void Update097( )
      {
         BeforeValidate097( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable097( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency097( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm097( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate097( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000917 */
                     pr_default.execute(15, new Object[] {A26ExamenFecha, A22ExamenCarrAsigCarreraId, A24ExamenCarrAsigAsignaturaId, A17ExamenId});
                     pr_default.close(15);
                     dsDefault.SmartCacheProvider.SetUpdated("Examen") ;
                     if ( (pr_default.getStatus(15) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Examen"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate097( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel097( ) ;
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
            EndLevel097( ) ;
         }
         CloseExtendedTableCursors097( ) ;
      }

      protected void DeferredUpdate097( )
      {
      }

      protected void delete( )
      {
         BeforeValidate097( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency097( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls097( ) ;
            AfterConfirm097( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete097( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart099( ) ;
                  while ( RcdFound9 != 0 )
                  {
                     getByPrimaryKey099( ) ;
                     Delete099( ) ;
                     ScanNext099( ) ;
                  }
                  ScanEnd099( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000918 */
                     pr_default.execute(16, new Object[] {A17ExamenId});
                     pr_default.close(16);
                     dsDefault.SmartCacheProvider.SetUpdated("Examen") ;
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
         sMode7 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel097( ) ;
         Gx_mode = sMode7;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls097( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV14Pgmname = "Examen";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
            /* Using cursor T000919 */
            pr_default.execute(17, new Object[] {A22ExamenCarrAsigCarreraId});
            A23ExamenCarrAsigCarreraNombre = T000919_A23ExamenCarrAsigCarreraNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23ExamenCarrAsigCarreraNombre", A23ExamenCarrAsigCarreraNombre);
            pr_default.close(17);
            /* Using cursor T000920 */
            pr_default.execute(18, new Object[] {A22ExamenCarrAsigCarreraId, A24ExamenCarrAsigAsignaturaId});
            A25ExamenCarrAsigAsignaturaNombre = T000920_A25ExamenCarrAsigAsignaturaNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25ExamenCarrAsigAsignaturaNombre", A25ExamenCarrAsigAsignaturaNombre);
            pr_default.close(18);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000921 */
            pr_default.execute(19, new Object[] {A17ExamenId});
            if ( (pr_default.getStatus(19) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Certificado"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(19);
         }
      }

      protected void ProcessNestedLevel099( )
      {
         nGXsfl_68_idx = 0;
         while ( nGXsfl_68_idx < nRC_GXsfl_68 )
         {
            ReadRow099( ) ;
            if ( ( nRcdExists_9 != 0 ) || ( nIsMod_9 != 0 ) )
            {
               standaloneNotModal099( ) ;
               GetKey099( ) ;
               if ( ( nRcdExists_9 == 0 ) && ( nRcdDeleted_9 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert099( ) ;
               }
               else
               {
                  if ( RcdFound9 != 0 )
                  {
                     if ( ( nRcdDeleted_9 != 0 ) && ( nRcdExists_9 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete099( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_9 != 0 ) && ( nRcdExists_9 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update099( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_9 == 0 )
                     {
                        GXCCtl = "ESTUDIANTEID_" + sGXsfl_68_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtEstudianteId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtEstudianteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A15EstudianteId), 4, 0, ".", ""))) ;
            ChangePostValue( edtEstudianteNombre_Internalname, StringUtil.RTrim( A18EstudianteNombre)) ;
            ChangePostValue( edtCarreraId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8CarreraId), 4, 0, ".", ""))) ;
            ChangePostValue( edtCarreraNombre_Internalname, StringUtil.RTrim( A9CarreraNombre)) ;
            ChangePostValue( edtExamenEstudianteNota_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ExamenEstudianteNota), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z15EstudianteId_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15EstudianteId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z27ExamenEstudianteNota_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z27ExamenEstudianteNota), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_9_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_9), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_9_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_9), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_9_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_9), 4, 0, ".", ""))) ;
            if ( nIsMod_9 != 0 )
            {
               ChangePostValue( "ESTUDIANTEID_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEstudianteId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ESTUDIANTENOMBRE_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEstudianteNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CARRERAID_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCarreraId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CARRERANOMBRE_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCarreraNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EXAMENESTUDIANTENOTA_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExamenEstudianteNota_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll099( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_9 = 0;
         nIsMod_9 = 0;
         nRcdDeleted_9 = 0;
      }

      protected void ProcessLevel097( )
      {
         /* Save parent mode. */
         sMode7 = Gx_mode;
         ProcessNestedLevel099( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode7;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
      }

      protected void EndLevel097( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(4);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete097( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(17);
            pr_default.close(18);
            pr_default.close(2);
            pr_default.close(3);
            context.CommitDataStores("examen",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues090( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(17);
            pr_default.close(18);
            pr_default.close(2);
            pr_default.close(3);
            context.RollbackDataStores("examen",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart097( )
      {
         /* Scan By routine */
         /* Using cursor T000922 */
         pr_default.execute(20);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound7 = 1;
            A17ExamenId = T000922_A17ExamenId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext097( )
      {
         /* Scan next routine */
         pr_default.readNext(20);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound7 = 1;
            A17ExamenId = T000922_A17ExamenId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
         }
      }

      protected void ScanEnd097( )
      {
         pr_default.close(20);
      }

      protected void AfterConfirm097( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert097( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate097( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete097( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete097( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate097( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes097( )
      {
         edtExamenId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenId_Enabled), 5, 0)), true);
         edtExamenFecha_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenFecha_Enabled), 5, 0)), true);
         edtExamenCarrAsigCarreraId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenCarrAsigCarreraId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenCarrAsigCarreraId_Enabled), 5, 0)), true);
         edtExamenCarrAsigCarreraNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenCarrAsigCarreraNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenCarrAsigCarreraNombre_Enabled), 5, 0)), true);
         edtExamenCarrAsigAsignaturaId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenCarrAsigAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenCarrAsigAsignaturaId_Enabled), 5, 0)), true);
         edtExamenCarrAsigAsignaturaNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenCarrAsigAsignaturaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenCarrAsigAsignaturaNombre_Enabled), 5, 0)), true);
         edtCarreraId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarreraId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarreraId_Enabled), 5, 0)), !bGXsfl_68_Refreshing);
      }

      protected void ZM099( short GX_JID )
      {
         if ( ( GX_JID == 18 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z27ExamenEstudianteNota = T00093_A27ExamenEstudianteNota[0];
            }
            else
            {
               Z27ExamenEstudianteNota = A27ExamenEstudianteNota;
            }
         }
         if ( GX_JID == -18 )
         {
            Z17ExamenId = A17ExamenId;
            Z27ExamenEstudianteNota = A27ExamenEstudianteNota;
            Z15EstudianteId = A15EstudianteId;
            Z18EstudianteNombre = A18EstudianteNombre;
            Z8CarreraId = A8CarreraId;
            Z9CarreraNombre = A9CarreraNombre;
         }
      }

      protected void standaloneNotModal099( )
      {
      }

      protected void standaloneModal099( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtEstudianteId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteId_Enabled), 5, 0)), !bGXsfl_68_Refreshing);
         }
         else
         {
            edtEstudianteId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteId_Enabled), 5, 0)), !bGXsfl_68_Refreshing);
         }
      }

      protected void Load099( )
      {
         /* Using cursor T000923 */
         pr_default.execute(21, new Object[] {A17ExamenId, A15EstudianteId});
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound9 = 1;
            A18EstudianteNombre = T000923_A18EstudianteNombre[0];
            A9CarreraNombre = T000923_A9CarreraNombre[0];
            A27ExamenEstudianteNota = T000923_A27ExamenEstudianteNota[0];
            A8CarreraId = T000923_A8CarreraId[0];
            ZM099( -18) ;
         }
         pr_default.close(21);
         OnLoadActions099( ) ;
      }

      protected void OnLoadActions099( )
      {
      }

      protected void CheckExtendedTable099( )
      {
         Gx_BScreen = 1;
         standaloneModal099( ) ;
         /* Using cursor T00094 */
         pr_default.execute(2, new Object[] {A15EstudianteId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "ESTUDIANTEID_" + sGXsfl_68_idx;
            GX_msglist.addItem("No matching 'Estudiante'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtEstudianteId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A18EstudianteNombre = T00094_A18EstudianteNombre[0];
         A8CarreraId = T00094_A8CarreraId[0];
         pr_default.close(2);
         /* Using cursor T00095 */
         pr_default.execute(3, new Object[] {A8CarreraId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No matching 'Carrera'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A9CarreraNombre = T00095_A9CarreraNombre[0];
         pr_default.close(3);
         if ( A22ExamenCarrAsigCarreraId != A8CarreraId )
         {
            GX_msglist.addItem("El estudiante no esta registrado en esta carrera", 1, "EXAMENCARRASIGCARRERAID");
            AnyError = 1;
            GX_FocusControl = edtExamenCarrAsigCarreraId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors099( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable099( )
      {
      }

      protected void gxLoad_19( short A15EstudianteId )
      {
         /* Using cursor T000924 */
         pr_default.execute(22, new Object[] {A15EstudianteId});
         if ( (pr_default.getStatus(22) == 101) )
         {
            GXCCtl = "ESTUDIANTEID_" + sGXsfl_68_idx;
            GX_msglist.addItem("No matching 'Estudiante'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtEstudianteId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A18EstudianteNombre = T000924_A18EstudianteNombre[0];
         A8CarreraId = T000924_A8CarreraId[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A18EstudianteNombre))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A8CarreraId), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(22) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(22);
      }

      protected void gxLoad_20( short A8CarreraId )
      {
         /* Using cursor T000925 */
         pr_default.execute(23, new Object[] {A8CarreraId});
         if ( (pr_default.getStatus(23) == 101) )
         {
            GX_msglist.addItem("No matching 'Carrera'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A9CarreraNombre = T000925_A9CarreraNombre[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A9CarreraNombre))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(23) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(23);
      }

      protected void GetKey099( )
      {
         /* Using cursor T000926 */
         pr_default.execute(24, new Object[] {A17ExamenId, A15EstudianteId});
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound9 = 1;
         }
         else
         {
            RcdFound9 = 0;
         }
         pr_default.close(24);
      }

      protected void getByPrimaryKey099( )
      {
         /* Using cursor T00093 */
         pr_default.execute(1, new Object[] {A17ExamenId, A15EstudianteId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM099( 18) ;
            RcdFound9 = 1;
            InitializeNonKey099( ) ;
            A27ExamenEstudianteNota = T00093_A27ExamenEstudianteNota[0];
            A15EstudianteId = T00093_A15EstudianteId[0];
            Z17ExamenId = A17ExamenId;
            Z15EstudianteId = A15EstudianteId;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load099( ) ;
            Gx_mode = sMode9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound9 = 0;
            InitializeNonKey099( ) ;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal099( ) ;
            Gx_mode = sMode9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes099( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency099( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00092 */
            pr_default.execute(0, new Object[] {A17ExamenId, A15EstudianteId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ExamenEstudiiante"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z27ExamenEstudianteNota != T00092_A27ExamenEstudianteNota[0] ) )
            {
               if ( Z27ExamenEstudianteNota != T00092_A27ExamenEstudianteNota[0] )
               {
                  GXUtil.WriteLog("examen:[seudo value changed for attri]"+"ExamenEstudianteNota");
                  GXUtil.WriteLogRaw("Old: ",Z27ExamenEstudianteNota);
                  GXUtil.WriteLogRaw("Current: ",T00092_A27ExamenEstudianteNota[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ExamenEstudiiante"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert099( )
      {
         BeforeValidate099( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable099( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM099( 0) ;
            CheckOptimisticConcurrency099( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm099( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert099( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000927 */
                     pr_default.execute(25, new Object[] {A17ExamenId, A27ExamenEstudianteNota, A15EstudianteId});
                     pr_default.close(25);
                     dsDefault.SmartCacheProvider.SetUpdated("ExamenEstudiiante") ;
                     if ( (pr_default.getStatus(25) == 1) )
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
               Load099( ) ;
            }
            EndLevel099( ) ;
         }
         CloseExtendedTableCursors099( ) ;
      }

      protected void Update099( )
      {
         BeforeValidate099( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable099( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency099( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm099( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate099( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000928 */
                     pr_default.execute(26, new Object[] {A27ExamenEstudianteNota, A17ExamenId, A15EstudianteId});
                     pr_default.close(26);
                     dsDefault.SmartCacheProvider.SetUpdated("ExamenEstudiiante") ;
                     if ( (pr_default.getStatus(26) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ExamenEstudiiante"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate099( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey099( ) ;
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
            EndLevel099( ) ;
         }
         CloseExtendedTableCursors099( ) ;
      }

      protected void DeferredUpdate099( )
      {
      }

      protected void Delete099( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate099( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency099( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls099( ) ;
            AfterConfirm099( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete099( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000929 */
                  pr_default.execute(27, new Object[] {A17ExamenId, A15EstudianteId});
                  pr_default.close(27);
                  dsDefault.SmartCacheProvider.SetUpdated("ExamenEstudiiante") ;
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
         sMode9 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel099( ) ;
         Gx_mode = sMode9;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls099( )
      {
         standaloneModal099( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000930 */
            pr_default.execute(28, new Object[] {A15EstudianteId});
            A18EstudianteNombre = T000930_A18EstudianteNombre[0];
            A8CarreraId = T000930_A8CarreraId[0];
            pr_default.close(28);
            /* Using cursor T000931 */
            pr_default.execute(29, new Object[] {A8CarreraId});
            A9CarreraNombre = T000931_A9CarreraNombre[0];
            pr_default.close(29);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000932 */
            pr_default.execute(30, new Object[] {A17ExamenId, A15EstudianteId});
            if ( (pr_default.getStatus(30) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Certificado"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(30);
         }
      }

      protected void EndLevel099( )
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

      public void ScanStart099( )
      {
         /* Scan By routine */
         /* Using cursor T000933 */
         pr_default.execute(31, new Object[] {A17ExamenId});
         RcdFound9 = 0;
         if ( (pr_default.getStatus(31) != 101) )
         {
            RcdFound9 = 1;
            A15EstudianteId = T000933_A15EstudianteId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext099( )
      {
         /* Scan next routine */
         pr_default.readNext(31);
         RcdFound9 = 0;
         if ( (pr_default.getStatus(31) != 101) )
         {
            RcdFound9 = 1;
            A15EstudianteId = T000933_A15EstudianteId[0];
         }
      }

      protected void ScanEnd099( )
      {
         pr_default.close(31);
      }

      protected void AfterConfirm099( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert099( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate099( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete099( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete099( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate099( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes099( )
      {
         edtEstudianteId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteId_Enabled), 5, 0)), !bGXsfl_68_Refreshing);
         edtEstudianteNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteNombre_Enabled), 5, 0)), !bGXsfl_68_Refreshing);
         edtCarreraNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarreraNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarreraNombre_Enabled), 5, 0)), !bGXsfl_68_Refreshing);
         edtExamenEstudianteNota_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExamenEstudianteNota_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExamenEstudianteNota_Enabled), 5, 0)), !bGXsfl_68_Refreshing);
      }

      protected void send_integrity_lvl_hashes099( )
      {
      }

      protected void send_integrity_lvl_hashes097( )
      {
      }

      protected void SubsflControlProps_689( )
      {
         edtEstudianteId_Internalname = "ESTUDIANTEID_"+sGXsfl_68_idx;
         imgprompt_15_Internalname = "PROMPT_15_"+sGXsfl_68_idx;
         edtEstudianteNombre_Internalname = "ESTUDIANTENOMBRE_"+sGXsfl_68_idx;
         edtCarreraId_Internalname = "CARRERAID_"+sGXsfl_68_idx;
         edtCarreraNombre_Internalname = "CARRERANOMBRE_"+sGXsfl_68_idx;
         edtExamenEstudianteNota_Internalname = "EXAMENESTUDIANTENOTA_"+sGXsfl_68_idx;
      }

      protected void SubsflControlProps_fel_689( )
      {
         edtEstudianteId_Internalname = "ESTUDIANTEID_"+sGXsfl_68_fel_idx;
         imgprompt_15_Internalname = "PROMPT_15_"+sGXsfl_68_fel_idx;
         edtEstudianteNombre_Internalname = "ESTUDIANTENOMBRE_"+sGXsfl_68_fel_idx;
         edtCarreraId_Internalname = "CARRERAID_"+sGXsfl_68_fel_idx;
         edtCarreraNombre_Internalname = "CARRERANOMBRE_"+sGXsfl_68_fel_idx;
         edtExamenEstudianteNota_Internalname = "EXAMENESTUDIANTENOTA_"+sGXsfl_68_fel_idx;
      }

      protected void AddRow099( )
      {
         nGXsfl_68_idx = (short)(nGXsfl_68_idx+1);
         sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_68_idx), 4, 0)), 4, "0");
         SubsflControlProps_689( ) ;
         SendRow099( ) ;
      }

      protected void SendRow099( )
      {
         Gridexamen_estudiianteRow = GXWebRow.GetNew(context);
         if ( subGridexamen_estudiiante_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridexamen_estudiiante_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridexamen_estudiiante_Class, "") != 0 )
            {
               subGridexamen_estudiiante_Linesclass = subGridexamen_estudiiante_Class+"Odd";
            }
         }
         else if ( subGridexamen_estudiiante_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridexamen_estudiiante_Backstyle = 0;
            subGridexamen_estudiiante_Backcolor = subGridexamen_estudiiante_Allbackcolor;
            if ( StringUtil.StrCmp(subGridexamen_estudiiante_Class, "") != 0 )
            {
               subGridexamen_estudiiante_Linesclass = subGridexamen_estudiiante_Class+"Uniform";
            }
         }
         else if ( subGridexamen_estudiiante_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridexamen_estudiiante_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridexamen_estudiiante_Class, "") != 0 )
            {
               subGridexamen_estudiiante_Linesclass = subGridexamen_estudiiante_Class+"Odd";
            }
            subGridexamen_estudiiante_Backcolor = (int)(0x0);
         }
         else if ( subGridexamen_estudiiante_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridexamen_estudiiante_Backstyle = 1;
            if ( ((int)(((nGXsfl_68_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridexamen_estudiiante_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridexamen_estudiiante_Class, "") != 0 )
               {
                  subGridexamen_estudiiante_Linesclass = subGridexamen_estudiiante_Class+"Odd";
               }
            }
            else
            {
               subGridexamen_estudiiante_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridexamen_estudiiante_Class, "") != 0 )
               {
                  subGridexamen_estudiiante_Linesclass = subGridexamen_estudiiante_Class+"Even";
               }
            }
         }
         imgprompt_15_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0)||(StringUtil.StrCmp(Gx_mode, "UPD")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0050.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ESTUDIANTEID_"+sGXsfl_68_idx+"'), id:'"+"ESTUDIANTEID_"+sGXsfl_68_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_9_"+sGXsfl_68_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_9_" + sGXsfl_68_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_68_idx + "',68)\"";
         ROClassString = "Attribute";
         Gridexamen_estudiianteRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEstudianteId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A15EstudianteId), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A15EstudianteId), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEstudianteId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtEstudianteId_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)68,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
         Gridexamen_estudiianteRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_15_Internalname,(String)sImgUrl,(String)imgprompt_15_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_15_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridexamen_estudiianteRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEstudianteNombre_Internalname,StringUtil.RTrim( A18EstudianteNombre),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEstudianteNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtEstudianteNombre_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)68,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridexamen_estudiianteRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCarreraId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A8CarreraId), 4, 0, ".", "")),((edtCarreraId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A8CarreraId), "ZZZ9")) : context.localUtil.Format( (decimal)(A8CarreraId), "ZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtCarreraId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtCarreraId_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)68,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridexamen_estudiianteRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCarreraNombre_Internalname,StringUtil.RTrim( A9CarreraNombre),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtCarreraNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtCarreraNombre_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)68,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_9_" + sGXsfl_68_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_68_idx + "',68)\"";
         ROClassString = "Attribute";
         Gridexamen_estudiianteRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtExamenEstudianteNota_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A27ExamenEstudianteNota), 4, 0, ".", "")),((edtExamenEstudianteNota_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A27ExamenEstudianteNota), "ZZZ9")) : context.localUtil.Format( (decimal)(A27ExamenEstudianteNota), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtExamenEstudianteNota_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtExamenEstudianteNota_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)68,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         context.httpAjaxContext.ajax_sending_grid_row(Gridexamen_estudiianteRow);
         send_integrity_lvl_hashes099( ) ;
         GXCCtl = "Z15EstudianteId_" + sGXsfl_68_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15EstudianteId), 4, 0, ".", "")));
         GXCCtl = "Z27ExamenEstudianteNota_" + sGXsfl_68_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z27ExamenEstudianteNota), 4, 0, ".", "")));
         GXCCtl = "nRcdDeleted_9_" + sGXsfl_68_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_9), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_9_" + sGXsfl_68_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_9), 4, 0, ".", "")));
         GXCCtl = "nIsMod_9_" + sGXsfl_68_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_9), 4, 0, ".", "")));
         GXCCtl = "vMODE_" + sGXsfl_68_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_68_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV9TrnContext);
         }
         GXCCtl = "vEXAMENID_" + sGXsfl_68_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ExamenId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ESTUDIANTEID_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEstudianteId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ESTUDIANTENOMBRE_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEstudianteNombre_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CARRERAID_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCarreraId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CARRERANOMBRE_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCarreraNombre_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "EXAMENESTUDIANTENOTA_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExamenEstudianteNota_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_15_"+sGXsfl_68_idx+"Link", StringUtil.RTrim( imgprompt_15_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridexamen_estudiianteContainer.AddRow(Gridexamen_estudiianteRow);
      }

      protected void ReadRow099( )
      {
         nGXsfl_68_idx = (short)(nGXsfl_68_idx+1);
         sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_68_idx), 4, 0)), 4, "0");
         SubsflControlProps_689( ) ;
         edtEstudianteId_Enabled = (int)(context.localUtil.CToN( cgiGet( "ESTUDIANTEID_"+sGXsfl_68_idx+"Enabled"), ".", ","));
         edtEstudianteNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "ESTUDIANTENOMBRE_"+sGXsfl_68_idx+"Enabled"), ".", ","));
         edtCarreraId_Enabled = (int)(context.localUtil.CToN( cgiGet( "CARRERAID_"+sGXsfl_68_idx+"Enabled"), ".", ","));
         edtCarreraNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "CARRERANOMBRE_"+sGXsfl_68_idx+"Enabled"), ".", ","));
         edtExamenEstudianteNota_Enabled = (int)(context.localUtil.CToN( cgiGet( "EXAMENESTUDIANTENOTA_"+sGXsfl_68_idx+"Enabled"), ".", ","));
         imgprompt_22_Link = cgiGet( "PROMPT_15_"+sGXsfl_68_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtEstudianteId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtEstudianteId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "ESTUDIANTEID_" + sGXsfl_68_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtEstudianteId_Internalname;
            wbErr = true;
            A15EstudianteId = 0;
         }
         else
         {
            A15EstudianteId = (short)(context.localUtil.CToN( cgiGet( edtEstudianteId_Internalname), ".", ","));
         }
         A18EstudianteNombre = cgiGet( edtEstudianteNombre_Internalname);
         A8CarreraId = (short)(context.localUtil.CToN( cgiGet( edtCarreraId_Internalname), ".", ","));
         A9CarreraNombre = cgiGet( edtCarreraNombre_Internalname);
         if ( ( ( context.localUtil.CToN( cgiGet( edtExamenEstudianteNota_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtExamenEstudianteNota_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "EXAMENESTUDIANTENOTA_" + sGXsfl_68_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtExamenEstudianteNota_Internalname;
            wbErr = true;
            A27ExamenEstudianteNota = 0;
         }
         else
         {
            A27ExamenEstudianteNota = (short)(context.localUtil.CToN( cgiGet( edtExamenEstudianteNota_Internalname), ".", ","));
         }
         GXCCtl = "Z15EstudianteId_" + sGXsfl_68_idx;
         Z15EstudianteId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "Z27ExamenEstudianteNota_" + sGXsfl_68_idx;
         Z27ExamenEstudianteNota = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdDeleted_9_" + sGXsfl_68_idx;
         nRcdDeleted_9 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdExists_9_" + sGXsfl_68_idx;
         nRcdExists_9 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nIsMod_9_" + sGXsfl_68_idx;
         nIsMod_9 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
      }

      protected void assign_properties_default( )
      {
         defedtEstudianteId_Enabled = edtEstudianteId_Enabled;
      }

      protected void ConfirmValues090( )
      {
         nGXsfl_68_idx = 0;
         sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_68_idx), 4, 0)), 4, "0");
         SubsflControlProps_689( ) ;
         while ( nGXsfl_68_idx < nRC_GXsfl_68 )
         {
            nGXsfl_68_idx = (short)(nGXsfl_68_idx+1);
            sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_68_idx), 4, 0)), 4, "0");
            SubsflControlProps_689( ) ;
            ChangePostValue( "Z15EstudianteId_"+sGXsfl_68_idx, cgiGet( "ZT_"+"Z15EstudianteId_"+sGXsfl_68_idx)) ;
            DeletePostValue( "ZT_"+"Z15EstudianteId_"+sGXsfl_68_idx) ;
            ChangePostValue( "Z27ExamenEstudianteNota_"+sGXsfl_68_idx, cgiGet( "ZT_"+"Z27ExamenEstudianteNota_"+sGXsfl_68_idx)) ;
            DeletePostValue( "ZT_"+"Z27ExamenEstudianteNota_"+sGXsfl_68_idx) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202010222161437", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("examen.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7ExamenId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Examen";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_ExamenCarrAsigCarreraId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12Insert_ExamenCarrAsigAsignaturaId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("examen:[SendSecurityCheck value for]"+"Insert_ExamenCarrAsigCarreraId:"+context.localUtil.Format( (decimal)(AV11Insert_ExamenCarrAsigCarreraId), "ZZZ9"));
         GXUtil.WriteLog("examen:[SendSecurityCheck value for]"+"Insert_ExamenCarrAsigAsignaturaId:"+context.localUtil.Format( (decimal)(AV12Insert_ExamenCarrAsigAsignaturaId), "ZZZ9"));
         GXUtil.WriteLog("examen:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z17ExamenId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17ExamenId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z26ExamenFecha", context.localUtil.DToC( Z26ExamenFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22ExamenCarrAsigCarreraId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z24ExamenCarrAsigAsignaturaId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_68", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_68_idx), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vEXAMENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ExamenId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vEXAMENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ExamenId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_EXAMENCARRASIGCARRERAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_ExamenCarrAsigCarreraId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_EXAMENCARRASIGASIGNATURAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12Insert_ExamenCarrAsigAsignaturaId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV14Pgmname));
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
         return formatLink("examen.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7ExamenId) ;
      }

      public override String GetPgmname( )
      {
         return "Examen" ;
      }

      public override String GetPgmdesc( )
      {
         return "Examen" ;
      }

      protected void InitializeNonKey097( )
      {
         A22ExamenCarrAsigCarreraId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22ExamenCarrAsigCarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22ExamenCarrAsigCarreraId), 4, 0)));
         A24ExamenCarrAsigAsignaturaId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24ExamenCarrAsigAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A24ExamenCarrAsigAsignaturaId), 4, 0)));
         A8CarreraId = 0;
         A26ExamenFecha = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26ExamenFecha", context.localUtil.Format(A26ExamenFecha, "99/99/99"));
         A23ExamenCarrAsigCarreraNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23ExamenCarrAsigCarreraNombre", A23ExamenCarrAsigCarreraNombre);
         A25ExamenCarrAsigAsignaturaNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25ExamenCarrAsigAsignaturaNombre", A25ExamenCarrAsigAsignaturaNombre);
         Z26ExamenFecha = DateTime.MinValue;
         Z22ExamenCarrAsigCarreraId = 0;
         Z24ExamenCarrAsigAsignaturaId = 0;
      }

      protected void InitAll097( )
      {
         A17ExamenId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ExamenId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17ExamenId), 4, 0)));
         InitializeNonKey097( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey099( )
      {
         A18EstudianteNombre = "";
         A8CarreraId = 0;
         A9CarreraNombre = "";
         A27ExamenEstudianteNota = 0;
         Z27ExamenEstudianteNota = 0;
      }

      protected void InitAll099( )
      {
         A15EstudianteId = 0;
         InitializeNonKey099( ) ;
      }

      protected void StandaloneModalInsert099( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202010222161449", true, true);
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
         context.AddJavascriptSource("examen.js", "?202010222161449", false, true);
         /* End function include_jscripts */
      }

      protected void init_level_properties9( )
      {
         edtEstudianteId_Enabled = defedtEstudianteId_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteId_Enabled), 5, 0)), !bGXsfl_68_Refreshing);
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
         edtExamenId_Internalname = "EXAMENID";
         edtExamenFecha_Internalname = "EXAMENFECHA";
         edtExamenCarrAsigCarreraId_Internalname = "EXAMENCARRASIGCARRERAID";
         edtExamenCarrAsigCarreraNombre_Internalname = "EXAMENCARRASIGCARRERANOMBRE";
         edtExamenCarrAsigAsignaturaId_Internalname = "EXAMENCARRASIGASIGNATURAID";
         edtExamenCarrAsigAsignaturaNombre_Internalname = "EXAMENCARRASIGASIGNATURANOMBRE";
         lblTitleestudiiante_Internalname = "TITLEESTUDIIANTE";
         edtEstudianteId_Internalname = "ESTUDIANTEID";
         edtEstudianteNombre_Internalname = "ESTUDIANTENOMBRE";
         edtCarreraId_Internalname = "CARRERAID";
         edtCarreraNombre_Internalname = "CARRERANOMBRE";
         edtExamenEstudianteNota_Internalname = "EXAMENESTUDIANTENOTA";
         divEstudiiantetable_Internalname = "ESTUDIIANTETABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_22_Internalname = "PROMPT_22";
         imgprompt_24_Internalname = "PROMPT_24";
         imgprompt_15_Internalname = "PROMPT_15";
         subGridexamen_estudiiante_Internalname = "GRIDEXAMEN_ESTUDIIANTE";
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
         Form.Caption = "Examen";
         edtExamenEstudianteNota_Jsonclick = "";
         edtCarreraNombre_Jsonclick = "";
         edtCarreraId_Jsonclick = "";
         edtEstudianteNombre_Jsonclick = "";
         imgprompt_15_Visible = 1;
         imgprompt_15_Link = "";
         imgprompt_22_Visible = 1;
         edtEstudianteId_Jsonclick = "";
         subGridexamen_estudiiante_Class = "Grid";
         subGridexamen_estudiiante_Backcolorstyle = 0;
         subGridexamen_estudiiante_Allowcollapsing = 0;
         subGridexamen_estudiiante_Allowselection = 0;
         edtExamenEstudianteNota_Enabled = 1;
         edtCarreraNombre_Enabled = 0;
         edtCarreraId_Enabled = 0;
         edtEstudianteNombre_Enabled = 0;
         edtEstudianteId_Enabled = 1;
         subGridexamen_estudiiante_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtExamenCarrAsigAsignaturaNombre_Jsonclick = "";
         edtExamenCarrAsigAsignaturaNombre_Enabled = 0;
         imgprompt_24_Visible = 1;
         imgprompt_24_Link = "";
         edtExamenCarrAsigAsignaturaId_Jsonclick = "";
         edtExamenCarrAsigAsignaturaId_Enabled = 1;
         edtExamenCarrAsigCarreraNombre_Jsonclick = "";
         edtExamenCarrAsigCarreraNombre_Enabled = 0;
         imgprompt_22_Visible = 1;
         imgprompt_22_Link = "";
         edtExamenCarrAsigCarreraId_Jsonclick = "";
         edtExamenCarrAsigCarreraId_Enabled = 1;
         edtExamenFecha_Jsonclick = "";
         edtExamenFecha_Enabled = 1;
         edtExamenId_Jsonclick = "";
         edtExamenId_Enabled = 1;
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

      protected void gxnrGridexamen_estudiiante_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_689( ) ;
         while ( nGXsfl_68_idx <= nRC_GXsfl_68 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal099( ) ;
            standaloneModal099( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow099( ) ;
            nGXsfl_68_idx = (short)(nGXsfl_68_idx+1);
            sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_68_idx), 4, 0)), 4, "0");
            SubsflControlProps_689( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridexamen_estudiianteContainer));
         /* End function gxnrGridexamen_estudiiante_newrow */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      public void Valid_Examencarrasigcarreraid( short GX_Parm1 ,
                                                 String GX_Parm2 )
      {
         A22ExamenCarrAsigCarreraId = GX_Parm1;
         A23ExamenCarrAsigCarreraNombre = GX_Parm2;
         /* Using cursor T000919 */
         pr_default.execute(17, new Object[] {A22ExamenCarrAsigCarreraId});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("No matching 'Examen Carr Asig'.", "ForeignKeyNotFound", 1, "EXAMENCARRASIGCARRERAID");
            AnyError = 1;
            GX_FocusControl = edtExamenCarrAsigCarreraId_Internalname;
         }
         A23ExamenCarrAsigCarreraNombre = T000919_A23ExamenCarrAsigCarreraNombre[0];
         pr_default.close(17);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A23ExamenCarrAsigCarreraNombre = "";
         }
         isValidOutput.Add(StringUtil.RTrim( A23ExamenCarrAsigCarreraNombre));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Examencarrasigasignaturaid( short GX_Parm1 ,
                                                    short GX_Parm2 ,
                                                    String GX_Parm3 )
      {
         A22ExamenCarrAsigCarreraId = GX_Parm1;
         A24ExamenCarrAsigAsignaturaId = GX_Parm2;
         A25ExamenCarrAsigAsignaturaNombre = GX_Parm3;
         /* Using cursor T000920 */
         pr_default.execute(18, new Object[] {A22ExamenCarrAsigCarreraId, A24ExamenCarrAsigAsignaturaId});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("No matching 'Examen Carr Asig'.", "ForeignKeyNotFound", 1, "EXAMENCARRASIGCARRERAID");
            AnyError = 1;
            GX_FocusControl = edtExamenCarrAsigCarreraId_Internalname;
         }
         A25ExamenCarrAsigAsignaturaNombre = T000920_A25ExamenCarrAsigAsignaturaNombre[0];
         pr_default.close(18);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A25ExamenCarrAsigAsignaturaNombre = "";
         }
         isValidOutput.Add(StringUtil.RTrim( A25ExamenCarrAsigAsignaturaNombre));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Estudianteid( short GX_Parm1 ,
                                      short GX_Parm2 ,
                                      short GX_Parm3 ,
                                      String GX_Parm4 ,
                                      String GX_Parm5 )
      {
         A15EstudianteId = GX_Parm1;
         A8CarreraId = GX_Parm2;
         A22ExamenCarrAsigCarreraId = GX_Parm3;
         A18EstudianteNombre = GX_Parm4;
         A9CarreraNombre = GX_Parm5;
         /* Using cursor T000930 */
         pr_default.execute(28, new Object[] {A15EstudianteId});
         if ( (pr_default.getStatus(28) == 101) )
         {
            GX_msglist.addItem("No matching 'Estudiante'.", "ForeignKeyNotFound", 1, "ESTUDIANTEID");
            AnyError = 1;
            GX_FocusControl = edtEstudianteId_Internalname;
         }
         A18EstudianteNombre = T000930_A18EstudianteNombre[0];
         A8CarreraId = T000930_A8CarreraId[0];
         pr_default.close(28);
         /* Using cursor T000931 */
         pr_default.execute(29, new Object[] {A8CarreraId});
         if ( (pr_default.getStatus(29) == 101) )
         {
            GX_msglist.addItem("No matching 'Carrera'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A9CarreraNombre = T000931_A9CarreraNombre[0];
         pr_default.close(29);
         if ( A22ExamenCarrAsigCarreraId != A8CarreraId )
         {
            GX_msglist.addItem("El estudiante no esta registrado en esta carrera", 1, "ESTUDIANTEID");
            AnyError = 1;
            GX_FocusControl = edtEstudianteId_Internalname;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A18EstudianteNombre = "";
            A8CarreraId = 0;
            A9CarreraNombre = "";
         }
         isValidOutput.Add(StringUtil.RTrim( A18EstudianteNombre));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A8CarreraId), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.RTrim( A9CarreraNombre));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7ExamenId',fld:'vEXAMENID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7ExamenId',fld:'vEXAMENID',pic:'ZZZ9',hsh:true},{av:'AV11Insert_ExamenCarrAsigCarreraId',fld:'vINSERT_EXAMENCARRASIGCARRERAID',pic:'ZZZ9'},{av:'AV12Insert_ExamenCarrAsigAsignaturaId',fld:'vINSERT_EXAMENCARRASIGASIGNATURAID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12092',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(28);
         pr_default.close(29);
         pr_default.close(5);
         pr_default.close(17);
         pr_default.close(18);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z26ExamenFecha = DateTime.MinValue;
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
         A26ExamenFecha = DateTime.MinValue;
         sImgUrl = "";
         A23ExamenCarrAsigCarreraNombre = "";
         A25ExamenCarrAsigAsignaturaNombre = "";
         lblTitleestudiiante_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridexamen_estudiianteContainer = new GXWebGrid( context);
         Gridexamen_estudiianteColumn = new GXWebColumn();
         A18EstudianteNombre = "";
         A9CarreraNombre = "";
         sMode9 = "";
         sStyleString = "";
         AV14Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode7 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV13TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z23ExamenCarrAsigCarreraNombre = "";
         Z25ExamenCarrAsigAsignaturaNombre = "";
         T00098_A23ExamenCarrAsigCarreraNombre = new String[] {""} ;
         T00099_A25ExamenCarrAsigAsignaturaNombre = new String[] {""} ;
         T000910_A17ExamenId = new short[1] ;
         T000910_A26ExamenFecha = new DateTime[] {DateTime.MinValue} ;
         T000910_A23ExamenCarrAsigCarreraNombre = new String[] {""} ;
         T000910_A22ExamenCarrAsigCarreraId = new short[1] ;
         T000910_A24ExamenCarrAsigAsignaturaId = new short[1] ;
         T000910_A25ExamenCarrAsigAsignaturaNombre = new String[] {""} ;
         T000911_A23ExamenCarrAsigCarreraNombre = new String[] {""} ;
         T000912_A25ExamenCarrAsigAsignaturaNombre = new String[] {""} ;
         T000913_A17ExamenId = new short[1] ;
         T00097_A17ExamenId = new short[1] ;
         T00097_A26ExamenFecha = new DateTime[] {DateTime.MinValue} ;
         T00097_A22ExamenCarrAsigCarreraId = new short[1] ;
         T00097_A24ExamenCarrAsigAsignaturaId = new short[1] ;
         T000914_A17ExamenId = new short[1] ;
         T000915_A17ExamenId = new short[1] ;
         T00096_A17ExamenId = new short[1] ;
         T00096_A26ExamenFecha = new DateTime[] {DateTime.MinValue} ;
         T00096_A22ExamenCarrAsigCarreraId = new short[1] ;
         T00096_A24ExamenCarrAsigAsignaturaId = new short[1] ;
         T000919_A23ExamenCarrAsigCarreraNombre = new String[] {""} ;
         T000920_A25ExamenCarrAsigAsignaturaNombre = new String[] {""} ;
         T000921_A16CertificadoId = new short[1] ;
         T000922_A17ExamenId = new short[1] ;
         Z18EstudianteNombre = "";
         Z9CarreraNombre = "";
         T000923_A17ExamenId = new short[1] ;
         T000923_A18EstudianteNombre = new String[] {""} ;
         T000923_A9CarreraNombre = new String[] {""} ;
         T000923_A27ExamenEstudianteNota = new short[1] ;
         T000923_A15EstudianteId = new short[1] ;
         T000923_A8CarreraId = new short[1] ;
         T00094_A18EstudianteNombre = new String[] {""} ;
         T00094_A8CarreraId = new short[1] ;
         T00095_A9CarreraNombre = new String[] {""} ;
         T000924_A18EstudianteNombre = new String[] {""} ;
         T000924_A8CarreraId = new short[1] ;
         T000925_A9CarreraNombre = new String[] {""} ;
         T000926_A17ExamenId = new short[1] ;
         T000926_A15EstudianteId = new short[1] ;
         T00093_A17ExamenId = new short[1] ;
         T00093_A27ExamenEstudianteNota = new short[1] ;
         T00093_A15EstudianteId = new short[1] ;
         T00092_A17ExamenId = new short[1] ;
         T00092_A27ExamenEstudianteNota = new short[1] ;
         T00092_A15EstudianteId = new short[1] ;
         T000930_A18EstudianteNombre = new String[] {""} ;
         T000930_A8CarreraId = new short[1] ;
         T000931_A9CarreraNombre = new String[] {""} ;
         T000932_A16CertificadoId = new short[1] ;
         T000933_A17ExamenId = new short[1] ;
         T000933_A15EstudianteId = new short[1] ;
         Gridexamen_estudiianteRow = new GXWebRow();
         subGridexamen_estudiiante_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.examen__default(),
            new Object[][] {
                new Object[] {
               T00092_A17ExamenId, T00092_A27ExamenEstudianteNota, T00092_A15EstudianteId
               }
               , new Object[] {
               T00093_A17ExamenId, T00093_A27ExamenEstudianteNota, T00093_A15EstudianteId
               }
               , new Object[] {
               T00094_A18EstudianteNombre, T00094_A8CarreraId
               }
               , new Object[] {
               T00095_A9CarreraNombre
               }
               , new Object[] {
               T00096_A17ExamenId, T00096_A26ExamenFecha, T00096_A22ExamenCarrAsigCarreraId, T00096_A24ExamenCarrAsigAsignaturaId
               }
               , new Object[] {
               T00097_A17ExamenId, T00097_A26ExamenFecha, T00097_A22ExamenCarrAsigCarreraId, T00097_A24ExamenCarrAsigAsignaturaId
               }
               , new Object[] {
               T00098_A23ExamenCarrAsigCarreraNombre
               }
               , new Object[] {
               T00099_A25ExamenCarrAsigAsignaturaNombre
               }
               , new Object[] {
               T000910_A17ExamenId, T000910_A26ExamenFecha, T000910_A23ExamenCarrAsigCarreraNombre, T000910_A22ExamenCarrAsigCarreraId, T000910_A24ExamenCarrAsigAsignaturaId, T000910_A25ExamenCarrAsigAsignaturaNombre
               }
               , new Object[] {
               T000911_A23ExamenCarrAsigCarreraNombre
               }
               , new Object[] {
               T000912_A25ExamenCarrAsigAsignaturaNombre
               }
               , new Object[] {
               T000913_A17ExamenId
               }
               , new Object[] {
               T000914_A17ExamenId
               }
               , new Object[] {
               T000915_A17ExamenId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000919_A23ExamenCarrAsigCarreraNombre
               }
               , new Object[] {
               T000920_A25ExamenCarrAsigAsignaturaNombre
               }
               , new Object[] {
               T000921_A16CertificadoId
               }
               , new Object[] {
               T000922_A17ExamenId
               }
               , new Object[] {
               T000923_A17ExamenId, T000923_A18EstudianteNombre, T000923_A9CarreraNombre, T000923_A27ExamenEstudianteNota, T000923_A15EstudianteId, T000923_A8CarreraId
               }
               , new Object[] {
               T000924_A18EstudianteNombre, T000924_A8CarreraId
               }
               , new Object[] {
               T000925_A9CarreraNombre
               }
               , new Object[] {
               T000926_A17ExamenId, T000926_A15EstudianteId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000930_A18EstudianteNombre, T000930_A8CarreraId
               }
               , new Object[] {
               T000931_A9CarreraNombre
               }
               , new Object[] {
               T000932_A16CertificadoId
               }
               , new Object[] {
               T000933_A17ExamenId, T000933_A15EstudianteId
               }
            }
         );
         AV14Pgmname = "Examen";
      }

      private short nIsMod_9 ;
      private short wcpOAV7ExamenId ;
      private short Z17ExamenId ;
      private short Z22ExamenCarrAsigCarreraId ;
      private short Z24ExamenCarrAsigAsignaturaId ;
      private short nRC_GXsfl_68 ;
      private short nGXsfl_68_idx=1 ;
      private short N22ExamenCarrAsigCarreraId ;
      private short N24ExamenCarrAsigAsignaturaId ;
      private short Z15EstudianteId ;
      private short Z27ExamenEstudianteNota ;
      private short nRcdDeleted_9 ;
      private short nRcdExists_9 ;
      private short GxWebError ;
      private short A22ExamenCarrAsigCarreraId ;
      private short A24ExamenCarrAsigAsignaturaId ;
      private short A15EstudianteId ;
      private short A8CarreraId ;
      private short AV7ExamenId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A17ExamenId ;
      private short subGridexamen_estudiiante_Backcolorstyle ;
      private short A27ExamenEstudianteNota ;
      private short subGridexamen_estudiiante_Allowselection ;
      private short subGridexamen_estudiiante_Allowhovering ;
      private short subGridexamen_estudiiante_Allowcollapsing ;
      private short subGridexamen_estudiiante_Collapsed ;
      private short nBlankRcdCount9 ;
      private short RcdFound9 ;
      private short nBlankRcdUsr9 ;
      private short AV11Insert_ExamenCarrAsigCarreraId ;
      private short AV12Insert_ExamenCarrAsigAsignaturaId ;
      private short RcdFound7 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short Z8CarreraId ;
      private short subGridexamen_estudiiante_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtExamenId_Enabled ;
      private int edtExamenFecha_Enabled ;
      private int edtExamenCarrAsigCarreraId_Enabled ;
      private int imgprompt_22_Visible ;
      private int edtExamenCarrAsigCarreraNombre_Enabled ;
      private int edtExamenCarrAsigAsignaturaId_Enabled ;
      private int imgprompt_24_Visible ;
      private int edtExamenCarrAsigAsignaturaNombre_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtEstudianteId_Enabled ;
      private int edtEstudianteNombre_Enabled ;
      private int edtCarreraId_Enabled ;
      private int edtCarreraNombre_Enabled ;
      private int edtExamenEstudianteNota_Enabled ;
      private int subGridexamen_estudiiante_Selectedindex ;
      private int subGridexamen_estudiiante_Selectioncolor ;
      private int subGridexamen_estudiiante_Hoveringcolor ;
      private int fRowAdded ;
      private int AV15GXV1 ;
      private int subGridexamen_estudiiante_Backcolor ;
      private int subGridexamen_estudiiante_Allbackcolor ;
      private int imgprompt_15_Visible ;
      private int defedtEstudianteId_Enabled ;
      private int idxLst ;
      private long GRIDEXAMEN_ESTUDIIANTE_nFirstRecordOnPage ;
      private String sPrefix ;
      private String sGXsfl_68_idx="0001" ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtExamenId_Internalname ;
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
      private String edtExamenId_Jsonclick ;
      private String edtExamenFecha_Internalname ;
      private String edtExamenFecha_Jsonclick ;
      private String edtExamenCarrAsigCarreraId_Internalname ;
      private String edtExamenCarrAsigCarreraId_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_22_Internalname ;
      private String imgprompt_22_Link ;
      private String edtExamenCarrAsigCarreraNombre_Internalname ;
      private String A23ExamenCarrAsigCarreraNombre ;
      private String edtExamenCarrAsigCarreraNombre_Jsonclick ;
      private String edtExamenCarrAsigAsignaturaId_Internalname ;
      private String edtExamenCarrAsigAsignaturaId_Jsonclick ;
      private String imgprompt_24_Internalname ;
      private String imgprompt_24_Link ;
      private String edtExamenCarrAsigAsignaturaNombre_Internalname ;
      private String A25ExamenCarrAsigAsignaturaNombre ;
      private String edtExamenCarrAsigAsignaturaNombre_Jsonclick ;
      private String divEstudiiantetable_Internalname ;
      private String lblTitleestudiiante_Internalname ;
      private String lblTitleestudiiante_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridexamen_estudiiante_Header ;
      private String A18EstudianteNombre ;
      private String A9CarreraNombre ;
      private String sMode9 ;
      private String edtEstudianteId_Internalname ;
      private String edtEstudianteNombre_Internalname ;
      private String edtCarreraId_Internalname ;
      private String edtCarreraNombre_Internalname ;
      private String edtExamenEstudianteNota_Internalname ;
      private String sStyleString ;
      private String AV14Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode7 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String Z23ExamenCarrAsigCarreraNombre ;
      private String Z25ExamenCarrAsigAsignaturaNombre ;
      private String Z18EstudianteNombre ;
      private String Z9CarreraNombre ;
      private String imgprompt_15_Internalname ;
      private String sGXsfl_68_fel_idx="0001" ;
      private String subGridexamen_estudiiante_Class ;
      private String subGridexamen_estudiiante_Linesclass ;
      private String imgprompt_15_Link ;
      private String ROClassString ;
      private String edtEstudianteId_Jsonclick ;
      private String edtEstudianteNombre_Jsonclick ;
      private String edtCarreraId_Jsonclick ;
      private String edtCarreraNombre_Jsonclick ;
      private String edtExamenEstudianteNota_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridexamen_estudiiante_Internalname ;
      private DateTime Z26ExamenFecha ;
      private DateTime A26ExamenFecha ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_68_Refreshing=false ;
      private bool returnInSub ;
      private IGxSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridexamen_estudiianteContainer ;
      private GXWebRow Gridexamen_estudiianteRow ;
      private GXWebColumn Gridexamen_estudiianteColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00098_A23ExamenCarrAsigCarreraNombre ;
      private String[] T00099_A25ExamenCarrAsigAsignaturaNombre ;
      private short[] T000910_A17ExamenId ;
      private DateTime[] T000910_A26ExamenFecha ;
      private String[] T000910_A23ExamenCarrAsigCarreraNombre ;
      private short[] T000910_A22ExamenCarrAsigCarreraId ;
      private short[] T000910_A24ExamenCarrAsigAsignaturaId ;
      private String[] T000910_A25ExamenCarrAsigAsignaturaNombre ;
      private String[] T000911_A23ExamenCarrAsigCarreraNombre ;
      private String[] T000912_A25ExamenCarrAsigAsignaturaNombre ;
      private short[] T000913_A17ExamenId ;
      private short[] T00097_A17ExamenId ;
      private DateTime[] T00097_A26ExamenFecha ;
      private short[] T00097_A22ExamenCarrAsigCarreraId ;
      private short[] T00097_A24ExamenCarrAsigAsignaturaId ;
      private short[] T000914_A17ExamenId ;
      private short[] T000915_A17ExamenId ;
      private short[] T00096_A17ExamenId ;
      private DateTime[] T00096_A26ExamenFecha ;
      private short[] T00096_A22ExamenCarrAsigCarreraId ;
      private short[] T00096_A24ExamenCarrAsigAsignaturaId ;
      private String[] T000919_A23ExamenCarrAsigCarreraNombre ;
      private String[] T000920_A25ExamenCarrAsigAsignaturaNombre ;
      private short[] T000921_A16CertificadoId ;
      private short[] T000922_A17ExamenId ;
      private short[] T000923_A17ExamenId ;
      private String[] T000923_A18EstudianteNombre ;
      private String[] T000923_A9CarreraNombre ;
      private short[] T000923_A27ExamenEstudianteNota ;
      private short[] T000923_A15EstudianteId ;
      private short[] T000923_A8CarreraId ;
      private String[] T00094_A18EstudianteNombre ;
      private short[] T00094_A8CarreraId ;
      private String[] T00095_A9CarreraNombre ;
      private String[] T000924_A18EstudianteNombre ;
      private short[] T000924_A8CarreraId ;
      private String[] T000925_A9CarreraNombre ;
      private short[] T000926_A17ExamenId ;
      private short[] T000926_A15EstudianteId ;
      private short[] T00093_A17ExamenId ;
      private short[] T00093_A27ExamenEstudianteNota ;
      private short[] T00093_A15EstudianteId ;
      private short[] T00092_A17ExamenId ;
      private short[] T00092_A27ExamenEstudianteNota ;
      private short[] T00092_A15EstudianteId ;
      private String[] T000930_A18EstudianteNombre ;
      private short[] T000930_A8CarreraId ;
      private String[] T000931_A9CarreraNombre ;
      private short[] T000932_A16CertificadoId ;
      private short[] T000933_A17ExamenId ;
      private short[] T000933_A15EstudianteId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV13TrnContextAtt ;
   }

   public class examen__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new ForEachCursor(def[24])
         ,new UpdateCursor(def[25])
         ,new UpdateCursor(def[26])
         ,new UpdateCursor(def[27])
         ,new ForEachCursor(def[28])
         ,new ForEachCursor(def[29])
         ,new ForEachCursor(def[30])
         ,new ForEachCursor(def[31])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000910 ;
          prmT000910 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00098 ;
          prmT00098 = new Object[] {
          new Object[] {"@ExamenCarrAsigCarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00099 ;
          prmT00099 = new Object[] {
          new Object[] {"@ExamenCarrAsigCarreraId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ExamenCarrAsigAsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000911 ;
          prmT000911 = new Object[] {
          new Object[] {"@ExamenCarrAsigCarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000912 ;
          prmT000912 = new Object[] {
          new Object[] {"@ExamenCarrAsigCarreraId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ExamenCarrAsigAsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000913 ;
          prmT000913 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00097 ;
          prmT00097 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000914 ;
          prmT000914 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000915 ;
          prmT000915 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00096 ;
          prmT00096 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000916 ;
          prmT000916 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ExamenFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ExamenCarrAsigCarreraId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ExamenCarrAsigAsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000917 ;
          prmT000917 = new Object[] {
          new Object[] {"@ExamenFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ExamenCarrAsigCarreraId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ExamenCarrAsigAsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000918 ;
          prmT000918 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000921 ;
          prmT000921 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000922 ;
          prmT000922 = new Object[] {
          } ;
          Object[] prmT000923 ;
          prmT000923 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00094 ;
          prmT00094 = new Object[] {
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00095 ;
          prmT00095 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000924 ;
          prmT000924 = new Object[] {
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000925 ;
          prmT000925 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000926 ;
          prmT000926 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00093 ;
          prmT00093 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00092 ;
          prmT00092 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000927 ;
          prmT000927 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ExamenEstudianteNota",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000928 ;
          prmT000928 = new Object[] {
          new Object[] {"@ExamenEstudianteNota",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000929 ;
          prmT000929 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000932 ;
          prmT000932 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000933 ;
          prmT000933 = new Object[] {
          new Object[] {"@ExamenId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000919 ;
          prmT000919 = new Object[] {
          new Object[] {"@ExamenCarrAsigCarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000920 ;
          prmT000920 = new Object[] {
          new Object[] {"@ExamenCarrAsigCarreraId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ExamenCarrAsigAsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000930 ;
          prmT000930 = new Object[] {
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000931 ;
          prmT000931 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00092", "SELECT [ExamenId], [ExamenEstudianteNota], [EstudianteId] FROM [ExamenEstudiiante] WITH (UPDLOCK) WHERE [ExamenId] = @ExamenId AND [EstudianteId] = @EstudianteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00092,1,0,true,false )
             ,new CursorDef("T00093", "SELECT [ExamenId], [ExamenEstudianteNota], [EstudianteId] FROM [ExamenEstudiiante] WITH (NOLOCK) WHERE [ExamenId] = @ExamenId AND [EstudianteId] = @EstudianteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00093,1,0,true,false )
             ,new CursorDef("T00094", "SELECT [EstudianteNombre], [CarreraId] FROM [Estudiante] WITH (NOLOCK) WHERE [EstudianteId] = @EstudianteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00094,1,0,true,false )
             ,new CursorDef("T00095", "SELECT [CarreraNombre] FROM [Carrera] WITH (NOLOCK) WHERE [CarreraId] = @CarreraId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00095,1,0,true,false )
             ,new CursorDef("T00096", "SELECT [ExamenId], [ExamenFecha], [ExamenCarrAsigCarreraId] AS ExamenCarrAsigCarreraId, [ExamenCarrAsigAsignaturaId] AS ExamenCarrAsigAsignaturaId FROM [Examen] WITH (UPDLOCK) WHERE [ExamenId] = @ExamenId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00096,1,0,true,false )
             ,new CursorDef("T00097", "SELECT [ExamenId], [ExamenFecha], [ExamenCarrAsigCarreraId] AS ExamenCarrAsigCarreraId, [ExamenCarrAsigAsignaturaId] AS ExamenCarrAsigAsignaturaId FROM [Examen] WITH (NOLOCK) WHERE [ExamenId] = @ExamenId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00097,1,0,true,false )
             ,new CursorDef("T00098", "SELECT [CarreraNombre] AS ExamenCarrAsigCarreraNombre FROM [Carrera] WITH (NOLOCK) WHERE [CarreraId] = @ExamenCarrAsigCarreraId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00098,1,0,true,false )
             ,new CursorDef("T00099", "SELECT [AsignaturaNombre] AS ExamenCarrAsigAsignaturaNombre FROM [CarreraAsignatura] WITH (NOLOCK) WHERE [CarreraId] = @ExamenCarrAsigCarreraId AND [AsignaturaId] = @ExamenCarrAsigAsignaturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00099,1,0,true,false )
             ,new CursorDef("T000910", "SELECT TM1.[ExamenId], TM1.[ExamenFecha], T2.[CarreraNombre] AS ExamenCarrAsigCarreraNombre, TM1.[ExamenCarrAsigCarreraId] AS ExamenCarrAsigCarreraId, TM1.[ExamenCarrAsigAsignaturaId] AS ExamenCarrAsigAsignaturaId, T3.[AsignaturaNombre] AS ExamenCarrAsigAsignaturaNombre FROM (([Examen] TM1 WITH (NOLOCK) INNER JOIN [Carrera] T2 WITH (NOLOCK) ON T2.[CarreraId] = TM1.[ExamenCarrAsigCarreraId]) INNER JOIN [CarreraAsignatura] T3 WITH (NOLOCK) ON T3.[CarreraId] = TM1.[ExamenCarrAsigCarreraId] AND T3.[AsignaturaId] = TM1.[ExamenCarrAsigAsignaturaId]) WHERE TM1.[ExamenId] = @ExamenId ORDER BY TM1.[ExamenId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000910,100,0,true,false )
             ,new CursorDef("T000911", "SELECT [CarreraNombre] AS ExamenCarrAsigCarreraNombre FROM [Carrera] WITH (NOLOCK) WHERE [CarreraId] = @ExamenCarrAsigCarreraId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000911,1,0,true,false )
             ,new CursorDef("T000912", "SELECT [AsignaturaNombre] AS ExamenCarrAsigAsignaturaNombre FROM [CarreraAsignatura] WITH (NOLOCK) WHERE [CarreraId] = @ExamenCarrAsigCarreraId AND [AsignaturaId] = @ExamenCarrAsigAsignaturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000912,1,0,true,false )
             ,new CursorDef("T000913", "SELECT [ExamenId] FROM [Examen] WITH (NOLOCK) WHERE [ExamenId] = @ExamenId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000913,1,0,true,false )
             ,new CursorDef("T000914", "SELECT TOP 1 [ExamenId] FROM [Examen] WITH (NOLOCK) WHERE ( [ExamenId] > @ExamenId) ORDER BY [ExamenId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000914,1,0,true,true )
             ,new CursorDef("T000915", "SELECT TOP 1 [ExamenId] FROM [Examen] WITH (NOLOCK) WHERE ( [ExamenId] < @ExamenId) ORDER BY [ExamenId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000915,1,0,true,true )
             ,new CursorDef("T000916", "INSERT INTO [Examen]([ExamenId], [ExamenFecha], [ExamenCarrAsigCarreraId], [ExamenCarrAsigAsignaturaId]) VALUES(@ExamenId, @ExamenFecha, @ExamenCarrAsigCarreraId, @ExamenCarrAsigAsignaturaId)", GxErrorMask.GX_NOMASK,prmT000916)
             ,new CursorDef("T000917", "UPDATE [Examen] SET [ExamenFecha]=@ExamenFecha, [ExamenCarrAsigCarreraId]=@ExamenCarrAsigCarreraId, [ExamenCarrAsigAsignaturaId]=@ExamenCarrAsigAsignaturaId  WHERE [ExamenId] = @ExamenId", GxErrorMask.GX_NOMASK,prmT000917)
             ,new CursorDef("T000918", "DELETE FROM [Examen]  WHERE [ExamenId] = @ExamenId", GxErrorMask.GX_NOMASK,prmT000918)
             ,new CursorDef("T000919", "SELECT [CarreraNombre] AS ExamenCarrAsigCarreraNombre FROM [Carrera] WITH (NOLOCK) WHERE [CarreraId] = @ExamenCarrAsigCarreraId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000919,1,0,true,false )
             ,new CursorDef("T000920", "SELECT [AsignaturaNombre] AS ExamenCarrAsigAsignaturaNombre FROM [CarreraAsignatura] WITH (NOLOCK) WHERE [CarreraId] = @ExamenCarrAsigCarreraId AND [AsignaturaId] = @ExamenCarrAsigAsignaturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000920,1,0,true,false )
             ,new CursorDef("T000921", "SELECT TOP 1 [CertificadoId] FROM [Certificado] WITH (NOLOCK) WHERE [ExamenId] = @ExamenId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000921,1,0,true,true )
             ,new CursorDef("T000922", "SELECT [ExamenId] FROM [Examen] WITH (NOLOCK) ORDER BY [ExamenId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000922,100,0,true,false )
             ,new CursorDef("T000923", "SELECT T1.[ExamenId], T2.[EstudianteNombre], T3.[CarreraNombre], T1.[ExamenEstudianteNota], T1.[EstudianteId], T2.[CarreraId] FROM (([ExamenEstudiiante] T1 WITH (NOLOCK) INNER JOIN [Estudiante] T2 WITH (NOLOCK) ON T2.[EstudianteId] = T1.[EstudianteId]) INNER JOIN [Carrera] T3 WITH (NOLOCK) ON T3.[CarreraId] = T2.[CarreraId]) WHERE T1.[ExamenId] = @ExamenId and T1.[EstudianteId] = @EstudianteId ORDER BY T1.[ExamenId], T1.[EstudianteId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000923,11,0,true,false )
             ,new CursorDef("T000924", "SELECT [EstudianteNombre], [CarreraId] FROM [Estudiante] WITH (NOLOCK) WHERE [EstudianteId] = @EstudianteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000924,1,0,true,false )
             ,new CursorDef("T000925", "SELECT [CarreraNombre] FROM [Carrera] WITH (NOLOCK) WHERE [CarreraId] = @CarreraId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000925,1,0,true,false )
             ,new CursorDef("T000926", "SELECT [ExamenId], [EstudianteId] FROM [ExamenEstudiiante] WITH (NOLOCK) WHERE [ExamenId] = @ExamenId AND [EstudianteId] = @EstudianteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000926,1,0,true,false )
             ,new CursorDef("T000927", "INSERT INTO [ExamenEstudiiante]([ExamenId], [ExamenEstudianteNota], [EstudianteId]) VALUES(@ExamenId, @ExamenEstudianteNota, @EstudianteId)", GxErrorMask.GX_NOMASK,prmT000927)
             ,new CursorDef("T000928", "UPDATE [ExamenEstudiiante] SET [ExamenEstudianteNota]=@ExamenEstudianteNota  WHERE [ExamenId] = @ExamenId AND [EstudianteId] = @EstudianteId", GxErrorMask.GX_NOMASK,prmT000928)
             ,new CursorDef("T000929", "DELETE FROM [ExamenEstudiiante]  WHERE [ExamenId] = @ExamenId AND [EstudianteId] = @EstudianteId", GxErrorMask.GX_NOMASK,prmT000929)
             ,new CursorDef("T000930", "SELECT [EstudianteNombre], [CarreraId] FROM [Estudiante] WITH (NOLOCK) WHERE [EstudianteId] = @EstudianteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000930,1,0,true,false )
             ,new CursorDef("T000931", "SELECT [CarreraNombre] FROM [Carrera] WITH (NOLOCK) WHERE [CarreraId] = @CarreraId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000931,1,0,true,false )
             ,new CursorDef("T000932", "SELECT TOP 1 [CertificadoId] FROM [Certificado] WITH (NOLOCK) WHERE [ExamenId] = @ExamenId AND [EstudianteId] = @EstudianteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000932,1,0,true,true )
             ,new CursorDef("T000933", "SELECT [ExamenId], [EstudianteId] FROM [ExamenEstudiiante] WITH (NOLOCK) WHERE [ExamenId] = @ExamenId ORDER BY [ExamenId], [EstudianteId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000933,11,0,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 19 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 20 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 23 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 24 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 28 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 29 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
       }
       getresults30( cursor, rslt, buf) ;
    }

    public void getresults30( int cursor ,
                              IFieldGetter rslt ,
                              Object[] buf )
    {
       switch ( cursor )
       {
             case 30 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 31 :
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
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
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 15 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 25 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 26 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 27 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 28 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 29 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
       setparameters30( cursor, stmt, parms) ;
    }

    public void setparameters30( int cursor ,
                                 IFieldSetter stmt ,
                                 Object[] parms )
    {
       switch ( cursor )
       {
             case 30 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 31 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
