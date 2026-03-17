import { Component, inject, input } from '@angular/core';
import { HomeService } from '../../../home-service';

@Component({
  selector: 'coffee-simple-image',
  imports: [],
  templateUrl: './simple-image.html',
  styleUrl: './simple-image.scss',
})
export class SimpleImage {
  homeService = inject(HomeService);
  parentId = input.required<number>();
  protected readonly dataResource = this.homeService.getHomeItemListByParentId(this.parentId);
  protected readonly dataTypeResource = this.homeService.getHomeItemTypeList();

}
