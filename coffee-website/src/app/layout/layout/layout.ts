import { Component, inject } from '@angular/core';

import { LayoutHeader } from '../layout-header/layout-header';
import { LayoutFooter } from '../layout-footer/layout-footer';

@Component({
  selector: 'app-layout',
  imports: [
    LayoutHeader,
    LayoutFooter,
  ],
  templateUrl: './layout.html',
  styleUrl: './layout.scss',
})
export class Layout {

}

@Component({
  selector: 'app-layout-header-content',
  template: `<ng-content></ng-content>`,
})
export class LayoutHeaderContent {}


@Component({
  selector: 'app-layout-main-content',
  template: `<ng-content></ng-content>`,
})
export class LayoutMainContent {}

@Component({
  selector: 'app-layout-footer-content',
  template: `<ng-content></ng-content>`,
})
export class LayoutFooterContent {}



