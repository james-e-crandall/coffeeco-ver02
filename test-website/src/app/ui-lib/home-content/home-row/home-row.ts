import { Component, inject, input } from '@angular/core';
import { HomeService } from '../../home-service';
import { HomeItem } from './home-item/home-item';

@Component({
  selector: 'coffee-home-row',
  imports: [HomeItem],
  templateUrl: './home-row.html',
  styleUrl: './home-row.scss',
})
export class HomeRow {
  homeService = inject(HomeService);
  parentId = input.required<number>();
  protected readonly dataResource = this.homeService.getHomeRowList(this.parentId);
}
