import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SimpleMessage } from './simple-message';

describe('SimpleMessage', () => {
  let component: SimpleMessage;
  let fixture: ComponentFixture<SimpleMessage>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SimpleMessage]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SimpleMessage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
