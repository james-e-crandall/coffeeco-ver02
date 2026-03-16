import { Injectable, Signal } from '@angular/core';
import { HomeItemList, HomeItemListSchema, HomeItemSchema, HomeContentList, HomeContentListSchema, HomeRowList, HomeRowListSchema, HomeItemTypeList, HomeItemTypeListSchema, HomeRowTypeList, HomeRowTypeListSchema } from './home.schema';
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

  getHomeRowListByParentId(
    parentId: Signal<number>
  ) : HttpResourceRef<HomeRowList | undefined> {
    return httpResource<HomeRowList>(
      () => `/api/HomeRow?$filter=HomeContentId eq ${parentId()}`,
      { parse: (response: unknown): HomeRowList => HomeRowListSchema.parse(response) },
    );
  }

  getHomeRowTypeList(
  ) : HttpResourceRef<HomeRowTypeList | undefined> {
    return httpResource<HomeRowTypeList>(
      () => `/api/HomeRowType`,
      { parse: (response: unknown): HomeRowTypeList => HomeRowTypeListSchema.parse(response) },
    );
  }

  getHomeRowTypeListByChildId(
    parentId: Signal<number>
  ) : HttpResourceRef<HomeRowTypeList | undefined> {
    return httpResource<HomeRowTypeList>(
      () => `/api/HomeRowType?$filter=Id eq ${parentId()}`,
      { parse: (response: unknown): HomeRowTypeList => HomeRowTypeListSchema.parse(response) },
    );
  }

  getHomeItemListByParentId(
    parentId: Signal<number>
  ) : HttpResourceRef<HomeItemList | undefined> {
    return httpResource<HomeItemList>(
      () => `/api/HomeItem?$filter=HomeRowId eq ${parentId()}`,
      { parse: (response: unknown): HomeItemList => HomeItemListSchema.parse(response) },
    );
  }

  getHomeItemTypeList(
  ) : HttpResourceRef<HomeItemTypeList | undefined> {
    return httpResource<HomeItemTypeList>(
      () => `/api/HomeItemType`,
      { parse: (response: unknown): HomeItemTypeList => HomeItemTypeListSchema.parse(response) },
    );
  }

    getHomeItemTypeListByChildId(
    parentId: Signal<number>
  ) : HttpResourceRef<HomeItemTypeList | undefined> {
    return httpResource<HomeItemTypeList>(
      () => `/api/HomeItemType?$filter=Id eq ${parentId()}`,
      { parse: (response: unknown): HomeItemTypeList => HomeItemTypeListSchema.parse(response) },
    );
  }


}
