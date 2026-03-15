import { z } from 'zod';
// --> Home
export const HomeContentSchema = z.object({
  Id: z.number(),
  // HomeRows: HomeRowSchemaArray
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
  // HomeRows: HomeRowSchemaArray
});

export type HomeRow = z.infer<typeof HomeRowSchema>;

export const HomeRowSchemaArray = z.array(HomeRowSchema);

// --> HomeRowList
export const HomeRowListSchema = z.object({
  value: HomeRowSchemaArray
});

export type HomeRowList = z.infer<typeof HomeContentListSchema>;

// --> HomeItem

export const HomeItemSchema = z.object({
  Id: z.number(),
  Text: z.string()
});

export type HomeItem = z.infer<typeof HomeItemSchema>;

export const HomeItemSchemaArray = z.array(HomeItemSchema);

// --> HomeSubGroupList
export const HomeItemListSchema = z.object({
  value: HomeItemSchemaArray
});

export type HomeItemList = z.infer<typeof HomeItemListSchema>;



