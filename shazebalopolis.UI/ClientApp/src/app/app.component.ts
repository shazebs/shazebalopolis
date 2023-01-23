import { Component, Inject, OnDestroy, OnInit } from '@angular/core';
import { Subject } from 'rxjs';
import { filter, takeUntil } from 'rxjs/operators';
import { InteractionStatus, RedirectRequest, PopupRequest } from '@azure/msal-browser';
import { MsalService, MsalBroadcastService, MsalGuardConfiguration, MSAL_GUARD_CONFIG } from '@azure/msal-angular';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit, OnDestroy {
  // local variables
  title = 'Shazebalopolis';
  isIframe = false;
  isUserLoggedIn: boolean = false;
  private readonly _destroying$ = new Subject<void>();
  isExpanded = false;

  /*
   * Constructor.
   * 
   */
  constructor(
    @Inject(MSAL_GUARD_CONFIG) private msalGuardConfig: MsalGuardConfiguration,
    private broadcastService: MsalBroadcastService,
    private authService: MsalService) { }

  /*
   * OnInit implementation.
   * 
   */
  ngOnInit(): void {
    this.isIframe = window !== window.parent && !window.opener;
    this.broadcastService.inProgress$.pipe(filter((status: InteractionStatus) => status === InteractionStatus.None), takeUntil(this._destroying$)).subscribe(() => {
      this.setLoginStatus();
    })
  }

  /*
   * OnDestroy implementation.
   * 
   */
  ngOnDestroy(): void {
    this._destroying$.next(undefined);
    this._destroying$.complete();
  }

  /*
   * App.Component login redirect.
   * 
   */
  LoginRedirect() {
    if (this.msalGuardConfig.authRequest) this.authService.loginRedirect({ ...this.msalGuardConfig.authRequest } as RedirectRequest);
    else this.authService.loginRedirect();
  }

  /*
   * App.Component logout redirect.
   * 
   */
  LogoutRedirect() {
    this.authService.logoutRedirect({postLogoutRedirectUri: 'https://localhost:44497'});
    localStorage.removeItem('Token'); 
  }

  /*
   * App.Component set login status.
   * 
   */
  setLoginStatus() {
    this.isUserLoggedIn = this.authService.instance.getAllAccounts().length > 0;
  }

  // Navbar functions
  collapse() {
    this.isExpanded = false;
  }
  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  /*
   * Turn OFF UI elements.
   * 
   */ 
  HideWindows(): void {
    var sidePaneMenu = document.getElementById('SidePaneMenu');
    var mainTimeline = document.getElementById('MainTimeline');
    var additionalContent = document.getElementById('AdditionalContent');
    if (sidePaneMenu != null) {
      sidePaneMenu.style.display = 'none';
    }
    if (mainTimeline != null) {
      mainTimeline.style.display = 'none';
    }
    if (additionalContent != null) {
      additionalContent.style.display = 'none';
    }
  }

  /*
   * Turn ON UI elements.
   * 
   */
  ShowWindows(): void {
    var sidePaneMenu = document.getElementById('SidePaneMenu');
    var mainTimeline = document.getElementById('MainTimeline');
    var additionalContent = document.getElementById('AdditionalContent');
    if (sidePaneMenu != null && window.innerWidth >= 1050) {
      sidePaneMenu.style.display = 'flex';
    }
    if (mainTimeline != null) {
      mainTimeline.style.display = 'flex';
    }
    if (additionalContent != null && window.innerWidth >= 1050) {
      additionalContent.style.display = 'block';
    }
  }
}
