import { z } from 'zod';
// --> Home
export const HomeContentSchema = z.object({
  Id: z.number(),
});

export type HomeContent = z.infer<typeof HomeContentSchema>;

export const HomeContentSchemaArray = z.array(HomeContentSchema);

// --> HomeList
export const HomeContentListSchema = z.object({
  value: HomeContentSchemaArray
});

export type HomeContentList = z.infer<typeof HomeContentListSchema>;

// --> HomeRow

export const HomeRowSchema = z.object({
  Id: z.number(),
  HomeRowTypeId: z.number().nullable()
});

export type HomeRow = z.infer<typeof HomeRowSchema>;

export const HomeRowSchemaArray = z.array(HomeRowSchema);

// --> HomeRowList
export const HomeRowListSchema = z.object({
  value: HomeRowSchemaArray
});

export type HomeRowList = z.infer<typeof HomeRowListSchema>;

// --> HomeRowType

export const HomeRowTypeSchema = z.object({
  Id: z.number(),
  Type: z.string(),
});

export type HomeRowType = z.infer<typeof HomeRowTypeSchema>;

export const HomeRowTypeSchemaArray = z.array(HomeRowTypeSchema);

// --> HomeSubGroupList
export const HomeRowTypeListSchema = z.object({
  value: HomeRowTypeSchemaArray
});

export type HomeRowTypeList = z.infer<typeof HomeRowTypeListSchema>;


// --> HomeItem

export const HomeItemSchema = z.object({
  Id: z.number(),
  Text: z.string(),
  HomeItemTypeId: z.number().nullable()
});

export type HomeItem = z.infer<typeof HomeItemSchema>;

export const HomeItemSchemaArray = z.array(HomeItemSchema);

// --> HomeSubGroupList
export const HomeItemListSchema = z.object({
  value: HomeItemSchemaArray
});

export type HomeItemList = z.infer<typeof HomeItemListSchema>;

// --> HomeItemType

export const HomeItemTypeSchema = z.object({
  Id: z.number(),
  Type: z.string(),
});

export type HomeItemType = z.infer<typeof HomeItemTypeSchema>;

export const HomeItemTypeSchemaArray = z.array(HomeItemTypeSchema);

// --> HomeSubGroupList
export const HomeItemTypeListSchema = z.object({
  value: HomeItemTypeSchemaArray
});

export type HomeItemTypeList = z.infer<typeof HomeItemTypeListSchema>;

