import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LedgerWrapperComponent } from './ledger-wrapper.component';

describe('LedgerWrapperComponent', () => {
  let component: LedgerWrapperComponent;
  let fixture: ComponentFixture<LedgerWrapperComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [LedgerWrapperComponent]
    });
    fixture = TestBed.createComponent(LedgerWrapperComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
