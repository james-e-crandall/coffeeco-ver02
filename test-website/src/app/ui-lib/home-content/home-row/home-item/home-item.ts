import { Component, inject, input } from '@angular/core';
import { HomeService } from '../../../home-service';

@Component({
  selector: 'coffee-home-item',
  imports: [],
  templateUrl: './home-item.html',
  styleUrl: './home-item.scss',
})
export class HomeItem {
  homeService = inject(HomeService);
  parentId = input.required<number>();
  protected readonly dataResource = this.homeService.getHomeItemList(this.parentId);
}
