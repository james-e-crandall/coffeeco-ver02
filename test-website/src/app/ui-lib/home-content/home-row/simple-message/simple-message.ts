import { Component, inject, input } from '@angular/core';
import { HomeService } from '../../../home-service';

@Component({
  selector: 'coffee-simple-message',
  imports: [],
  templateUrl: './simple-message.html',
  styleUrl: './simple-message.scss',
})
export class SimpleMessage {
  homeService = inject(HomeService);
  parentId = input.required<number>();
  protected readonly dataResource = this.homeService.getHomeItemListById(this.parentId);
  protected readonly dataTypeResource = this.homeService.getHomeItemTypeList();
}
