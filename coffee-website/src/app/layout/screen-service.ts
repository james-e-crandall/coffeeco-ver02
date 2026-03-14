import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { inject, Injectable } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { map } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ScreenService {
  private breakpointObserver = inject(BreakpointObserver);
  private isHadsetBreakpoints = [
      Breakpoints.XSmall,
      Breakpoints.Medium,
      Breakpoints.Handset,
      Breakpoints.HandsetPortrait,
    ];

  private isTabletBreakpoints = [
      Breakpoints.Small,
      Breakpoints.Tablet,
      Breakpoints.TabletPortrait,
  ];

  private isWebBreakpoints = [

      Breakpoints.Large,
      Breakpoints.XLarge,
      Breakpoints.Web,
      Breakpoints.WebPortrait,
      Breakpoints.WebLandscape,
  ];


  // A signal that is true when the screen is in portrait mode on a handset device
  public readonly isHandset = toSignal(
    this.breakpointObserver.observe(this.isHadsetBreakpoints).pipe(
      map(result => result.matches) // Map the BreakpointState to a simple boolean signal
    ),
    { initialValue: false } // Provide an initial value
  );

  // A signal that is true when the screen is in portrait mode on a handset device
  public readonly isTablet = toSignal(
    this.breakpointObserver.observe(this.isTabletBreakpoints).pipe(
      map(result => result.matches) // Map the BreakpointState to a simple boolean signal
    ),
    { initialValue: false } // Provide an initial value
  );

  // A signal that is true when the screen is in portrait mode on a handset device
  public readonly isWeb = toSignal(
    this.breakpointObserver.observe(this.isWebBreakpoints).pipe(
      map(result => result.matches) // Map the BreakpointState to a simple boolean signal
    ),
    { initialValue: false } // Provide an initial value
  );

  // A signal that provides a string value based on the current active breakpoint
  public readonly currentBreakpoint = toSignal(
    this.breakpointObserver.observe([
      Breakpoints.XSmall,
      Breakpoints.Small,
      Breakpoints.Medium,
      Breakpoints.Large,
      Breakpoints.XLarge,

      Breakpoints.Handset,
      Breakpoints.Tablet,
      Breakpoints.Web,

      Breakpoints.HandsetPortrait,
      Breakpoints.TabletPortrait,
      Breakpoints.WebPortrait,

      Breakpoints.HandsetLandscape,
      Breakpoints.TabletLandscape,
      Breakpoints.WebLandscape,

    ]).pipe(
      map(result => {
        if (result.breakpoints[Breakpoints.XSmall]) return Breakpoints.XSmall;
        if (result.breakpoints[Breakpoints.Small]) return Breakpoints.Small;
        if (result.breakpoints[Breakpoints.Medium]) return Breakpoints.Medium;
        if (result.breakpoints[Breakpoints.Large]) return Breakpoints.Large;
        if (result.breakpoints[Breakpoints.XLarge]) return Breakpoints.XLarge;
        if (result.breakpoints[Breakpoints.Handset]) Breakpoints.Handset;
        if (result.breakpoints[Breakpoints.Tablet]) return Breakpoints.Tablet;
        if (result.breakpoints[Breakpoints.Web]) return Breakpoints.Web;

        if (result.breakpoints[Breakpoints.HandsetPortrait]) return Breakpoints.HandsetPortrait;
        if (result.breakpoints[Breakpoints.TabletPortrait]) return Breakpoints.TabletPortrait;
        if (result.breakpoints[Breakpoints.WebPortrait]) return Breakpoints.WebPortrait;

        if (result.breakpoints[Breakpoints.HandsetLandscape]) return Breakpoints.HandsetLandscape;
        if (result.breakpoints[Breakpoints.TabletLandscape]) return Breakpoints.TabletLandscape;
        if (result.breakpoints[Breakpoints.WebLandscape]) return Breakpoints.WebLandscape;
        return 'Unknown';
      })
    ),
    { initialValue: 'Unknown' }
  );


}
