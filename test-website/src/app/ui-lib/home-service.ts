import { Injectable, Signal } from '@angular/core';
import { HomeItemList, HomeItemListSchema, HomeItemSchema, HomeContentList, HomeContentListSchema, HomeRowList, HomeRowListSchema } from './home.schema';
import { httpResource, HttpResourceRef } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class HomeService {
  getHomeContentList() : HttpResourceRef<HomeContentList | undefined> {
    return httpResource<HomeContentList>(
      () => `/api/HomeContent`,
      { parse: (response: unknown): HomeContentList => HomeContentListSchema.parse(response) },
    );
  }

  getHomeRowList(
    parentId: Signal<number>
  ) : HttpResourceRef<HomeRowList | undefined> {
    return httpResource<HomeRowList>(
      () => `/api/HomeRow?$filter=HomeContentId eq ${parentId()}`,
      { parse: (response: unknown): HomeRowList => HomeRowListSchema.parse(response) },
    );
  }

  getHomeItemList(
    parentId: Signal<number>
  ) : HttpResourceRef<HomeItemList | undefined> {
    return httpResource<HomeItemList>(
      () => `/api/HomeItem?$filter=HomeRowId eq ${parentId()}`,
      { parse: (response: unknown): HomeItemList => HomeItemListSchema.parse(response) },
    );
  }

}
