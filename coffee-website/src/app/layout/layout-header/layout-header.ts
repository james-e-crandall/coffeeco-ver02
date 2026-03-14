import { Component, inject, input } from '@angular/core';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatListModule } from '@angular/material/list';
import { MatIconModule } from '@angular/material/icon';
import {MatMenuModule} from '@angular/material/menu';
import { ScreenService } from '../screen-service';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-layout-header',
  imports: [
    MatToolbarModule,
    MatButtonModule,
    MatListModule,
    MatIconModule,
    MatMenuModule,
    RouterLink
  ],
  templateUrl: './layout-header.html',
  styleUrl: './layout-header.scss',
})
export class LayoutHeader {
  public screenService = inject(ScreenService);
}
