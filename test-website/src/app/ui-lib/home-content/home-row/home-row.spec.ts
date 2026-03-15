import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeRow } from './home-row';

describe('HomeRow', () => {
  let component: HomeRow;
  let fixture: ComponentFixture<HomeRow>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HomeRow]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HomeRow);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
