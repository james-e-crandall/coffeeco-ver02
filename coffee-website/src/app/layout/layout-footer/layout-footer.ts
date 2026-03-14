import { Component, inject } from '@angular/core';
import { ScreenService } from '../screen-service';
import { MatToolbarModule } from '@angular/material/toolbar';

@Component({
  selector: 'app-layout-footer',
  imports: [
    MatToolbarModule
  ],
  templateUrl: './layout-footer.html',
  styleUrl: './layout-footer.scss',
})
export class LayoutFooter {
  public screenService = inject(ScreenService);
}
