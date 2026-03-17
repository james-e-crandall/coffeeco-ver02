import { Component, inject, input } from '@angular/core';
import { HomeService } from '../../home-service';
import { HomeItem } from './home-item/home-item';
import { NgComponentOutlet } from '@angular/common';
import { SimpleMessage } from './simple-message/simple-message';

@Component({
  selector: 'coffee-home-row',
  imports: [
    NgComponentOutlet
  ],
  templateUrl: './home-row.html',
  styleUrl: './home-row.scss',
})
export class HomeRow {
  homeService = inject(HomeService);
  parentId = input.required<number>();
  protected readonly dataResource = this.homeService.getHomeRowListByParentId(this.parentId);
  protected readonly dataTypeResource = this.homeService.getHomeRowTypeList();

  getItemComponent(HomeRowTypeId:number | null) {
    switch (HomeRowTypeId) {
      case (2): {
        console.log(" case (2):HomeRowTypeId: " + HomeRowTypeId);
        return SimpleMessage;
      }
      case (1): {
        console.log(" case (1): HomeRowTypeId: " + HomeRowTypeId);
        return SimpleMessage;
      }
      default: {
        console.log("default: HomeRowTypeId: " + HomeRowTypeId);
          return HomeItem;
        }
    }
  }

}
