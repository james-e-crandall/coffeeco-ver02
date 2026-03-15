import { Component, inject } from '@angular/core';
import { HomeService } from '../home-service';
import { HomeRow } from './home-row/home-row';

@Component({
  selector: 'coffee-home-content',
  imports: [HomeRow],
  templateUrl: './home-content.html',
  styleUrl: './home-content.scss',
})
export class HomeContent {
  homeService = inject(HomeService);

  protected readonly dataResource = this.homeService.getHomeContentList();
}
