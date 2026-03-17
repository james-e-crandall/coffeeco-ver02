import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SimpleImage } from './simple-image';

describe('SimpleImage', () => {
  let component: SimpleImage;
  let fixture: ComponentFixture<SimpleImage>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SimpleImage]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SimpleImage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
